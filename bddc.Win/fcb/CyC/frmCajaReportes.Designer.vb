<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaReportes
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnReporteVentaFichas = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReportePagosManuales = New System.Windows.Forms.Button()
        Me.btnReporteRetiroEfectivo = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.gbFechaRegistro = New System.Windows.Forms.GroupBox()
        Me.ucFechaProcesoFin = New bddc.Win.ucFecha()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucFechaProcesoIni = New bddc.Win.ucFecha()
        Me.gbCaja = New System.Windows.Forms.GroupBox()
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarUsuario = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.chkClientes = New System.Windows.Forms.CheckBox()
        Me.btn_temp = New System.Windows.Forms.Button()
        Me.btn_temp2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbFechaRegistro.SuspendLayout()
        Me.gbCaja.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Reportes de Operaciones"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgCajayConteo
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 74
        Me.PictureBox2.TabStop = False
        '
        'btnReporteVentaFichas
        '
        Me.btnReporteVentaFichas.Location = New System.Drawing.Point(15, 54)
        Me.btnReporteVentaFichas.Name = "btnReporteVentaFichas"
        Me.btnReporteVentaFichas.Size = New System.Drawing.Size(271, 32)
        Me.btnReporteVentaFichas.TabIndex = 1
        Me.btnReporteVentaFichas.Text = "Registro de Ventas de Fichas"
        Me.btnReporteVentaFichas.UseVisualStyleBackColor = True
        Me.btnReporteVentaFichas.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_temp2)
        Me.GroupBox1.Controls.Add(Me.btn_temp)
        Me.GroupBox1.Controls.Add(Me.btnReportePagosManuales)
        Me.GroupBox1.Controls.Add(Me.btnReporteRetiroEfectivo)
        Me.GroupBox1.Controls.Add(Me.btnReporteVentaFichas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 134)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes"
        '
        'btnReportePagosManuales
        '
        Me.btnReportePagosManuales.Location = New System.Drawing.Point(15, 92)
        Me.btnReportePagosManuales.Name = "btnReportePagosManuales"
        Me.btnReportePagosManuales.Size = New System.Drawing.Size(271, 29)
        Me.btnReportePagosManuales.TabIndex = 2
        Me.btnReportePagosManuales.Text = "Registro de Pagos Manuales (Jackpots)"
        Me.btnReportePagosManuales.UseVisualStyleBackColor = True
        '
        'btnReporteRetiroEfectivo
        '
        Me.btnReporteRetiroEfectivo.Location = New System.Drawing.Point(15, 19)
        Me.btnReporteRetiroEfectivo.Name = "btnReporteRetiroEfectivo"
        Me.btnReporteRetiroEfectivo.Size = New System.Drawing.Size(271, 29)
        Me.btnReporteRetiroEfectivo.TabIndex = 0
        Me.btnReporteRetiroEfectivo.Text = "Retiro de Efectivo con Tarjetas Crédito/Débito"
        Me.btnReporteRetiroEfectivo.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Location = New System.Drawing.Point(342, 354)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(47, 39)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'gbFechaRegistro
        '
        Me.gbFechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gbFechaRegistro.Controls.Add(Me.ucFechaProcesoFin)
        Me.gbFechaRegistro.Controls.Add(Me.Label3)
        Me.gbFechaRegistro.Controls.Add(Me.Label1)
        Me.gbFechaRegistro.Controls.Add(Me.ucFechaProcesoIni)
        Me.gbFechaRegistro.Location = New System.Drawing.Point(12, 85)
        Me.gbFechaRegistro.Name = "gbFechaRegistro"
        Me.gbFechaRegistro.Size = New System.Drawing.Size(236, 42)
        Me.gbFechaRegistro.TabIndex = 2
        Me.gbFechaRegistro.TabStop = False
        Me.gbFechaRegistro.Text = "Fecha Registro"
        '
        'ucFechaProcesoFin
        '
        Me.ucFechaProcesoFin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucFechaProcesoFin.Location = New System.Drawing.Point(135, 12)
        Me.ucFechaProcesoFin.Name = "ucFechaProcesoFin"
        Me.ucFechaProcesoFin.Size = New System.Drawing.Size(96, 25)
        Me.ucFechaProcesoFin.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "a"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "De"
        '
        'ucFechaProcesoIni
        '
        Me.ucFechaProcesoIni.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucFechaProcesoIni.Location = New System.Drawing.Point(31, 12)
        Me.ucFechaProcesoIni.Name = "ucFechaProcesoIni"
        Me.ucFechaProcesoIni.Size = New System.Drawing.Size(96, 25)
        Me.ucFechaProcesoIni.TabIndex = 78
        '
        'gbCaja
        '
        Me.gbCaja.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gbCaja.Controls.Add(Me.cboCaja)
        Me.gbCaja.Location = New System.Drawing.Point(254, 85)
        Me.gbCaja.Name = "gbCaja"
        Me.gbCaja.Size = New System.Drawing.Size(61, 42)
        Me.gbCaja.TabIndex = 77
        Me.gbCaja.TabStop = False
        Me.gbCaja.Text = "Caja"
        '
        'cboCaja
        '
        Me.cboCaja.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(6, 15)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(49, 21)
        Me.cboCaja.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox2.Controls.Add(Me.btnBuscarUsuario)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.chkClientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 72)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clientes"
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgClientes
        Me.btnBuscarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(196, 33)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(34, 33)
        Me.btnBuscarUsuario.TabIndex = 5
        Me.btnBuscarUsuario.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(11, 45)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(180, 20)
        Me.txtCliente.TabIndex = 4
        '
        'chkClientes
        '
        Me.chkClientes.AutoSize = True
        Me.chkClientes.Checked = True
        Me.chkClientes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClientes.Location = New System.Drawing.Point(12, 21)
        Me.chkClientes.Name = "chkClientes"
        Me.chkClientes.Size = New System.Drawing.Size(56, 17)
        Me.chkClientes.TabIndex = 3
        Me.chkClientes.Text = "Todos"
        Me.chkClientes.UseVisualStyleBackColor = True
        '
        'btn_temp
        '
        Me.btn_temp.Location = New System.Drawing.Point(292, 46)
        Me.btn_temp.Name = "btn_temp"
        Me.btn_temp.Size = New System.Drawing.Size(79, 24)
        Me.btn_temp.TabIndex = 3
        Me.btn_temp.Text = "Luxor Lima"
        Me.btn_temp.UseVisualStyleBackColor = True
        '
        'btn_temp2
        '
        Me.btn_temp2.Location = New System.Drawing.Point(292, 71)
        Me.btn_temp2.Name = "btn_temp2"
        Me.btn_temp2.Size = New System.Drawing.Size(79, 23)
        Me.btn_temp2.TabIndex = 4
        Me.btn_temp2.Text = "Luxor Tacna"
        Me.btn_temp2.UseVisualStyleBackColor = True
        '
        'frmCajaReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 399)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbCaja)
        Me.Controls.Add(Me.gbFechaRegistro)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCajaReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes de Operaciones"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbFechaRegistro.ResumeLayout(False)
        Me.gbFechaRegistro.PerformLayout()
        Me.gbCaja.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnReporteVentaFichas As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReporteRetiroEfectivo As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents gbFechaRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents ucFechaProcesoIni As bddc.Win.ucFecha
    Friend WithEvents btnReportePagosManuales As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ucFechaProcesoFin As bddc.Win.ucFecha
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkClientes As System.Windows.Forms.CheckBox
    Friend WithEvents btnBuscarUsuario As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents btn_temp As System.Windows.Forms.Button
    Friend WithEvents btn_temp2 As System.Windows.Forms.Button
End Class
