<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte6
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.txtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboTipoJuego = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGenerarRpt = New System.Windows.Forms.Button
        Me.dgvResultados = New System.Windows.Forms.DataGridView
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteGeneroId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoJuegoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteNombres = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoJuego = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DropTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WinLossTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApuestaPromTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TiempoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PasesHora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HouseEdge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WinTeorico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.crvResultados = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crCalendarioPuntaje1 = New bddc.Win.crCalendarioPuntaje
        Me.btnSalir = New System.Windows.Forms.Button
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
        Me.Label2.Size = New System.Drawing.Size(321, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Resumen de Puntaje por Jugador (Calendario)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFechaFin)
        Me.GroupBox1.Controls.Add(Me.txtFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboTipoJuego)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnGenerarRpt)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 38)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Fecha Final"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFin.Location = New System.Drawing.Point(399, 12)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaFin.TabIndex = 68
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaIni.Location = New System.Drawing.Point(229, 12)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaIni.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Fecha Inicio"
        '
        'cboTipoJuego
        '
        Me.cboTipoJuego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoJuego.FormattingEnabled = True
        Me.cboTipoJuego.Location = New System.Drawing.Point(48, 12)
        Me.cboTipoJuego.Name = "cboTipoJuego"
        Me.cboTipoJuego.Size = New System.Drawing.Size(92, 21)
        Me.cboTipoJuego.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Juego"
        '
        'btnGenerarRpt
        '
        Me.btnGenerarRpt.Location = New System.Drawing.Point(649, 10)
        Me.btnGenerarRpt.Name = "btnGenerarRpt"
        Me.btnGenerarRpt.Size = New System.Drawing.Size(99, 23)
        Me.btnGenerarRpt.TabIndex = 4
        Me.btnGenerarRpt.Text = "Generar"
        Me.btnGenerarRpt.UseVisualStyleBackColor = True
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteId, Me.ClienteCodigo, Me.ClienteGeneroId, Me.TipoJuegoId, Me.ClienteApellidos, Me.ClienteNombres, Me.TipoJuego, Me.DropTotal, Me.WinLossTotal, Me.ApuestaPromTotal, Me.TiempoTotal, Me.PasesHora, Me.HouseEdge, Me.WinTeorico})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResultados.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvResultados.Location = New System.Drawing.Point(13, 249)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultados.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvResultados.Size = New System.Drawing.Size(749, 165)
        Me.dgvResultados.TabIndex = 0
        Me.dgvResultados.Visible = False
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
        Me.ClienteCodigo.Width = 50
        '
        'ClienteGeneroId
        '
        Me.ClienteGeneroId.DataPropertyName = "ClienteGeneroId"
        Me.ClienteGeneroId.HeaderText = "ClienteGeneroId"
        Me.ClienteGeneroId.Name = "ClienteGeneroId"
        Me.ClienteGeneroId.ReadOnly = True
        Me.ClienteGeneroId.Visible = False
        '
        'TipoJuegoId
        '
        Me.TipoJuegoId.DataPropertyName = "TipoJuegoId"
        Me.TipoJuegoId.HeaderText = "TipoJuegoId"
        Me.TipoJuegoId.Name = "TipoJuegoId"
        Me.TipoJuegoId.ReadOnly = True
        Me.TipoJuegoId.Visible = False
        '
        'ClienteApellidos
        '
        Me.ClienteApellidos.DataPropertyName = "ClienteApellidos"
        Me.ClienteApellidos.HeaderText = "Apellidos"
        Me.ClienteApellidos.Name = "ClienteApellidos"
        Me.ClienteApellidos.ReadOnly = True
        '
        'ClienteNombres
        '
        Me.ClienteNombres.DataPropertyName = "ClienteNombres"
        Me.ClienteNombres.HeaderText = "Nombres"
        Me.ClienteNombres.Name = "ClienteNombres"
        Me.ClienteNombres.ReadOnly = True
        '
        'TipoJuego
        '
        Me.TipoJuego.DataPropertyName = "TipoJuego"
        Me.TipoJuego.HeaderText = "Juego"
        Me.TipoJuego.Name = "TipoJuego"
        Me.TipoJuego.ReadOnly = True
        '
        'DropTotal
        '
        Me.DropTotal.DataPropertyName = "DropTotal"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.DropTotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.DropTotal.HeaderText = "Drop"
        Me.DropTotal.Name = "DropTotal"
        Me.DropTotal.ReadOnly = True
        '
        'WinLossTotal
        '
        Me.WinLossTotal.DataPropertyName = "WinLossTotal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.WinLossTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.WinLossTotal.HeaderText = "Win/Loss"
        Me.WinLossTotal.Name = "WinLossTotal"
        Me.WinLossTotal.ReadOnly = True
        '
        'ApuestaPromTotal
        '
        Me.ApuestaPromTotal.DataPropertyName = "ApuestaPromTotal"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.ApuestaPromTotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.ApuestaPromTotal.HeaderText = "Apuesta Prom"
        Me.ApuestaPromTotal.Name = "ApuestaPromTotal"
        Me.ApuestaPromTotal.ReadOnly = True
        '
        'TiempoTotal
        '
        Me.TiempoTotal.DataPropertyName = "TiempoTotal"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.TiempoTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.TiempoTotal.HeaderText = "Tiempo"
        Me.TiempoTotal.Name = "TiempoTotal"
        Me.TiempoTotal.ReadOnly = True
        '
        'PasesHora
        '
        Me.PasesHora.DataPropertyName = "PasesHora"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N3"
        Me.PasesHora.DefaultCellStyle = DataGridViewCellStyle6
        Me.PasesHora.HeaderText = "Pases/Hr"
        Me.PasesHora.Name = "PasesHora"
        Me.PasesHora.ReadOnly = True
        '
        'HouseEdge
        '
        Me.HouseEdge.DataPropertyName = "HouseEdge"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N3"
        Me.HouseEdge.DefaultCellStyle = DataGridViewCellStyle7
        Me.HouseEdge.HeaderText = "HouseEdge"
        Me.HouseEdge.Name = "HouseEdge"
        Me.HouseEdge.ReadOnly = True
        '
        'WinTeorico
        '
        Me.WinTeorico.DataPropertyName = "WinTeorico"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N3"
        Me.WinTeorico.DefaultCellStyle = DataGridViewCellStyle8
        Me.WinTeorico.HeaderText = "Win Teórico"
        Me.WinTeorico.Name = "WinTeorico"
        Me.WinTeorico.ReadOnly = True
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(14, 642)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(74, 13)
        Me.lblMensaje.TabIndex = 0
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
        'crvResultados
        '
        Me.crvResultados.ActiveViewIndex = -1
        Me.crvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvResultados.DisplayGroupTree = False
        Me.crvResultados.Location = New System.Drawing.Point(13, 119)
        Me.crvResultados.Name = "crvResultados"
        Me.crvResultados.SelectionFormula = ""
        Me.crvResultados.ShowCloseButton = False
        Me.crvResultados.ShowGroupTreeButton = False
        Me.crvResultados.ShowRefreshButton = False
        Me.crvResultados.Size = New System.Drawing.Size(752, 489)
        Me.crvResultados.TabIndex = 2
        Me.crvResultados.ViewTimeSelectionFormula = ""
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.Location = New System.Drawing.Point(712, 614)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 53)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmReporte6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(779, 677)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.crvResultados)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReporte6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Puntaje por Jugador (Calendario)"
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
    Friend WithEvents crvResultados As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ClienteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteGeneroId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoJuegoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoJuego As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DropTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WinLossTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApuestaPromTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasesHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HouseEdge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WinTeorico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboTipoJuego As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents crCalendarioPuntaje1 As bddc.Win.crCalendarioPuntaje
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
