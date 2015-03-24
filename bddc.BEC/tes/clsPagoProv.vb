
Namespace TES

    Public Class clsPagoProv

#Region "Miembros Privados"
        Private intNroItem As Integer
        Private strFecha As String
        Private strEmpresa As String
        Private strProvRUC As String
        Private strProvNombre As String
        Private strProvNumDoc As String
        Private intMoneda As Integer
        Private strMoneda As String
        Private decMonto As Decimal
        Private intEstado As Integer
#End Region

#Region "Propiedades"
        Public Property NroItem() As Integer
            Get
                Return intNroItem
            End Get
            Set(ByVal Value As Integer)
                intNroItem = Value
            End Set
        End Property
        Public Property Empresa() As String
            Get
                Return strEmpresa
            End Get
            Set(ByVal Value As String)
                strEmpresa = Value
            End Set
        End Property
        Public Property Fecha() As String
            Get
                Return strFecha
            End Get
            Set(ByVal Value As String)
                strFecha = Value
            End Set
        End Property
        Public Property ProvRUC() As String
            Get
                Return strProvRUC
            End Get
            Set(ByVal Value As String)
                strProvRUC = Value
            End Set
        End Property
        Public Property ProvNombre() As String
            Get
                Return strProvNombre
            End Get
            Set(ByVal Value As String)
                strProvNombre = Value
            End Set
        End Property
        Public Property ProvNumDoc() As String
            Get
                Return strProvNumDoc
            End Get
            Set(ByVal Value As String)
                strProvNumDoc = Value
            End Set
        End Property
        Public Property MonedaId() As Integer
            Get
                Return intMoneda
            End Get
            Set(ByVal Value As Integer)
                intMoneda = Value
            End Set
        End Property
        Public Property Moneda() As String
            Get
                Return strMoneda
            End Get
            Set(ByVal Value As String)
                strMoneda = Value
            End Set
        End Property
        Public Property Monto() As Decimal
            Get
                Return decMonto
            End Get
            Set(ByVal Value As Decimal)
                decMonto = Value
            End Set
        End Property
        Public ReadOnly Property VerMonto() As String
            Get
                Return strMoneda & " " & decMonto.ToString("0.00")
            End Get
        End Property
        Public Property Estado() As Integer
            Get
                Return intEstado
            End Get
            Set(ByVal Value As Integer)
                intEstado = Value
            End Set
        End Property

#End Region

    End Class

End Namespace
