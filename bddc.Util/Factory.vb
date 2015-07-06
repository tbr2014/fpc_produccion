Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Configuration

Public Class Factory

    Public Shared ConfigOrigen As Util.Enumeracion.enmConfigOrigen

    Public Sub New()
        'ConfigOrigen = Configuration.ConfigurationSettings.AppSettings("ConfigOrigen")
    End Sub

    Private Shared Function ReadRegedit(ByVal strValor As String) As String
        Dim reg As RegistryKey
        Dim strDbConnection As String = ""

        reg = Registry.LocalMachine.OpenSubKey("SOFTWARE\BDDC")
        strDbConnection = reg.GetValue(strValor)
        Return strDbConnection

    End Function

    Public Shared ReadOnly Property Version() As String
        Get
            Select Case ConfigOrigen
                Case Enumeracion.enmConfigOrigen.FIESTACONFING
                    Return ConfigurationSettings.AppSettings("Version")
                Case Enumeracion.enmConfigOrigen.LUXORCONFING
                    Return ConfigurationSettings.AppSettings("Version")
                Case Else
                    Return ConfigurationSettings.AppSettings("Version")
            End Select
        End Get
    End Property

    Public Shared ReadOnly Property GetConexion() As String
        Get
            'Select Case ConfigOrigen
            '    Case Enumeracion.enmConfigOrigen.FIESTACONFING
            '        Return ConfigurationSettings.AppSettings("ConnectionStringFiesta")
            '    Case Enumeracion.enmConfigOrigen.LUXORCONFING
            '        Return ConfigurationSettings.AppSettings("ConnectionString")
            '    Case Enumeracion.enmConfigOrigen.TACNACONFING
            '        Return ConfigurationSettings.AppSettings("ConnectionStringTacna")
            '    Case Enumeracion.enmConfigOrigen.REGISTRY
            '        Return ReadRegedit("ConnectionString")
            '    Case Else
            '        Return ConfigurationSettings.AppSettings("ConnectionString")
            'End Select
            Select Case ConfigOrigen
                Case Enumeracion.enmConfigOrigen.FIESTACONFING
                    Return ConfigurationSettings.AppSettings("ConnectionStringFiesta")
                Case Enumeracion.enmConfigOrigen.LUXORCONFING
                    Return ConfigurationSettings.AppSettings("ConnectionStringLuxor")
                Case Enumeracion.enmConfigOrigen.TACNACONFING
                    Return ConfigurationSettings.AppSettings("ConnectionStringTacna")
                Case Enumeracion.enmConfigOrigen.REGISTRY
                    Return ReadRegedit("ConnectionString")
                Case Else
                    Return ConfigurationSettings.AppSettings("ConnectionString")
            End Select
        End Get
    End Property

    Public Shared ReadOnly Property FCB_NumMesasxTipoJuego() As String
        Get
            Select Case ConfigOrigen
                Case Enumeracion.enmConfigOrigen.FIESTACONFING
                    Return ConfigurationSettings.AppSettings("FCB_NumMesasxTipoJuego")
                Case Enumeracion.enmConfigOrigen.REGISTRY
                    Return ReadRegedit("FCB_NumMesasxTipoJuego")
                Case Else
                    Return ConfigurationSettings.AppSettings("FCB_NumMesasxTipoJuego")
            End Select
        End Get
    End Property

    Public Shared ReadOnly Property FCB_RepositorioFotos() As String
        Get
            Select Case ConfigOrigen
                Case Enumeracion.enmConfigOrigen.FIESTACONFING
                    Return ConfigurationSettings.AppSettings("FCB_RepositorioFotos")
                Case Enumeracion.enmConfigOrigen.REGISTRY
                    Return ReadRegedit("FCB_RepositorioFotos")
                Case Else
                    Return ConfigurationSettings.AppSettings("FCB_RepositorioFotos")
            End Select
        End Get
    End Property

    Public Shared ReadOnly Property FCB_HorarioAtencionIni() As String
        Get
            Select Case ConfigOrigen
                Case Enumeracion.enmConfigOrigen.FIESTACONFING
                    Return ConfigurationSettings.AppSettings("FCB_HorarioAtencionIni")
                Case Enumeracion.enmConfigOrigen.REGISTRY
                    Return ReadRegedit("FCB_HorarioAtencionIni")
                Case Else
                    Return ConfigurationSettings.AppSettings("FCB_HorarioAtencionIni")
            End Select
        End Get
    End Property

    Public Shared ReadOnly Property FCB_HorarioAtencionFin() As String
        Get
            Select Case ConfigOrigen
                Case Enumeracion.enmConfigOrigen.FIESTACONFING
                    Return ConfigurationSettings.AppSettings("FCB_HorarioAtencionFin")
                Case Enumeracion.enmConfigOrigen.REGISTRY
                    Return ReadRegedit("FCB_HorarioAtencionFin")
                Case Else
                    Return ConfigurationSettings.AppSettings("FCB_HorarioAtencionFin")
            End Select
        End Get
    End Property

    Public Shared ReadOnly Property FCB_ClienteMaxTier() As String
        Get
            Select Case ConfigOrigen
                Case Enumeracion.enmConfigOrigen.FIESTACONFING
                    Return ConfigurationSettings.AppSettings("FCB_ClienteMaxTier")
                Case Enumeracion.enmConfigOrigen.REGISTRY
                    Return ReadRegedit("FCB_ClienteMaxTier")
                Case Else
                    Return ConfigurationSettings.AppSettings("FCB_ClienteMaxTier")
            End Select
        End Get
    End Property

    Public Shared ReadOnly Property CyC_HorarioAtencionIni() As String
        Get
            Select Case ConfigOrigen
                Case Enumeracion.enmConfigOrigen.FIESTACONFING
                    Return ConfigurationSettings.AppSettings("CyC_HorarioAtencionIniFiesta")
                Case Enumeracion.enmConfigOrigen.LUXORCONFING
                    Return ConfigurationSettings.AppSettings("CyC_HorarioAtencionIniLuxor")
                Case Else
                    Return ConfigurationSettings.AppSettings("CyC_HorarioAtencionIni")
            End Select
        End Get
    End Property

    Public Shared ReadOnly Property CyC_HorarioAtencionFin() As String
        Get
            Select Case ConfigOrigen
                Case Enumeracion.enmConfigOrigen.FIESTACONFING
                    Return ConfigurationSettings.AppSettings("CyC_HorarioAtencionFinFiesta")
                Case Enumeracion.enmConfigOrigen.LUXORCONFING
                    Return ConfigurationSettings.AppSettings("CyC_HorarioAtencionFinLuxor")
                Case Else
                    Return ConfigurationSettings.AppSettings("CyC_HorarioAtencionFin")
            End Select
        End Get
    End Property

    ' Propiedades para Proceso de Interface de PostGreSql -> MySql

    Private Function ReadRegedit_SQLSERVER(ByVal strValor As String) As String
        Dim reg As RegistryKey
        Dim strDbConnection As String = ""

        reg = Registry.LocalMachine.OpenSubKey("SOFTWARE\ITPE")
        strDbConnection = reg.GetValue(strValor)
        Return strDbConnection

    End Function

    Public Shared ReadOnly Property GetConexion_SQLSERVER() As String
        Get
            Return ConfigurationSettings.AppSettings("ConnectionString_SQLSERVER")
        End Get
    End Property

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class




