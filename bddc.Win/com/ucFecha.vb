Public Class ucFecha

    Private objHorario As Util.clsHorario
    Private Shared intTipoTurno As Util.Enumeracion.enmFCBTipoTurno

#Region "Operaciones"

    Public Sub TipoTurno(ByVal pintTipoTurno As Util.Enumeracion.enmFCBTipoTurno)
        intTipoTurno = pintTipoTurno
    End Sub

    Public Sub IngresarFecha(ByVal bolHabilitar As Boolean)
        txtFecha.Enabled = bolHabilitar
    End Sub

    Public Sub UsarCalendario(ByVal bolHabilitar As Boolean)
        dtpFecha.Enabled = bolHabilitar
    End Sub

    Public Sub Aplicar()

        Try
            Dim strFechaProceso As String = ""
            objHorario = New Util.clsHorario

            Select Case intTipoTurno

                Case Util.Enumeracion.enmFCBTipoTurno.Mesas
                    strFechaProceso = objHorario.FechaProcesoFCB

                Case Util.Enumeracion.enmFCBTipoTurno.Cajas
                    strFechaProceso = objHorario.FechaProcesoCyC(frmLogin.Unidad)

                Case Else
                    MsgBox("Elegir Tipo de Turno!", MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
                    Exit Sub

            End Select

            If strFechaProceso <> "" Then
                dtpFecha.Value = strFechaProceso
                dtpFecha.MaxDate = dtpFecha.Value
            End If

        Catch ex As Exception

            Dim strMsjError As String = Util.Constante.FCB_HoraProceso_ERR
            strMsjError = Replace(strMsjError, "XX", Util.Factory.CyC_HorarioAtencionIni)
            strMsjError = Replace(strMsjError, "YY", Util.Factory.CyC_HorarioAtencionFin)

            MsgBox(strMsjError, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)

        Finally
            objHorario = Nothing

        End Try

    End Sub

#End Region

#Region "Eventos de Controles"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        intTipoTurno = 0
        txtFecha.Enabled = False
        dtpFecha.Enabled = False

    End Sub

    Private Sub ucFecha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub dtpFechaRegistro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        txtFecha.Text = dtpFecha.Value
    End Sub

#End Region

End Class
