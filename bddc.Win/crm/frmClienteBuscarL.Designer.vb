<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteBuscarL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBuscarApe = New System.Windows.Forms.TextBox
        Me.txtBuscarReferencia = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBuscarCodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscarNomb = New System.Windows.Forms.TextBox
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteEstadoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteApePat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteApeMat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteNombres = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tsslblMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.BdClientesDataSet1 = New bddc.Win.BDClientesDataSet
        Me.Tblbdd_clienteBusquedaTableAdapter = New System.Windows.Forms.BindingSource(Me.components)
        Me.Luxor_tblbdd_clienteBusquedaTableAdapter = New bddc.Win.BDClientesDataSetTableAdapters.Luxor_tblbdd_clienteBusquedaTableAdapter
        Me.btnVolver = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BdClientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tblbdd_clienteBusquedaTableAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(77, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(195, 26)
        Me.Label22.TabIndex = 73
        Me.Label22.Text = "Búsqueda de Clientes"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBuscarApe)
        Me.GroupBox1.Controls.Add(Me.btnVolver)
        Me.GroupBox1.Controls.Add(Me.txtBuscarReferencia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBuscarCodigo)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBuscarNomb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 92)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellido"
        '
        'txtBuscarApe
        '
        Me.txtBuscarApe.Location = New System.Drawing.Point(246, 42)
        Me.txtBuscarApe.MaxLength = 50
        Me.txtBuscarApe.Name = "txtBuscarApe"
        Me.txtBuscarApe.Size = New System.Drawing.Size(115, 20)
        Me.txtBuscarApe.TabIndex = 3
        '
        'txtBuscarReferencia
        '
        Me.txtBuscarReferencia.Location = New System.Drawing.Point(73, 65)
        Me.txtBuscarReferencia.MaxLength = 50
        Me.txtBuscarReferencia.Name = "txtBuscarReferencia"
        Me.txtBuscarReferencia.Size = New System.Drawing.Size(288, 20)
        Me.txtBuscarReferencia.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Referencia"
        '
        'txtBuscarCodigo
        '
        Me.txtBuscarCodigo.Location = New System.Drawing.Point(73, 19)
        Me.txtBuscarCodigo.MaxLength = 13
        Me.txtBuscarCodigo.Name = "txtBuscarCodigo"
        Me.txtBuscarCodigo.Size = New System.Drawing.Size(115, 20)
        Me.txtBuscarCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txtBuscarNomb
        '
        Me.txtBuscarNomb.Location = New System.Drawing.Point(73, 42)
        Me.txtBuscarNomb.MaxLength = 50
        Me.txtBuscarNomb.Name = "txtBuscarNomb"
        Me.txtBuscarNomb.Size = New System.Drawing.Size(115, 20)
        Me.txtBuscarNomb.TabIndex = 2
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteId, Me.ClienteNombreCompleto, Me.ClienteEstadoId, Me.ClienteCodigo, Me.ClienteApePat, Me.ClienteApeMat, Me.ClienteApellidos, Me.ClienteNombres})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.Location = New System.Drawing.Point(22, 155)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClientes.RowHeadersWidth = 20
        Me.dgvClientes.Size = New System.Drawing.Size(480, 340)
        Me.dgvClientes.TabIndex = 74
        '
        'ClienteId
        '
        Me.ClienteId.DataPropertyName = "ClienteId"
        Me.ClienteId.HeaderText = "ClienteId"
        Me.ClienteId.Name = "ClienteId"
        Me.ClienteId.ReadOnly = True
        Me.ClienteId.Visible = False
        '
        'ClienteNombreCompleto
        '
        Me.ClienteNombreCompleto.DataPropertyName = "ClienteNombreCompleto"
        Me.ClienteNombreCompleto.HeaderText = "ClienteNombreCompleto"
        Me.ClienteNombreCompleto.Name = "ClienteNombreCompleto"
        Me.ClienteNombreCompleto.ReadOnly = True
        Me.ClienteNombreCompleto.Visible = False
        '
        'ClienteEstadoId
        '
        Me.ClienteEstadoId.DataPropertyName = "ClienteEstadoId"
        Me.ClienteEstadoId.HeaderText = "ClienteEstadoId"
        Me.ClienteEstadoId.Name = "ClienteEstadoId"
        Me.ClienteEstadoId.ReadOnly = True
        Me.ClienteEstadoId.Visible = False
        '
        'ClienteCodigo
        '
        Me.ClienteCodigo.DataPropertyName = "ClienteCodigo"
        Me.ClienteCodigo.HeaderText = "Código"
        Me.ClienteCodigo.Name = "ClienteCodigo"
        Me.ClienteCodigo.ReadOnly = True
        '
        'ClienteApePat
        '
        Me.ClienteApePat.DataPropertyName = "ClienteApePat"
        Me.ClienteApePat.HeaderText = "ClienteApePat"
        Me.ClienteApePat.Name = "ClienteApePat"
        Me.ClienteApePat.ReadOnly = True
        Me.ClienteApePat.Visible = False
        '
        'ClienteApeMat
        '
        Me.ClienteApeMat.DataPropertyName = "ClienteApeMat"
        Me.ClienteApeMat.HeaderText = "ClienteApeMat"
        Me.ClienteApeMat.Name = "ClienteApeMat"
        Me.ClienteApeMat.ReadOnly = True
        Me.ClienteApeMat.Visible = False
        '
        'ClienteApellidos
        '
        Me.ClienteApellidos.DataPropertyName = "ClienteApellidos"
        Me.ClienteApellidos.HeaderText = "Apellidos"
        Me.ClienteApellidos.Name = "ClienteApellidos"
        Me.ClienteApellidos.ReadOnly = True
        Me.ClienteApellidos.Width = 150
        '
        'ClienteNombres
        '
        Me.ClienteNombres.DataPropertyName = "ClienteNombres"
        Me.ClienteNombres.HeaderText = "Nombres"
        Me.ClienteNombres.Name = "ClienteNombres"
        Me.ClienteNombres.ReadOnly = True
        Me.ClienteNombres.Width = 180
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblMensaje})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 518)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(515, 22)
        Me.StatusStrip1.TabIndex = 75
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslblMensaje
        '
        Me.tsslblMensaje.Name = "tsslblMensaje"
        Me.tsslblMensaje.Size = New System.Drawing.Size(51, 17)
        Me.tsslblMensaje.Text = "Mensaje"
        '
        'BdClientesDataSet1
        '
        Me.BdClientesDataSet1.DataSetName = "BDClientesDataSet"
        Me.BdClientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tblbdd_clienteBusquedaTableAdapter
        '
        Me.Tblbdd_clienteBusquedaTableAdapter.DataMember = "Luxor_tblbdd_clienteBusqueda"
        Me.Tblbdd_clienteBusquedaTableAdapter.DataSource = Me.BdClientesDataSet1
        '
        'Luxor_tblbdd_clienteBusquedaTableAdapter
        '
        Me.Luxor_tblbdd_clienteBusquedaTableAdapter.ClearBeforeFill = True
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Location = New System.Drawing.Point(431, 40)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(49, 46)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(376, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(49, 46)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgClientes
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'frmClienteBuscarL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 540)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmClienteBuscarL"
        Me.Text = "Busqueda de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BdClientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tblbdd_clienteBusquedaTableAdapter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarApe As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtBuscarReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarNomb As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents ClienteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteEstadoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteApePat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteApeMat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslblMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BdClientesDataSet1 As bddc.Win.BDClientesDataSet
    Friend WithEvents Tblbdd_clienteBusquedaTableAdapter As System.Windows.Forms.BindingSource
    Friend WithEvents Luxor_tblbdd_clienteBusquedaTableAdapter As bddc.Win.BDClientesDataSetTableAdapters.Luxor_tblbdd_clienteBusquedaTableAdapter
End Class
