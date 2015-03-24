<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeg_Accesos
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
        Me.gbBuscar = New System.Windows.Forms.GroupBox
        Me.txtUsuarioId = New System.Windows.Forms.TextBox
        Me.cboUsuarioBuscar = New System.Windows.Forms.ComboBox
        Me.clbOpciones = New System.Windows.Forms.CheckedListBox
        Me.gbOpciones = New System.Windows.Forms.GroupBox
        Me.chkOpciones = New System.Windows.Forms.CheckBox
        Me.gbPermisos = New System.Windows.Forms.GroupBox
        Me.chkPermisos = New System.Windows.Forms.CheckBox
        Me.clbPermisos = New System.Windows.Forms.CheckedListBox
        Me.gbHorario = New System.Windows.Forms.GroupBox
        Me.chkHorario = New System.Windows.Forms.CheckBox
        Me.clbHorario = New System.Windows.Forms.CheckedListBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tsslblMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.gbModulos = New System.Windows.Forms.GroupBox
        Me.cboModulos = New System.Windows.Forms.ComboBox
        Me.gbRoles = New System.Windows.Forms.GroupBox
        Me.cboRoles = New System.Windows.Forms.ComboBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboUbicaciones = New System.Windows.Forms.ComboBox
        Me.gbBuscar.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.gbPermisos.SuspendLayout()
        Me.gbHorario.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbModulos.SuspendLayout()
        Me.gbRoles.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.txtUsuarioId)
        Me.gbBuscar.Controls.Add(Me.cboUsuarioBuscar)
        Me.gbBuscar.Location = New System.Drawing.Point(12, 97)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(446, 50)
        Me.gbBuscar.TabIndex = 1
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Usuario"
        '
        'txtUsuarioId
        '
        Me.txtUsuarioId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioId.Location = New System.Drawing.Point(398, 20)
        Me.txtUsuarioId.Name = "txtUsuarioId"
        Me.txtUsuarioId.ReadOnly = True
        Me.txtUsuarioId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtUsuarioId.Size = New System.Drawing.Size(36, 20)
        Me.txtUsuarioId.TabIndex = 0
        Me.txtUsuarioId.TabStop = False
        Me.txtUsuarioId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboUsuarioBuscar
        '
        Me.cboUsuarioBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboUsuarioBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUsuarioBuscar.FormattingEnabled = True
        Me.cboUsuarioBuscar.Location = New System.Drawing.Point(7, 20)
        Me.cboUsuarioBuscar.Name = "cboUsuarioBuscar"
        Me.cboUsuarioBuscar.Size = New System.Drawing.Size(242, 21)
        Me.cboUsuarioBuscar.TabIndex = 1
        '
        'clbOpciones
        '
        Me.clbOpciones.FormattingEnabled = True
        Me.clbOpciones.Location = New System.Drawing.Point(7, 19)
        Me.clbOpciones.Name = "clbOpciones"
        Me.clbOpciones.Size = New System.Drawing.Size(242, 304)
        Me.clbOpciones.TabIndex = 0
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.chkOpciones)
        Me.gbOpciones.Controls.Add(Me.clbOpciones)
        Me.gbOpciones.Location = New System.Drawing.Point(12, 209)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(261, 347)
        Me.gbOpciones.TabIndex = 3
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones del Sistema"
        '
        'chkOpciones
        '
        Me.chkOpciones.AutoSize = True
        Me.chkOpciones.Location = New System.Drawing.Point(7, 324)
        Me.chkOpciones.Name = "chkOpciones"
        Me.chkOpciones.Size = New System.Drawing.Size(56, 17)
        Me.chkOpciones.TabIndex = 1
        Me.chkOpciones.Text = "Todos"
        Me.chkOpciones.UseVisualStyleBackColor = True
        '
        'gbPermisos
        '
        Me.gbPermisos.Controls.Add(Me.chkPermisos)
        Me.gbPermisos.Controls.Add(Me.clbPermisos)
        Me.gbPermisos.Location = New System.Drawing.Point(279, 385)
        Me.gbPermisos.Name = "gbPermisos"
        Me.gbPermisos.Size = New System.Drawing.Size(179, 114)
        Me.gbPermisos.TabIndex = 6
        Me.gbPermisos.TabStop = False
        Me.gbPermisos.Text = "Permisos"
        '
        'chkPermisos
        '
        Me.chkPermisos.AutoSize = True
        Me.chkPermisos.Location = New System.Drawing.Point(7, 90)
        Me.chkPermisos.Name = "chkPermisos"
        Me.chkPermisos.Size = New System.Drawing.Size(56, 17)
        Me.chkPermisos.TabIndex = 1
        Me.chkPermisos.Text = "Todos"
        Me.chkPermisos.UseVisualStyleBackColor = True
        '
        'clbPermisos
        '
        Me.clbPermisos.FormattingEnabled = True
        Me.clbPermisos.Location = New System.Drawing.Point(7, 20)
        Me.clbPermisos.MultiColumn = True
        Me.clbPermisos.Name = "clbPermisos"
        Me.clbPermisos.Size = New System.Drawing.Size(160, 64)
        Me.clbPermisos.TabIndex = 0
        '
        'gbHorario
        '
        Me.gbHorario.Controls.Add(Me.chkHorario)
        Me.gbHorario.Controls.Add(Me.clbHorario)
        Me.gbHorario.Location = New System.Drawing.Point(279, 209)
        Me.gbHorario.Name = "gbHorario"
        Me.gbHorario.Size = New System.Drawing.Size(179, 170)
        Me.gbHorario.TabIndex = 5
        Me.gbHorario.TabStop = False
        Me.gbHorario.Text = "Horario"
        '
        'chkHorario
        '
        Me.chkHorario.AutoSize = True
        Me.chkHorario.Location = New System.Drawing.Point(6, 149)
        Me.chkHorario.Name = "chkHorario"
        Me.chkHorario.Size = New System.Drawing.Size(56, 17)
        Me.chkHorario.TabIndex = 1
        Me.chkHorario.Text = "Todos"
        Me.chkHorario.UseVisualStyleBackColor = True
        '
        'clbHorario
        '
        Me.clbHorario.ColumnWidth = 50
        Me.clbHorario.FormattingEnabled = True
        Me.clbHorario.Items.AddRange(New Object() {"00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"})
        Me.clbHorario.Location = New System.Drawing.Point(6, 19)
        Me.clbHorario.MultiColumn = True
        Me.clbHorario.Name = "clbHorario"
        Me.clbHorario.Size = New System.Drawing.Size(161, 124)
        Me.clbHorario.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblMensaje})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 562)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(465, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslblMensaje
        '
        Me.tsslblMensaje.Name = "tsslblMensaje"
        Me.tsslblMensaje.Size = New System.Drawing.Size(51, 17)
        Me.tsslblMensaje.Text = "Mensaje"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configuracion de Accesos de Usuarios"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgAccesos
        Me.PictureBox2.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        '
        'gbModulos
        '
        Me.gbModulos.Controls.Add(Me.cboModulos)
        Me.gbModulos.Location = New System.Drawing.Point(12, 153)
        Me.gbModulos.Name = "gbModulos"
        Me.gbModulos.Size = New System.Drawing.Size(261, 50)
        Me.gbModulos.TabIndex = 2
        Me.gbModulos.TabStop = False
        Me.gbModulos.Text = "Módulos del Sistema"
        '
        'cboModulos
        '
        Me.cboModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModulos.FormattingEnabled = True
        Me.cboModulos.Location = New System.Drawing.Point(6, 20)
        Me.cboModulos.Name = "cboModulos"
        Me.cboModulos.Size = New System.Drawing.Size(243, 21)
        Me.cboModulos.TabIndex = 0
        '
        'gbRoles
        '
        Me.gbRoles.Controls.Add(Me.cboRoles)
        Me.gbRoles.Location = New System.Drawing.Point(279, 153)
        Me.gbRoles.Name = "gbRoles"
        Me.gbRoles.Size = New System.Drawing.Size(179, 50)
        Me.gbRoles.TabIndex = 4
        Me.gbRoles.TabStop = False
        Me.gbRoles.Text = "Rol"
        '
        'cboRoles
        '
        Me.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoles.FormattingEnabled = True
        Me.cboRoles.Location = New System.Drawing.Point(7, 19)
        Me.cboRoles.Name = "cboRoles"
        Me.cboRoles.Size = New System.Drawing.Size(160, 21)
        Me.cboRoles.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbNuevo, Me.tsbAgregar, Me.tsbGuardar, Me.tsbImprimir, Me.tsbEliminar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(465, 31)
        Me.ToolStrip1.TabIndex = 71
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Enabled = False
        Me.tsbBuscar.Image = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(70, 28)
        Me.tsbBuscar.Text = "Buscar"
        Me.tsbBuscar.Visible = False
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Enabled = False
        Me.tsbNuevo.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(70, 28)
        Me.tsbNuevo.Text = "Nuevo"
        Me.tsbNuevo.Visible = False
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Enabled = False
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
        'tsbImprimir
        '
        Me.tsbImprimir.Enabled = False
        Me.tsbImprimir.Image = Global.bddc.Win.My.Resources.Resources.imgImpresion
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(81, 28)
        Me.tsbImprimir.Text = "Imprimir"
        Me.tsbImprimir.Visible = False
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = Global.bddc.Win.My.Resources.Resources.btngridBorrar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(78, 28)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(57, 28)
        Me.tsbSalir.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboUbicaciones)
        Me.GroupBox1.Location = New System.Drawing.Point(279, 505)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 50)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubicación"
        Me.GroupBox1.Visible = False
        '
        'cboUbicaciones
        '
        Me.cboUbicaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUbicaciones.FormattingEnabled = True
        Me.cboUbicaciones.Location = New System.Drawing.Point(7, 19)
        Me.cboUbicaciones.Name = "cboUbicaciones"
        Me.cboUbicaciones.Size = New System.Drawing.Size(160, 21)
        Me.cboUbicaciones.TabIndex = 0
        Me.cboUbicaciones.Visible = False
        '
        'frmSeg_Accesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 584)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbRoles)
        Me.Controls.Add(Me.gbModulos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbHorario)
        Me.Controls.Add(Me.gbPermisos)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSeg_Accesos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion de Accesos de Usuarios"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones.PerformLayout()
        Me.gbPermisos.ResumeLayout(False)
        Me.gbPermisos.PerformLayout()
        Me.gbHorario.ResumeLayout(False)
        Me.gbHorario.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbModulos.ResumeLayout(False)
        Me.gbRoles.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents cboUsuarioBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents clbOpciones As System.Windows.Forms.CheckedListBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents gbPermisos As System.Windows.Forms.GroupBox
    Friend WithEvents clbPermisos As System.Windows.Forms.CheckedListBox
    Friend WithEvents gbHorario As System.Windows.Forms.GroupBox
    Friend WithEvents clbHorario As System.Windows.Forms.CheckedListBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslblMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents gbModulos As System.Windows.Forms.GroupBox
    Friend WithEvents gbRoles As System.Windows.Forms.GroupBox
    Friend WithEvents cboModulos As System.Windows.Forms.ComboBox
    Friend WithEvents chkOpciones As System.Windows.Forms.CheckBox
    Friend WithEvents chkPermisos As System.Windows.Forms.CheckBox
    Friend WithEvents chkHorario As System.Windows.Forms.CheckBox
    Friend WithEvents cboRoles As System.Windows.Forms.ComboBox
    Friend WithEvents txtUsuarioId As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboUbicaciones As System.Windows.Forms.ComboBox
End Class
