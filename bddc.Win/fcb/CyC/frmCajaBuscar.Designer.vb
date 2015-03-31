<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaBuscar
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
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbEstados = New System.Windows.Forms.GroupBox()
        Me.chkActivos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkFiltro = New System.Windows.Forms.CheckBox()
        Me.gbCaja = New System.Windows.Forms.GroupBox()
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.gbFechaRegistro = New System.Windows.Forms.GroupBox()
        Me.ucFechaProceso = New bddc.Win.ucFecha()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Ver2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.statusStrip1.SuspendLayout()
        Me.gbEstados.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbCaja.SuspendLayout()
        Me.gbFechaRegistro.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 26)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Registro de Transacción en Caja"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMensaje})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(594, 22)
        Me.statusStrip1.TabIndex = 73
        Me.statusStrip1.Text = "StatusStrip1"
        '
        'tssMensaje
        '
        Me.tssMensaje.Name = "tssMensaje"
        Me.tssMensaje.Size = New System.Drawing.Size(51, 17)
        Me.tssMensaje.Text = "Mensaje"
        '
        'gbEstados
        '
        Me.gbEstados.Controls.Add(Me.chkActivos)
        Me.gbEstados.Location = New System.Drawing.Point(335, 75)
        Me.gbEstados.Name = "gbEstados"
        Me.gbEstados.Size = New System.Drawing.Size(122, 42)
        Me.gbEstados.TabIndex = 89
        Me.gbEstados.TabStop = False
        Me.gbEstados.Text = "Estados"
        '
        'chkActivos
        '
        Me.chkActivos.AutoSize = True
        Me.chkActivos.Location = New System.Drawing.Point(6, 19)
        Me.chkActivos.Name = "chkActivos"
        Me.chkActivos.Size = New System.Drawing.Size(85, 17)
        Me.chkActivos.TabIndex = 0
        Me.chkActivos.Text = "Sólo Activos"
        Me.chkActivos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFiltro)
        Me.GroupBox1.Location = New System.Drawing.Point(126, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 42)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'chkFiltro
        '
        Me.chkFiltro.AutoSize = True
        Me.chkFiltro.Location = New System.Drawing.Point(16, 19)
        Me.chkFiltro.Name = "chkFiltro"
        Me.chkFiltro.Size = New System.Drawing.Size(172, 17)
        Me.chkFiltro.TabIndex = 1
        Me.chkFiltro.Text = "Sólo los Registros para Imprimir"
        Me.chkFiltro.UseVisualStyleBackColor = True
        '
        'gbCaja
        '
        Me.gbCaja.Controls.Add(Me.cboCaja)
        Me.gbCaja.Location = New System.Drawing.Point(463, 75)
        Me.gbCaja.Name = "gbCaja"
        Me.gbCaja.Size = New System.Drawing.Size(66, 42)
        Me.gbCaja.TabIndex = 93
        Me.gbCaja.TabStop = False
        Me.gbCaja.Text = "Caja"
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(6, 15)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(51, 21)
        Me.cboCaja.TabIndex = 0
        '
        'gbFechaRegistro
        '
        Me.gbFechaRegistro.Controls.Add(Me.ucFechaProceso)
        Me.gbFechaRegistro.Location = New System.Drawing.Point(12, 75)
        Me.gbFechaRegistro.Name = "gbFechaRegistro"
        Me.gbFechaRegistro.Size = New System.Drawing.Size(108, 42)
        Me.gbFechaRegistro.TabIndex = 94
        Me.gbFechaRegistro.TabStop = False
        Me.gbFechaRegistro.Text = "Fecha Registro"
        '
        'ucFechaProceso
        '
        Me.ucFechaProceso.Location = New System.Drawing.Point(6, 13)
        Me.ucFechaProceso.Name = "ucFechaProceso"
        Me.ucFechaProceso.Size = New System.Drawing.Size(96, 25)
        Me.ucFechaProceso.TabIndex = 78
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToOrderColumns = True
        Me.dgvResultados.AllowUserToResizeColumns = False
        Me.dgvResultados.AllowUserToResizeRows = False
        Me.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvResultados.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ver2})
        Me.dgvResultados.Location = New System.Drawing.Point(10, 133)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RowHeadersVisible = False
        Me.dgvResultados.Size = New System.Drawing.Size(574, 414)
        Me.dgvResultados.TabIndex = 98
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.ToolTipText = "Ver Registro"
        Me.DataGridViewImageColumn1.Width = 5
        '
        'btnExport
        '
        Me.btnExport.Image = Global.bddc.Win.My.Resources.Resources.excel
        Me.btnExport.Location = New System.Drawing.Point(553, 12)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(33, 33)
        Me.btnExport.TabIndex = 99
        Me.btnExport.UseVisualStyleBackColor = True
        Me.btnExport.Visible = False
        '
        'Ver2
        '
        Me.Ver2.HeaderText = ""
        Me.Ver2.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.Ver2.Name = "Ver2"
        Me.Ver2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Ver2.ToolTipText = "Ver Registro"
        Me.Ver2.Width = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(535, 79)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(51, 38)
        Me.btnBuscar.TabIndex = 95
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Location = New System.Drawing.Point(533, 601)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(53, 53)
        Me.btnVolver.TabIndex = 92
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgCajayConteo
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'frmCajaBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 681)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.gbFechaRegistro)
        Me.Controls.Add(Me.gbCaja)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbEstados)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCajaBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Transacciones en Caja"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.gbEstados.ResumeLayout(False)
        Me.gbEstados.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbCaja.ResumeLayout(False)
        Me.gbFechaRegistro.ResumeLayout(False)
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gbEstados As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents gbFechaRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents ucFechaProceso As bddc.Win.ucFecha
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents Ver2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
