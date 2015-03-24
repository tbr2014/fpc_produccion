Option Explicit On
Option Strict On

Namespace FJM
    Public Class clsMesa

        Private intMesaId As Integer
        Private intPitId As Integer
        Private intTipoJuegoId As Integer
        Private strTipoJuego As String
        Private strNroMesa As String
        Private intMonedaId As Integer
        Private intEstadoId As Integer

        Public Sub New()

            intMesaId = 0
            intPitId = 0
            intTipoJuegoId = 0
            strNroMesa = ""
            intEstadoId = 0

        End Sub

        Public Property MesaId() As Integer
            Get
                Return intMesaId
            End Get
            Set(ByVal Value As Integer)
                intMesaId = Value
            End Set
        End Property

        Public Property PitId() As Integer
            Get
                Return intPitId
            End Get
            Set(ByVal Value As Integer)
                intPitId = Value
            End Set
        End Property
        Public Property TipoJuego() As String
            Get
                Return strTipoJuego
            End Get
            Set(ByVal value As String)
                strTipoJuego = value
            End Set
        End Property
        Public Property TipoJuegoId() As Integer
            Get
                Return intTipoJuegoId
            End Get
            Set(ByVal Value As Integer)
                intTipoJuegoId = Value
            End Set
        End Property

        Public Property NroMesa() As String
            Get
                Return strNroMesa
            End Get
            Set(ByVal Value As String)
                strNroMesa = Value
            End Set
        End Property

        Public Property MonedaId() As Integer
            Get
                Return intMonedaId
            End Get
            Set(ByVal Value As Integer)
                intMonedaId = Value
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


    End Class ' clsClienteFJM

End Namespace ' CLI
