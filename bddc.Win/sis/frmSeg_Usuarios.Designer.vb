<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeg_Usuarios
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tsslblMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbDatosPrincipales = New System.Windows.Forms.GroupBox
        Me.btnGenerarClave = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboTipoAutenticacion = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUsuarioId = New System.Windows.Forms.TextBox
        Me.gbDatosAdicionales = New System.Windows.Forms.GroupBox
        Me.txtInfoAdic = New System.Windows.Forms.TextBox
        Me.gbAccesos = New System.Windows.Forms.GroupBox
        Me.btnAccesos = New System.Windows.Forms.Button
        Me.dgvResultados = New System.Windows.Forms.DataGridView
        Me.Módulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsuarioId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Permisos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ubicación = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Opciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModuloId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RolId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModuloSiglas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.gbBuscar = New System.Windows.Forms.GroupBox
        Me.cboUsuarioBuscar = New System.Windows.Forms.ComboBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1.SuspendLayout()
        Me.gbDatosPrincipales.SuspendLayout()
        Me.gbDatosAdicionales.SuspendLayout()
        Me.gbAccesos.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblMensaje})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 475)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(678, 22)
        Me.StatusStrip1.TabIndex = 0
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
        Me.Label2.Text = "Administración de Usuarios del Sistema"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbDatosPrincipales
        '
        Me.gbDatosPrincipales.Controls.Add(Me.btnGenerarClave)
        Me.gbDatosPrincipales.Controls.Add(Me.txtPassword)
        Me.gbDatosPrincipales.Controls.Add(Me.Label5)
        Me.gbDatosPrincipales.Controls.Add(Me.cboTipoAutenticacion)
        Me.gbDatosPrincipales.Controls.Add(Me.Label4)
        Me.gbDatosPrincipales.Controls.Add(Me.txtNombre)
        Me.gbDatosPrincipales.Controls.Add(Me.Label1)
        Me.gbDatosPrincipales.Location = New System.Drawing.Point(12, 154)
        Me.gbDatosPrincipales.Name = "gbDatosPrincipales"
        Me.gbDatosPrincipales.Size = New System.Drawing.Size(349, 70)
        Me.gbDatosPrincipales.TabIndex = 2
        Me.gbDatosPrincipales.TabStop = False
        Me.gbDatosPrincipales.Text = "Datos Principales"
        '
        'btnGenerarClave
        '
        Me.btnGenerarClave.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgTrasladoRating
        Me.btnGenerarClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenerarClave.Location = New System.Drawing.Point(296, 38)
        Me.btnGenerarClave.Name = "btnGenerarClave"
        Me.btnGenerarClave.Size = New System.Drawing.Size(36, 23)
        Me.btnGenerarClave.TabIndex = 4
        Me.btnGenerarClave.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(224, 40)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(66, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Password"
        '
        'cboTipoAutenticacion
        '
        Me.cboTipoAutenticacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoAutenticacion.FormattingEnabled = True
        Me.cboTipoAutenticacion.Location = New System.Drawing.Point(85, 40)
        Me.cboTipoAutenticacion.Name = "cboTipoAutenticacion"
        Me.cboTipoAutenticacion.Size = New System.Drawing.Size(74, 21)
        Me.cboTipoAutenticacion.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Autenticación"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(85, 16)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(205, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txtUsuarioId
        '
        Me.txtUsuarioId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioId.Location = New System.Drawing.Point(296, 20)
        Me.txtUsuarioId.Name = "txtUsuarioId"
        Me.txtUsuarioId.ReadOnly = True
        Me.txtUsuarioId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtUsuarioId.Size = New System.Drawing.Size(36, 20)
        Me.txtUsuarioId.TabIndex = 0
        Me.txtUsuarioId.TabStop = False
        Me.txtUsuarioId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.txtInfoAdic)
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(367, 98)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(286, 126)
        Me.gbDatosAdicionales.TabIndex = 3
        Me.gbDatosAdicionales.TabStop = False
        Me.gbDatosAdicionales.Text = "Información Adicional"
        '
        'txtInfoAdic
        '
        Me.txtInfoAdic.Location = New System.Drawing.Point(10, 19)
        Me.txtInfoAdic.MaxLength = 200
        Me.txtInfoAdic.Multiline = True
        Me.txtInfoAdic.Name = "txtInfoAdic"
        Me.txtInfoAdic.Size = New System.Drawing.Size(270, 97)
        Me.txtInfoAdic.TabIndex = 0
        '
        'gbAccesos
        '
        Me.gbAccesos.Controls.Add(Me.btnAccesos)
        Me.gbAccesos.Controls.Add(Me.dgvResultados)
        Me.gbAccesos.Location = New System.Drawing.Point(12, 230)
        Me.gbAccesos.Name = "gbAccesos"
        Me.gbAccesos.Size = New System.Drawing.Size(641, 228)
        Me.gbAccesos.TabIndex = 4
        Me.gbAccesos.TabStop = False
        Me.gbAccesos.Text = "Accesos del Usuario"
        '
        'btnAccesos
        '
        Me.btnAccesos.Image = Global.bddc.Win.My.Resources.Resources.imgAccesos
        Me.btnAccesos.Location = New System.Drawing.Point(575, 167)
        Me.btnAccesos.Name = "btnAccesos"
        Me.btnAccesos.Size = New System.Drawing.Size(59, 55)
        Me.btnAccesos.TabIndex = 1
        Me.btnAccesos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAccesos.UseVisualStyleBackColor = True
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToResizeRows = False
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Módulo, Me.Nombre, Me.UsuarioId, Me.Rol, Me.Permisos, Me.Horario, Me.Ubicación, Me.Opciones, Me.ModuloId, Me.RolId, Me.EstadoId, Me.ModuloSiglas})
        Me.dgvResultados.Location = New System.Drawing.Point(7, 20)
        Me.dgvResultados.MultiSelect = False
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvResultados.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultados.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvResultados.ShowCellErrors = False
        Me.dgvResultados.ShowCellToolTips = False
        Me.dgvResultados.ShowEditingIcon = False
        Me.dgvResultados.ShowRowErrors = False
        Me.dgvResultados.Size = New System.Drawing.Size(628, 147)
        Me.dgvResultados.TabIndex = 0
        '
        'Módulo
        '
        Me.Módulo.DataPropertyName = "Modulo"
        Me.Módulo.HeaderText = "Módulo"
        Me.Módulo.Name = "Módulo"
        Me.Módulo.ReadOnly = True
        Me.Módulo.Width = 160
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Visible = False
        '
        'UsuarioId
        '
        Me.UsuarioId.DataPropertyName = "UsuarioId"
        Me.UsuarioId.HeaderText = "UsuarioId"
        Me.UsuarioId.Name = "UsuarioId"
        Me.UsuarioId.ReadOnly = True
        Me.UsuarioId.Visible = False
        '
        'Rol
        '
        Me.Rol.DataPropertyName = "Rol"
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.ReadOnly = True
        Me.Rol.Width = 80
        '
        'Permisos
        '
        Me.Permisos.DataPropertyName = "Permisos"
        Me.Permisos.HeaderText = "Permisos"
        Me.Permisos.Name = "Permisos"
        Me.Permisos.ReadOnly = True
        Me.Permisos.Width = 60
        '
        'Horario
        '
        Me.Horario.DataPropertyName = "Horario"
        Me.Horario.HeaderText = "Horario"
        Me.Horario.Name = "Horario"
        Me.Horario.ReadOnly = True
        Me.Horario.Width = 180
        '
        'Ubicación
        '
        Me.Ubicación.DataPropertyName = "Ubicacion"
        Me.Ubicación.HeaderText = "Ubicación"
        Me.Ubicación.Name = "Ubicación"
        Me.Ubicación.ReadOnly = True
        Me.Ubicación.Visible = False
        Me.Ubicación.Width = 60
        '
        'Opciones
        '
        Me.Opciones.DataPropertyName = "Opciones"
        Me.Opciones.HeaderText = "Opciones"
        Me.Opciones.Name = "Opciones"
        Me.Opciones.ReadOnly = True
        Me.Opciones.Width = 80
        '
        'ModuloId
        '
        Me.ModuloId.DataPropertyName = "ModuloId"
        Me.ModuloId.HeaderText = "ModuloId"
        Me.ModuloId.Name = "ModuloId"
        Me.ModuloId.ReadOnly = True
        Me.ModuloId.Visible = False
        '
        'RolId
        '
        Me.RolId.DataPropertyName = "RolId"
        Me.RolId.HeaderText = "RolId"
        Me.RolId.Name = "RolId"
        Me.RolId.ReadOnly = True
        Me.RolId.Visible = False
        '
        'EstadoId
        '
        Me.EstadoId.DataPropertyName = "EstadoId"
        Me.EstadoId.HeaderText = "EstadoId"
        Me.EstadoId.Name = "EstadoId"
        Me.EstadoId.ReadOnly = True
        Me.EstadoId.Visible = False
        '
        'ModuloSiglas
        '
        Me.ModuloSiglas.DataPropertyName = "ModuloSiglas"
        Me.ModuloSiglas.HeaderText = "ModuloSiglas"
        Me.ModuloSiglas.Name = "ModuloSiglas"
        Me.ModuloSiglas.ReadOnly = True
        Me.ModuloSiglas.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgUsuarios
        Me.PictureBox2.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.txtUsuarioId)
        Me.gbBuscar.Controls.Add(Me.cboUsuarioBuscar)
        Me.gbBuscar.Location = New System.Drawing.Point(12, 98)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(349, 50)
        Me.gbBuscar.TabIndex = 1
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Usuario"
        '
        'cboUsuarioBuscar
        '
        Me.cboUsuarioBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboUsuarioBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUsuarioBuscar.FormattingEnabled = True
        Me.cboUsuarioBuscar.Location = New System.Drawing.Point(7, 20)
        Me.cboUsuarioBuscar.Name = "cboUsuarioBuscar"
        Me.cboUsuarioBuscar.Size = New System.Drawing.Size(283, 21)
        Me.cboUsuarioBuscar.Sorted = True
        Me.cboUsuarioBuscar.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbNuevo, Me.tsbAgregar, Me.tsbGuardar, Me.tsbImprimir, Me.tsbEliminar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(678, 31)
        Me.ToolStrip1.TabIndex = 73
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
        Me.tsbNuevo.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(70, 28)
        Me.tsbNuevo.Text = "Nuevo"
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
        'frmSeg_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 497)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.gbAccesos)
        Me.Controls.Add(Me.gbDatosAdicionales)
        Me.Controls.Add(Me.gbDatosPrincipales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSeg_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Administración de Usuarios del Sistema"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbDatosPrincipales.ResumeLayout(False)
        Me.gbDatosPrincipales.PerformLayout()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        Me.gbAccesos.ResumeLayout(False)
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslblMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents gbDatosPrincipales As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarClave As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboTipoAutenticacion As System.Windows.Forms.ComboBox
    Friend WithEvents gbDatosAdicionales As System.Windows.Forms.GroupBox
    Friend WithEvents txtInfoAdic As System.Windows.Forms.TextBox
    Friend WithEvents gbAccesos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents btnAccesos As System.Windows.Forms.Button
    Friend WithEvents txtUsuarioId As System.Windows.Forms.TextBox
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents cboUsuarioBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Módulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Permisos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Horario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubicación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Opciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModuloId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RolId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModuloSiglas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
