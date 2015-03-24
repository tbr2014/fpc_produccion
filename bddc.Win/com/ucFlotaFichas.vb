Public Class ucFlotaFichas

#Region "Propiedades"

    Public ReadOnly Property NumRegistros() As Integer
        Get
            Return dgvFlotaFichas.RowCount
        End Get
    End Property

#End Region

#Region "Operaciones"

    Public Sub CargarGridFlotaFichas(ByVal strDenominacionFichas As String)

        Dim objDataTable As New DataTable
        Dim objDatarow As DataRow
        Dim arrDenominaciones As New ArrayList
        Dim strDenominaciones() As String = strDenominacionFichas.Split("|")

        If strDenominaciones.Count > 1 Then

            With objDataTable
                .Columns.Add(New DataColumn("Denominacion"))
                .Columns.Add(New DataColumn("Cantidad"))
                .Columns.Add(New DataColumn("Subtotal"))
            End With


            For k As Integer = 0 To strDenominaciones.Count - 1
                objDatarow = objDataTable.NewRow

                objDatarow(0) = strDenominaciones(k)
                objDatarow(1) = 0
                objDatarow(2) = 0

                objDataTable.Rows.Add(objDatarow)
            Next

            objDatarow = objDataTable.NewRow
            objDatarow(0) = "Total"
            objDatarow(1) = ""
            objDatarow(2) = 0

            objDataTable.Rows.Add(objDatarow)

            dgvFlotaFichas.DataSource = objDataTable
            dgvFlotaFichas.Visible = True

        Else
            dgvFlotaFichas.Visible = False
        End If

    End Sub

    Public Sub CalcularSubTotalesFlota()
        Dim decSubtotal As Decimal = 0
        Dim intCantidad As Decimal = 0

        For k As Integer = 0 To dgvFlotaFichas.Rows.Count - 2
            If dgvFlotaFichas.Rows(k).Cells(1).Value <> "" Then
                intCantidad = dgvFlotaFichas.Rows(k).Cells(1).Value
            Else
                intCantidad = 0
            End If

            decSubtotal = Math.Round(dgvFlotaFichas.Rows(k).Cells(0).Value * intCantidad, 2)
            dgvFlotaFichas.Rows(k).Cells(2).Value = decSubtotal.ToString("0.00")
        Next

        CalcularTotalesFlota()

    End Sub

    Public Sub CalcularTotalesFlota()
        Dim decTotal As Decimal = 0

        If dgvFlotaFichas.RowCount > 1 Then
            For k As Integer = 0 To dgvFlotaFichas.RowCount - 2
                decTotal += IIf(dgvFlotaFichas.Rows(k).Cells(2).Value <> 0, dgvFlotaFichas.Rows(k).Cells(2).Value, 0)
            Next
            dgvFlotaFichas.Rows(dgvFlotaFichas.RowCount - 1).Cells(2).Value = decTotal.ToString("0.00")
        End If
        
    End Sub

    Public Function GetCadenaFlotaFichas() As String
        Dim strFlotaFichas As String = ""

        For k As Integer = 0 To dgvFlotaFichas.Rows.Count - 2
            strFlotaFichas &= dgvFlotaFichas.Rows(k).Cells(1).Value
            If k < dgvFlotaFichas.Rows.Count - 2 Then strFlotaFichas &= "|"
        Next

        Return strFlotaFichas

    End Function

    Public Sub SetCadenaFlotaFichas(ByVal strFlotaFichas As String)
        Dim strDatos() As String = strFlotaFichas.Split("|")

        If strDatos.Length > 0 Then
            For k As Integer = 0 To dgvFlotaFichas.Rows.Count - 2
                dgvFlotaFichas.Rows(k).Cells(1).Value = strDatos(k)
            Next
            CalcularSubTotalesFlota()
        End If

    End Sub

    Public Sub ResetCadenaFlotaFichas()

        For k As Integer = 0 To dgvFlotaFichas.Rows.Count - 1
            dgvFlotaFichas.Rows(k).Cells(1).Value = ""
            dgvFlotaFichas.Rows(k).Cells(2).Value = 0
        Next

    End Sub

#End Region

#Region "Eventos de Controles"

    Private Sub dgvFlotaFichas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFlotaFichas.CellEndEdit
        If e.RowIndex < dgvFlotaFichas.RowCount - 1 Then
            If dgvFlotaFichas.Rows(e.RowIndex).Cells(1).Value <> "" And IsNumeric(dgvFlotaFichas.Rows(e.RowIndex).Cells(1).Value) Then
                Dim decSubtotal As Decimal = 0
                decSubtotal = Math.Round(dgvFlotaFichas.Rows(e.RowIndex).Cells(0).Value * dgvFlotaFichas.Rows(e.RowIndex).Cells(1).Value, 2)
                dgvFlotaFichas.Rows(e.RowIndex).Cells(2).Value = decSubtotal
                CalcularTotalesFlota()
            Else
                dgvFlotaFichas.Rows(e.RowIndex).Cells(1).Value = "0"
            End If
        Else
            dgvFlotaFichas.Rows(e.RowIndex).Cells(1).Value = ""
        End If
    End Sub

#End Region

End Class
