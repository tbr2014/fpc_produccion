Imports System.Data.SqlClient

Public Class Dato
    Function EsNuloBD(ByVal valorBD As Object)
        If Not valorBD Is System.DBNull.Value Then
            Return valorBD
        End If
        Return Nothing
    End Function
    Function EsNulo(ByVal valor As Object, ByVal pTipoDato As System.Type)
        Dim result As New Object

        If Not valor Is Nothing Then
            result = valor
        Else

            Select Case pTipoDato.Name
                Case "Int16", "Int32", "Int64", "Integer", "Decimal"
                    result = 0
                Case "String"
                    result = ""
                Case Else
                    result = 0
            End Select
        End If
        Return result

    End Function
End Class

'Public Class clsItem
'    Public Nombre As String
'    Public Valor As Integer

'    Sub New(ByVal strNombre As String, ByVal intValor As Integer)
'        Nombre = strNombre
'        Valor = intValor
'    End Sub

'    Public Overrides Function ToString() As String
'        Return Nombre
'    End Function

'End Class


