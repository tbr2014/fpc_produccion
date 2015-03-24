Public Class DBNulls

    Shared Function NullValue(ByVal value As Date) As Object
        If value = "1/1/1900" Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Shared Function NullValue(ByVal value As String) As Object
        If value.Trim() = "" Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Shared Function NullValue(ByVal value As Integer) As Object
        If value = 0 Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Shared Function NullValue(ByVal value As Double) As Object
        If value = 0 Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Shared Function NullValue(ByVal d As IDataReader, ByVal n As String, ByVal value As Object) As Object
        Dim i As Integer, j As Integer
        For i = 0 To d.FieldCount - 1
            If d.GetName(i).ToUpper() = n.ToUpper() Then
                j = i
                Exit For
            End If
        Next
        If d.IsDBNull(j) Then
            Return value
        Else
            Return d.Item(n)
        End If
    End Function

End Class

