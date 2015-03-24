Imports System.Drawing

Public Class frmEstimadoMesas

#Region "Atributos"
    Private objBEC As BEC.FJM.clsEstimadoMesa
    Private objDALC As DALC.FJM.clsEstimadoMesa
    Private arrGrilla(5) As ArrayList
    Private arrDrop As ArrayList
    Private arrWinLoss As ArrayList
    Private Shared decTipoCambio As Decimal
    Private Shared intFilaSubTotal As ArrayList
    Private Shared intFilaTotal As Integer
    Private Shared arrDatosxPit(5) As ArrayList
    Private Shared intColumnaInicio As Integer = 8
    Private objHorario As Util.clsHorario

    Public Shared bolEditar As Boolean
    Private Shared bolGuardar As Boolean

#End Region

#Region "Operaciones"

    Private Sub CargarParametros()
        Dim objDALC As New DALC.COM.clsTipoCambio
        decTipoCambio = objDALC.Leer(frmLogin.Unidad)
    End Sub

    Private Sub ResetGrilla()

        Try
            arrDrop = New ArrayList
            arrWinLoss = New ArrayList

            For k As Integer = 1 To 12
                arrDrop.Add(0)
                arrWinLoss.Add(0)
            Next

            '====
            'Pit 1
            '====
            arrGrilla(0) = New ArrayList

            With arrGrilla(0)

                .Add(New BEC.FJM.viwEstimadoMesa(9, 1, "RL", "01", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(10, 1, "RL", "02", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 2, "US$", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(7, 2, "BJ", "07", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(8, 2, "BJ", "08", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 2, "US$", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(11, 1, "RL", "03", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(12, 1, "RL", "04", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(13, 1, "RL", "05", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(14, 1, "RL", "06", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 1, "S/.", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(1, 2, "BJ", "01", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(2, 2, "BJ", "02", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(3, 2, "BJ", "03", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(4, 2, "BJ", "04", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(5, 2, "BJ", "05", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(6, 2, "BJ", "06", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 1, "S/.", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(15, 3, "PK", "01", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(16, 3, "PK", "02", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 1, "S/.", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "Total", "", 2, "US$", arrDrop, arrWinLoss))

            End With

            '====
            'Pit 2
            '====
            arrGrilla(1) = New ArrayList

            With arrGrilla(1)

                .Add(New BEC.FJM.viwEstimadoMesa(17, 5, "MDPB", "01", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(18, 5, "MDPB", "02", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(19, 5, "MDPB", "03", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(20, 5, "MDPB", "04", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 2, "US$", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "Total", "", 2, "US$", arrDrop, arrWinLoss))

            End With

            '====
            'Pit 3
            '====
            arrGrilla(2) = New ArrayList

            With arrGrilla(2)

                .Add(New BEC.FJM.viwEstimadoMesa(21, 1, "RL", "08", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(22, 1, "RL", "09", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 2, "US$", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(23, 2, "BJ", "10", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(24, 2, "BJ", "11", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 2, "US$", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(25, 5, "MDPB", "05", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(26, 4, "THP", "06", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(27, 4, "THP", "07", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(28, 4, "THP", "08", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(29, 4, "THP", "09", 2, "US$", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 2, "US$", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "Total", "", 2, "US$", arrDrop, arrWinLoss))

            End With

            '====
            'Pit 4
            '====
            arrGrilla(3) = New ArrayList

            With arrGrilla(3)

                .Add(New BEC.FJM.viwEstimadoMesa(30, 1, "RL", "07", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(31, 2, "BJ", "09", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 1, "S/.", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(32, 4, "THP", "01", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(33, 4, "THP", "02", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(34, 4, "THP", "03", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(35, 4, "THP", "04", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(36, 4, "THP", "05", 1, "S/.", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "SubTotal", "", 1, "S/.", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "Total", "", 1, "S/.", arrDrop, arrWinLoss))

            End With

            '=============
            ' Consolidado
            '=============

            arrGrilla(4) = New ArrayList

            With arrGrilla(4)

                .Add(New BEC.FJM.viwEstimadoMesa(0, 1, "Pit", "01", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 2, "Pit", "02", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 3, "Pit", "03", 2, "US$", arrDrop, arrWinLoss))
                .Add(New BEC.FJM.viwEstimadoMesa(0, 4, "Pit", "04", 2, "US$", arrDrop, arrWinLoss))

                .Add(New BEC.FJM.viwEstimadoMesa(0, 0, "Total", "", 2, "US$", arrDrop, arrWinLoss))

            End With

            'Escribiendo en la grilla:
            dgvFormPit_1.DataSource = arrGrilla(0)
            dgvFormPit_2.DataSource = arrGrilla(1)
            dgvFormPit_3.DataSource = arrGrilla(2)
            dgvFormPit_4.DataSource = arrGrilla(3)
            dgvFormPit_5.DataSource = arrGrilla(4)

            Me.ResumeLayout(True)

            FormatGrilla()

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        End Try

    End Sub

    Private Sub FormatGrilla()

        Dim objGrilla As DataGridView
        Dim objFont As New Font("Tahoma", 7)
        Dim objColor(4), objColorActual As Color
        Dim strMoneda As String = ""
        Dim strTipoJuego As String = ""

        objColor(0) = Color.Blue
        objColor(1) = Color.Green
        objColor(2) = Color.Black ' SubTota/Total (Numeros)
        objColor(3) = Color.Gainsboro   ' SubTotal (Fondo)
        objColor(4) = Color.LightSlateGray    ' Total (Fondo)

        Try

            For k As Integer = 1 To TabControl1.TabPages.Count

                strMoneda = "MonedaId" & k.ToString
                strTipoJuego = "TipoJuego" & k.ToString

                objGrilla = New DataGridView
                Select Case k
                    Case 1
                        objGrilla = dgvFormPit_1
                        TabControl1.TabPages("tpPit1").Show()
                    Case 2
                        objGrilla = dgvFormPit_2
                        TabControl1.TabPages("tpPit2").Show()
                    Case 3
                        objGrilla = dgvFormPit_3
                        TabControl1.TabPages("tpPit3").Show()
                    Case 4
                        objGrilla = dgvFormPit_4
                        TabControl1.TabPages("tpPit4").Show()
                    Case 5
                        objGrilla = dgvFormPit_5
                        TabControl1.TabPages("tpConsolidado").Show()
                End Select

                objGrilla.Font = objFont

                For fil As Integer = 0 To objGrilla.RowCount - 1

                    If Convert.ToInt16(objGrilla.Item(strMoneda, fil).Value) = 1 Then
                        objColorActual = objColor(0)
                    Else
                        objColorActual = objColor(1)
                    End If

                    For col As Integer = intColumnaInicio - 3 To objGrilla.ColumnCount - 1

                        objGrilla.Item(col, fil).Style.ForeColor = objColorActual
                        If col = 5 Then objGrilla.Item(col, fil).Style.Font = New Font(objGrilla.Font, FontStyle.Bold)

                        If col >= 8 Then
                            If col Mod 2 = 0 Then objGrilla.Item(col, fil).Style.BackColor = Color.WhiteSmoke
                        End If

                        'Si es una fila para Total:
                        Select Case objGrilla.Item(strTipoJuego, fil).Value
                            Case "SubTotal"
                                objGrilla.Item(col, fil).Style.BackColor = objColor(3)
                                objGrilla.Item(col, fil).Style.ForeColor = objColor(2)
                                objGrilla.Item(col, fil).ReadOnly = True

                            Case "Total"
                                objGrilla.Item(col, fil).Style.BackColor = objColor(4)
                                objGrilla.Item(col, fil).Style.ForeColor = objColor(2)
                                objGrilla.Item(col, fil).ReadOnly = True

                        End Select

                    Next

                Next

                ' Seteando Filas de SubTotal y Total:
                intFilaSubTotal = New ArrayList
                intFilaTotal = 0

                For fil As Integer = 0 To objGrilla.RowCount - 1

                    Select Case objGrilla.Item(strTipoJuego, fil).Value
                        Case "SubTotal"
                            intFilaSubTotal.Add(fil)
                        Case "Total"
                            intFilaTotal = fil
                    End Select

                Next

                ' Guardando datos de la grilla:
                If k.ToString <> "" Then
                    arrDatosxPit(k) = New ArrayList
                    arrDatosxPit(k).Add(intFilaSubTotal)
                    arrDatosxPit(k).Add(intFilaTotal)
                End If

            Next

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        End Try

    End Sub

    Private Sub ResetFila(ByVal objGrilla As DataGridView, ByVal intFila As Integer)
        If intFila <> -1 Then
            For col As Integer = intColumnaInicio To objGrilla.ColumnCount - 1
                Dim decValor As Decimal = 0 ' 
                objGrilla.Item(col, intFila).Value = Math.Round(decValor, 2)
            Next
        End If
    End Sub

    Private Sub Acumular_en_Fila(ByVal objGrillaOrigen As DataGridView, ByVal intFilaOrigen As Integer, ByVal objGrillaDestino As DataGridView, ByVal intFilaDestino As Integer)

        If intFilaOrigen <> -1 And intFilaDestino <> -1 Then

            Dim intMonedaId_Origen As Integer = objGrillaOrigen.Item(intColumnaInicio - 2, intFilaOrigen).Value
            Dim intMonedaId_Destino As Integer = objGrillaDestino.Item(intColumnaInicio - 2, intFilaDestino).Value

            For col As Integer = intColumnaInicio To objGrillaOrigen.ColumnCount - 1
                Dim decValor As Decimal = Convert.ToDecimal(objGrillaDestino.Item(col, intFilaDestino).Value)

                If intMonedaId_Origen <> intMonedaId_Destino Then
                    Select Case intMonedaId_Origen
                        Case 1
                            decValor += Convert.ToDecimal(objGrillaOrigen.Item(col, intFilaOrigen).Value) / decTipoCambio
                        Case 2
                            decValor += Convert.ToDecimal(objGrillaOrigen.Item(col, intFilaOrigen).Value)
                    End Select
                Else
                    decValor += Convert.ToDecimal(objGrillaOrigen.Item(col, intFilaOrigen).Value)
                End If

                objGrillaDestino.Item(col, intFilaDestino).Value = Math.Round(decValor, 2)
            Next

        End If

    End Sub

    Private Sub SumarizarFilas(ByVal objGrilla As DataGridView)

        Dim strNumPit() As String = objGrilla.Name.Split("_")
        Dim intFilaDestino As Integer = 0

        intFilaSubTotal = arrDatosxPit(strNumPit(1))(0)
        intFilaTotal = arrDatosxPit(strNumPit(1))(1)

        'Reset:
        For k As Integer = 0 To intFilaSubTotal.Count - 1
            ResetFila(objGrilla, intFilaSubTotal(k))
        Next

        Select Case strNumPit(1)

            Case 1
                For intFilaActual As Integer = 0 To 20
                    Select Case intFilaActual
                        Case 0, 1
                            intFilaDestino = intFilaSubTotal(0)
                        Case 3, 4
                            intFilaDestino = intFilaSubTotal(1)
                        Case 6, 7, 8, 9
                            intFilaDestino = intFilaSubTotal(2)
                        Case 11, 12, 13, 14, 15, 16
                            intFilaDestino = intFilaSubTotal(3)
                        Case 18, 19
                            intFilaDestino = intFilaSubTotal(4)
                        Case Else
                            intFilaDestino = -1
                    End Select
                    Acumular_en_Fila(objGrilla, intFilaActual, objGrilla, intFilaDestino)
                Next

            Case 2
                For intFilaActual As Integer = 0 To 20
                    Select Case intFilaActual
                        Case 0, 1, 2, 3
                            intFilaDestino = intFilaSubTotal(0)
                        Case Else
                            intFilaDestino = -1
                    End Select
                    Acumular_en_Fila(objGrilla, intFilaActual, objGrilla, intFilaDestino)
                Next

            Case 3
                For intFilaActual As Integer = 0 To 20
                    Select Case intFilaActual
                        Case 0, 1
                            intFilaDestino = intFilaSubTotal(0)
                        Case 3, 4
                            intFilaDestino = intFilaSubTotal(1)
                        Case 6, 7, 8, 9, 10
                            intFilaDestino = intFilaSubTotal(2)
                        Case Else
                            intFilaDestino = -1
                    End Select
                    Acumular_en_Fila(objGrilla, intFilaActual, objGrilla, intFilaDestino)
                Next

            Case 4
                For intFilaActual As Integer = 0 To 20
                    Select Case intFilaActual
                        Case 0, 1
                            intFilaDestino = intFilaSubTotal(0)
                        Case 3, 4, 5, 6, 7
                            intFilaDestino = intFilaSubTotal(1)
                        Case Else
                            intFilaDestino = -1
                    End Select
                    Acumular_en_Fila(objGrilla, intFilaActual, objGrilla, intFilaDestino)
                Next

        End Select

        'Sub-totales:
        ResetFila(objGrilla, intFilaTotal)
        For k As Integer = 0 To intFilaSubTotal.Count - 1
            Acumular_en_Fila(objGrilla, intFilaSubTotal(k), objGrilla, intFilaTotal)
        Next

        'Consolidado:
        ResetFila(dgvFormPit_5, arrDatosxPit(5)(1)) ' Grand Total
        ResetFila(dgvFormPit_5, strNumPit(1) - 1)
        Acumular_en_Fila(objGrilla, intFilaTotal, dgvFormPit_5, strNumPit(1) - 1)

        For intFilaActual As Integer = 0 To arrDatosxPit(5)(1) - 1
            Acumular_en_Fila(dgvFormPit_5, intFilaActual, dgvFormPit_5, arrDatosxPit(5)(1))
        Next

    End Sub

    Private Sub EscribirDatos()

        Dim objGrilla As DataGridView
        Dim intResultado As Integer = 0

        Try

            If bolEditar And Not bolGuardar Then

                Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
                If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
                    intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                Else
                    Throw New DataException(Util.Constante.Acc_SesionERR)
                End If


                For k As Integer = 1 To TabControl1.TabPages.Count

                    '1. Seleccionar una grilla:
                    objGrilla = New DataGridView
                    Select Case k
                        Case 1
                            objGrilla = dgvFormPit_1
                            'TabControl1.TabPages("tpPit1").Show()
                        Case 2
                            objGrilla = dgvFormPit_2
                            'TabControl1.TabPages("tpPit2").Show()
                        Case 3
                            objGrilla = dgvFormPit_3
                            'TabControl1.TabPages("tpPit3").Show()
                        Case 4
                            objGrilla = dgvFormPit_4
                            'TabControl1.TabPages("tpPit4").Show()
                        Case 5
                            objGrilla = dgvFormPit_5
                            'TabControl1.TabPages("tpConsolidado").Show()
                    End Select

                    '2. Recoger datos de las mesas:
                    Dim intMesaId As Integer

                    objDALC = New DALC.FJM.clsEstimadoMesa

                    For fil As Integer = 0 To objGrilla.RowCount - 1

                        intMesaId = objGrilla.Item(1, fil).Value
                        If intMesaId <> 0 Then
                            objBEC = New BEC.FJM.clsEstimadoMesa
                            With objBEC
                                .EstimadoMesaId = objGrilla.Item(0, fil).Value
                                .MesaId = intMesaId
                                .EstimadoMesaFecha = ucFechaProceso.txtFecha.Text
                                .AudCreac_UsuarioId = intUsuarioId
                            End With

                            For col As Integer = intColumnaInicio To objGrilla.ColumnCount - 1
                                If col = 7 Then
                                    objBEC.EstimadoMesaLista = objGrilla.Item(col, fil).Value
                                Else
                                    objBEC.EstimadoMesaLista &= "|" & objGrilla.Item(col, fil).Value
                                End If
                            Next

                            intResultado += objDALC.Escribir(objBEC, frmLogin.Unidad)

                        End If

                    Next

                Next

                'TabControl1.TabPages("tpPit1").Show()

                If intResultado = 36 Then
                    bolGuardar = True 'Datos guardados.
                    bolEditar = False 'Fin de Edición

                    tssMensaje.Text = Util.Constante.Ope_ActualizarGridOK

                    If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                        ' Pista de Auditoría:
                        frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                        frmLogin.objColeccionFCB.objAuditoria = Nothing
                        ' Fin de Auditoría
                    End If

                    MsgBox(Util.Constante.Ope_ActualizarGridOK, MsgBoxStyle.Information, Util.Constante.Msj_SistemaTitulo)
                Else
                    Throw New DataException(Util.Constante.Ope_ActualizarGridERR)
                End If

            Else
                Throw New DataException(Util.Constante.Ope_ActualizarGridERR)
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        End Try

    End Sub

    Private Sub LeerDatos()

        Dim objGrilla As DataGridView
        Dim intResultado As Integer = 0
        Dim arrFiltro As New ArrayList
        Dim arrResultado As IList
        Dim strValores() As String = Nothing
        Dim intMesaId As Integer

        Try
            If ucFechaProceso.txtFecha.Text <> "" Then

                ResetGrilla()
                objDALC = New DALC.FJM.clsEstimadoMesa

                arrFiltro.Add(ucFechaProceso.txtFecha.Text)
                arrResultado = objDALC.Buscar(arrFiltro, frmLogin.Unidad)

                If arrResultado Is Nothing Then
                    tssMensaje.Text = Util.Constante.Ope_BuscarNONE
                    Exit Sub
                End If

                For k As Integer = 1 To TabControl1.TabPages.Count

                    '1. Seleccionar una grilla:
                    objGrilla = New DataGridView
                    Select Case k
                        Case 1
                            objGrilla = dgvFormPit_1
                            TabControl1.TabPages("tpPit1").Show()
                        Case 2
                            objGrilla = dgvFormPit_2
                            TabControl1.TabPages("tpPit2").Show()
                        Case 3
                            objGrilla = dgvFormPit_3
                            TabControl1.TabPages("tpPit3").Show()
                        Case 4
                            objGrilla = dgvFormPit_4
                            TabControl1.TabPages("tpPit4").Show()
                        Case 5
                            objGrilla = dgvFormPit_5
                            TabControl1.TabPages("tpConsolidado").Show()
                    End Select

                    '2. Recoger datos de las mesas:
                    For fil As Integer = 0 To objGrilla.RowCount - 1

                        intMesaId = objGrilla.Item(1, fil).Value

                        For p As Integer = 0 To arrResultado.Count - 1
                            objBEC = New BEC.FJM.clsEstimadoMesa
                            objBEC = CType(arrResultado(p), BEC.FJM.clsEstimadoMesa)

                            If intMesaId = objBEC.MesaId Then
                                objGrilla.Item(0, fil).Value = objBEC.EstimadoMesaId
                                strValores = objBEC.EstimadoMesaLista.Split("|")

                                For col As Integer = intColumnaInicio To objGrilla.ColumnCount - 1
                                    objGrilla.Item(col, fil).Value = strValores(col - intColumnaInicio + 1)
                                Next
                                Exit For
                            End If

                        Next

                    Next

                Next

                If arrResultado.Count = 36 Then

                    SumarizarFilas(dgvFormPit_1)
                    SumarizarFilas(dgvFormPit_2)
                    SumarizarFilas(dgvFormPit_3)
                    SumarizarFilas(dgvFormPit_4)

                    tssMensaje.Text = Util.Constante.Ope_LeerOK

                    TabControl1.TabPages("tpPit1").Show()
                    TabControl1.TabPages("tpPit1").Select()
                    TabControl1.TabPages("tpPit1").ResumeLayout(False)

                    bolGuardar = False

                Else
                    tssMensaje.Text = Util.Constante.Ope_LeerERR
                End If

            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        Finally
            objDALC = Nothing
        End Try

    End Sub

    Private Sub HabilitarGridPits(ByVal bolEstado As Boolean)
        dgvFormPit_1.ReadOnly = Not bolEstado
        dgvFormPit_2.ReadOnly = Not bolEstado
        dgvFormPit_3.ReadOnly = Not bolEstado
        dgvFormPit_4.ReadOnly = Not bolEstado
        dgvFormPit_5.ReadOnly = Not bolEstado
    End Sub

    Private Sub HabilitarGrid()

        objHorario = New Util.clsHorario

        If ucFechaProceso.txtFecha.Text = objHorario.FechaProcesoFCB Then
            HabilitarGridPits(True)
        Else
            HabilitarGridPits(False)
        End If
        LeerDatos()

    End Sub

#End Region

#Region "Eventos de Controles"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmEstimadoMesas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmLogin.ConfigurarBarraxPermisos(ToolStrip1, Util.Enumeracion.enmSEGModulos.MODFPC)
        CargarParametros()
        ResetGrilla()

        'Control Fecha:
        ucFechaProceso.TipoTurno(Util.Enumeracion.enmFCBTipoTurno.Mesas)
        ucFechaProceso.IngresarFecha(False)
        ucFechaProceso.UsarCalendario(True)
        ucFechaProceso.Aplicar()

        'objHorario = New Util.clsHorario
        'dtpFechaProceso.Value = objHorario.FechaProcesoFCB 'Today.AddDays(-1).ToShortDateString
        'dtpFechaProceso.MaxDate = dtpFechaProceso.Value

        HabilitarGrid()

        'Timer1.Enabled = True
        'Timer1.Start()

    End Sub

    Private Sub dgvFormPit_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFormPit_1.CellEndEdit, dgvFormPit_2.CellEndEdit, dgvFormPit_3.CellEndEdit, dgvFormPit_4.CellEndEdit
        Try
            If bolEditar = False Then
                bolEditar = True 'Si nadie edita, tomo el control para Editar!
                SumarizarFilas(CType(sender, DataGridView))
            Else
                tssMensaje.Text = Util.Constante.Msj_UsuarioEditando
            End If

        Catch ex As Exception
            tssMensaje.Text = Util.Constante.Msj_DatoInvalido
        End Try

    End Sub

    Private Sub dgvFormPit_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFormPit_1.CellLeave, dgvFormPit_2.CellLeave, dgvFormPit_3.CellLeave, dgvFormPit_4.CellLeave
        tssMensaje.ForeColor = Color.Black
        tssMensaje.Text = ""
    End Sub

    Private Sub dgvFormPit_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvFormPit_1.DataError, dgvFormPit_2.DataError, dgvFormPit_3.DataError, dgvFormPit_4.DataError
        tssMensaje.ForeColor = Color.Red
        tssMensaje.Text = Util.Constante.Msj_DatoInvalido
    End Sub

    'Private Sub pbGuardarCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    EscribirDatos()
    '    LeerDatos()
    'End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If bolEditar = True Then
            EscribirDatos()
        Else
            MsgBox(Util.Constante.Ope_ActualizarGridERR & " - " & Util.Constante.Msj_UsuarioEditando, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
        End If
        LeerDatos()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub HabilitarGrid_Launch(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        HabilitarGrid()
    End Sub

#End Region

    Private Sub dgvFormPit_1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFormPit_1.CellContentClick

    End Sub
End Class