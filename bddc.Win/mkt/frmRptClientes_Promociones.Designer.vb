<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptClientes_Promociones
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvResultadosSlots = New System.Windows.Forms.DataGridView
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteNombres = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteFecNac = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteGeneroId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteGenero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DomicilioCiudad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteTelefonos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteCorreoElectronico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rank = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SlotWager = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SlotWon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SlotPoints = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnVolver = New System.Windows.Forms.Button
        Me.dgvResultadosMesas = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DropTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WinLossTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApuestaPromTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TiempoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvResultadosSlots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusStrip1.SuspendLayout()
        CType(Me.dgvResultadosMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvResultadosSlots
        '
        Me.dgvResultadosSlots.AllowUserToAddRows = False
        Me.dgvResultadosSlots.AllowUserToDeleteRows = False
        Me.dgvResultadosSlots.AllowUserToResizeRows = False
        Me.dgvResultadosSlots.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultadosSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultadosSlots.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteId, Me.ClienteCodigo, Me.ClienteApellidos, Me.ClienteNombres, Me.ClienteFecNac, Me.ClienteGeneroId, Me.ClienteGenero, Me.DomicilioCiudad, Me.ClienteTelefonos, Me.ClienteCorreoElectronico, Me.Tier, Me.Rank, Me.SlotWager, Me.SlotWon, Me.SlotPoints})
        Me.dgvResultadosSlots.Location = New System.Drawing.Point(12, 12)
        Me.dgvResultadosSlots.Name = "dgvResultadosSlots"
        Me.dgvResultadosSlots.ReadOnly = True
        Me.dgvResultadosSlots.RowHeadersWidth = 20
        Me.dgvResultadosSlots.Size = New System.Drawing.Size(723, 555)
        Me.dgvResultadosSlots.TabIndex = 0
        '
        'ClienteId
        '
        Me.ClienteId.DataPropertyName = "ClienteId"
        Me.ClienteId.HeaderText = "ClienteId"
        Me.ClienteId.Name = "ClienteId"
        Me.ClienteId.ReadOnly = True
        Me.ClienteId.Visible = False
        '
        'ClienteCodigo
        '
        Me.ClienteCodigo.DataPropertyName = "ClienteCodigo"
        Me.ClienteCodigo.HeaderText = "Código"
        Me.ClienteCodigo.Name = "ClienteCodigo"
        Me.ClienteCodigo.ReadOnly = True
        '
        'ClienteApellidos
        '
        Me.ClienteApellidos.DataPropertyName = "ClienteApellidos"
        Me.ClienteApellidos.HeaderText = "Apellidos"
        Me.ClienteApellidos.Name = "ClienteApellidos"
        Me.ClienteApellidos.ReadOnly = True
        Me.ClienteApellidos.Width = 150
        '
        'ClienteNombres
        '
        Me.ClienteNombres.DataPropertyName = "ClienteNombres"
        Me.ClienteNombres.HeaderText = "Nombres"
        Me.ClienteNombres.Name = "ClienteNombres"
        Me.ClienteNombres.ReadOnly = True
        Me.ClienteNombres.Width = 150
        '
        'ClienteFecNac
        '
        Me.ClienteFecNac.DataPropertyName = "ClienteFecNac"
        Me.ClienteFecNac.HeaderText = "ClienteFecNac"
        Me.ClienteFecNac.Name = "ClienteFecNac"
        Me.ClienteFecNac.ReadOnly = True
        Me.ClienteFecNac.Visible = False
        '
        'ClienteGeneroId
        '
        Me.ClienteGeneroId.DataPropertyName = "ClienteGeneroId"
        Me.ClienteGeneroId.HeaderText = "ClienteGeneroId"
        Me.ClienteGeneroId.Name = "ClienteGeneroId"
        Me.ClienteGeneroId.ReadOnly = True
        Me.ClienteGeneroId.Visible = False
        '
        'ClienteGenero
        '
        Me.ClienteGenero.DataPropertyName = "ClienteGenero"
        Me.ClienteGenero.HeaderText = "ClienteGenero"
        Me.ClienteGenero.Name = "ClienteGenero"
        Me.ClienteGenero.ReadOnly = True
        Me.ClienteGenero.Visible = False
        '
        'DomicilioCiudad
        '
        Me.DomicilioCiudad.DataPropertyName = "DomicilioCiudad"
        Me.DomicilioCiudad.HeaderText = "Dirección"
        Me.DomicilioCiudad.Name = "DomicilioCiudad"
        Me.DomicilioCiudad.ReadOnly = True
        Me.DomicilioCiudad.Width = 200
        '
        'ClienteTelefonos
        '
        Me.ClienteTelefonos.DataPropertyName = "ClienteTelefonos"
        Me.ClienteTelefonos.HeaderText = "Teléfonos"
        Me.ClienteTelefonos.Name = "ClienteTelefonos"
        Me.ClienteTelefonos.ReadOnly = True
        '
        'ClienteCorreoElectronico
        '
        Me.ClienteCorreoElectronico.DataPropertyName = "ClienteCorreoElectronico"
        Me.ClienteCorreoElectronico.HeaderText = "Email"
        Me.ClienteCorreoElectronico.Name = "ClienteCorreoElectronico"
        Me.ClienteCorreoElectronico.ReadOnly = True
        Me.ClienteCorreoElectronico.Width = 180
        '
        'Tier
        '
        Me.Tier.DataPropertyName = "Tier"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Tier.DefaultCellStyle = DataGridViewCellStyle1
        Me.Tier.HeaderText = "Tier"
        Me.Tier.Name = "Tier"
        Me.Tier.ReadOnly = True
        Me.Tier.Width = 40
        '
        'Rank
        '
        Me.Rank.DataPropertyName = "Rank"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Rank.DefaultCellStyle = DataGridViewCellStyle2
        Me.Rank.HeaderText = "Rank"
        Me.Rank.Name = "Rank"
        Me.Rank.ReadOnly = True
        Me.Rank.Width = 40
        '
        'SlotWager
        '
        Me.SlotWager.DataPropertyName = "SlotWager"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.SlotWager.DefaultCellStyle = DataGridViewCellStyle3
        Me.SlotWager.HeaderText = "SlotWager"
        Me.SlotWager.Name = "SlotWager"
        Me.SlotWager.ReadOnly = True
        Me.SlotWager.Width = 80
        '
        'SlotWon
        '
        Me.SlotWon.DataPropertyName = "SlotWon"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.SlotWon.DefaultCellStyle = DataGridViewCellStyle4
        Me.SlotWon.HeaderText = "SlotWon"
        Me.SlotWon.Name = "SlotWon"
        Me.SlotWon.ReadOnly = True
        Me.SlotWon.Width = 80
        '
        'SlotPoints
        '
        Me.SlotPoints.DataPropertyName = "SlotPoints"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.SlotPoints.DefaultCellStyle = DataGridViewCellStyle5
        Me.SlotPoints.HeaderText = "SlotPoints"
        Me.SlotPoints.Name = "SlotPoints"
        Me.SlotPoints.ReadOnly = True
        Me.SlotPoints.Width = 80
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMensaje})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 631)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(747, 22)
        Me.statusStrip1.TabIndex = 74
        Me.statusStrip1.Text = "StatusStrip1"
        '
        'tssMensaje
        '
        Me.tssMensaje.Name = "tssMensaje"
        Me.tssMensaje.Size = New System.Drawing.Size(51, 17)
        Me.tssMensaje.Text = "Mensaje"
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Location = New System.Drawing.Point(682, 573)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(53, 53)
        Me.btnVolver.TabIndex = 93
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'dgvResultadosMesas
        '
        Me.dgvResultadosMesas.AllowUserToAddRows = False
        Me.dgvResultadosMesas.AllowUserToDeleteRows = False
        Me.dgvResultadosMesas.AllowUserToResizeRows = False
        Me.dgvResultadosMesas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultadosMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultadosMesas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DropTotal, Me.WinLossTotal, Me.ApuestaPromTotal, Me.TiempoTotal})
        Me.dgvResultadosMesas.Location = New System.Drawing.Point(12, 12)
        Me.dgvResultadosMesas.Name = "dgvResultadosMesas"
        Me.dgvResultadosMesas.ReadOnly = True
        Me.dgvResultadosMesas.RowHeadersWidth = 20
        Me.dgvResultadosMesas.Size = New System.Drawing.Size(723, 555)
        Me.dgvResultadosMesas.TabIndex = 94
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ClienteId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ClienteId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ClienteCodigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ClienteApellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ClienteNombres"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ClienteFecNac"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ClienteFecNac"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ClienteGeneroId"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ClienteGeneroId"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ClienteGenero"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ClienteGenero"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DomicilioCiudad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ClienteTelefonos"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Teléfonos"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ClienteCorreoElectronico"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 180
        '
        'DropTotal
        '
        Me.DropTotal.DataPropertyName = "DropTotal"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.DropTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.DropTotal.HeaderText = "Drop"
        Me.DropTotal.Name = "DropTotal"
        Me.DropTotal.ReadOnly = True
        Me.DropTotal.Width = 80
        '
        'WinLossTotal
        '
        Me.WinLossTotal.DataPropertyName = "WinLossTotal"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "n2"
        Me.WinLossTotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.WinLossTotal.HeaderText = "Win/Loss"
        Me.WinLossTotal.Name = "WinLossTotal"
        Me.WinLossTotal.ReadOnly = True
        Me.WinLossTotal.Width = 80
        '
        'ApuestaPromTotal
        '
        Me.ApuestaPromTotal.DataPropertyName = "ApuestaPromTotal"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "n2"
        Me.ApuestaPromTotal.DefaultCellStyle = DataGridViewCellStyle8
        Me.ApuestaPromTotal.HeaderText = "Apu. Prom"
        Me.ApuestaPromTotal.Name = "ApuestaPromTotal"
        Me.ApuestaPromTotal.ReadOnly = True
        Me.ApuestaPromTotal.Width = 80
        '
        'TiempoTotal
        '
        Me.TiempoTotal.DataPropertyName = "TiempoTotal"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.TiempoTotal.DefaultCellStyle = DataGridViewCellStyle9
        Me.TiempoTotal.HeaderText = "Tiempo Hr"
        Me.TiempoTotal.Name = "TiempoTotal"
        Me.TiempoTotal.ReadOnly = True
        Me.TiempoTotal.Width = 80
        '
        'frmRptClientes_Promociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 653)
        Me.Controls.Add(Me.dgvResultadosMesas)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.dgvResultadosSlots)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRptClientes_Promociones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Clientes de Slots (Table Trac)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvResultadosSlots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        CType(Me.dgvResultadosMesas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvResultadosSlots As System.Windows.Forms.DataGridView
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents ClienteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteFecNac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteGeneroId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteGenero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomicilioCiudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteTelefonos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCorreoElectronico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SlotWager As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SlotWon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SlotPoints As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvResultadosMesas As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DropTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WinLossTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApuestaPromTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
