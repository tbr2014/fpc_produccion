Namespace COM

    Public Class clsItem
        Private intItemId As Integer
        Private strItemNombre As String

        Public Property ItemId() As Integer
            Get
                Return intItemId
            End Get
            Set(ByVal value As Integer)
                intItemId = value
            End Set
        End Property

        Public Property ItemNombre() As String
            Get
                Return strItemNombre
            End Get
            Set(ByVal value As String)
                strItemNombre = value
            End Set
        End Property

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Sub New()
            intItemId = 0
            strItemNombre = ""
        End Sub

        Public Sub New(ByVal intId As Integer, ByVal strNombre As String)
            intItemId = intId
            strItemNombre = strNombre
        End Sub

        Public Overrides Function ToString() As String
            Return strItemNombre
        End Function

    End Class

End Namespace
