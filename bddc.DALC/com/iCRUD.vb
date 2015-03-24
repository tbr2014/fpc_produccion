Namespace COM

    Public Interface ICRUD
        Function Leer(ByVal Id As Integer, ByVal Unidad As String) As Object
        Function Escribir(ByRef obj As Object, ByVal Unidad As String) As Integer
        Function Eliminar(ByVal Id As Integer, ByVal Unidad As String) As Integer
        Function Buscar(ByVal arrFiltro As IList, ByVal Unidad As String) As IList
    End Interface

End Namespace


