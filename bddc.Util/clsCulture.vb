Imports System.Globalization
Imports System.Threading

Public Class clsCulture

    Private strCulture As String = "es-PE"

    Sub New()
        SetCulture()
    End Sub

    Private Sub SetCulture()
        Dim objCI As CultureInfo = New CultureInfo(strCulture)
        Thread.CurrentThread.CurrentCulture = objCI
        Thread.CurrentThread.CurrentUICulture = objCI
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
