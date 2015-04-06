<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.objSeguridad = New bddc.Win.thlaadfs.wsSeguridad()
        Me.ssLogin = New System.Windows.Forms.StatusStrip()
        Me.tsslblIdioma = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboUbicaciones = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCambioPassword = New System.Windows.Forms.LinkLabel()
        Me.ssLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(115, 22)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(205, 25)
        Me.txtUsuario.TabIndex = 1
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(115, 57)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClave.MaxLength = 10
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(205, 25)
        Me.txtClave.TabIndex = 2
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.SystemColors.Control
        Me.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Image = Global.bddc.Win.My.Resources.Resources.btnOk
        Me.btnIngresar.Location = New System.Drawing.Point(207, 120)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(51, 52)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'objSeguridad
        '
        Me.objSeguridad.Credentials = Nothing
        Me.objSeguridad.Url = "http://10.0.0.157/itpe.WebService/wsSeguridad.asmx"
        Me.objSeguridad.UseDefaultCredentials = False
        '
        'ssLogin
        '
        Me.ssLogin.AutoSize = False
        Me.ssLogin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblIdioma, Me.tsslblVersion})
        Me.ssLogin.Location = New System.Drawing.Point(0, 196)
        Me.ssLogin.Name = "ssLogin"
        Me.ssLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ssLogin.Size = New System.Drawing.Size(359, 21)
        Me.ssLogin.SizingGrip = False
        Me.ssLogin.Stretch = False
        Me.ssLogin.TabIndex = 0
        '
        'tsslblIdioma
        '
        Me.tsslblIdioma.Name = "tsslblIdioma"
        Me.tsslblIdioma.Size = New System.Drawing.Size(44, 16)
        Me.tsslblIdioma.Text = "Idioma"
        '
        'tsslblVersion
        '
        Me.tsslblVersion.Name = "tsslblVersion"
        Me.tsslblVersion.Size = New System.Drawing.Size(46, 16)
        Me.tsslblVersion.Text = "Version"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnSalir.Location = New System.Drawing.Point(266, 120)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 52)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'cboUbicaciones
        '
        Me.cboUbicaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUbicaciones.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUbicaciones.FormattingEnabled = True
        Me.cboUbicaciones.Location = New System.Drawing.Point(115, 89)
        Me.cboUbicaciones.Name = "cboUbicaciones"
        Me.cboUbicaciones.Size = New System.Drawing.Size(205, 24)
        Me.cboUbicaciones.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unidad"
        '
        'lblCambioPassword
        '
        Me.lblCambioPassword.AutoSize = True
        Me.lblCambioPassword.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambioPassword.Location = New System.Drawing.Point(214, 177)
        Me.lblCambioPassword.Name = "lblCambioPassword"
        Me.lblCambioPassword.Size = New System.Drawing.Size(105, 13)
        Me.lblCambioPassword.TabIndex = 7
        Me.lblCambioPassword.TabStop = True
        Me.lblCambioPassword.Text = "Cambiar Contraseña"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(359, 217)
        Me.Controls.Add(Me.lblCambioPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboUbicaciones)
        Me.Controls.Add(Me.ssLogin)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso al Sistema"
        Me.ssLogin.ResumeLayout(False)
        Me.ssLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents objSeguridad As bddc.Win.thlaadfs.wsSeguridad
    Friend WithEvents ssLogin As System.Windows.Forms.StatusStrip
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tsslblVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslblIdioma As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cboUbicaciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCambioPassword As System.Windows.Forms.LinkLabel
    'Friend WithEvents TestWorker As System.ComponentModel.BackgroundWorker

End Class
