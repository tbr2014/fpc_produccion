Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms


Public Class frmClienteTicketsImprimir
    Implements IDisposable

    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    Public intClienteId As Integer
    Public intTipoJuegoId As Util.Enumeracion.enmFJMTipoNegocio
    'Private Shared strPrinterName = "PrimoPDF"
    Private Shared strPrinterName As String = ""
    Private Shared decPageWidth As Decimal = 10
    Private Shared decPageHeight As Decimal = 9.33

#Region "Operaciones"

    'Private Sub Buscar()

    '    Dim objDALC As New DALC.CLI.clsCliente
    '    Dim arrParam As New ArrayList
    '    Dim arrResultado As IList

    '    arrParam.Add(txtNombres.Text.Trim)
    '    arrParam.Add(txtApellidos.Text.Trim)

    '    arrResultado = objDALC.Buscar(arrParam)

    '    dgvClientes.DataSource = arrResultado
    '    'dgvClientes.Focus()

    'End Sub

    Private Function ClienteEscribirImpresion() As Boolean

        Dim objDALC As New DALC.CLI.clsClienteTicket
        Dim objBEC As New BEC.CLI.viwClienteTicket
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try

            With objBEC
                .ClienteId = lblClienteId.Text
                .ClienteNumDoc = txtNumDoc.Text.Trim
                .ClienteNombreCompleto = txtNombreCompleto.Text.Trim
                .ClienteNumTarjeta = Me.txtNumTarjeta.Text.Trim
                .TicketsTotal = txtTicketsTotal.Text
                .TicketsImpresos = txtTicketsImprimir.Value
                .TicketsNumInicial = txtNumInicial.Text.Trim
                .TicketsGUID = txtGUID.Text
                .TipoJuegoId = Me.intTipoJuegoId
                .AudUsuarioId = 1  ' iD DEL uSUARIO lOGUEADO
            End With

            intResultado = objDALC.Escribir(objBEC, frmLogin.Unidad)

            If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
                lblMensaje.Text = Util.Constante.Ope_OperacionOK

                If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                    Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
                    If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                    ' Pista de Auditoría:
                    frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Print, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                    frmLogin.objColeccionFCB.objAuditoria = Nothing
                    ' Fin de Auditoría
                End If

                Return True
            Else
                Throw New DataException(Util.Constante.Ope_EscribirERR)
                Return False
            End If

        Catch ex As Exception
            lblMensaje.Text = ex.Message
            Return False
        Finally
            objDALC = Nothing
        End Try

    End Function

    Private Sub VistaPrevia(ByVal strDato() As String)
        Try
            'CargarFuente()

            Dim arrParam(3) As ReportParameter

            arrParam(0) = New ReportParameter("rpNombreCompleto", strDato(0), False)
            arrParam(1) = New ReportParameter("rpNumDoc", strDato(1), False)
            arrParam(2) = New ReportParameter("rpNumTarjeta", strDato(2), False)
            arrParam(3) = New ReportParameter("rpGUID", strDato(3), False)

            With Me.rptViewer
                .LocalReport.SetParameters(arrParam)
                .Visible = True
                .RefreshReport()
            End With

        Catch ex As Exception
            Me.rptViewer.Visible = False
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Imprimir(ByVal intNumCopias As Integer)

        'Paper Size:
        Dim objPageSize As New PaperSize("PageSize", (decPageWidth / 2.54) * 100, (decPageHeight / 2.54) * 100)

        'Page Settings:
        Dim objPageSetting As New PageSettings
        With objPageSetting
            .PaperSize = objPageSize
        End With

        'Printer Settings:
        Dim objPrinterSettings As New PrinterSettings

        strPrinterName = "Epson DFX-8000" ' Util.Factory.FCB_ImpresoraTickets.ToString

        With objPrinterSettings
            .PrinterName = strPrinterName
            .Copies = intNumCopias
            '.PrinterName = "Epson DFX-8000"
        End With

        'Setting Parametros
        If objPrinterSettings.IsDefaultPrinter Then

            With objPrintDocument
                .PrinterSettings.PrinterName = strPrinterName
                .PrinterSettings = objPrinterSettings
                .DefaultPageSettings.PaperSize = objPageSize
                .DefaultPageSettings.PrinterSettings = objPrinterSettings
            End With

            'Exit Sub

            Export(rptViewer.LocalReport)

            m_currentPageIndex = 0
            If m_streams Is Nothing Or m_streams.Count = 0 Then
                Return
            End If

            If Not objPrintDocument.PrinterSettings.IsValid Then
                Dim msg As String = String.Format("Can't find printer ""{0}"".", strPrinterName)
                Console.WriteLine(msg)
                Return
            End If

            AddHandler objPrintDocument.PrintPage, AddressOf PrintPage

            'objPrintPreviewDialog = New PrintPreviewDialog

            'With objPrintPreviewDialog
            '    .Document = objPrintDocument
            '    .Refresh()
            '    .ShowDialog()
            'End With

            objPrintDocument.Print()

        End If

    End Sub

    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, _
     ByVal willSeek As Boolean) As Stream
        Dim strFile As String = name & Now.Year.ToString & Now.Month.ToString("00") & Now.Day.ToString("00") & "T" & Now.Hour.ToString("00") & Now.Minute.ToString("00") & Now.Second.ToString("00")
        Dim stream As Stream = _
            New FileStream("..\..\" + _
             strFile + "." + fileNameExtension, FileMode.Create)
        m_streams.Add(stream)
        Return stream
    End Function

    Private Sub Export(ByVal report As LocalReport)
        'Dim deviceInfo As String = _
        '  "<DeviceInfo>" + _
        '  "  <OutputFormat>EMF</OutputFormat>" + _
        '"  <PageWidth>8.5in</PageWidth>" + _
        '"  <PageHeight>11in</PageHeight>" + _
        '"  <MarginTop>0.25in</MarginTop>" + _
        '"  <MarginLeft>0.25in</MarginLeft>" + _
        '"  <MarginRight>0.25in</MarginRight>" + _
        '"  <MarginBottom>0.25in</MarginBottom>" + _
        '  "</DeviceInfo>"

        Dim deviceInfo As String = _
          "<DeviceInfo>" + _
            "  <OutputFormat>EMF</OutputFormat>" + _
            "  <PageWidth>" + decPageWidth.ToString + "cm</PageWidth>" + _
            "  <PageHeight>" + decPageHeight.ToString + "cm</PageHeight>" + _
            "  <MarginTop>0in</MarginTop>" + _
            "  <MarginLeft>0in</MarginLeft>" + _
            "  <MarginRight>0in</MarginRight>" + _
            "  <MarginBottom>0in</MarginBottom>" + _
          "</DeviceInfo>"

        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)

        Dim stream As Stream
        For Each stream In m_streams
            stream.Position = 0
        Next

    End Sub

    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
        ev.Graphics.DrawImage(pageImage, ev.PageBounds)

        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Public Function GenerarID() As String
        Dim sGUID As String
        sGUID = Mid(System.Guid.NewGuid.ToString(), 1, 6).ToUpper
        Return sGUID
    End Function

#End Region

    Private Sub btnImprimirRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        'Reset Impresión anterior:
        'm_streams.Clear()

        Dim strDato(3) As String

        strDato(0) = txtNombreCompleto.Text
        strDato(1) = txtNumDoc.Text
        strDato(2) = txtNumTarjeta.Text
        strDato(3) = txtGUID.Text

        VistaPrevia(strDato)

        If ClienteEscribirImpresion() Then
            Imprimir(txtTicketsImprimir.Value)
            If MessageBox.Show("Es conforme?", "Impresión", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                gbCorreccion.Visible = True
            End If

        Else
            lblMensaje.Text = Util.Constante.Ope_OperacionERR
        End If

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub frmImpresion1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNumDoc.Enabled = False
        txtNombreCompleto.Enabled = False
        txtNumTarjeta.Enabled = False

        gbPreImpresion.Enabled = False
        btnImprimir.Visible = False
        gbCorreccion.Visible = False
        lblMensaje.Text = ""
        'btnBuscar.Focus()

        Select Case intTipoJuegoId
            Case Util.Enumeracion.enmFJMTipoNegocio.Mesas
                Me.lblTitulo.Text &= " - Mesas"
            Case Util.Enumeracion.enmFJMTipoNegocio.Slots
                Me.lblTitulo.Text &= " - Slots"
        End Select

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        Dim objDALC As New DALC.CLI.clsClienteTicket
        Dim objBEC As New BEC.CLI.viwClienteTicket
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try
            With objBEC
                .ClienteId = lblClienteId.Text
                .TicketsPendientes = txtTicketsHabilitar.Value
                .TipoJuegoId = Me.intTipoJuegoId
            End With

            intResultado = objDALC.Extornar(objBEC, frmLogin.Unidad)

            If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
                MsgBox(Util.Constante.Ope_ActualizarOK, MsgBoxStyle.Information, Util.Constante.Msj_SistemaTitulo)
                Me.Close()
            Else
                Throw New DataException(Util.Constante.Ope_ActualizarERR)
            End If

        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

        Dim objfrm As New frmClienteTicketBuscar

        Try
            txtNumDoc.Enabled = False
            txtNombreCompleto.Enabled = False
            txtNumTarjeta.Enabled = False
            lblMensaje.Text = ""

            objfrm.intTipoJuegoId = Me.intTipoJuegoId
            objfrm.ShowDialog()

            If objfrm.objClienteTicket.ClienteId > 0 Then

                txtNumDoc.Enabled = True
                txtNombreCompleto.Enabled = True
                txtNumTarjeta.Enabled = True

                With objfrm.objClienteTicket
                    lblClienteId.Text = .ClienteId
                    txtNumDoc.Text = .ClienteNumDoc
                    txtNumTarjeta.Text = .ClienteNumTarjeta
                    txtNombreCompleto.Text = .ClienteNombreCompleto
                    txtTicketsTotal.Text = Math.Floor(.TicketsTotal)

                    Dim intTicketsImprimir As Integer = Math.Floor(.TicketsTotal) - .TicketsImpresos

                    If intTicketsImprimir >= 1 Then
                        txtTicketsImprimir.Text = intTicketsImprimir
                        txtTicketsImprimir.Maximum = intTicketsImprimir
                        txtTicketsHabilitar.Maximum = intTicketsImprimir

                        txtNumInicial.Text = ""

                        If .TicketsGUID <> "" Then
                            txtGUID.Text = .TicketsGUID
                        Else
                            txtGUID.Text = GenerarID()
                        End If

                        gbPreImpresion.Enabled = True
                        btnImprimir.Visible = True

                        lblMensaje.Text = Util.Constante.Ope_LeerOK

                    Else
                        Throw New DataException(Util.Constante.FCB_ImprimirTicket_NONE)
                    End If

                End With

            Else
                Throw New DataException(Util.Constante.FCB_ImprimirTicket_ERR)
            End If

        Catch ex As Exception
            lblClienteId.Text = ""
            txtNumDoc.Text = ""
            txtNumTarjeta.Text = ""
            txtNombreCompleto.Text = ""
            txtTicketsTotal.Text = ""
            txtTicketsImprimir.Text = ""
            txtNumInicial.Text = ""
            'txtGUID.Text = GenerarID()

            gbPreImpresion.Enabled = False
            btnImprimir.Visible = False

            lblMensaje.Text = ex.Message
        End Try

        objfrm.Dispose()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

End Class