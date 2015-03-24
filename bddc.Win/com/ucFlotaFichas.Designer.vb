<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFlotaFichas
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvFlotaFichas = New System.Windows.Forms.DataGridView
        Me.Denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvFlotaFichas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFlotaFichas
        '
        Me.dgvFlotaFichas.AllowUserToAddRows = False
        Me.dgvFlotaFichas.AllowUserToDeleteRows = False
        Me.dgvFlotaFichas.AllowUserToOrderColumns = True
        Me.dgvFlotaFichas.AllowUserToResizeColumns = False
        Me.dgvFlotaFichas.AllowUserToResizeRows = False
        Me.dgvFlotaFichas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvFlotaFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFlotaFichas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Denominacion, Me.Cantidad, Me.Subtotal})
        Me.dgvFlotaFichas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFlotaFichas.Location = New System.Drawing.Point(0, 0)
        Me.dgvFlotaFichas.MultiSelect = False
        Me.dgvFlotaFichas.Name = "dgvFlotaFichas"
        Me.dgvFlotaFichas.RowHeadersVisible = False
        Me.dgvFlotaFichas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFlotaFichas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvFlotaFichas.Size = New System.Drawing.Size(235, 336)
        Me.dgvFlotaFichas.TabIndex = 1
        '
        'Denominacion
        '
        Me.Denominacion.DataPropertyName = "Denominacion"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Denominacion.DefaultCellStyle = DataGridViewCellStyle1
        Me.Denominacion.HeaderText = "Denominación"
        Me.Denominacion.Name = "Denominacion"
        Me.Denominacion.ReadOnly = True
        Me.Denominacion.Width = 80
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MaxInputLength = 10
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 60
        '
        'Subtotal
        '
        Me.Subtotal.DataPropertyName = "Subtotal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Subtotal.Width = 80
        '
        'ucFlotaFichas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvFlotaFichas)
        Me.Name = "ucFlotaFichas"
        Me.Size = New System.Drawing.Size(235, 336)
        CType(Me.dgvFlotaFichas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvFlotaFichas As System.Windows.Forms.DataGridView
    Friend WithEvents Denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
