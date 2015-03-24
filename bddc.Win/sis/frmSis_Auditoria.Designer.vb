<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSis_Auditoria
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbUsuario = New System.Windows.Forms.ComboBox
        Me.cbTipoEvento = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGenerarRpt = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.txtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.dgvResultados = New System.Windows.Forms.DataGridView
        Me.UsuarioId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsuarioNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsuarioTerminal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EventoFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EventoTipoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EventoTipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EventoAplicacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.btnVolver = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.crvResultados = New CrystalDecisions.Windows.Forms.CrystalReportViewer
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
        Me.Label2.Size = New System.Drawing.Size(274, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Auditoría de Eventos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Inicio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbUsuario)
        Me.GroupBox1.Controls.Add(Me.cbTipoEvento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnGenerarRpt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFechaFin)
        Me.GroupBox1.Controls.Add(Me.txtFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 37)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'cbUsuario
        '
        Me.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(58, 12)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(138, 21)
        Me.cbUsuario.TabIndex = 72
        '
        'cbTipoEvento
        '
        Me.cbTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoEvento.FormattingEnabled = True
        Me.cbTipoEvento.Location = New System.Drawing.Point(249, 12)
        Me.cbTipoEvento.Name = "cbTipoEvento"
        Me.cbTipoEvento.Size = New System.Drawing.Size(80, 21)
        Me.cbTipoEvento.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Evento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Usuario"
        '
        'btnGenerarRpt
        '
        Me.btnGenerarRpt.Location = New System.Drawing.Point(669, 10)
        Me.btnGenerarRpt.Name = "btnGenerarRpt"
        Me.btnGenerarRpt.Size = New System.Drawing.Size(80, 23)
        Me.btnGenerarRpt.TabIndex = 66
        Me.btnGenerarRpt.Text = "Generar"
        Me.btnGenerarRpt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Fecha Final"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFin.Location = New System.Drawing.Point(569, 11)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaFin.TabIndex = 64
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaIni.Location = New System.Drawing.Point(405, 11)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaIni.TabIndex = 63
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToOrderColumns = True
        Me.dgvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsuarioId, Me.UsuarioNombre, Me.UsuarioTerminal, Me.EventoFecha, Me.EventoTipoId, Me.EventoTipo, Me.EventoAplicacion})
        Me.dgvResultados.Location = New System.Drawing.Point(13, 118)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.Size = New System.Drawing.Size(754, 394)
        Me.dgvResultados.TabIndex = 15
        Me.dgvResultados.Visible = False
        '
        'UsuarioId
        '
        Me.UsuarioId.DataPropertyName = "UsuarioId"
        Me.UsuarioId.HeaderText = "UsuarioId"
        Me.UsuarioId.Name = "UsuarioId"
        Me.UsuarioId.ReadOnly = True
        Me.UsuarioId.Visible = False
        '
        'UsuarioNombre
        '
        Me.UsuarioNombre.DataPropertyName = "UsuarioNombre"
        Me.UsuarioNombre.HeaderText = "Usuario"
        Me.UsuarioNombre.Name = "UsuarioNombre"
        Me.UsuarioNombre.ReadOnly = True
        Me.UsuarioNombre.Width = 150
        '
        'UsuarioTerminal
        '
        Me.UsuarioTerminal.DataPropertyName = "UsuarioTerminal"
        Me.UsuarioTerminal.HeaderText = "Terminal"
        Me.UsuarioTerminal.Name = "UsuarioTerminal"
        Me.UsuarioTerminal.ReadOnly = True
        '
        'EventoFecha
        '
        Me.EventoFecha.DataPropertyName = "EventoFecha"
        Me.EventoFecha.HeaderText = "Fecha"
        Me.EventoFecha.Name = "EventoFecha"
        Me.EventoFecha.ReadOnly = True
        Me.EventoFecha.Width = 120
        '
        'EventoTipoId
        '
        Me.EventoTipoId.DataPropertyName = "EventoTipoId"
        Me.EventoTipoId.HeaderText = "EventoTipoId"
        Me.EventoTipoId.Name = "EventoTipoId"
        Me.EventoTipoId.ReadOnly = True
        Me.EventoTipoId.Visible = False
        '
        'EventoTipo
        '
        Me.EventoTipo.DataPropertyName = "EventoTipo"
        Me.EventoTipo.HeaderText = "Tipo Evento"
        Me.EventoTipo.Name = "EventoTipo"
        Me.EventoTipo.ReadOnly = True
        Me.EventoTipo.Width = 90
        '
        'EventoAplicacion
        '
        Me.EventoAplicacion.DataPropertyName = "EventoAplicacion"
        Me.EventoAplicacion.HeaderText = "Aplicacion->Opción"
        Me.EventoAplicacion.Name = "EventoAplicacion"
        Me.EventoAplicacion.ReadOnly = True
        Me.EventoAplicacion.Width = 220
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(12, 527)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(74, 13)
        Me.lblMensaje.TabIndex = 64
        Me.lblMensaje.Text = "<Mensajes>"
        '
        'btnVolver
        '
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.Location = New System.Drawing.Point(711, 518)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(56, 53)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgAuditoria
        Me.PictureBox2.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'crvResultados
        '
        Me.crvResultados.ActiveViewIndex = -1
        Me.crvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvResultados.DisplayGroupTree = False
        Me.crvResultados.Location = New System.Drawing.Point(13, 118)
        Me.crvResultados.Name = "crvResultados"
        Me.crvResultados.SelectionFormula = ""
        Me.crvResultados.ShowCloseButton = False
        Me.crvResultados.ShowGroupTreeButton = False
        Me.crvResultados.ShowRefreshButton = False
        Me.crvResultados.Size = New System.Drawing.Size(754, 382)
        Me.crvResultados.TabIndex = 66
        Me.crvResultados.ViewTimeSelectionFormula = ""
        '
        'frmSis_Auditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(779, 576)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.crvResultados)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSis_Auditoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoría de Eventos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerarRpt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipoEvento As System.Windows.Forms.ComboBox
    Friend WithEvents UsuarioId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioTerminal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventoFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventoTipoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventoTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventoAplicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crvResultados As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
