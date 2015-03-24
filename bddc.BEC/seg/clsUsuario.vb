Namespace SEG

    Public Class clsUsuario
        Inherits COM.clsAuditoria

#Region "Miembros Privados"
        Private intUsuarioId As Integer
        Private strNombre As String
        Private strUsuario As String
        Private strClave As String
        Private strAdicional As String
        Private intTipoAutenticacionId As Integer
        Private intEstadoId As Integer
        'Private datUsuarioFecReg As Date

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
        Public Property Usuario() As String
            Get
                Return strUsuario
            End Get
            Set(ByVal Value As String)
                strUsuario = Value
            End Set
        End Property
        Public Property Clave() As String
            Get
                Return strClave
            End Get
            Set(ByVal Value As String)
                strClave = Value
            End Set
        End Property
        Public Property Adicional() As String
            Get
                Return strAdicional
            End Get
            Set(ByVal Value As String)
                strAdicional = Value
            End Set
        End Property
        Public Property TipoAutenticacionId() As Integer
            Get
                Return intTipoAutenticacionId
            End Get
            Set(ByVal Value As Integer)
                intTipoAutenticacionId = Value
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
        'Public Property UsuarioFecReg() As Date
        '    Get
        '        Return datUsuarioFecReg
        '    End Get
        '    Set(ByVal Value As Date)
        '        datUsuarioFecReg = Value
        '    End Set
        'End Property

#End Region

        Public Sub New()
            strAdicional = ""
            strNombre = ""
        End Sub
    End Class

End Namespace

