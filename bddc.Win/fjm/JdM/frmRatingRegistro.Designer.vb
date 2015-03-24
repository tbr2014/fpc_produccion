<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRatingRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRatingRegistro))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtClienteCodigo = New System.Windows.Forms.TextBox
        Me.txtClienteNombre = New System.Windows.Forms.TextBox
        Me.gbTipoMoneda = New System.Windows.Forms.GroupBox
        Me.rbMoneda2 = New System.Windows.Forms.RadioButton
        Me.rbMoneda1 = New System.Windows.Forms.RadioButton
        Me.txtDrop = New System.Windows.Forms.TextBox
        Me.txtApuestaProm = New System.Windows.Forms.TextBox
        Me.gbTipoJuego = New System.Windows.Forms.GroupBox
        Me.rbJuego4 = New System.Windows.Forms.RadioButton
        Me.rbJuego5 = New System.Windows.Forms.RadioButton
        Me.rbJuego3 = New System.Windows.Forms.RadioButton
        Me.rbJuego1 = New System.Windows.Forms.RadioButton
        Me.rbJuego2 = New System.Windows.Forms.RadioButton
        Me.txtWinLoss = New System.Windows.Forms.TextBox
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView
        Me.MovimientoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Juego = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Drop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WinLoss = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApuestaProm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoHoraIni = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimientoDuracionHr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Borrar = New System.Windows.Forms.DataGridViewImageColumn
        Me.lblClienteId = New System.Windows.Forms.Label
        Me.lblMovimientoId = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboHoraIni = New System.Windows.Forms.ComboBox
        Me.cboHoraFin = New System.Windows.Forms.ComboBox
        Me.cboMinIni = New System.Windows.Forms.ComboBox
        Me.cboMinFin = New System.Windows.Forms.ComboBox
        Me.cboNroMesa = New System.Windows.Forms.ComboBox
        Me.dtpFechaMov = New System.Windows.Forms.DateTimePicker
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDuracionHr = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblEstadoCierre = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.gbTipoMoneda.SuspendLayout()
        Me.gbTipoJuego.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Registro de Rating"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Id. Cliente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nro. Mesa:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(250, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Moneda:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fecha:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Win/Loss:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(248, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Hora Inicio:"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Drop:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Apuesta Prom.:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Juego:"
        '
        'txtClienteCodigo
        '
        Me.txtClienteCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteCodigo.Location = New System.Drawing.Point(116, 15)
        Me.txtClienteCodigo.Name = "txtClienteCodigo"
        Me.txtClienteCodigo.ReadOnly = True
        Me.txtClienteCodigo.Size = New System.Drawing.Size(107, 20)
        Me.txtClienteCodigo.TabIndex = 0
        Me.txtClienteCodigo.TabStop = False
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Location = New System.Drawing.Point(115, 42)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.ReadOnly = True
        Me.txtClienteNombre.Size = New System.Drawing.Size(320, 20)
        Me.txtClienteNombre.TabIndex = 1
        Me.txtClienteNombre.TabStop = False
        '
        'gbTipoMoneda
        '
        Me.gbTipoMoneda.Controls.Add(Me.rbMoneda2)
        Me.gbTipoMoneda.Controls.Add(Me.rbMoneda1)
        Me.gbTipoMoneda.Enabled = False
        Me.gbTipoMoneda.Location = New System.Drawing.Point(331, 120)
        Me.gbTipoMoneda.Name = "gbTipoMoneda"
        Me.gbTipoMoneda.Size = New System.Drawing.Size(116, 31)
        Me.gbTipoMoneda.TabIndex = 4
        Me.gbTipoMoneda.TabStop = False
        '
        'rbMoneda2
        '
        Me.rbMoneda2.AutoSize = True
        Me.rbMoneda2.Location = New System.Drawing.Point(62, 7)
        Me.rbMoneda2.Name = "rbMoneda2"
        Me.rbMoneda2.Size = New System.Drawing.Size(46, 17)
        Me.rbMoneda2.TabIndex = 1
        Me.rbMoneda2.TabStop = True
        Me.rbMoneda2.Text = "US$"
        Me.rbMoneda2.UseVisualStyleBackColor = True
        '
        'rbMoneda1
        '
        Me.rbMoneda1.AutoSize = True
        Me.rbMoneda1.Location = New System.Drawing.Point(11, 7)
        Me.rbMoneda1.Name = "rbMoneda1"
        Me.rbMoneda1.Size = New System.Drawing.Size(40, 17)
        Me.rbMoneda1.TabIndex = 0
        Me.rbMoneda1.TabStop = True
        Me.rbMoneda1.Text = "S/."
        Me.rbMoneda1.UseVisualStyleBackColor = True
        '
        'txtDrop
        '
        Me.txtDrop.Location = New System.Drawing.Point(115, 157)
        Me.txtDrop.Name = "txtDrop"
        Me.txtDrop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDrop.Size = New System.Drawing.Size(85, 20)
        Me.txtDrop.TabIndex = 5
        Me.txtDrop.Text = "0.00"
        '
        'txtApuestaProm
        '
        Me.txtApuestaProm.Location = New System.Drawing.Point(115, 209)
        Me.txtApuestaProm.Name = "txtApuestaProm"
        Me.txtApuestaProm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtApuestaProm.Size = New System.Drawing.Size(85, 20)
        Me.txtApuestaProm.TabIndex = 7
        Me.txtApuestaProm.Text = "0.00"
        '
        'gbTipoJuego
        '
        Me.gbTipoJuego.Controls.Add(Me.rbJuego4)
        Me.gbTipoJuego.Controls.Add(Me.rbJuego5)
        Me.gbTipoJuego.Controls.Add(Me.rbJuego3)
        Me.gbTipoJuego.Controls.Add(Me.rbJuego1)
        Me.gbTipoJuego.Controls.Add(Me.rbJuego2)
        Me.gbTipoJuego.Location = New System.Drawing.Point(115, 90)
        Me.gbTipoJuego.Name = "gbTipoJuego"
        Me.gbTipoJuego.Size = New System.Drawing.Size(332, 30)
        Me.gbTipoJuego.TabIndex = 3
        Me.gbTipoJuego.TabStop = False
        '
        'rbJuego4
        '
        Me.rbJuego4.AutoSize = True
        Me.rbJuego4.Location = New System.Drawing.Point(191, 7)
        Me.rbJuego4.Name = "rbJuego4"
        Me.rbJuego4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbJuego4.Size = New System.Drawing.Size(47, 17)
        Me.rbJuego4.TabIndex = 3
        Me.rbJuego4.TabStop = True
        Me.rbJuego4.Text = "THP"
        Me.rbJuego4.UseVisualStyleBackColor = True
        '
        'rbJuego5
        '
        Me.rbJuego5.AutoSize = True
        Me.rbJuego5.Location = New System.Drawing.Point(247, 7)
        Me.rbJuego5.Name = "rbJuego5"
        Me.rbJuego5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbJuego5.Size = New System.Drawing.Size(56, 17)
        Me.rbJuego5.TabIndex = 4
        Me.rbJuego5.TabStop = True
        Me.rbJuego5.Text = "MDPB"
        Me.rbJuego5.UseVisualStyleBackColor = True
        '
        'rbJuego3
        '
        Me.rbJuego3.AutoSize = True
        Me.rbJuego3.Location = New System.Drawing.Point(136, 7)
        Me.rbJuego3.Name = "rbJuego3"
        Me.rbJuego3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbJuego3.Size = New System.Drawing.Size(39, 17)
        Me.rbJuego3.TabIndex = 2
        Me.rbJuego3.TabStop = True
        Me.rbJuego3.Text = "PK"
        Me.rbJuego3.UseVisualStyleBackColor = True
        '
        'rbJuego1
        '
        Me.rbJuego1.AutoSize = True
        Me.rbJuego1.Location = New System.Drawing.Point(6, 7)
        Me.rbJuego1.Name = "rbJuego1"
        Me.rbJuego1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbJuego1.Size = New System.Drawing.Size(39, 17)
        Me.rbJuego1.TabIndex = 0
        Me.rbJuego1.TabStop = True
        Me.rbJuego1.Text = "RL"
        Me.rbJuego1.UseVisualStyleBackColor = True
        '
        'rbJuego2
        '
        Me.rbJuego2.AutoSize = True
        Me.rbJuego2.Location = New System.Drawing.Point(71, 7)
        Me.rbJuego2.Name = "rbJuego2"
        Me.rbJuego2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbJuego2.Size = New System.Drawing.Size(37, 17)
        Me.rbJuego2.TabIndex = 1
        Me.rbJuego2.TabStop = True
        Me.rbJuego2.Text = "BJ"
        Me.rbJuego2.UseVisualStyleBackColor = True
        '
        'txtWinLoss
        '
        Me.txtWinLoss.Location = New System.Drawing.Point(115, 183)
        Me.txtWinLoss.Name = "txtWinLoss"
        Me.txtWinLoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtWinLoss.Size = New System.Drawing.Size(85, 20)
        Me.txtWinLoss.TabIndex = 6
        Me.txtWinLoss.Text = "0.00"
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.AllowUserToResizeColumns = False
        Me.dgvMovimientos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovimientoId, Me.Fecha, Me.Juego, Me.Nro, Me.MovimientoMoneda, Me.Drop, Me.WinLoss, Me.ApuestaProm, Me.MovimientoHoraIni, Me.MovimientoHoraFin, Me.MovimientoDuracionHr, Me.Borrar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMovimientos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMovimientos.Location = New System.Drawing.Point(12, 343)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMovimientos.Size = New System.Drawing.Size(494, 178)
        Me.dgvMovimientos.TabIndex = 9
        '
        'MovimientoId
        '
        Me.MovimientoId.DataPropertyName = "MovimientoId"
        Me.MovimientoId.HeaderText = "MovimientoId"
        Me.MovimientoId.Name = "MovimientoId"
        Me.MovimientoId.ReadOnly = True
        Me.MovimientoId.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MovimientoId.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "MovimientoFecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 70
        '
        'Juego
        '
        Me.Juego.DataPropertyName = "TipoJuego"
        Me.Juego.HeaderText = "Juego"
        Me.Juego.Name = "Juego"
        Me.Juego.ReadOnly = True
        Me.Juego.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Juego.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Juego.Width = 40
        '
        'Nro
        '
        Me.Nro.DataPropertyName = "MovimientoNroMesa"
        Me.Nro.HeaderText = "Mesa"
        Me.Nro.Name = "Nro"
        Me.Nro.ReadOnly = True
        Me.Nro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Nro.Width = 40
        '
        'MovimientoMoneda
        '
        Me.MovimientoMoneda.DataPropertyName = "MovimientoMoneda"
        Me.MovimientoMoneda.HeaderText = ""
        Me.MovimientoMoneda.Name = "MovimientoMoneda"
        Me.MovimientoMoneda.ReadOnly = True
        Me.MovimientoMoneda.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MovimientoMoneda.Width = 35
        '
        'Drop
        '
        Me.Drop.DataPropertyName = "MovimientoDrop"
        Me.Drop.HeaderText = "Drop"
        Me.Drop.Name = "Drop"
        Me.Drop.ReadOnly = True
        Me.Drop.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Drop.Width = 60
        '
        'WinLoss
        '
        Me.WinLoss.DataPropertyName = "MovimientoWinLoss"
        Me.WinLoss.HeaderText = "Win/Loss"
        Me.WinLoss.Name = "WinLoss"
        Me.WinLoss.ReadOnly = True
        Me.WinLoss.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.WinLoss.Width = 60
        '
        'ApuestaProm
        '
        Me.ApuestaProm.DataPropertyName = "MovimientoApuestaProm"
        Me.ApuestaProm.HeaderText = "Prom."
        Me.ApuestaProm.Name = "ApuestaProm"
        Me.ApuestaProm.ReadOnly = True
        Me.ApuestaProm.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApuestaProm.Width = 50
        '
        'MovimientoHoraIni
        '
        Me.MovimientoHoraIni.DataPropertyName = "MovimientoHoraIni"
        Me.MovimientoHoraIni.HeaderText = "Inicio"
        Me.MovimientoHoraIni.Name = "MovimientoHoraIni"
        Me.MovimientoHoraIni.ReadOnly = True
        Me.MovimientoHoraIni.Visible = False
        Me.MovimientoHoraIni.Width = 50
        '
        'MovimientoHoraFin
        '
        Me.MovimientoHoraFin.DataPropertyName = "MovimientoHoraFin"
        Me.MovimientoHoraFin.HeaderText = "Fin"
        Me.MovimientoHoraFin.Name = "MovimientoHoraFin"
        Me.MovimientoHoraFin.ReadOnly = True
        Me.MovimientoHoraFin.Visible = False
        Me.MovimientoHoraFin.Width = 50
        '
        'MovimientoDuracionHr
        '
        Me.MovimientoDuracionHr.DataPropertyName = "MovimientoDuracionHr"
        Me.MovimientoDuracionHr.HeaderText = "Dur. Hr."
        Me.MovimientoDuracionHr.MinimumWidth = 10
        Me.MovimientoDuracionHr.Name = "MovimientoDuracionHr"
        Me.MovimientoDuracionHr.ReadOnly = True
        Me.MovimientoDuracionHr.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MovimientoDuracionHr.Width = 70
        '
        'Borrar
        '
        Me.Borrar.HeaderText = "Borrar"
        Me.Borrar.Image = CType(resources.GetObject("Borrar.Image"), System.Drawing.Image)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Visible = False
        Me.Borrar.Width = 40
        '
        'lblClienteId
        '
        Me.lblClienteId.AutoSize = True
        Me.lblClienteId.Location = New System.Drawing.Point(262, 109)
        Me.lblClienteId.Name = "lblClienteId"
        Me.lblClienteId.Size = New System.Drawing.Size(0, 13)
        Me.lblClienteId.TabIndex = 0
        Me.lblClienteId.Visible = False
        '
        'lblMovimientoId
        '
        Me.lblMovimientoId.AutoSize = True
        Me.lblMovimientoId.Location = New System.Drawing.Point(292, 107)
        Me.lblMovimientoId.Name = "lblMovimientoId"
        Me.lblMovimientoId.Size = New System.Drawing.Size(0, 13)
        Me.lblMovimientoId.TabIndex = 0
        Me.lblMovimientoId.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(260, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Hora Fin:"
        Me.Label6.Visible = False
        '
        'cboHoraIni
        '
        Me.cboHoraIni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboHoraIni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboHoraIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHoraIni.FormattingEnabled = True
        Me.cboHoraIni.Location = New System.Drawing.Point(331, 184)
        Me.cboHoraIni.Name = "cboHoraIni"
        Me.cboHoraIni.Size = New System.Drawing.Size(51, 21)
        Me.cboHoraIni.TabIndex = 8
        Me.cboHoraIni.Visible = False
        '
        'cboHoraFin
        '
        Me.cboHoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHoraFin.FormattingEnabled = True
        Me.cboHoraFin.Location = New System.Drawing.Point(330, 209)
        Me.cboHoraFin.Name = "cboHoraFin"
        Me.cboHoraFin.Size = New System.Drawing.Size(51, 21)
        Me.cboHoraFin.TabIndex = 10
        Me.cboHoraFin.Visible = False
        '
        'cboMinIni
        '
        Me.cboMinIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinIni.FormattingEnabled = True
        Me.cboMinIni.Location = New System.Drawing.Point(388, 184)
        Me.cboMinIni.Name = "cboMinIni"
        Me.cboMinIni.Size = New System.Drawing.Size(51, 21)
        Me.cboMinIni.TabIndex = 9
        Me.cboMinIni.Visible = False
        '
        'cboMinFin
        '
        Me.cboMinFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinFin.FormattingEnabled = True
        Me.cboMinFin.Location = New System.Drawing.Point(387, 209)
        Me.cboMinFin.Name = "cboMinFin"
        Me.cboMinFin.Size = New System.Drawing.Size(51, 21)
        Me.cboMinFin.TabIndex = 11
        Me.cboMinFin.Visible = False
        '
        'cboNroMesa
        '
        Me.cboNroMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNroMesa.FormattingEnabled = True
        Me.cboNroMesa.Location = New System.Drawing.Point(115, 125)
        Me.cboNroMesa.Name = "cboNroMesa"
        Me.cboNroMesa.Size = New System.Drawing.Size(85, 21)
        Me.cboNroMesa.TabIndex = 4
        '
        'dtpFechaMov
        '
        Me.dtpFechaMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMov.Location = New System.Drawing.Point(115, 68)
        Me.dtpFechaMov.Name = "dtpFechaMov"
        Me.dtpFechaMov.Size = New System.Drawing.Size(90, 20)
        Me.dtpFechaMov.TabIndex = 2
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(9, 524)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(74, 13)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "<Mensajes>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(258, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Duración:"
        '
        'txtDuracionHr
        '
        Me.txtDuracionHr.Location = New System.Drawing.Point(330, 158)
        Me.txtDuracionHr.Name = "txtDuracionHr"
        Me.txtDuracionHr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDuracionHr.Size = New System.Drawing.Size(51, 20)
        Me.txtDuracionHr.TabIndex = 8
        Me.txtDuracionHr.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(384, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Min."
        '
        'lblEstadoCierre
        '
        Me.lblEstadoCierre.AutoSize = True
        Me.lblEstadoCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCierre.Location = New System.Drawing.Point(209, 73)
        Me.lblEstadoCierre.Name = "lblEstadoCierre"
        Me.lblEstadoCierre.Size = New System.Drawing.Size(115, 13)
        Me.lblEstadoCierre.TabIndex = 66
        Me.lblEstadoCierre.Text = "<Estado de Cierre>"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbNuevo, Me.tsbAgregar, Me.tsbGuardar, Me.tsbEliminar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(518, 31)
        Me.ToolStrip1.TabIndex = 67
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Image = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(67, 28)
        Me.tsbBuscar.Text = "Buscar"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(66, 28)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Image = Global.bddc.Win.My.Resources.Resources.btnOk
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(74, 28)
        Me.tsbAgregar.Text = "Agregar"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.bddc.Win.My.Resources.Resources.btngridGuardar
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(74, 28)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = Global.bddc.Win.My.Resources.Resources.btngridBorrar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(71, 28)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'tsbImprimir
        '
        Me.tsbImprimir.Enabled = False
        Me.tsbImprimir.Image = Global.bddc.Win.My.Resources.Resources.imgImpresion
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(73, 28)
        Me.tsbImprimir.Text = "Imprimir"
        Me.tsbImprimir.Visible = False
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(55, 28)
        Me.tsbSalir.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblEstadoCierre)
        Me.GroupBox1.Controls.Add(Me.txtDuracionHr)
        Me.GroupBox1.Controls.Add(Me.txtClienteCodigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtClienteNombre)
        Me.GroupBox1.Controls.Add(Me.cboMinFin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboHoraFin)
        Me.GroupBox1.Controls.Add(Me.txtApuestaProm)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboMinIni)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.gbTipoMoneda)
        Me.GroupBox1.Controls.Add(Me.dtpFechaMov)
        Me.GroupBox1.Controls.Add(Me.cboHoraIni)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtWinLoss)
        Me.GroupBox1.Controls.Add(Me.cboNroMesa)
        Me.GroupBox1.Controls.Add(Me.gbTipoJuego)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDrop)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 240)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Rating"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Borrar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Visible = False
        Me.DataGridViewImageColumn1.Width = 40
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'frmRatingRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(518, 541)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.lblMovimientoId)
        Me.Controls.Add(Me.lblClienteId)
        Me.Controls.Add(Me.dgvMovimientos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRatingRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Rating"
        Me.gbTipoMoneda.ResumeLayout(False)
        Me.gbTipoMoneda.PerformLayout()
        Me.gbTipoJuego.ResumeLayout(False)
        Me.gbTipoJuego.PerformLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtClienteCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteNombre As System.Windows.Forms.TextBox
    Friend WithEvents gbTipoMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents rbMoneda2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbMoneda1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtDrop As System.Windows.Forms.TextBox
    Friend WithEvents txtApuestaProm As System.Windows.Forms.TextBox
    Friend WithEvents gbTipoJuego As System.Windows.Forms.GroupBox
    Friend WithEvents txtWinLoss As System.Windows.Forms.TextBox
    Friend WithEvents dgvMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents lblClienteId As System.Windows.Forms.Label
    Friend WithEvents rbJuego4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbJuego5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbJuego3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbJuego1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbJuego2 As System.Windows.Forms.RadioButton
    Friend WithEvents lblMovimientoId As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboHoraIni As System.Windows.Forms.ComboBox
    Friend WithEvents cboHoraFin As System.Windows.Forms.ComboBox
    Friend WithEvents cboMinIni As System.Windows.Forms.ComboBox
    Friend WithEvents cboMinFin As System.Windows.Forms.ComboBox
    Friend WithEvents cboNroMesa As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaMov As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDuracionHr As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblEstadoCierre As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents MovimientoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Juego As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Drop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WinLoss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApuestaProm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoHoraIni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoHoraFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientoDuracionHr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Borrar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
End Class
