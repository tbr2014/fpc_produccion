<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAperturaCaja
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GBoxDatosIniCaja = New System.Windows.Forms.GroupBox()
        Me.lblCasino = New System.Windows.Forms.Label()
        Me.lblFechaApertura = New System.Windows.Forms.Label()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.DTPFechaAper = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GBoxDetalleCaja = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.TxtCasinoNombre = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ValorM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ValorBllD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantBllD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALBllD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.ValorMnD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantMnD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALMnD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GBoxDatosIniCaja.SuspendLayout()
        Me.GBoxDetalleCaja.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(614, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GBoxDatosIniCaja
        '
        Me.GBoxDatosIniCaja.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GBoxDatosIniCaja.Controls.Add(Me.TextBox1)
        Me.GBoxDatosIniCaja.Controls.Add(Me.TxtCasinoNombre)
        Me.GBoxDatosIniCaja.Controls.Add(Me.lblUsuario)
        Me.GBoxDatosIniCaja.Controls.Add(Me.ComboBox2)
        Me.GBoxDatosIniCaja.Controls.Add(Me.ComboBox1)
        Me.GBoxDatosIniCaja.Controls.Add(Me.DTPFechaAper)
        Me.GBoxDatosIniCaja.Controls.Add(Me.lblTurno)
        Me.GBoxDatosIniCaja.Controls.Add(Me.lblCaja)
        Me.GBoxDatosIniCaja.Controls.Add(Me.lblFechaApertura)
        Me.GBoxDatosIniCaja.Controls.Add(Me.lblCasino)
        Me.GBoxDatosIniCaja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxDatosIniCaja.Location = New System.Drawing.Point(13, 37)
        Me.GBoxDatosIniCaja.Name = "GBoxDatosIniCaja"
        Me.GBoxDatosIniCaja.Size = New System.Drawing.Size(341, 180)
        Me.GBoxDatosIniCaja.TabIndex = 1
        Me.GBoxDatosIniCaja.TabStop = False
        Me.GBoxDatosIniCaja.Text = "Datos iniciales"
        '
        'lblCasino
        '
        Me.lblCasino.AutoSize = True
        Me.lblCasino.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasino.Location = New System.Drawing.Point(14, 26)
        Me.lblCasino.Name = "lblCasino"
        Me.lblCasino.Size = New System.Drawing.Size(50, 15)
        Me.lblCasino.TabIndex = 0
        Me.lblCasino.Text = "Casino:"
        '
        'lblFechaApertura
        '
        Me.lblFechaApertura.AutoSize = True
        Me.lblFechaApertura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaApertura.Location = New System.Drawing.Point(14, 58)
        Me.lblFechaApertura.Name = "lblFechaApertura"
        Me.lblFechaApertura.Size = New System.Drawing.Size(109, 15)
        Me.lblFechaApertura.TabIndex = 1
        Me.lblFechaApertura.Text = "Fecha de Apertura:"
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.Location = New System.Drawing.Point(14, 88)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(36, 15)
        Me.lblCaja.TabIndex = 2
        Me.lblCaja.Text = "Caja:"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(14, 118)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(42, 15)
        Me.lblTurno.TabIndex = 3
        Me.lblTurno.Text = "Turno:"
        '
        'DTPFechaAper
        '
        Me.DTPFechaAper.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaAper.Location = New System.Drawing.Point(128, 52)
        Me.DTPFechaAper.Name = "DTPFechaAper"
        Me.DTPFechaAper.Size = New System.Drawing.Size(200, 21)
        Me.DTPFechaAper.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(128, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 23)
        Me.ComboBox1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(128, 110)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 23)
        Me.ComboBox2.TabIndex = 7
        '
        'GBoxDetalleCaja
        '
        Me.GBoxDetalleCaja.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GBoxDetalleCaja.Controls.Add(Me.GroupBox2)
        Me.GBoxDetalleCaja.Controls.Add(Me.GroupBox1)
        Me.GBoxDetalleCaja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxDetalleCaja.Location = New System.Drawing.Point(13, 223)
        Me.GBoxDetalleCaja.Name = "GBoxDetalleCaja"
        Me.GBoxDetalleCaja.Size = New System.Drawing.Size(589, 299)
        Me.GBoxDetalleCaja.TabIndex = 2
        Me.GBoxDetalleCaja.TabStop = False
        Me.GBoxDetalleCaja.Text = "Detalles de Caja"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 550)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(614, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(14, 150)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(54, 15)
        Me.lblUsuario.TabIndex = 8
        Me.lblUsuario.Text = "Usuario:"
        '
        'TxtCasinoNombre
        '
        Me.TxtCasinoNombre.BackColor = System.Drawing.SystemColors.Info
        Me.TxtCasinoNombre.Enabled = False
        Me.TxtCasinoNombre.Location = New System.Drawing.Point(128, 23)
        Me.TxtCasinoNombre.Name = "TxtCasinoNombre"
        Me.TxtCasinoNombre.Size = New System.Drawing.Size(200, 21)
        Me.TxtCasinoNombre.TabIndex = 0
        Me.TxtCasinoNombre.Text = """Nombre del Casino"""
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(128, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 21)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = """Nombre del usuario logeado"""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 273)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Soles"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Location = New System.Drawing.Point(353, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 273)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dólar EE.UU"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 122)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Billetes"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Valor, Me.Cant, Me.TOTAL})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(189, 47)
        Me.DataGridView1.TabIndex = 2
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'Cant
        '
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 156)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Monedas"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ValorM, Me.CantM, Me.TOTALM})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(189, 49)
        Me.DataGridView2.TabIndex = 2
        '
        'ValorM
        '
        Me.ValorM.HeaderText = "Valor"
        Me.ValorM.Name = "ValorM"
        '
        'CantM
        '
        Me.CantM.HeaderText = "Cant"
        Me.CantM.Name = "CantM"
        '
        'TOTALM
        '
        Me.TOTALM.HeaderText = "TOTAL"
        Me.TOTALM.Name = "TOTALM"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(360, 125)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(242, 92)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Apertura Caja Montos"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox6.Controls.Add(Me.DataGridView3)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(207, 122)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Billetes"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox7.Controls.Add(Me.DataGridView4)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 157)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(207, 110)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Monedas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto Soles: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto Dólares:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(111, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 21)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(111, 52)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(115, 21)
        Me.TextBox3.TabIndex = 3
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ValorBllD, Me.CantBllD, Me.TOTALBllD})
        Me.DataGridView3.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(195, 47)
        Me.DataGridView3.TabIndex = 0
        '
        'ValorBllD
        '
        Me.ValorBllD.HeaderText = "Valor"
        Me.ValorBllD.Name = "ValorBllD"
        '
        'CantBllD
        '
        Me.CantBllD.HeaderText = "Cant"
        Me.CantBllD.Name = "CantBllD"
        '
        'TOTALBllD
        '
        Me.TOTALBllD.HeaderText = "TOTAL"
        Me.TOTALBllD.Name = "TOTALBllD"
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ValorMnD, Me.CantMnD, Me.TOTALMnD})
        Me.DataGridView4.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(195, 48)
        Me.DataGridView4.TabIndex = 0
        '
        'ValorMnD
        '
        Me.ValorMnD.HeaderText = "Valor"
        Me.ValorMnD.Name = "ValorMnD"
        '
        'CantMnD
        '
        Me.CantMnD.HeaderText = "Cant"
        Me.CantMnD.Name = "CantMnD"
        '
        'TOTALMnD
        '
        Me.TOTALMnD.HeaderText = "TOTAL"
        Me.TOTALMnD.Name = "TOTALMnD"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.bddc.Win.My.Resources.Resources.btngridGuardar
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton2.Text = "Guardar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton3.Text = "Salir"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TextBox5)
        Me.GroupBox8.Controls.Add(Me.TextBox4)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(360, 37)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(242, 82)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Cambio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Compra:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Venta:"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox4.Location = New System.Drawing.Point(111, 26)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(115, 21)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox5.Location = New System.Drawing.Point(111, 52)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(115, 21)
        Me.TextBox5.TabIndex = 3
        '
        'FormAperturaCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 572)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GBoxDetalleCaja)
        Me.Controls.Add(Me.GBoxDatosIniCaja)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FormAperturaCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura de Caja"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GBoxDatosIniCaja.ResumeLayout(False)
        Me.GBoxDatosIniCaja.PerformLayout()
        Me.GBoxDetalleCaja.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GBoxDatosIniCaja As System.Windows.Forms.GroupBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents lblFechaApertura As System.Windows.Forms.Label
    Friend WithEvents lblCasino As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DTPFechaAper As System.Windows.Forms.DateTimePicker
    Friend WithEvents GBoxDetalleCaja As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents TxtCasinoNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ValorM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents ValorBllD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantBllD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALBllD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents ValorMnD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantMnD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALMnD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
