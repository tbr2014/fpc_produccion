<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTasaCambio_Tacna
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDia = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtTasa = New System.Windows.Forms.TextBox()
        Me.dptFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TacnatblauxtipocambioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdClientesDataSet1 = New bddc.Win.BDClientesDataSet()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Tacna_tblaux_tipocambioTableAdapter = New bddc.Win.BDClientesDataSetTableAdapters.Tacna_tblaux_tipocambioTableAdapter()
        Me.TableAdapterManager1 = New bddc.Win.BDClientesDataSetTableAdapters.TableAdapterManager()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FtdcyyyyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FtdcmmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FtdcddDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TacnatblauxtipocambioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdClientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.bddc.Win.My.Resources.Resources.imgTipoCambio
        Me.PictureBox1.Location = New System.Drawing.Point(12, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tasa de Cambio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDia)
        Me.GroupBox1.Controls.Add(Me.txtMes)
        Me.GroupBox1.Controls.Add(Me.txtAño)
        Me.GroupBox1.Controls.Add(Me.chkEstado)
        Me.GroupBox1.Controls.Add(Me.txtTasa)
        Me.GroupBox1.Controls.Add(Me.dptFecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 109)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'txtDia
        '
        Me.txtDia.AutoSize = True
        Me.txtDia.Location = New System.Drawing.Point(174, 81)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(0, 13)
        Me.txtDia.TabIndex = 11
        '
        'txtMes
        '
        Me.txtMes.AutoSize = True
        Me.txtMes.Location = New System.Drawing.Point(174, 53)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(0, 13)
        Me.txtMes.TabIndex = 10
        '
        'txtAño
        '
        Me.txtAño.AutoSize = True
        Me.txtAño.Location = New System.Drawing.Point(171, 20)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(0, 13)
        Me.txtAño.TabIndex = 9
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Location = New System.Drawing.Point(47, 83)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(15, 14)
        Me.chkEstado.TabIndex = 8
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtTasa
        '
        Me.txtTasa.Location = New System.Drawing.Point(47, 51)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Size = New System.Drawing.Size(100, 20)
        Me.txtTasa.TabIndex = 7
        '
        'dptFecha
        '
        Me.dptFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptFecha.Location = New System.Drawing.Point(47, 25)
        Me.dptFecha.Name = "dptFecha"
        Me.dptFecha.Size = New System.Drawing.Size(102, 20)
        Me.dptFecha.TabIndex = 6
        Me.dptFecha.Value = New Date(2013, 8, 13, 14, 17, 41, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tasa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.TasaDataGridViewTextBoxColumn, Me.FtdcyyyyDataGridViewTextBoxColumn, Me.FtdcmmDataGridViewTextBoxColumn, Me.FtdcddDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TacnatblauxtipocambioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(352, 203)
        Me.DataGridView1.TabIndex = 3
        '
        'TacnatblauxtipocambioBindingSource
        '
        Me.TacnatblauxtipocambioBindingSource.DataMember = "Tacna_tblaux_tipocambio"
        Me.TacnatblauxtipocambioBindingSource.DataSource = Me.BdClientesDataSet1
        '
        'BdClientesDataSet1
        '
        Me.BdClientesDataSet1.DataSetName = "BDClientesDataSet"
        Me.BdClientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(12, 465)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(64, 13)
        Me.lblMensaje.TabIndex = 4
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
        Me.ToolStrip1.TabIndex = 76
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
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.Image = Global.bddc.Win.My.Resources.Resources.btngridBorrar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(78, 28)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.Visible = False
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
        'Tacna_tblaux_tipocambioTableAdapter
        '
        Me.Tacna_tblaux_tipocambioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager1.Tacna_tblaux_tipocambioTableAdapter = Me.Tacna_tblaux_tipocambioTableAdapter
        Me.TableAdapterManager1.Tacna_tblbdd_clienteBusquedaTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = bddc.Win.BDClientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmTasaCambio_Tacna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 485)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmTasaCambio_Tacna"
        Me.Text = "Tasa de Cambio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TacnatblauxtipocambioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdClientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents dptFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTasa As System.Windows.Forms.TextBox
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents BdClientesDataSet1 As bddc.Win.BDClientesDataSet
    Friend WithEvents TacnatblauxtipocambioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tacna_tblaux_tipocambioTableAdapter As bddc.Win.BDClientesDataSetTableAdapters.Tacna_tblaux_tipocambioTableAdapter
    Friend WithEvents TableAdapterManager1 As bddc.Win.BDClientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtAño As System.Windows.Forms.Label
    Friend WithEvents txtMes As System.Windows.Forms.Label
    Friend WithEvents txtDia As System.Windows.Forms.Label
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FtdcyyyyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FtdcmmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FtdcddDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
