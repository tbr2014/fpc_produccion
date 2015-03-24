<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptClientes_Juegos
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
        Me.rbTipoJuego0 = New System.Windows.Forms.RadioButton
        Me.cbDistrito = New System.Windows.Forms.ComboBox
        Me.rbTipoJuego5 = New System.Windows.Forms.RadioButton
        Me.rbTipoJuego4 = New System.Windows.Forms.RadioButton
        Me.rbTipoJuego3 = New System.Windows.Forms.RadioButton
        Me.rbTipoJuego2 = New System.Windows.Forms.RadioButton
        Me.rbTipoJuego1 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkSexo2 = New System.Windows.Forms.CheckBox
        Me.chkSexo1 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGenerarRpt = New System.Windows.Forms.Button
        Me.txtDistritoBuscar = New System.Windows.Forms.TextBox
        Me.dgvResultados = New System.Windows.Forms.DataGridView
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteGeneroId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnVolver = New System.Windows.Forms.Button
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
        Me.Label2.Text = "Reporte de Clientes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbTipoJuego0)
        Me.GroupBox1.Controls.Add(Me.cbDistrito)
        Me.GroupBox1.Controls.Add(Me.rbTipoJuego5)
        Me.GroupBox1.Controls.Add(Me.rbTipoJuego4)
        Me.GroupBox1.Controls.Add(Me.rbTipoJuego3)
        Me.GroupBox1.Controls.Add(Me.rbTipoJuego2)
        Me.GroupBox1.Controls.Add(Me.rbTipoJuego1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkSexo2)
        Me.GroupBox1.Controls.Add(Me.chkSexo1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnGenerarRpt)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 38)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'rbTipoJuego0
        '
        Me.rbTipoJuego0.AutoSize = True
        Me.rbTipoJuego0.Location = New System.Drawing.Point(48, 14)
        Me.rbTipoJuego0.Name = "rbTipoJuego0"
        Me.rbTipoJuego0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbTipoJuego0.Size = New System.Drawing.Size(55, 17)
        Me.rbTipoJuego0.TabIndex = 79
        Me.rbTipoJuego0.TabStop = True
        Me.rbTipoJuego0.Text = "Todos"
        Me.rbTipoJuego0.UseVisualStyleBackColor = True
        '
        'cbDistrito
        '
        Me.cbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDistrito.FormattingEnabled = True
        Me.cbDistrito.Location = New System.Drawing.Point(399, 13)
        Me.cbDistrito.Name = "cbDistrito"
        Me.cbDistrito.Size = New System.Drawing.Size(135, 21)
        Me.cbDistrito.TabIndex = 78
        '
        'rbTipoJuego5
        '
        Me.rbTipoJuego5.AutoSize = True
        Me.rbTipoJuego5.Location = New System.Drawing.Point(286, 14)
        Me.rbTipoJuego5.Name = "rbTipoJuego5"
        Me.rbTipoJuego5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbTipoJuego5.Size = New System.Drawing.Size(56, 17)
        Me.rbTipoJuego5.TabIndex = 77
        Me.rbTipoJuego5.TabStop = True
        Me.rbTipoJuego5.Text = "MDPB"
        Me.rbTipoJuego5.UseVisualStyleBackColor = True
        '
        'rbTipoJuego4
        '
        Me.rbTipoJuego4.AutoSize = True
        Me.rbTipoJuego4.Location = New System.Drawing.Point(234, 14)
        Me.rbTipoJuego4.Name = "rbTipoJuego4"
        Me.rbTipoJuego4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbTipoJuego4.Size = New System.Drawing.Size(47, 17)
        Me.rbTipoJuego4.TabIndex = 76
        Me.rbTipoJuego4.TabStop = True
        Me.rbTipoJuego4.Text = "THP"
        Me.rbTipoJuego4.UseVisualStyleBackColor = True
        '
        'rbTipoJuego3
        '
        Me.rbTipoJuego3.AutoSize = True
        Me.rbTipoJuego3.Location = New System.Drawing.Point(189, 14)
        Me.rbTipoJuego3.Name = "rbTipoJuego3"
        Me.rbTipoJuego3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbTipoJuego3.Size = New System.Drawing.Size(39, 17)
        Me.rbTipoJuego3.TabIndex = 75
        Me.rbTipoJuego3.TabStop = True
        Me.rbTipoJuego3.Text = "PK"
        Me.rbTipoJuego3.UseVisualStyleBackColor = True
        '
        'rbTipoJuego2
        '
        Me.rbTipoJuego2.AutoSize = True
        Me.rbTipoJuego2.Location = New System.Drawing.Point(147, 14)
        Me.rbTipoJuego2.Name = "rbTipoJuego2"
        Me.rbTipoJuego2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbTipoJuego2.Size = New System.Drawing.Size(37, 17)
        Me.rbTipoJuego2.TabIndex = 74
        Me.rbTipoJuego2.TabStop = True
        Me.rbTipoJuego2.Text = "BJ"
        Me.rbTipoJuego2.UseVisualStyleBackColor = True
        '
        'rbTipoJuego1
        '
        Me.rbTipoJuego1.AutoSize = True
        Me.rbTipoJuego1.Location = New System.Drawing.Point(104, 14)
        Me.rbTipoJuego1.Name = "rbTipoJuego1"
        Me.rbTipoJuego1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbTipoJuego1.Size = New System.Drawing.Size(39, 17)
        Me.rbTipoJuego1.TabIndex = 73
        Me.rbTipoJuego1.TabStop = True
        Me.rbTipoJuego1.Text = "RL"
        Me.rbTipoJuego1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Juego"
        '
        'chkSexo2
        '
        Me.chkSexo2.AutoSize = True
        Me.chkSexo2.Location = New System.Drawing.Point(618, 14)
        Me.chkSexo2.Name = "chkSexo2"
        Me.chkSexo2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSexo2.Size = New System.Drawing.Size(32, 17)
        Me.chkSexo2.TabIndex = 71
        Me.chkSexo2.Text = "F"
        Me.chkSexo2.UseVisualStyleBackColor = True
        '
        'chkSexo1
        '
        Me.chkSexo1.AutoSize = True
        Me.chkSexo1.Location = New System.Drawing.Point(577, 14)
        Me.chkSexo1.Name = "chkSexo1"
        Me.chkSexo1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSexo1.Size = New System.Drawing.Size(35, 17)
        Me.chkSexo1.TabIndex = 70
        Me.chkSexo1.Text = "M"
        Me.chkSexo1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(540, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(358, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Distrito"
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
        'txtDistritoBuscar
        '
        Me.txtDistritoBuscar.Location = New System.Drawing.Point(630, 37)
        Me.txtDistritoBuscar.Name = "txtDistritoBuscar"
        Me.txtDistritoBuscar.Size = New System.Drawing.Size(131, 20)
        Me.txtDistritoBuscar.TabIndex = 68
        Me.txtDistritoBuscar.Visible = False
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToResizeRows = False
        Me.dgvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteId, Me.ClienteCodigo, Me.ClienteGeneroId})
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
        'ClienteId
        '
        Me.ClienteId.DataPropertyName = "ClienteId"
        Me.ClienteId.HeaderText = "ClienteId"
        Me.ClienteId.Name = "ClienteId"
        Me.ClienteId.ReadOnly = True
        Me.ClienteId.Visible = False
        '
        'ClienteCodigo
        '
        Me.ClienteCodigo.DataPropertyName = "ClienteCodigo"
        Me.ClienteCodigo.HeaderText = "Id"
        Me.ClienteCodigo.Name = "ClienteCodigo"
        Me.ClienteCodigo.ReadOnly = True
        Me.ClienteCodigo.Width = 41
        '
        'ClienteGeneroId
        '
        Me.ClienteGeneroId.DataPropertyName = "ClienteGeneroId"
        Me.ClienteGeneroId.HeaderText = "ClienteGeneroId"
        Me.ClienteGeneroId.Name = "ClienteGeneroId"
        Me.ClienteGeneroId.ReadOnly = True
        Me.ClienteGeneroId.Visible = False
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
        Me.btnVolver.TabIndex = 96
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmRptClientes_Juegos
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
        Me.Controls.Add(Me.txtDistritoBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRptClientes_Juegos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Clientes"
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
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents txtDistritoBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkSexo2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSexo1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbTipoJuego1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbTipoJuego5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipoJuego4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipoJuego3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipoJuego2 As System.Windows.Forms.RadioButton
    Friend WithEvents ClienteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteGeneroId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents rbTipoJuego0 As System.Windows.Forms.RadioButton
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
