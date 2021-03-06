'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''
''  viwEstimadoMesa.vb
''  Implementation of the Class viwEstimadoMesa
''  Generated by Enterprise Architect
''  Created on:      25-Jun-2010 03:44:23 p.m.
''  Original author: alejandro.borjas
''  
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''  Modification history:
''  
''
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



Option Explicit On
Option Strict On

Namespace FJM
    Public Class viwEstimadoMesa


        Private intEstimadoMesaId As Integer
        Private intMesaId As Integer
        Private intTipoJuegoId As Integer
        Private strTipoJuego As String
        Private strNroMesa As String
        Private intMonedaId As Integer
        Private strMoneda As String
        Private decDrop19 As Decimal
        Private decWin19 As Decimal
        Private decDrop20 As Decimal
        Private decWin20 As Decimal
        Private decDrop21 As Decimal
        Private decWin21 As Decimal
        Private decDrop22 As Decimal
        Private decWin22 As Decimal
        Private decDrop23 As Decimal
        Private decWin23 As Decimal
        Private decDrop00 As Decimal
        Private decWin00 As Decimal
        Private decDrop01 As Decimal
        Private decWin01 As Decimal
        Private decDrop02 As Decimal
        Private decWin02 As Decimal
        Private decDrop03 As Decimal
        Private decWin03 As Decimal
        Private decDrop04 As Decimal
        Private decWin04 As Decimal
        Private decDrop05 As Decimal
        Private decWin05 As Decimal
        Private decDrop06 As Decimal
        Private decWin06 As Decimal

        Public Property EstimadoMesaId() As Integer
            Get
                Return intEstimadoMesaId
            End Get
            Set(ByVal Value As Integer)
                intEstimadoMesaId = Value
            End Set
        End Property

        Public Property MesaId() As Integer
            Get
                Return intMesaId
            End Get
            Set(ByVal Value As Integer)
                intMesaId = Value
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

        Public Property TipoJuego() As String
            Get
                Return strTipoJuego
            End Get
            Set(ByVal Value As String)
                strTipoJuego = Value
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

        Public ReadOnly Property Juego() As String
            Get
                Return strTipoJuego & " " & strNroMesa
            End Get
        End Property

        Public Property MonedaId() As Integer
            Get
                Return intMonedaId
            End Get
            Set(ByVal Value As Integer)
                intMonedaId = Value
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

        Public Property Drop19() As Decimal
            Get
                Return decDrop19
            End Get
            Set(ByVal Value As Decimal)
                decDrop19 = Value
            End Set
        End Property

        Public Property Win19() As Decimal
            Get
                Return decWin19
            End Get
            Set(ByVal Value As Decimal)
                decWin19 = Value
            End Set
        End Property

        Public Property Drop20() As Decimal
            Get
                Return decDrop20
            End Get
            Set(ByVal Value As Decimal)
                decDrop20 = Value
            End Set
        End Property

        Public Property Win20() As Decimal
            Get
                Return decWin20
            End Get
            Set(ByVal Value As Decimal)
                decWin20 = Value
            End Set
        End Property

        Public Property Drop21() As Decimal
            Get
                Return decDrop21
            End Get
            Set(ByVal Value As Decimal)
                decDrop21 = Value
            End Set
        End Property

        Public Property Win21() As Decimal
            Get
                Return decWin21
            End Get
            Set(ByVal Value As Decimal)
                decWin21 = Value
            End Set
        End Property

        Public Property Drop22() As Decimal
            Get
                Return decDrop22
            End Get
            Set(ByVal Value As Decimal)
                decDrop22 = Value
            End Set
        End Property

        Public Property Win22() As Decimal
            Get
                Return decWin22
            End Get
            Set(ByVal Value As Decimal)
                decWin22 = Value
            End Set
        End Property

        Public Property Drop23() As Decimal
            Get
                Return decDrop23
            End Get
            Set(ByVal Value As Decimal)
                decDrop23 = Value
            End Set
        End Property

        Public Property Win23() As Decimal
            Get
                Return decWin23
            End Get
            Set(ByVal Value As Decimal)
                decWin23 = Value
            End Set
        End Property

        Public Property Drop00() As Decimal
            Get
                Return decDrop00
            End Get
            Set(ByVal Value As Decimal)
                decDrop00 = Value
            End Set
        End Property

        Public Property Win00() As Decimal
            Get
                Return decWin00
            End Get
            Set(ByVal Value As Decimal)
                decWin00 = Value
            End Set
        End Property

        Public Property Drop01() As Decimal
            Get
                Return decDrop01
            End Get
            Set(ByVal Value As Decimal)
                decDrop01 = Value
            End Set
        End Property

        Public Property Win01() As Decimal
            Get
                Return decWin01
            End Get
            Set(ByVal Value As Decimal)
                decWin01 = Value
            End Set
        End Property

        Public Property Drop02() As Decimal
            Get
                Return decDrop02
            End Get
            Set(ByVal Value As Decimal)
                decDrop02 = Value
            End Set
        End Property

        Public Property Win02() As Decimal
            Get
                Return decWin02
            End Get
            Set(ByVal Value As Decimal)
                decWin02 = Value
            End Set
        End Property

        Public Property Drop03() As Decimal
            Get
                Return decDrop03
            End Get
            Set(ByVal Value As Decimal)
                decDrop03 = Value
            End Set
        End Property

        Public Property Win03() As Decimal
            Get
                Return decWin03
            End Get
            Set(ByVal Value As Decimal)
                decWin03 = Value
            End Set
        End Property

        Public Property Drop04() As Decimal
            Get
                Return decDrop04
            End Get
            Set(ByVal Value As Decimal)
                decDrop04 = Value
            End Set
        End Property

        Public Property Win04() As Decimal
            Get
                Return decWin04
            End Get
            Set(ByVal Value As Decimal)
                decWin04 = Value
            End Set
        End Property

        Public Property Drop05() As Decimal
            Get
                Return decDrop05
            End Get
            Set(ByVal Value As Decimal)
                decDrop05 = Value
            End Set
        End Property

        Public Property Win05() As Decimal
            Get
                Return decWin05
            End Get
            Set(ByVal Value As Decimal)
                decWin05 = Value
            End Set
        End Property

        Public Property Drop06() As Decimal
            Get
                Return decDrop06
            End Get
            Set(ByVal Value As Decimal)
                decDrop06 = Value
            End Set
        End Property

        Public Property Win06() As Decimal
            Get
                Return decWin06
            End Get
            Set(ByVal Value As Decimal)
                decWin06 = Value
            End Set
        End Property

        Public Sub New()

        End Sub

        ''' 
        ''' <param name="pintMesaId"></param>
        ''' <param name="pintTipoJuegoId"></param>
        ''' <param name="pstrTipoJuego"></param>
        ''' <param name="pstrNroMesa"></param>
        ''' <param name="pintMonedaId"></param>
        ''' <param name="pstrMoneda"></param>
        ''' <param name="parrDrop"></param>
        ''' <param name="parrWinLoss"></param>
        Public Sub New(ByVal pintMesaId As Integer, ByVal pintTipoJuegoId As Integer, ByVal pstrTipoJuego As String, ByVal pstrNroMesa As String, ByVal pintMonedaId As Integer, ByVal pstrMoneda As String, ByVal parrDrop As IList, ByVal parrWinLoss As IList)

            intEstimadoMesaId = 0
            intMesaId = pintMesaId
            intTipoJuegoId = pintTipoJuegoId
            strTipoJuego = pstrTipoJuego
            strNroMesa = pstrNroMesa
            intMonedaId = pintMonedaId
            strMoneda = pstrMoneda

            For k As Integer = 0 To parrDrop.Count - 1
                Select Case k + 1
                    Case 1
                        Drop19 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 2
                        Drop20 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 3
                        Drop21 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 4
                        Drop22 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 5
                        Drop23 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 6
                        Drop00 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 7
                        Drop01 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 8
                        Drop02 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 9
                        Drop03 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 10
                        Drop04 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 11
                        Drop05 = Convert.ToDecimal(parrDrop(k).ToString)
                    Case 12
                        Drop06 = Convert.ToDecimal(parrDrop(k).ToString)
                End Select
            Next

            For k As Integer = 0 To parrWinLoss.Count - 1
                Select Case k + 1
                    Case 1
                        Win19 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 2
                        Win20 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 3
                        Win21 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 4
                        Win22 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 5
                        Win23 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 6
                        Win00 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 7
                        Win01 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 8
                        Win02 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 9
                        Win03 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 10
                        Win04 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 11
                        Win05 = Convert.ToDecimal(parrWinLoss(k).ToString)
                    Case 12
                        Win06 = Convert.ToDecimal(parrWinLoss(k).ToString)
                End Select
            Next

        End Sub

        Protected Overrides Sub Finalize()

        End Sub


    End Class ' viwEstimadoMesa

End Namespace ' CLI