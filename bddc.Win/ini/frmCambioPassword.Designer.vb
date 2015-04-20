<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioPassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNewPassword2 = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboUbicaciones = New System.Windows.Forms.ComboBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblmensaje = New System.Windows.Forms.Label()
        Me.txtUsuarioId = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNewPassword2)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.txtOldPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 134)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtNewPassword2
        '
        Me.txtNewPassword2.Location = New System.Drawing.Point(195, 95)
        Me.txtNewPassword2.MaxLength = 10
        Me.txtNewPassword2.Name = "txtNewPassword2"
        Me.txtNewPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword2.Size = New System.Drawing.Size(154, 20)
        Me.txtNewPassword2.TabIndex = 5
        Me.txtNewPassword2.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(195, 57)
        Me.txtNewPassword.MaxLength = 10
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(154, 20)
        Me.txtNewPassword.TabIndex = 4
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(195, 21)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(154, 20)
        Me.txtOldPassword.TabIndex = 3
        Me.txtOldPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Confirme Nueva Contraseña :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nueva Contraseña :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña Actual :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonSalir, Me.ToolStripButtonGuardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(389, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonSalir
        '
        Me.ToolStripButtonSalir.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.ToolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSalir.Name = "ToolStripButtonSalir"
        Me.ToolStripButtonSalir.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButtonSalir.Text = "Salir"
        '
        'ToolStripButtonGuardar
        '
        Me.ToolStripButtonGuardar.Image = Global.bddc.Win.My.Resources.Resources.btngridGuardar
        Me.ToolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonGuardar.Name = "ToolStripButtonGuardar"
        Me.ToolStripButtonGuardar.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButtonGuardar.Text = "Guardar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboUbicaciones)
        Me.GroupBox2.Controls.Add(Me.txtUsuario)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 77)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'cboUbicaciones
        '
        Me.cboUbicaciones.FormattingEnabled = True
        Me.cboUbicaciones.Location = New System.Drawing.Point(80, 45)
        Me.cboUbicaciones.Name = "cboUbicaciones"
        Me.cboUbicaciones.Size = New System.Drawing.Size(154, 21)
        Me.cboUbicaciones.TabIndex = 8
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(80, 14)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(154, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Unidad :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Usuario :"
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.ForeColor = System.Drawing.Color.Maroon
        Me.lblmensaje.Location = New System.Drawing.Point(10, 249)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(0, 13)
        Me.lblmensaje.TabIndex = 4
        '
        'txtUsuarioId
        '
        Me.txtUsuarioId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioId.Location = New System.Drawing.Point(330, 51)
        Me.txtUsuarioId.Name = "txtUsuarioId"
        Me.txtUsuarioId.ReadOnly = True
        Me.txtUsuarioId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtUsuarioId.Size = New System.Drawing.Size(36, 20)
        Me.txtUsuarioId.TabIndex = 5
        Me.txtUsuarioId.TabStop = False
        Me.txtUsuarioId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmCambioPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 268)
        Me.Controls.Add(Me.txtUsuarioId)
        Me.Controls.Add(Me.lblmensaje)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCambioPassword"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboUbicaciones As System.Windows.Forms.ComboBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButtonSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioId As System.Windows.Forms.TextBox
End Class
