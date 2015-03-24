Namespace SEG

    <Serializable()> _
    Public Class clsUsuarioConfig

#Region "Miembros Privados"

        Private intUsuarioId As Integer
        Private strNombre As String
        Private intModuloId As Integer
        Private strModulo As String
        Private strModuloSiglas As String
        Private intRolId As Integer
        Private strRol As String
        Private strPermisos As String
        Private strHorario As String
        Private strUbicacion As String
        Private strOpciones As String
        Private intEstadoId As Integer

#End Region

#Region "Propiedades"
        Public Property UsuarioId() As Integer
            Get
                Return intUsuarioId
            End Get
            Set(ByVal Value As Integer)
                intUsuarioId = Value
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
        Public Property ModuloId() As Integer
            Get
                Return intModuloId
            End Get
            Set(ByVal Value As Integer)
                intModuloId = Value
            End Set
        End Property
        Public Property Modulo() As String
            Get
                Return strModulo
            End Get
            Set(ByVal Value As String)
                strModulo = Value
            End Set
        End Property
        Public Property ModuloSiglas() As String
            Get
                Return strModuloSiglas
            End Get
            Set(ByVal Value As String)
                strModuloSiglas = Value
            End Set
        End Property
        Public Property RolId() As Integer
            Get
                Return intRolId
            End Get
            Set(ByVal Value As Integer)
                intRolId = Value
            End Set
        End Property
        Public Property Rol() As String
            Get
                Return strRol
            End Get
            Set(ByVal Value As String)
                strRol = Value
            End Set
        End Property
        Public Property Permisos() As String
            Get
                Return strPermisos
            End Get
            Set(ByVal Value As String)
                strPermisos = Value
            End Set
        End Property
        Public Property Horario() As String
            Get
                Return strHorario
            End Get
            Set(ByVal Value As String)
                strHorario = Value
            End Set
        End Property
        Public Property Ubicacion() As String
            Get
                Return strUbicacion
            End Get
            Set(ByVal Value As String)
                strUbicacion = Value
            End Set
        End Property
        Public Property Opciones() As String
            Get
                Return strOpciones
            End Get
            Set(ByVal Value As String)
                strOpciones = Value
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
