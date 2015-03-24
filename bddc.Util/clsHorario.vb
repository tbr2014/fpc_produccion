Public Class clsHorario

    Public Function FechaProcesoFCB() As String

        Dim strFechaProceso As String = ""
        Select Case Now.Hour
            Case Is >= Util.Factory.FCB_HorarioAtencionIni
                strFechaProceso = Now.ToShortDateString

            Case Is < Util.Factory.FCB_HorarioAtencionFin
                strFechaProceso = Now.AddDays(-1).ToShortDateString

            Case Else
                strFechaProceso = Now.AddDays(-1).ToShortDateString

        End Select

        Return strFechaProceso

    End Function

    Public Function FechaProcesoCyC(ByVal Unidad As String) As String

        'Dim strDatos As String = Util.Factory.CyC_HorarioAtencionIni

        Dim strFechaProceso As String = ""

        Dim saveNow As DateTime = DateTime.Now
        Dim hora As String = saveNow.ToString("HH:mm")


        Dim uni As Integer = StrComp(Unidad, "FIESTA CASINO BENAVIDES")
        If uni = 0 Then
            Util.Factory.ConfigOrigen = 1
            Dim HoraIni As String = Util.Factory.CyC_HorarioAtencionIni
            Dim HoraFin As String = Util.Factory.CyC_HorarioAtencionFin

            Select Case Now.Hour
                Case Is >= HoraIni
                    strFechaProceso = Now.ToShortDateString

                Case Is <= HoraFin
                    strFechaProceso = Now.AddDays(-1).ToShortDateString

                Case Else
                    strFechaProceso = Now.ToShortDateString

            End Select
        Else
            Util.Factory.ConfigOrigen = 2

            Select Case Now.Hour
                Case Is >= Util.Factory.CyC_HorarioAtencionIni
                    strFechaProceso = Now.ToShortDateString

                Case Is <= Util.Factory.CyC_HorarioAtencionFin
                    strFechaProceso = Now.AddDays(-1).ToShortDateString

                Case Else
                    strFechaProceso = Now.ToShortDateString

            End Select

        End If


        Return strFechaProceso

    End Function

End Class
