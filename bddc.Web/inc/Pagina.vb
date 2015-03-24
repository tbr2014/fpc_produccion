Imports System.Web
Imports System.Security
Imports System.Security.Principal

Public Class Pagina
    Public Shared Function Nombre() As String
        Dim sPath As String = System.Web.HttpContext.Current.Request.Url.AbsolutePath
        Dim oInfo As New System.IO.FileInfo(sPath)
        Return oInfo.Name
    End Function

    'Public Shared Function UserDomain() As String
    '    AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
    '    Dim user As WindowsPrincipal = CType(System.Threading.Thread.CurrentPrincipal, WindowsPrincipal)
    '    Dim ident As WindowsIdentity = user.Identity
    '    Return ident.Name
    'End Function

    Public Shared Function UserHostName() As String
        Return HttpContext.Current.Request.UserHostName
    End Function

End Class
