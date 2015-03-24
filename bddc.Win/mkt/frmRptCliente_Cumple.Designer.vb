<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptCliente_Cumple
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnGenerarRpt = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.txtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvResultados = New System.Windows.Forms.DataGridView
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnVolver = New System.Windows.Forms.Button
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteGeneroId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Lista de Cumpleaños de Clientes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGenerarRpt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFechaFin)
        Me.GroupBox1.Controls.Add(Me.txtFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 38)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'btnGenerarRpt
        '
        Me.btnGenerarRpt.Location = New System.Drawing.Point(668, 10)
        Me.btnGenerarRpt.Name = "btnGenerarRpt"
        Me.btnGenerarRpt.Size = New System.Drawing.Size(80, 23)
        Me.btnGenerarRpt.TabIndex = 66
        Me.btnGenerarRpt.Text = "Generar"
        Me.btnGenerarRpt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Fecha Final"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFin.Location = New System.Drawing.Point(267, 12)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaFin.TabIndex = 64
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaIni.Location = New System.Drawing.Point(84, 12)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaIni.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Inicio"
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteId, Me.ClienteGeneroId, Me.ClienteCodigo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResultados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResultados.Location = New System.Drawing.Point(13, 119)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvResultados.RowHeadersWidth = 20
        Me.dgvResultados.Size = New System.Drawing.Size(754, 393)
        Me.dgvResultados.TabIndex = 15
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(12, 558)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(74, 13)
        Me.lblMensaje.TabIndex = 64
        Me.lblMensaje.Text = "<Mensajes>"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgReportes
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Location = New System.Drawing.Point(714, 523)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(53, 53)
        Me.btnVolver.TabIndex = 95
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'ClienteId
        '
        Me.ClienteId.DataPropertyName = "ClienteId"
        Me.ClienteId.HeaderText = "ClienteId"
        Me.ClienteId.Name = "ClienteId"
        Me.ClienteId.ReadOnly = True
        Me.ClienteId.Visible = False
        '
        'ClienteGeneroId
        '
        Me.ClienteGeneroId.DataPropertyName = "ClienteGeneroId"
        Me.ClienteGeneroId.HeaderText = "ClienteGeneroId"
        Me.ClienteGeneroId.Name = "ClienteGeneroId"
        Me.ClienteGeneroId.ReadOnly = True
        Me.ClienteGeneroId.Visible = False
        '
        'ClienteCodigo
        '
        Me.ClienteCodigo.DataPropertyName = "ClienteCodigo"
        Me.ClienteCodigo.HeaderText = "Id"
        Me.ClienteCodigo.Name = "ClienteCodigo"
        Me.ClienteCodigo.ReadOnly = True
        '
        'frmRptCliente_Cumple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(779, 588)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRptCliente_Cumple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Cumpleaños de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerarRpt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents txtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents ClienteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteGeneroId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
