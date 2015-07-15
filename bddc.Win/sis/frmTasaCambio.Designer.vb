<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTasaCambio
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
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDClientesDataSet = New bddc.Win.BDClientesDataSet()
        Me.txtTasa = New System.Windows.Forms.TextBox()
        Me.dptFecha = New System.Windows.Forms.DateTimePicker()
        Me.EstadoLabel = New System.Windows.Forms.Label()
        Me.TasaLabel = New System.Windows.Forms.Label()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FtdcyyyyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FtdcmmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FtdcddDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager1 = New bddc.Win.BDClientesDataSetTableAdapters.TableAdapterManager()
        Me.Fiesta_tblaux_tipocambioTableAdapter = New bddc.Win.BDClientesDataSetTableAdapters.Fiesta_tblaux_tipocambioTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDClientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(12, 465)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(74, 13)
        Me.lblMensaje.TabIndex = 74
        Me.lblMensaje.Text = "<Mensajes>"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbNuevo, Me.tsbAgregar, Me.tsbGuardar, Me.tsbEliminar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(377, 31)
        Me.ToolStrip1.TabIndex = 75
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
        'tsbEliminar
        '
        Me.tsbEliminar.Image = Global.bddc.Win.My.Resources.Resources.btngridBorrar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(78, 28)
        Me.tsbEliminar.Text = "Eliminar"
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
        Me.Label2.Location = New System.Drawing.Point(72, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 26)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Tasa de Cambio"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgTipoCambio
        Me.PictureBox2.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkEstado)
        Me.GroupBox1.Controls.Add(Me.txtTasa)
        Me.GroupBox1.Controls.Add(Me.dptFecha)
        Me.GroupBox1.Controls.Add(Me.EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.TasaLabel)
        Me.GroupBox1.Controls.Add(Me.FechaLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 108)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BindingSource1, "Estado", True))
        Me.chkEstado.Location = New System.Drawing.Point(54, 80)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(15, 14)
        Me.chkEstado.TabIndex = 5
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Fiesta_tblaux_tipocambio"
        Me.BindingSource1.DataSource = Me.BDClientesDataSet
        '
        'BDClientesDataSet
        '
        Me.BDClientesDataSet.DataSetName = "BDClientesDataSet"
        Me.BDClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTasa
        '
        Me.txtTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Tasa", True))
        Me.txtTasa.Location = New System.Drawing.Point(54, 51)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Size = New System.Drawing.Size(100, 20)
        Me.txtTasa.TabIndex = 4
        '
        'dptFecha
        '
        Me.dptFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "Fecha", True))
        Me.dptFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptFecha.Location = New System.Drawing.Point(54, 25)
        Me.dptFecha.Name = "dptFecha"
        Me.dptFecha.Size = New System.Drawing.Size(102, 20)
        Me.dptFecha.TabIndex = 3
        Me.dptFecha.Value = New Date(2013, 8, 13, 14, 17, 41, 0)
        '
        'EstadoLabel
        '
        Me.EstadoLabel.AutoSize = True
        Me.EstadoLabel.Location = New System.Drawing.Point(10, 80)
        Me.EstadoLabel.Name = "EstadoLabel"
        Me.EstadoLabel.Size = New System.Drawing.Size(40, 13)
        Me.EstadoLabel.TabIndex = 2
        Me.EstadoLabel.Text = "Estado"
        '
        'TasaLabel
        '
        Me.TasaLabel.AutoSize = True
        Me.TasaLabel.Location = New System.Drawing.Point(10, 51)
        Me.TasaLabel.Name = "TasaLabel"
        Me.TasaLabel.Size = New System.Drawing.Size(31, 13)
        Me.TasaLabel.TabIndex = 1
        Me.TasaLabel.Text = "Tasa"
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Location = New System.Drawing.Point(10, 25)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(37, 13)
        Me.FechaLabel.TabIndex = 0
        Me.FechaLabel.Text = "Fecha"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.txtDia)
        Me.GroupBox2.Controls.Add(Me.txtMes)
        Me.GroupBox2.Controls.Add(Me.txtAño)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 239)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FtdcyyyyDataGridViewTextBoxColumn, Me.FtdcmmDataGridViewTextBoxColumn, Me.FtdcddDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TasaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(7, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 213)
        Me.DataGridView1.TabIndex = 0
        '
        'FtdcyyyyDataGridViewTextBoxColumn
        '
        Me.FtdcyyyyDataGridViewTextBoxColumn.DataPropertyName = "ftdc_yyyy"
        Me.FtdcyyyyDataGridViewTextBoxColumn.HeaderText = "ftdc_yyyy"
        Me.FtdcyyyyDataGridViewTextBoxColumn.Name = "FtdcyyyyDataGridViewTextBoxColumn"
        Me.FtdcyyyyDataGridViewTextBoxColumn.Visible = False
        '
        'FtdcmmDataGridViewTextBoxColumn
        '
        Me.FtdcmmDataGridViewTextBoxColumn.DataPropertyName = "ftdc_mm"
        Me.FtdcmmDataGridViewTextBoxColumn.HeaderText = "ftdc_mm"
        Me.FtdcmmDataGridViewTextBoxColumn.Name = "FtdcmmDataGridViewTextBoxColumn"
        Me.FtdcmmDataGridViewTextBoxColumn.Visible = False
        '
        'FtdcddDataGridViewTextBoxColumn
        '
        Me.FtdcddDataGridViewTextBoxColumn.DataPropertyName = "ftdc_dd"
        Me.FtdcddDataGridViewTextBoxColumn.HeaderText = "ftdc_dd"
        Me.FtdcddDataGridViewTextBoxColumn.Name = "FtdcddDataGridViewTextBoxColumn"
        Me.FtdcddDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'TasaDataGridViewTextBoxColumn
        '
        Me.TasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.HeaderText = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.Name = "TasaDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'txtDia
        '
        Me.txtDia.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtDia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ftdc_dd", True))
        Me.txtDia.Location = New System.Drawing.Point(222, 107)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(100, 20)
        Me.txtDia.TabIndex = 82
        Me.txtDia.TabStop = False
        '
        'txtMes
        '
        Me.txtMes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtMes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ftdc_mm", True))
        Me.txtMes.Location = New System.Drawing.Point(222, 86)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 81
        Me.txtMes.TabStop = False
        '
        'txtAño
        '
        Me.txtAño.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ftdc_yyyy", True))
        Me.txtAño.Location = New System.Drawing.Point(222, 62)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 80
        Me.txtAño.TabStop = False
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.Fiesta_tblaux_tipocambioTableAdapter = Nothing
        Me.TableAdapterManager1.Fiesta_tblbdd_clienteBusquedaTableAdapter = Nothing
        Me.TableAdapterManager1.Fiesta_tblbdd_clienteTableAdapter = Nothing
        Me.TableAdapterManager1.Fiesta_tblbdd_consumo_ttrTableAdapter = Nothing
        Me.TableAdapterManager1.Fiesta_tblfjm_grupoclientebaccaratTableAdapter = Nothing
        Me.TableAdapterManager1.Fiesta_tblttr_cliente_consumoTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tblaux_tipocambioTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tblbdd_clienteBusquedaTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tblbdd_clienteTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tblbdd_consumo_ttrTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tbllim_grupoclientebaccaratTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tblttr_cliente_consumoTableAdapter = Nothing
        Me.TableAdapterManager1.Prueba_tblaux_tipocambioTableAdapter = Nothing
        Me.TableAdapterManager1.Tacna_tblaux_tipocambioTableAdapter = Nothing
        Me.TableAdapterManager1.Tacna_tblbdd_clienteBusquedaTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = bddc.Win.BDClientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Fiesta_tblaux_tipocambioTableAdapter
        '
        Me.Fiesta_tblaux_tipocambioTableAdapter.ClearBeforeFill = True
        '
        'frmTasaCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 485)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblMensaje)
        Me.Name = "frmTasaCambio"
        Me.Text = "Tasa de Cambio"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDClientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager1 As bddc.Win.BDClientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents txtTasa As System.Windows.Forms.TextBox
    Friend WithEvents dptFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents EstadoLabel As System.Windows.Forms.Label
    Friend WithEvents TasaLabel As System.Windows.Forms.Label
    Friend WithEvents FechaLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BDClientesDataSet As bddc.Win.BDClientesDataSet
    Friend WithEvents Fiesta_tblaux_tipocambioTableAdapter As bddc.Win.BDClientesDataSetTableAdapters.Fiesta_tblaux_tipocambioTableAdapter
    Friend WithEvents FtdcyyyyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FtdcmmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FtdcddDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
End Class
