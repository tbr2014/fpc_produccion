Imports System

Public Class Menu

    Public Shared Sub generarMenu(ByRef omnuMenu As skmMenu.Menu, _
                              ByVal path As String, ByVal arrConfig As BEC.SEG.clsUsuarioConfig())

        Try
            omnuMenu.DataSource = path
            omnuMenu.CssClass = "menustyle"
            omnuMenu.DefaultCssClass = "menuitem"
            omnuMenu.DefaultMouseOverCssClass = "mouseover"
            omnuMenu.SelectedMenuItemStyle.CssClass = "selectedmenu"
            omnuMenu.Opacity = "75"

            If Not arrConfig Is Nothing Then
                Dim objBEC As BEC.SEG.clsUsuarioConfig
                Dim strCar As String

                omnuMenu.UserRoles.Clear()

                For k As Integer = 0 To arrConfig.Length - 1
                    objBEC = New BEC.SEG.clsUsuarioConfig
                    objBEC = arrConfig(k)

                    strCar = objBEC.Horario.Substring(Now.Hour, 1)
                    If strCar = Util.Enumeracion.enmResultadoOperacion.OK Then
                        omnuMenu.UserRoles.Add(objBEC.Modulo)
                    End If

                Next
            Else
                omnuMenu.UserRoles.Add("MODCLI")
                omnuMenu.UserRoles.Add("MODMOV")
                omnuMenu.UserRoles.Add("MODFJM")
                omnuMenu.UserRoles.Add("MODTBL")
                omnuMenu.UserRoles.Add("MODSEG")
            End If

            omnuMenu.DataBind()

        Catch ex As Exception
            Throw New DataException("Error al generar la estructura de Opciones del Usuario")
        End Try

    End Sub

    Public Shared Function NombreOpcion(ByVal intOpcion As Util.Enumeracion.enmOpcionMenu) As String
        Dim objOpciones As New Util.OpcionMenu
        Return objOpciones.NombreOpcionMenu(intOpcion)
    End Function

End Class
