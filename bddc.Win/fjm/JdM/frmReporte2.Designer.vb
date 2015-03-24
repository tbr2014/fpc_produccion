<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte2
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboTipoJuego = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBuscarCliente = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGenerarRpt = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.txtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.dgvResultados = New System.Windows.Forms.DataGridView
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoJuego = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoNroMesa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoDrop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoWinLoss = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoPromedio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoTiempo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.crvResultados = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crRatingDetalle1 = New bddc.Win.crRatingDetalle
        Me.chkVistaPreliminar = New System.Windows.Forms.CheckBox
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
        Me.Label2.Size = New System.Drawing.Size(263, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Rating de Clientes (Detallado)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(357, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Inicio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTipoJuego)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtBuscarCliente)
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
        'cboTipoJuego
        '
        Me.cboTipoJuego.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboTipoJuego.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoJuego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoJuego.FormattingEnabled = True
        Me.cboTipoJuego.Location = New System.Drawing.Point(285, 10)
        Me.cboTipoJuego.MaxLength = 100
        Me.cboTipoJuego.Name = "cboTipoJuego"
        Me.cboTipoJuego.Size = New System.Drawing.Size(66, 21)
        Me.cboTipoJuego.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Juego"
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBuscarCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtBuscarCliente.FormattingEnabled = True
        Me.txtBuscarCliente.Location = New System.Drawing.Point(55, 10)
        Me.txtBuscarCliente.MaxLength = 100
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(184, 21)
        Me.txtBuscarCliente.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Buscar"
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
        Me.Label3.Location = New System.Drawing.Point(512, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Fecha Final"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFin.Location = New System.Drawing.Point(580, 11)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(83, 20)
        Me.txtFechaFin.TabIndex = 64
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaIni.Location = New System.Drawing.Point(428, 11)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(78, 20)
        Me.txtFechaIni.TabIndex = 63
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToOrderColumns = True
        Me.dgvResultados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteId, Me.ClienteCodigo, Me.ClienteNombreCompleto, Me.TipoJuego, Me.MovimientoFecha, Me.MovimientoNroMesa, Me.MovimientoMoneda, Me.MovimientoDrop, Me.MovimientoWinLoss, Me.MovimientoPromedio, Me.MovimientoTiempo})
        Me.dgvResultados.Location = New System.Drawing.Point(13, 118)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.Size = New System.Drawing.Size(754, 394)
        Me.dgvResultados.TabIndex = 15
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
        Me.ClienteCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClienteCodigo.DataPropertyName = "ClienteCodigo"
        Me.ClienteCodigo.HeaderText = "Id"
        Me.ClienteCodigo.Name = "ClienteCodigo"
        Me.ClienteCodigo.ReadOnly = True
        Me.ClienteCodigo.Width = 41
        '
        'ClienteNombreCompleto
        '
        Me.ClienteNombreCompleto.DataPropertyName = "ClienteNombreCompleto"
        Me.ClienteNombreCompleto.HeaderText = "Cliente"
        Me.ClienteNombreCompleto.Name = "ClienteNombreCompleto"
        Me.ClienteNombreCompleto.ReadOnly = True
        '
        'TipoJuego
        '
        Me.TipoJuego.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoJuego.DataPropertyName = "TipoJuego"
        Me.TipoJuego.HeaderText = "Juego"
        Me.TipoJuego.Name = "TipoJuego"
        Me.TipoJuego.ReadOnly = True
        Me.TipoJuego.Width = 61
        '
        'MovimientoFecha
        '
        Me.MovimientoFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MovimientoFecha.DataPropertyName = "MovimientoFecha"
        Me.MovimientoFecha.HeaderText = "Fecha"
        Me.MovimientoFecha.Name = "MovimientoFecha"
        Me.MovimientoFecha.ReadOnly = True
        Me.MovimientoFecha.Width = 62
        '
        'MovimientoNroMesa
        '
        Me.MovimientoNroMesa.DataPropertyName = "MovimientoNroMesa"
        Me.MovimientoNroMesa.HeaderText = "Mesa"
        Me.MovimientoNroMesa.Name = "MovimientoNroMesa"
        Me.MovimientoNroMesa.ReadOnly = True
        Me.MovimientoNroMesa.Width = 40
        '
        'MovimientoMoneda
        '
        Me.MovimientoMoneda.DataPropertyName = "MovimientoMoneda"
        Me.MovimientoMoneda.HeaderText = "Mon."
        Me.MovimientoMoneda.Name = "MovimientoMoneda"
        Me.MovimientoMoneda.ReadOnly = True
        Me.MovimientoMoneda.Width = 40
        '
        'MovimientoDrop
        '
        Me.MovimientoDrop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MovimientoDrop.DataPropertyName = "MovimientoDrop"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.MovimientoDrop.DefaultCellStyle = DataGridViewCellStyle1
        Me.MovimientoDrop.HeaderText = "Drop"
        Me.MovimientoDrop.Name = "MovimientoDrop"
        Me.MovimientoDrop.ReadOnly = True
        Me.MovimientoDrop.Width = 55
        '
        'MovimientoWinLoss
        '
        Me.MovimientoWinLoss.DataPropertyName = "MovimientoWinLoss"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.MovimientoWinLoss.DefaultCellStyle = DataGridViewCellStyle2
        Me.MovimientoWinLoss.HeaderText = "Win/Loss"
        Me.MovimientoWinLoss.Name = "MovimientoWinLoss"
        Me.MovimientoWinLoss.ReadOnly = True
        Me.MovimientoWinLoss.Width = 70
        '
        'MovimientoPromedio
        '
        Me.MovimientoPromedio.DataPropertyName = "MovimientoPromedio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.MovimientoPromedio.DefaultCellStyle = DataGridViewCellStyle3
        Me.MovimientoPromedio.HeaderText = "Apu. Prom"
        Me.MovimientoPromedio.Name = "MovimientoPromedio"
        Me.MovimientoPromedio.ReadOnly = True
        Me.MovimientoPromedio.Width = 80
        '
        'MovimientoTiempo
        '
        Me.MovimientoTiempo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MovimientoTiempo.DataPropertyName = "MovimientoTiempo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.MovimientoTiempo.DefaultCellStyle = DataGridViewCellStyle4
        Me.MovimientoTiempo.HeaderText = "Tiempo"
        Me.MovimientoTiempo.Name = "MovimientoTiempo"
        Me.MovimientoTiempo.ReadOnly = True
        Me.MovimientoTiempo.Width = 67
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
        Me.crvResultados.Size = New System.Drawing.Size(754, 394)
        Me.crvResultados.TabIndex = 66
        Me.crvResultados.ViewTimeSelectionFormula = ""
        '
        'chkVistaPreliminar
        '
        Me.chkVistaPreliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVistaPreliminar.AutoSize = True
        Me.chkVistaPreliminar.Location = New System.Drawing.Point(543, 537)
        Me.chkVistaPreliminar.Name = "chkVistaPreliminar"
        Me.chkVistaPreliminar.Size = New System.Drawing.Size(97, 17)
        Me.chkVistaPreliminar.TabIndex = 67
        Me.chkVistaPreliminar.Text = "Vista Preliminar"
        Me.chkVistaPreliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.Location = New System.Drawing.Point(714, 523)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 53)
        Me.btnSalir.TabIndex = 68
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmReporte2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(779, 588)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.chkVistaPreliminar)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.crvResultados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReporte2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rating de Clientes (Detallado)"
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
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents crvResultados As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crRatingDetalle1 As bddc.Win.crRatingDetalle
    Friend WithEvents chkVistaPreliminar As System.Windows.Forms.CheckBox
    Friend WithEvents ClienteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoJuego As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoNroMesa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoDrop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoWinLoss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoPromedio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoTiempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBuscarCliente As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoJuego As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
