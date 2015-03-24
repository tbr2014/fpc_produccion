Imports System.Configuration

Public Class Conexion

    Private Shared Conexion As String

    Public Function GetConexion() As String

        Select Case ConfigurationSettings.AppSettings("ConfigOrigen")
            Case 1
                Return GetConexionConfig()
            Case 2
                Return GetConexionRegistry()
            Case Else
                Return GetConexionRegistry() ' Si no hay app.config, asumir Registry!
        End Select

    End Function

    Private Function GetConexionRegistry() As String
        If Conexion Is Nothing Then Conexion = Factory.ConnectionString
        Return Conexion
    End Function

    Private Function GetConexionConfig() As String
        If Conexion Is Nothing Then Conexion = ConfigurationSettings.AppSettings("ConnectionString")
        Return Conexion
    End Function

End Class

