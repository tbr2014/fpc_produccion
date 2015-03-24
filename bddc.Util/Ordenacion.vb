Imports System.Collections

Public Class Ordenacion
    Implements IComparer

    Private intClase As Integer

    Sub New(ByVal pintClase As Integer)
        intClase = pintClase
    End Sub
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

        Select Case intClase
            Case 1 ' viwCotizacionResumen
                Return CType(x, BEC.CEO.viwCotizacionResumen).DiaOrden.CompareTo(CType(y, BEC.CEO.viwCotizacionResumen).DiaOrden)
        End Select

    End Function

End Class
