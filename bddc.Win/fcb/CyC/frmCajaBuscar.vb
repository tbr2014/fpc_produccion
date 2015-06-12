Imports System.Windows.Forms
Imports System.IO

Public Class frmCajaBuscar

#Region "Atributos"
    Private objHorario As Util.clsHorario
#End Region

#Region "Operaciones"

    Private Sub LeerParametros()

        Dim objDL As New DALC.COM.clsParametro
        Dim objBEC As BEC.COM.clsParametro
        Dim arrResultados As IList

        Try

            'Control Fecha:
            ucFechaProceso.TipoTurno(Util.Enumeracion.enmFCBTipoTurno.Cajas)
            ucFechaProceso.IngresarFecha(False)
            ucFechaProceso.UsarCalendario(True)
            ucFechaProceso.Aplicar()

            ' Parametro(s):
            '27:       Cajas Grupo

            'arrResultados = objDL.Seleccionar("27", frmLogin.Unidad)

            Select Case frmLogin.Unidad
                Case "FIESTA CASINO BENAVIDES"
                    arrResultados = objDL.Seleccionar("26", frmLogin.Unidad)

                    If arrResultados.Count > 0 Then
                        cboCaja.Items.Clear()

                        For k As Integer = 0 To arrResultados.Count - 1
                            objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                            Select Case objBEC.GrupoId

                                Case Util.Enumeracion.enmGrupoParametro.FCB_CajayConteo_Cajas
                                    Me.cboCaja.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))
                            End Select
                        Next

                        Me.cboCaja.Items.Insert(0, New BEC.COM.clsItem(0, ""))
                        Me.cboCaja.SelectedItem = Me.cboCaja.Items(0)

                    End If

                Case "LUXOR LIMA CASINO"
                    arrResultados = objDL.Seleccionar("27", frmLogin.Unidad)

                    If arrResultados.Count > 0 Then
                        cboCaja.Items.Clear()

                        For k As Integer = 0 To arrResultados.Count - 1
                            objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                            Select Case objBEC.GrupoId

                                Case Util.Enumeracion.enmGrupoParametro.FCB_CajayConteo_Cajas_Grupo
                                    Me.cboCaja.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))
                            End Select
                        Next

                        Me.cboCaja.Items.Insert(0, New BEC.COM.clsItem(0, ""))
                        Me.cboCaja.SelectedItem = Me.cboCaja.Items(0)

                    End If

                Case "LUXOR TACNA"
                    arrResultados = objDL.Seleccionar("26", frmLogin.Unidad)

                    If arrResultados.Count > 0 Then
                        cboCaja.Items.Clear()

                        For k As Integer = 0 To arrResultados.Count - 1
                            objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                            Select Case objBEC.GrupoId

                                Case Util.Enumeracion.enmGrupoParametro.FCB_CajayConteo_Cajas
                                    Me.cboCaja.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))
                            End Select
                        Next

                        Me.cboCaja.Items.Insert(0, New BEC.COM.clsItem(0, ""))
                        Me.cboCaja.SelectedItem = Me.cboCaja.Items(0)

                    End If

                Case "EMPRESA DE PRUEBA"
                    arrResultados = objDL.Seleccionar("26", frmLogin.Unidad)

                    If arrResultados.Count > 0 Then
                        cboCaja.Items.Clear()

                        For k As Integer = 0 To arrResultados.Count - 1
                            objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                            Select Case objBEC.GrupoId

                                Case Util.Enumeracion.enmGrupoParametro.FCB_CajayConteo_Cajas
                                    Me.cboCaja.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))
                            End Select
                        Next

                        Me.cboCaja.Items.Insert(0, New BEC.COM.clsItem(0, ""))
                        Me.cboCaja.SelectedItem = Me.cboCaja.Items(0)

                    End If
            End Select
        Catch ex As Exception
            'Me.tssMensaje.Text = ex.Message
        Finally
            objDL = Nothing
        End Try

    End Sub

    Private Sub LeerOperacionesCaja()
        Dim objBEC As BEC.FCB.clsOperacionCaja
        Dim objDALC As New DALC.FCB.clsOperacionCaja
        Dim arrResultado As ArrayList
        Dim arrFiltro As New ArrayList
        Dim Monto As String

        With arrFiltro
            .Add(ucFechaProceso.txtFecha.Text)
            .Add(CType(cboCaja.SelectedItem, BEC.COM.clsItem).ItemNombre)
            .Add(Util.Enumeracion.enmResultadoOperacion.NONE)
        End With

        'Limpiar el datasource del grid
        dgvResultados.DataSource = ""

        arrResultado = objDALC.Buscar(arrFiltro, frmLogin.Unidad)

        If arrResultado IsNot Nothing Then
            dgvResultados.Visible = True
            dgvResultados.DataSource = arrResultado

            CleanDGV()

            tssMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count.ToString)

            For k As Integer = 0 To dgvResultados.Rows.Count - 1

                objBEC = New BEC.FCB.clsOperacionCaja
                objBEC = CType(arrResultado(k), BEC.FCB.clsOperacionCaja)

                Monto = objBEC.OperacionMonto
                'Monto = dgvResultados.Rows(k).Cells(8).Value.ToString()
                Monto = Monto.Substring(0, Monto.Length - 1)
                objBEC.OperacionMonto = Monto
            Next

        Else
            dgvResultados.Visible = False
            tssMensaje.Text = Util.Constante.Ope_BuscarNONE
        End If


        FiltrarRegistros()
        MarcarRegistros()

    End Sub

    Private Sub MarcarRegistros()

        Dim strLimiteOperacionCaja() As String = Configuration.ConfigurationManager.AppSettings("FCB_LimiteMontoOperacionCaja").Split("|")
        Dim intMontoLimiteMonedaId As Integer = strLimiteOperacionCaja(0)
        Dim decMontoLimiteImporte As Decimal = strLimiteOperacionCaja(1)
        Dim decMontoImporte As Decimal = 0
        Dim decTipoCambio As Decimal = 0


        For k As Integer = 0 To dgvResultados.Rows.Count - 1
            decTipoCambio = dgvResultados.Rows(k).Cells("OperacionTipoCambio").Value
            decMontoImporte = Util.TipoCambio.Valor(dgvResultados.Rows(k).Cells("OperacionMontoMonedaId").Value, dgvResultados.Rows(k).Cells("OperacionMontoImporte").Value, intMontoLimiteMonedaId, decTipoCambio)

            '1. Marcar los registros para imprimir:
            If decMontoImporte >= decMontoLimiteImporte Then
                dgvResultados.Rows(k).DefaultCellStyle.BackColor = Color.Yellow
                'imageCell = CType(dgvResultados.Rows(k).Cells("Estado"), DataGridViewImageCell)
                'imageCell()
            Else

            End If

            '2. Marcar los registros eliminados:
            If dgvResultados.Rows(k).Cells("EstadoId").Value <> Util.Enumeracion.enmResultadoOperacion.OK Then
                dgvResultados.Rows(k).DefaultCellStyle.BackColor = Color.Red
            End If

        Next
    End Sub

    Private Sub FiltrarRegistros()

        Dim strLimiteOperacionCaja() As String = Configuration.ConfigurationManager.AppSettings("FCB_LimiteMontoOperacionCaja").Split("|")
        Dim intMontoLimiteMonedaId As Integer = strLimiteOperacionCaja(0)
        Dim decMontoLimiteImporte As Decimal = strLimiteOperacionCaja(1)
        Dim decMontoImporte As Decimal = 0
        Dim decTipoCambio As Decimal = 0
        Dim arrResultados, arrResultadosFiltrados As ArrayList
        Dim objBEC As BEC.FCB.clsOperacionCaja
        Dim bolHayFiltro As Boolean = False

        Try
            If chkFiltro.Checked Or chkActivos.Checked Then

                If dgvResultados.DataSource IsNot Nothing Then

                    arrResultados = dgvResultados.DataSource
                    arrResultadosFiltrados = New ArrayList

                    For k As Integer = 0 To arrResultados.Count - 1
                        objBEC = New BEC.FCB.clsOperacionCaja
                        objBEC = CType(arrResultados(k), BEC.FCB.clsOperacionCaja)

                        decTipoCambio = objBEC.OperacionTipoCambio
                        decMontoImporte = Util.TipoCambio.Valor(objBEC.OperacionMontoMonedaId, objBEC.OperacionMontoImporte, intMontoLimiteMonedaId, decTipoCambio)

                        If chkFiltro.Checked And Not chkActivos.Checked And decMontoImporte >= decMontoLimiteImporte Then
                            arrResultadosFiltrados.Add(objBEC)
                        ElseIf Not chkFiltro.Checked And chkActivos.Checked And objBEC.EstadoId = Util.Enumeracion.enmResultadoOperacion.OK Then
                            arrResultadosFiltrados.Add(objBEC)
                        ElseIf chkFiltro.Checked And chkActivos.Checked And decMontoImporte >= decMontoLimiteImporte And chkActivos.Checked And objBEC.EstadoId = Util.Enumeracion.enmResultadoOperacion.OK Then
                            arrResultadosFiltrados.Add(objBEC)
                        End If

                    Next

                    If arrResultadosFiltrados IsNot Nothing Then

                        If arrResultadosFiltrados.Count > 0 Then
                            dgvResultados.DataSource = arrResultadosFiltrados
                            CleanDGV()
                            MarcarRegistros()

                            tssMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultadosFiltrados.Count.ToString)

                        Else
                            Throw New DataException(Util.Constante.Ope_BuscarNONE)
                        End If

                    Else
                        Throw New DataException(Util.Constante.Ope_BuscarNONE)
                    End If

                Else
                    Throw New DataException(Util.Constante.Ope_BuscarSinParametros)
                End If

            End If

        Catch ex As Exception
            dgvResultados.Visible = False
            tssMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub CleanDGV()
        '1.-
        dgvResultados.Columns("OperacionCajaId").Visible = False
        '2.-
        dgvResultados.Columns(2).HeaderText = "No. Registro"
        '3.-
        dgvResultados.Columns("OperacionFecha").Visible = False

        dgvResultados.Columns.Remove("SujetoObligado")
        dgvResultados.Columns.Remove("OficialCumplimiento")

        '4.-
        dgvResultados.Columns("OperacionMontoMonedaId").Visible = False
        '5.-
        dgvResultados.Columns("OperacionMontoImporte").Visible = False
        '6.-
        dgvResultados.Columns("OperacionTipoCambio").Visible = False

        dgvResultados.Columns.Remove("OperacionModalidadId")

        '7.-
        dgvResultados.Columns("OperacionTipoId").Visible = False

        dgvResultados.Columns.Remove("OperacionReferencia")
        dgvResultados.Columns.Remove("OperacionTarjetaNum")
        dgvResultados.Columns.Remove("OperacionCaja")

        '8.-
        dgvResultados.Columns("ClienteId").Visible = False
        '9.-
        dgvResultados.Columns(9).HeaderText = "Cliente"

        dgvResultados.Columns.Remove("ClienteDocumento")

        '10.-
        dgvResultados.Columns(10).HeaderText = "Hora"
        '11.-
        dgvResultados.Columns(11).HeaderText = "Monto"

        dgvResultados.Columns.Remove("OperacionFichaMoneda")
        dgvResultados.Columns.Remove("OperacionFichaCantidad")
        dgvResultados.Columns.Remove("OperacionFichaDenominacion")
        dgvResultados.Columns.Remove("OperacionMaquinaNum")
        dgvResultados.Columns.Remove("OperacionComentario")

        '12.-
        dgvResultados.Columns("EstadoId").Visible = False

        dgvResultados.Columns.Remove("NumRegistro")
        '13.-
        'dgvResultados.Columns.Remove("Userid")
        dgvResultados.Columns.Remove("UserName")
        dgvResultados.Columns.Remove("TipoTarjetaCred")

        '14.-
        dgvResultados.Columns("NombreCaja").Visible = False
        '15.-
        dgvResultados.Columns("TipoDocumento").Visible = False
        '16.-
        dgvResultados.Columns("NumeroDocumento").Visible = False

        dgvResultados.Columns.Remove("AudCreac_UsuarioId")
        dgvResultados.Columns.Remove("AudCreac_Fecha")
        dgvResultados.Columns.Remove("AudEdic_UsuarioId")
        dgvResultados.Columns.Remove("AudCreac_Usuario")
        dgvResultados.Columns.Remove("AudEdic_Fecha")
        dgvResultados.Columns.Remove("AudEdic_Usuario")
        '17.-
        'dgvResultados.Columns.Remove("UnidadId")
    End Sub

    Private Sub Exportar()

        Dim result As DialogResult = folderBrowserDialog1.ShowDialog()
        Dim Path As String
        Dim di As DirectoryInfo
        Dim outputFile As String
        Dim Fecha As String = DateTime.Now.ToString("MM-dd-yy")
        Dim TipoOp As Integer
        Dim TipoOpNombre As String
        Dim ClienteTipoDoc As Integer
        Dim NumeroDoc As String
        Dim Nombre As String
        Dim Moneda As String
        Dim Monto As String

        If result = DialogResult.OK Then
            Path = FolderBrowserDialog1.SelectedPath
        End If

        If Not Directory.Exists(Path) Then
            di = Directory.CreateDirectory(Path)
        End If

        'Ruta para exportar
        outputFile = Path & "\" & "ReporteRegistroTransacciónCaja_" & Fecha & ".csv"

        'Verificar que el datagridview tenga informacion
        If dgvResultados.RowCount > 0 Then

            Using writer As StreamWriter = New StreamWriter(outputFile)

                writer.WriteLine("Fecha, Codigo_Operacion, DNI_Cliente, Nombre, Caja, Hora, Moneda, Monto, Tipo_Operacion")

                For Each row As DataGridViewRow In dgvResultados.Rows
                    'Obtener el valor de la celda de los diferentes campos

                    'Fecha
                    writer.Write(row.Cells(3).Value.ToString())
                    writer.Write(",")

                    'Codigo Operacion
                    writer.Write(row.Cells(2).Value.ToString())
                    writer.Write(",")

                    'DNI
                    ClienteTipoDoc = Convert.ToInt32(row.Cells(15).Value.ToString())
                    Select Case ClienteTipoDoc
                        Case 0
                            NumeroDoc = "TipoDoc-" & row.Cells(16).Value.ToString()
                        Case 1
                            NumeroDoc = "DNI-" & row.Cells(16).Value.ToString()
                        Case 2
                            NumeroDoc = "CE-" & row.Cells(16).Value.ToString()
                        Case 3
                            NumeroDoc = "PAS-" & row.Cells(16).Value.ToString()
                        Case 4
                            NumeroDoc = "CEDULA-" & row.Cells(16).Value.ToString()
                    End Select
                    writer.Write(NumeroDoc)
                    writer.Write(",")

                    'Nombre
                    Nombre = row.Cells(9).Value.ToString()
                    Nombre = Nombre.Replace(",", "")
                    writer.Write(Nombre)
                    writer.Write(",")

                    'Caja
                    writer.Write(row.Cells(13).Value.ToString())
                    writer.Write(",")

                    'Hora
                    writer.Write(row.Cells(10).Value.ToString())
                    writer.Write(",")

                    'Moneda
                    Moneda = row.Cells(4).Value.ToString()
                    Select Case Moneda
                        Case "1"
                            writer.Write("S/.")
                            Moneda = "S/. "
                        Case "2"
                            writer.Write("US$")
                            Moneda = "US$ "
                        Case "3"
                            writer.Write("€")
                            Moneda = "€ "
                    End Select
                    writer.Write(",")

                    'Monto
                    Monto = row.Cells(11).Value.ToString()
                    writer.Write(Monto.Replace(Moneda, ""))
                    writer.Write(",")

                    'Tipo Operacion
                    TipoOp = Convert.ToInt32(row.Cells(7).Value.ToString())
                    Select Case TipoOp
                        Case 1
                            TipoOpNombre = "Canje Dinero por Fichas"
                        Case 2
                            TipoOpNombre = "Canje Fichas por Dinero"
                        Case 3
                            TipoOpNombre = "Canje Tickets Slots"
                        Case 4
                            TipoOpNombre = "Canje Tickets por Fichas"
                        Case 5
                            TipoOpNombre = "Cobro premio Jackpot"
                        Case 6
                            TipoOpNombre = "Retiro Efectivo"
                    End Select
                    writer.Write(TipoOpNombre)

                    writer.WriteLine()
                Next

            End Using

            tssMensaje.Text = Util.Constante.Ope_ExportarReporte
        End If
    End Sub

#End Region

#Region "Eventos de Controles"

    Private Sub frmCajaBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnExport.Visible = False

        LeerParametros()

        'objHorario = New Util.clsHorario
        'Dim strFechaProceso As String = objHorario.FechaProcesoCyC

        'If strFechaProceso = "" Then strFechaProceso = Now.AddDays(-1).ToShortDateString

        'txtBuscarFecha.Text = strFechaProceso
        'dtpFechaRegistro.MaxDate = txtBuscarFecha.Text
        'dtpFechaRegistro.Value = dtpFechaRegistro.MaxDate

        LeerOperacionesCaja()

    End Sub

#End Region

    'Private Sub dtpFechaRegistro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtBuscarFecha.Text = dtpFechaRegistro.Value
    '    LeerOperacionesCaja()
    'End Sub

    Private Sub dgvResultados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvResultados.CellContentClick
        If e.ColumnIndex = 0 And e.RowIndex > -1 Then
            Dim objFrm As New frmCajaRegistro
            objFrm.intOperacionCajaId = dgvResultados.Rows(e.RowIndex).Cells("OperacionCajaId").Value
            objFrm.ShowDialog()
            objFrm.Dispose()
            LeerOperacionesCaja()
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Filtro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltro.CheckedChanged, chkActivos.CheckedChanged
        LeerOperacionesCaja()

        If chkFiltro.Checked = True Then
            btnExport.Visible = True
        End If
        If chkFiltro.Checked = False Then
            btnExport.Visible = False
        End If

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        LeerOperacionesCaja()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            Exportar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub
End Class