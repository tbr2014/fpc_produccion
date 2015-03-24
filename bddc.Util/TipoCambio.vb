Public Class TipoCambio

    Shared Function Valor(ByVal intMonedaId As Integer, ByVal decNumero As Decimal, ByVal intMonedaNuevaId As Integer, ByVal decTipoCambio As Decimal) As Decimal
        If intMonedaId <> intMonedaNuevaId Then

            Dim decFactor As Decimal = decTipoCambio

            If decFactor <> 0 Then
                Select Case intMonedaNuevaId
                    Case 1
                        Return (decNumero * decFactor).ToString("0.000")

                    Case 2
                        Return (decNumero / decFactor).ToString("0.000")

                End Select

            Else
                Return 0
            End If

        Else
            Return decNumero
        End If
    End Function

End Class
