<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaRegistroOperador
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
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbSeccion1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbtnMastercad = New System.Windows.Forms.RadioButton()
        Me.rbtnVisa = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbModalidadOperacion1 = New System.Windows.Forms.RadioButton()
        Me.rbModalidadOperacion3 = New System.Windows.Forms.RadioButton()
        Me.rbModalidadOperacion2 = New System.Windows.Forms.RadioButton()
        Me.txtTarjetaNum = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOperacionCodigo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtJackpotMaquina = New System.Windows.Forms.TextBox()
        Me.txtFichaCantidad = New System.Windows.Forms.TextBox()
        Me.cboFichaVenta = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbTipoOperacion6 = New System.Windows.Forms.RadioButton()
        Me.rbTipoOperacion5 = New System.Windows.Forms.RadioButton()
        Me.rbTipoOperacion4 = New System.Windows.Forms.RadioButton()
        Me.rbTipoOperacion1 = New System.Windows.Forms.RadioButton()
        Me.rbTipoOperacion3 = New System.Windows.Forms.RadioButton()
        Me.rbTipoOperacion2 = New System.Windows.Forms.RadioButton()
        Me.cboMontoMoneda = New System.Windows.Forms.ComboBox()
        Me.txtMontoImporte = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbSeccion3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtClienteDireccionDist = New System.Windows.Forms.TextBox()
        Me.txtClienteDireccionProv = New System.Windows.Forms.TextBox()
        Me.txtClienteDireccionDpto = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtClienteDireccionUrb = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtClienteDireccionInt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtClienteDireccionNro = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtClienteDireccion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtClienteNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtClientePais = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClienteNumDoc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtClienteApellidos = New System.Windows.Forms.TextBox()
        Me.txtClienteNombres = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClienteBuscar = New System.Windows.Forms.Button()
        Me.lblClienteId = New System.Windows.Forms.Label()
        Me.btnClienteNuevo = New System.Windows.Forms.Button()
        Me.gbCaja = New System.Windows.Forms.GroupBox()
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.gbFechaRegistro = New System.Windows.Forms.GroupBox()
        Me.ucFechaProceso = New bddc.Win.ucFecha()
        Me.gbSeccion2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusStrip1.SuspendLayout()
        Me.gbSeccion1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbSeccion3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbCaja.SuspendLayout()
        Me.gbFechaRegistro.SuspendLayout()
        Me.gbSeccion2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbNuevo, Me.tsbAgregar, Me.tsbGuardar, Me.tsbEliminar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(604, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Image = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(70, 28)
        Me.tsbBuscar.Text = "Buscar"
        Me.tsbBuscar.Visible = False
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(70, 28)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Image = Global.bddc.Win.My.Resources.Resources.btnOk
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(77, 28)
        Me.tsbAgregar.Text = "Agregar"
        Me.tsbAgregar.Visible = False
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.bddc.Win.My.Resources.Resources.btngridGuardar
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(77, 28)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = Global.bddc.Win.My.Resources.Resources.btngridBorrar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(78, 28)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(57, 28)
        Me.tsbSalir.Text = "Salir"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Registro de Operación en Caja"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgCajayConteo
        Me.PictureBox2.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMensaje})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 643)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(604, 22)
        Me.statusStrip1.TabIndex = 0
        Me.statusStrip1.Text = "StatusStrip1"
        '
        'tssMensaje
        '
        Me.tssMensaje.Name = "tssMensaje"
        Me.tssMensaje.Size = New System.Drawing.Size(51, 17)
        Me.tssMensaje.Text = "Mensaje"
        '
        'gbSeccion1
        '
        Me.gbSeccion1.Controls.Add(Me.GroupBox1)
        Me.gbSeccion1.Controls.Add(Me.lblOperacionCodigo)
        Me.gbSeccion1.Controls.Add(Me.Label20)
        Me.gbSeccion1.Controls.Add(Me.GroupBox2)
        Me.gbSeccion1.Controls.Add(Me.cboMontoMoneda)
        Me.gbSeccion1.Controls.Add(Me.txtMontoImporte)
        Me.gbSeccion1.Controls.Add(Me.Label6)
        Me.gbSeccion1.Location = New System.Drawing.Point(11, 97)
        Me.gbSeccion1.Name = "gbSeccion1"
        Me.gbSeccion1.Size = New System.Drawing.Size(589, 275)
        Me.gbSeccion1.TabIndex = 1
        Me.gbSeccion1.TabStop = False
        Me.gbSeccion1.Text = "Información de la Operación"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 77)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modalidad Operación"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbtnMastercad)
        Me.GroupBox6.Controls.Add(Me.rbtnVisa)
        Me.GroupBox6.Location = New System.Drawing.Point(408, 13)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(158, 58)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        '
        'rbtnMastercad
        '
        Me.rbtnMastercad.AutoSize = True
        Me.rbtnMastercad.Location = New System.Drawing.Point(11, 31)
        Me.rbtnMastercad.Name = "rbtnMastercad"
        Me.rbtnMastercad.Size = New System.Drawing.Size(79, 17)
        Me.rbtnMastercad.TabIndex = 8
        Me.rbtnMastercad.Text = "MasterCard"
        Me.rbtnMastercad.UseVisualStyleBackColor = True
        '
        'rbtnVisa
        '
        Me.rbtnVisa.AutoSize = True
        Me.rbtnVisa.Location = New System.Drawing.Point(11, 12)
        Me.rbtnVisa.Name = "rbtnVisa"
        Me.rbtnVisa.Size = New System.Drawing.Size(45, 17)
        Me.rbtnVisa.TabIndex = 7
        Me.rbtnVisa.Text = "Visa"
        Me.rbtnVisa.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbModalidadOperacion1)
        Me.GroupBox5.Controls.Add(Me.rbModalidadOperacion3)
        Me.GroupBox5.Controls.Add(Me.rbModalidadOperacion2)
        Me.GroupBox5.Controls.Add(Me.txtTarjetaNum)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(398, 58)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        '
        'rbModalidadOperacion1
        '
        Me.rbModalidadOperacion1.AutoSize = True
        Me.rbModalidadOperacion1.Location = New System.Drawing.Point(14, 12)
        Me.rbModalidadOperacion1.Name = "rbModalidadOperacion1"
        Me.rbModalidadOperacion1.Size = New System.Drawing.Size(64, 17)
        Me.rbModalidadOperacion1.TabIndex = 0
        Me.rbModalidadOperacion1.Text = "Efectivo"
        Me.rbModalidadOperacion1.UseVisualStyleBackColor = True
        '
        'rbModalidadOperacion3
        '
        Me.rbModalidadOperacion3.AutoSize = True
        Me.rbModalidadOperacion3.Location = New System.Drawing.Point(150, 11)
        Me.rbModalidadOperacion3.Name = "rbModalidadOperacion3"
        Me.rbModalidadOperacion3.Size = New System.Drawing.Size(107, 17)
        Me.rbModalidadOperacion3.TabIndex = 2
        Me.rbModalidadOperacion3.Text = "Tarjeta de Débito"
        Me.rbModalidadOperacion3.UseVisualStyleBackColor = True
        '
        'rbModalidadOperacion2
        '
        Me.rbModalidadOperacion2.AutoSize = True
        Me.rbModalidadOperacion2.Location = New System.Drawing.Point(150, 31)
        Me.rbModalidadOperacion2.Name = "rbModalidadOperacion2"
        Me.rbModalidadOperacion2.Size = New System.Drawing.Size(109, 17)
        Me.rbModalidadOperacion2.TabIndex = 1
        Me.rbModalidadOperacion2.Text = "Tarjeta de Crédito"
        Me.rbModalidadOperacion2.UseVisualStyleBackColor = True
        '
        'txtTarjetaNum
        '
        Me.txtTarjetaNum.Location = New System.Drawing.Point(276, 30)
        Me.txtTarjetaNum.Mask = "0000-0000-0000-0000"
        Me.txtTarjetaNum.Name = "txtTarjetaNum"
        Me.txtTarjetaNum.Size = New System.Drawing.Size(113, 20)
        Me.txtTarjetaNum.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(273, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "No. Tarjeta"
        '
        'lblOperacionCodigo
        '
        Me.lblOperacionCodigo.AutoSize = True
        Me.lblOperacionCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacionCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblOperacionCodigo.Location = New System.Drawing.Point(422, 20)
        Me.lblOperacionCodigo.Name = "lblOperacionCodigo"
        Me.lblOperacionCodigo.Size = New System.Drawing.Size(46, 13)
        Me.lblOperacionCodigo.TabIndex = 6
        Me.lblOperacionCodigo.Text = "Codigo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(294, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Código de Operación"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtJackpotMaquina)
        Me.GroupBox2.Controls.Add(Me.txtFichaCantidad)
        Me.GroupBox2.Controls.Add(Me.cboFichaVenta)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.rbTipoOperacion6)
        Me.GroupBox2.Controls.Add(Me.rbTipoOperacion5)
        Me.GroupBox2.Controls.Add(Me.rbTipoOperacion4)
        Me.GroupBox2.Controls.Add(Me.rbTipoOperacion1)
        Me.GroupBox2.Controls.Add(Me.rbTipoOperacion3)
        Me.GroupBox2.Controls.Add(Me.rbTipoOperacion2)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 113)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Operación"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(478, 59)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Máquina"
        '
        'txtJackpotMaquina
        '
        Me.txtJackpotMaquina.Location = New System.Drawing.Point(526, 56)
        Me.txtJackpotMaquina.MaxLength = 6
        Me.txtJackpotMaquina.Name = "txtJackpotMaquina"
        Me.txtJackpotMaquina.Size = New System.Drawing.Size(45, 20)
        Me.txtJackpotMaquina.TabIndex = 11
        '
        'txtFichaCantidad
        '
        Me.txtFichaCantidad.Location = New System.Drawing.Point(102, 81)
        Me.txtFichaCantidad.Name = "txtFichaCantidad"
        Me.txtFichaCantidad.Size = New System.Drawing.Size(33, 20)
        Me.txtFichaCantidad.TabIndex = 10
        '
        'cboFichaVenta
        '
        Me.cboFichaVenta.Enabled = False
        Me.cboFichaVenta.FormattingEnabled = True
        Me.cboFichaVenta.Location = New System.Drawing.Point(102, 58)
        Me.cboFichaVenta.Name = "cboFichaVenta"
        Me.cboFichaVenta.Size = New System.Drawing.Size(70, 21)
        Me.cboFichaVenta.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(36, 61)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Ficha  US$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "No. Ficha(s)"
        '
        'rbTipoOperacion6
        '
        Me.rbTipoOperacion6.AutoSize = True
        Me.rbTipoOperacion6.Location = New System.Drawing.Point(279, 76)
        Me.rbTipoOperacion6.Name = "rbTipoOperacion6"
        Me.rbTipoOperacion6.Size = New System.Drawing.Size(149, 17)
        Me.rbTipoOperacion6.TabIndex = 5
        Me.rbTipoOperacion6.TabStop = True
        Me.rbTipoOperacion6.Text = "Retiro de Efectivo en Caja"
        Me.rbTipoOperacion6.UseVisualStyleBackColor = True
        '
        'rbTipoOperacion5
        '
        Me.rbTipoOperacion5.AutoSize = True
        Me.rbTipoOperacion5.Location = New System.Drawing.Point(279, 57)
        Me.rbTipoOperacion5.Name = "rbTipoOperacion5"
        Me.rbTipoOperacion5.Size = New System.Drawing.Size(189, 17)
        Me.rbTipoOperacion5.TabIndex = 4
        Me.rbTipoOperacion5.TabStop = True
        Me.rbTipoOperacion5.Text = "Cobro de Premio (Jackpot) en Caja"
        Me.rbTipoOperacion5.UseVisualStyleBackColor = True
        '
        'rbTipoOperacion4
        '
        Me.rbTipoOperacion4.AutoSize = True
        Me.rbTipoOperacion4.Location = New System.Drawing.Point(279, 38)
        Me.rbTipoOperacion4.Name = "rbTipoOperacion4"
        Me.rbTipoOperacion4.Size = New System.Drawing.Size(245, 17)
        Me.rbTipoOperacion4.TabIndex = 3
        Me.rbTipoOperacion4.TabStop = True
        Me.rbTipoOperacion4.Text = "Canje de Tickets de sorteos por fichas en Caja"
        Me.rbTipoOperacion4.UseVisualStyleBackColor = True
        '
        'rbTipoOperacion1
        '
        Me.rbTipoOperacion1.AutoSize = True
        Me.rbTipoOperacion1.Location = New System.Drawing.Point(6, 19)
        Me.rbTipoOperacion1.Name = "rbTipoOperacion1"
        Me.rbTipoOperacion1.Size = New System.Drawing.Size(187, 17)
        Me.rbTipoOperacion1.TabIndex = 0
        Me.rbTipoOperacion1.TabStop = True
        Me.rbTipoOperacion1.Text = "Canje de dinero por fichas en Caja"
        Me.rbTipoOperacion1.UseVisualStyleBackColor = True
        '
        'rbTipoOperacion3
        '
        Me.rbTipoOperacion3.AutoSize = True
        Me.rbTipoOperacion3.Location = New System.Drawing.Point(279, 19)
        Me.rbTipoOperacion3.Name = "rbTipoOperacion3"
        Me.rbTipoOperacion3.Size = New System.Drawing.Size(280, 17)
        Me.rbTipoOperacion3.TabIndex = 2
        Me.rbTipoOperacion3.TabStop = True
        Me.rbTipoOperacion3.Text = "Canje de tickets (créditos de máquinas tragamonedas)"
        Me.rbTipoOperacion3.UseVisualStyleBackColor = True
        '
        'rbTipoOperacion2
        '
        Me.rbTipoOperacion2.AutoSize = True
        Me.rbTipoOperacion2.Location = New System.Drawing.Point(6, 38)
        Me.rbTipoOperacion2.Name = "rbTipoOperacion2"
        Me.rbTipoOperacion2.Size = New System.Drawing.Size(187, 17)
        Me.rbTipoOperacion2.TabIndex = 1
        Me.rbTipoOperacion2.TabStop = True
        Me.rbTipoOperacion2.Text = "Canje de fichas por dinero en Caja"
        Me.rbTipoOperacion2.UseVisualStyleBackColor = True
        '
        'cboMontoMoneda
        '
        Me.cboMontoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMontoMoneda.FormattingEnabled = True
        Me.cboMontoMoneda.Location = New System.Drawing.Point(128, 17)
        Me.cboMontoMoneda.Name = "cboMontoMoneda"
        Me.cboMontoMoneda.Size = New System.Drawing.Size(56, 21)
        Me.cboMontoMoneda.TabIndex = 1
        '
        'txtMontoImporte
        '
        Me.txtMontoImporte.Location = New System.Drawing.Point(190, 18)
        Me.txtMontoImporte.Name = "txtMontoImporte"
        Me.txtMontoImporte.Size = New System.Drawing.Size(93, 20)
        Me.txtMontoImporte.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Monto Operación"
        '
        'gbSeccion3
        '
        Me.gbSeccion3.Controls.Add(Me.Label3)
        Me.gbSeccion3.Controls.Add(Me.GroupBox3)
        Me.gbSeccion3.Controls.Add(Me.txtClienteNacionalidad)
        Me.gbSeccion3.Controls.Add(Me.Label11)
        Me.gbSeccion3.Controls.Add(Me.txtClientePais)
        Me.gbSeccion3.Controls.Add(Me.Label7)
        Me.gbSeccion3.Controls.Add(Me.txtClienteNumDoc)
        Me.gbSeccion3.Controls.Add(Me.Label10)
        Me.gbSeccion3.Controls.Add(Me.txtClienteApellidos)
        Me.gbSeccion3.Controls.Add(Me.txtClienteNombres)
        Me.gbSeccion3.Controls.Add(Me.Label9)
        Me.gbSeccion3.Controls.Add(Me.Label8)
        Me.gbSeccion3.Enabled = False
        Me.gbSeccion3.Location = New System.Drawing.Point(17, 434)
        Me.gbSeccion3.Name = "gbSeccion3"
        Me.gbSeccion3.Size = New System.Drawing.Size(588, 206)
        Me.gbSeccion3.TabIndex = 5
        Me.gbSeccion3.TabStop = False
        Me.gbSeccion3.Text = "Información del Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "(Solo en caso de Extranjero)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtClienteDireccionDist)
        Me.GroupBox3.Controls.Add(Me.txtClienteDireccionProv)
        Me.GroupBox3.Controls.Add(Me.txtClienteDireccionDpto)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtClienteDireccionUrb)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtClienteDireccionInt)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtClienteDireccionNro)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtClienteDireccion)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(571, 97)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Si es de nacionalidad Peruana"
        '
        'txtClienteDireccionDist
        '
        Me.txtClienteDireccionDist.Location = New System.Drawing.Point(364, 16)
        Me.txtClienteDireccionDist.Name = "txtClienteDireccionDist"
        Me.txtClienteDireccionDist.Size = New System.Drawing.Size(201, 20)
        Me.txtClienteDireccionDist.TabIndex = 6
        '
        'txtClienteDireccionProv
        '
        Me.txtClienteDireccionProv.Location = New System.Drawing.Point(364, 42)
        Me.txtClienteDireccionProv.Name = "txtClienteDireccionProv"
        Me.txtClienteDireccionProv.Size = New System.Drawing.Size(201, 20)
        Me.txtClienteDireccionProv.TabIndex = 7
        '
        'txtClienteDireccionDpto
        '
        Me.txtClienteDireccionDpto.Location = New System.Drawing.Point(364, 67)
        Me.txtClienteDireccionDpto.Name = "txtClienteDireccionDpto"
        Me.txtClienteDireccionDpto.Size = New System.Drawing.Size(201, 20)
        Me.txtClienteDireccionDpto.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(284, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Departamento"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(306, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Provincia"
        '
        'txtClienteDireccionUrb
        '
        Me.txtClienteDireccionUrb.Location = New System.Drawing.Point(64, 65)
        Me.txtClienteDireccionUrb.Name = "txtClienteDireccionUrb"
        Me.txtClienteDireccionUrb.Size = New System.Drawing.Size(214, 20)
        Me.txtClienteDireccionUrb.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Urb./Zona"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(318, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Distrito"
        '
        'txtClienteDireccionInt
        '
        Me.txtClienteDireccionInt.Location = New System.Drawing.Point(183, 39)
        Me.txtClienteDireccionInt.Name = "txtClienteDireccionInt"
        Me.txtClienteDireccionInt.Size = New System.Drawing.Size(56, 20)
        Me.txtClienteDireccionInt.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(126, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Dpto./Int."
        '
        'txtClienteDireccionNro
        '
        Me.txtClienteDireccionNro.Location = New System.Drawing.Point(64, 39)
        Me.txtClienteDireccionNro.Name = "txtClienteDireccionNro"
        Me.txtClienteDireccionNro.Size = New System.Drawing.Size(56, 20)
        Me.txtClienteDireccionNro.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "No."
        '
        'txtClienteDireccion
        '
        Me.txtClienteDireccion.Location = New System.Drawing.Point(64, 16)
        Me.txtClienteDireccion.Name = "txtClienteDireccion"
        Me.txtClienteDireccion.Size = New System.Drawing.Size(213, 20)
        Me.txtClienteDireccion.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Dirección"
        '
        'txtClienteNacionalidad
        '
        Me.txtClienteNacionalidad.Location = New System.Drawing.Point(69, 74)
        Me.txtClienteNacionalidad.Name = "txtClienteNacionalidad"
        Me.txtClienteNacionalidad.Size = New System.Drawing.Size(213, 20)
        Me.txtClienteNacionalidad.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nacionalidad"
        '
        'txtClientePais
        '
        Me.txtClientePais.Location = New System.Drawing.Point(369, 48)
        Me.txtClientePais.Name = "txtClientePais"
        Me.txtClientePais.Size = New System.Drawing.Size(201, 20)
        Me.txtClientePais.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(334, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "País"
        '
        'txtClienteNumDoc
        '
        Me.txtClienteNumDoc.Location = New System.Drawing.Point(69, 48)
        Me.txtClienteNumDoc.Name = "txtClienteNumDoc"
        Me.txtClienteNumDoc.Size = New System.Drawing.Size(99, 20)
        Me.txtClienteNumDoc.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Documento"
        '
        'txtClienteApellidos
        '
        Me.txtClienteApellidos.Location = New System.Drawing.Point(369, 22)
        Me.txtClienteApellidos.Name = "txtClienteApellidos"
        Me.txtClienteApellidos.Size = New System.Drawing.Size(201, 20)
        Me.txtClienteApellidos.TabIndex = 1
        '
        'txtClienteNombres
        '
        Me.txtClienteNombres.Location = New System.Drawing.Point(69, 22)
        Me.txtClienteNombres.Name = "txtClienteNombres"
        Me.txtClienteNombres.Size = New System.Drawing.Size(213, 20)
        Me.txtClienteNombres.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Apellido(s)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nombre(s)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Cliente"
        '
        'btnClienteBuscar
        '
        Me.btnClienteBuscar.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.btnClienteBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClienteBuscar.Location = New System.Drawing.Point(90, 12)
        Me.btnClienteBuscar.Name = "btnClienteBuscar"
        Me.btnClienteBuscar.Size = New System.Drawing.Size(39, 33)
        Me.btnClienteBuscar.TabIndex = 3
        Me.btnClienteBuscar.UseVisualStyleBackColor = True
        '
        'lblClienteId
        '
        Me.lblClienteId.AutoSize = True
        Me.lblClienteId.Location = New System.Drawing.Point(312, 22)
        Me.lblClienteId.Name = "lblClienteId"
        Me.lblClienteId.Size = New System.Drawing.Size(16, 13)
        Me.lblClienteId.TabIndex = 0
        Me.lblClienteId.Text = "Id"
        Me.lblClienteId.Visible = False
        '
        'btnClienteNuevo
        '
        Me.btnClienteNuevo.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgClientes
        Me.btnClienteNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClienteNuevo.Location = New System.Drawing.Point(538, 12)
        Me.btnClienteNuevo.Name = "btnClienteNuevo"
        Me.btnClienteNuevo.Size = New System.Drawing.Size(39, 33)
        Me.btnClienteNuevo.TabIndex = 4
        Me.btnClienteNuevo.UseVisualStyleBackColor = True
        '
        'gbCaja
        '
        Me.gbCaja.Controls.Add(Me.cboCaja)
        Me.gbCaja.Location = New System.Drawing.Point(533, 49)
        Me.gbCaja.Name = "gbCaja"
        Me.gbCaja.Size = New System.Drawing.Size(67, 42)
        Me.gbCaja.TabIndex = 76
        Me.gbCaja.TabStop = False
        Me.gbCaja.Text = "Caja"
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(6, 15)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(55, 21)
        Me.cboCaja.TabIndex = 0
        '
        'gbFechaRegistro
        '
        Me.gbFechaRegistro.Controls.Add(Me.ucFechaProceso)
        Me.gbFechaRegistro.Enabled = False
        Me.gbFechaRegistro.Location = New System.Drawing.Point(414, 49)
        Me.gbFechaRegistro.Name = "gbFechaRegistro"
        Me.gbFechaRegistro.Size = New System.Drawing.Size(113, 42)
        Me.gbFechaRegistro.TabIndex = 91
        Me.gbFechaRegistro.TabStop = False
        Me.gbFechaRegistro.Text = "Fecha Proceso"
        '
        'ucFechaProceso
        '
        Me.ucFechaProceso.Location = New System.Drawing.Point(6, 11)
        Me.ucFechaProceso.Name = "ucFechaProceso"
        Me.ucFechaProceso.Size = New System.Drawing.Size(96, 25)
        Me.ucFechaProceso.TabIndex = 93
        '
        'gbSeccion2
        '
        Me.gbSeccion2.Controls.Add(Me.Label21)
        Me.gbSeccion2.Controls.Add(Me.Label1)
        Me.gbSeccion2.Controls.Add(Me.btnClienteBuscar)
        Me.gbSeccion2.Controls.Add(Me.lblClienteId)
        Me.gbSeccion2.Controls.Add(Me.btnClienteNuevo)
        Me.gbSeccion2.Location = New System.Drawing.Point(16, 378)
        Me.gbSeccion2.Name = "gbSeccion2"
        Me.gbSeccion2.Size = New System.Drawing.Size(580, 50)
        Me.gbSeccion2.TabIndex = 92
        Me.gbSeccion2.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(411, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Agregar/editar Cliente(s)"
        '
        'frmCajaRegistroOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 665)
        Me.Controls.Add(Me.gbSeccion2)
        Me.Controls.Add(Me.gbFechaRegistro)
        Me.Controls.Add(Me.gbCaja)
        Me.Controls.Add(Me.gbSeccion3)
        Me.Controls.Add(Me.gbSeccion1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCajaRegistroOperador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Operación en Caja"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.gbSeccion1.ResumeLayout(False)
        Me.gbSeccion1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbSeccion3.ResumeLayout(False)
        Me.gbSeccion3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbCaja.ResumeLayout(False)
        Me.gbFechaRegistro.ResumeLayout(False)
        Me.gbSeccion2.ResumeLayout(False)
        Me.gbSeccion2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gbSeccion1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbSeccion3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMontoMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtClienteApellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTipoOperacion1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipoOperacion3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipoOperacion2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtClienteNumDoc As System.Windows.Forms.TextBox
    Friend WithEvents rbTipoOperacion5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipoOperacion4 As System.Windows.Forms.RadioButton
    Friend WithEvents txtClientePais As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtClienteNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtClienteDireccionUrb As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtClienteDireccionInt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtClienteDireccionNro As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtClienteDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtClienteDireccionDist As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteDireccionProv As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteDireccionDpto As System.Windows.Forms.TextBox
    Friend WithEvents btnClienteBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblClienteId As System.Windows.Forms.Label
    Friend WithEvents btnClienteNuevo As System.Windows.Forms.Button
    Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents gbFechaRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents rbTipoOperacion6 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboFichaVenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtFichaCantidad As System.Windows.Forms.TextBox
    Friend WithEvents gbSeccion2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblOperacionCodigo As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ucFechaProceso As bddc.Win.ucFecha
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtJackpotMaquina As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnMastercad As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnVisa As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbModalidadOperacion1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbModalidadOperacion3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbModalidadOperacion2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtTarjetaNum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
