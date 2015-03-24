Namespace SEG

    Public Class clsMenuOpcion
        Public arrMenuOpcion As IList
        Public uni As String
        ''Sistema:
        'Public Const SISTIT As String = "Fiesta Player Club"
        'Public Const SISLGI As String = "Log In"
        'Public Const SISLGO As String = "Log Out"
        'Public Const SISINI As String = "Bienvenidos"
        'Public Const SISMIW As String = "Página en Construcción"

        'Public Const MODFPC As String = "Sistema Fiesta Player Club"
        'Public Const _MODFPC As Integer = 200


        Sub New(ByVal Unidad As String)

            arrMenuOpcion = New ArrayList
            uni = Unidad
            arrMenuOpcion = LeerOpciones()
            
        End Sub

        Private Function LeerOpciones() As BEC.COM.clsParametro()

            Dim objDL As New DALC.COM.clsParametro
            Dim arrResultados As BEC.COM.clsParametro()

            Try
                ' 1. Parametro
                arrResultados = objDL.Seleccionar("104", uni)

                If arrResultados.Count > 0 Then Return arrResultados

            Catch ex As Exception
                MsgBox(Util.Constante.Acc_ConfigERR, MsgBoxStyle.Critical)
            Finally
                objDL = Nothing
            End Try

            Return Nothing

        End Function

    End Class

End Namespace


