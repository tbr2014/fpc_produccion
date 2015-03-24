<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte10
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
        Me.components = New System.ComponentModel.Container
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbBeneficiario = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.pbEspera = New System.Windows.Forms.ProgressBar
        Me.chkClientes = New System.Windows.Forms.CheckBox
        Me.chlClientes = New System.Windows.Forms.CheckedListBox
        Me.chklBusqueda = New System.Windows.Forms.CheckedListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.txtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.crvResultados = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.btnGenerarRpt = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.txtCcli_id = New System.Windows.Forms.TextBox
        Me.BdClientesDataSet1 = New bddc.Win.BDClientesDataSet
        Me.Tblfjm_GrupoClienteBaccaratBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Luxor_tbllim_grupoclientebaccaratTableAdapter = New bddc.Win.BDClientesDataSetTableAdapters.Luxor_tbllim_grupoclientebaccaratTableAdapter
        Me.TableAdapterManager1 = New bddc.Win.BDClientesDataSetTableAdapters.TableAdapterManager
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BdClientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tblfjm_GrupoClienteBaccaratBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 28)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Reporte de Comisiones (Baccarat)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgReportes
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbBeneficiario)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFechaFin)
        Me.GroupBox1.Controls.Add(Me.txtFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 475)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Beneficiario:"
        '
        'cbBeneficiario
        '
        Me.cbBeneficiario.FormattingEnabled = True
        Me.cbBeneficiario.Location = New System.Drawing.Point(13, 100)
        Me.cbBeneficiario.Name = "cbBeneficiario"
        Me.cbBeneficiario.Size = New System.Drawing.Size(199, 21)
        Me.cbBeneficiario.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.pbEspera)
        Me.GroupBox2.Controls.Add(Me.chkClientes)
        Me.GroupBox2.Controls.Add(Me.chlClientes)
        Me.GroupBox2.Controls.Add(Me.chklBusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 331)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clientes"
        '
        'pbEspera
        '
        Me.pbEspera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbEspera.Location = New System.Drawing.Point(6, 309)
        Me.pbEspera.Name = "pbEspera"
        Me.pbEspera.Size = New System.Drawing.Size(203, 15)
        Me.pbEspera.TabIndex = 2
        '
        'chkClientes
        '
        Me.chkClientes.AutoSize = True
        Me.chkClientes.Location = New System.Drawing.Point(10, 16)
        Me.chkClientes.Name = "chkClientes"
        Me.chkClientes.Size = New System.Drawing.Size(111, 17)
        Me.chkClientes.TabIndex = 1
        Me.chkClientes.Text = "Seleccionar todos"
        Me.chkClientes.UseVisualStyleBackColor = True
        '
        'chlClientes
        '
        Me.chlClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chlClientes.FormattingEnabled = True
        Me.chlClientes.Location = New System.Drawing.Point(7, 36)
        Me.chlClientes.Name = "chlClientes"
        Me.chlClientes.Size = New System.Drawing.Size(202, 259)
        Me.chlClientes.TabIndex = 0
        '
        'chklBusqueda
        '
        Me.chklBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chklBusqueda.FormattingEnabled = True
        Me.chklBusqueda.Location = New System.Drawing.Point(7, 36)
        Me.chklBusqueda.Name = "chklBusqueda"
        Me.chklBusqueda.Size = New System.Drawing.Size(202, 259)
        Me.chklBusqueda.TabIndex = 3
        Me.chklBusqueda.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Fecha Final:"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFin.Location = New System.Drawing.Point(93, 47)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaFin.TabIndex = 66
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaIni.Location = New System.Drawing.Point(93, 21)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaIni.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Fecha Inicio:"
        '
        'crvResultados
        '
        Me.crvResultados.ActiveViewIndex = -1
        Me.crvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvResultados.DisplayGroupTree = False
        Me.crvResultados.Location = New System.Drawing.Point(276, 85)
        Me.crvResultados.Name = "crvResultados"
        Me.crvResultados.SelectionFormula = ""
        Me.crvResultados.ShowCloseButton = False
        Me.crvResultados.ShowGroupTreeButton = False
        Me.crvResultados.ShowRefreshButton = False
        Me.crvResultados.Size = New System.Drawing.Size(703, 475)
        Me.crvResultados.TabIndex = 88
        Me.crvResultados.ViewTimeSelectionFormula = ""
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.bddc.Win.My.Resources.Resources.btngridGuardar
        Me.btnGuardar.Location = New System.Drawing.Point(19, 569)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 53)
        Me.btnGuardar.TabIndex = 90
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(251, 589)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(74, 13)
        Me.lblMensaje.TabIndex = 93
        Me.lblMensaje.Text = "<Mensajes>"
        '
        'btnGenerarRpt
        '
        Me.btnGenerarRpt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarRpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarRpt.Location = New System.Drawing.Point(86, 569)
        Me.btnGenerarRpt.Name = "btnGenerarRpt"
        Me.btnGenerarRpt.Size = New System.Drawing.Size(61, 53)
        Me.btnGenerarRpt.TabIndex = 91
        Me.btnGenerarRpt.Text = "Generar Reporte"
        Me.btnGenerarRpt.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.Location = New System.Drawing.Point(153, 569)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 53)
        Me.btnSalir.TabIndex = 92
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtCcli_id
        '
        Me.txtCcli_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCcli_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCcli_id.Location = New System.Drawing.Point(254, 605)
        Me.txtCcli_id.Name = "txtCcli_id"
        Me.txtCcli_id.ReadOnly = True
        Me.txtCcli_id.Size = New System.Drawing.Size(49, 13)
        Me.txtCcli_id.TabIndex = 89
        Me.txtCcli_id.TabStop = False
        '
        'BdClientesDataSet1
        '
        Me.BdClientesDataSet1.DataSetName = "BDClientesDataSet"
        Me.BdClientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tblfjm_GrupoClienteBaccaratBindingSource
        '
        Me.Tblfjm_GrupoClienteBaccaratBindingSource.DataMember = "Luxor_tbllim_grupoclientebaccarat"
        Me.Tblfjm_GrupoClienteBaccaratBindingSource.DataSource = Me.BdClientesDataSet1
        '
        'Luxor_tbllim_grupoclientebaccaratTableAdapter
        '
        Me.Luxor_tbllim_grupoclientebaccaratTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Fiesta_tblaux_tipocambioTableAdapter = Nothing
        Me.TableAdapterManager1.Fiesta_tblbdd_clienteTableAdapter = Nothing
        Me.TableAdapterManager1.Fiesta_tblbdd_consumo_ttrTableAdapter = Nothing
        Me.TableAdapterManager1.Fiesta_tblfjm_grupoclientebaccaratTableAdapter = Nothing
        Me.TableAdapterManager1.Fiesta_tblttr_cliente_consumoTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tblaux_tipocambioTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tblbdd_clienteBusquedaTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tblbdd_clienteTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tblbdd_consumo_ttrTableAdapter = Nothing
        Me.TableAdapterManager1.Luxor_tbllim_grupoclientebaccaratTableAdapter = Me.Luxor_tbllim_grupoclientebaccaratTableAdapter
        Me.TableAdapterManager1.Luxor_tblttr_cliente_consumoTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = bddc.Win.BDClientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmReporte10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 634)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnGenerarRpt)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtCcli_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.crvResultados)
        Me.Name = "frmReporte10"
        Me.Text = "Reporte de Comisiones (Bacarat)"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BdClientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tblfjm_GrupoClienteBaccaratBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbBeneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pbEspera As System.Windows.Forms.ProgressBar
    Friend WithEvents chkClientes As System.Windows.Forms.CheckBox
    Friend WithEvents chlClientes As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklBusqueda As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crvResultados As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnGenerarRpt As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtCcli_id As System.Windows.Forms.TextBox
    Friend WithEvents BdClientesDataSet1 As bddc.Win.BDClientesDataSet
    Friend WithEvents Tblfjm_GrupoClienteBaccaratBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Luxor_tbllim_grupoclientebaccaratTableAdapter As bddc.Win.BDClientesDataSetTableAdapters.Luxor_tbllim_grupoclientebaccaratTableAdapter
    Friend WithEvents TableAdapterManager1 As bddc.Win.BDClientesDataSetTableAdapters.TableAdapterManager
End Class
