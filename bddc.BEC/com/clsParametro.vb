Namespace COM

    Public Class clsParametro

#Region "Miembros Privados"
        Private intGrupoId As Integer
        Private intParametroId As Integer
        Private strNombre As String
        Private strSiglas As String
        Private intEstadoId As Integer
#End Region

#Region "Propiedades"
        Public Property GrupoId() As Integer
            Get
                Return intGrupoId
            End Get
            Set(ByVal Value As Integer)
                intGrupoId = Value
            End Set
        End Property
        Public Property ParametroId() As Integer
            Get
                Return intParametroId
            End Get
            Set(ByVal Value As Integer)
                intParametroId = Value
            End Set
        End Property
        Public Property Nombre() As String
            Get
                Return strNombre
            End Get
            Set(ByVal Value As String)
                strNombre = Value
            End Set
        End Property
        Public Property Siglas() As String
            Get
                Return strSiglas
            End Get
            Set(ByVal Value As String)
                strSiglas = Value
            End Set
        End Property
        Public Property EstadoId() As Integer
            Get
                Return intEstadoId
            End Get
            Set(ByVal Value As Integer)
                intEstadoId = Value
            End Set
        End Property
#End Region

    End Class

End Namespace
