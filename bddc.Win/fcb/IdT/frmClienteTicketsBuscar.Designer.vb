<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteTicketBuscar
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoJuegoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteNumDoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteNumTarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteCategoriaId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TicketsTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TicketsImpresos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TicketsPendientes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TicketsNumInicial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TicketsNumImpresiones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TicketsFechaImpresion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TicketsImpresionEstadoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudUsuarioId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TicketsGUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBuscarNumTarjeta = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBuscarApeNom = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tsslblMensaje = New System.Windows.Forms.ToolStripStatusLabel
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteId, Me.TipoJuegoId, Me.ClienteCodigo, Me.ClienteNumDoc, Me.ClienteNombreCompleto, Me.ClienteNumTarjeta, Me.ClienteCategoriaId, Me.TicketsTotal, Me.TicketsImpresos, Me.TicketsPendientes, Me.TicketsNumInicial, Me.TicketsNumImpresiones, Me.TicketsFechaImpresion, Me.TicketsImpresionEstadoId, Me.AudUsuarioId, Me.TicketsGUID})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.Location = New System.Drawing.Point(12, 120)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClientes.Size = New System.Drawing.Size(460, 356)
        Me.dgvClientes.TabIndex = 12
        '
        'ClienteId
        '
        Me.ClienteId.DataPropertyName = "ClienteId"
        Me.ClienteId.HeaderText = "ClienteId"
        Me.ClienteId.Name = "ClienteId"
        Me.ClienteId.ReadOnly = True
        Me.ClienteId.Visible = False
        '
        'TipoJuegoId
        '
        Me.TipoJuegoId.DataPropertyName = "TipoJuegoId"
        Me.TipoJuegoId.HeaderText = "TipoJuegoId"
        Me.TipoJuegoId.Name = "TipoJuegoId"
        Me.TipoJuegoId.ReadOnly = True
        Me.TipoJuegoId.Visible = False
        '
        'ClienteCodigo
        '
        Me.ClienteCodigo.DataPropertyName = "ClienteCodigo"
        Me.ClienteCodigo.HeaderText = "Id"
        Me.ClienteCodigo.Name = "ClienteCodigo"
        Me.ClienteCodigo.ReadOnly = True
        Me.ClienteCodigo.Visible = False
        Me.ClienteCodigo.Width = 50
        '
        'ClienteNumDoc
        '
        Me.ClienteNumDoc.DataPropertyName = "ClienteNumDoc"
        Me.ClienteNumDoc.HeaderText = "Documento"
        Me.ClienteNumDoc.Name = "ClienteNumDoc"
        Me.ClienteNumDoc.ReadOnly = True
        Me.ClienteNumDoc.Width = 80
        '
        'ClienteNombreCompleto
        '
        Me.ClienteNombreCompleto.DataPropertyName = "ClienteNombreCompleto"
        Me.ClienteNombreCompleto.HeaderText = "Nombre"
        Me.ClienteNombreCompleto.Name = "ClienteNombreCompleto"
        Me.ClienteNombreCompleto.ReadOnly = True
        Me.ClienteNombreCompleto.Width = 200
        '
        'ClienteNumTarjeta
        '
        Me.ClienteNumTarjeta.DataPropertyName = "ClienteNumTarjeta"
        Me.ClienteNumTarjeta.HeaderText = "Tarjeta"
        Me.ClienteNumTarjeta.Name = "ClienteNumTarjeta"
        Me.ClienteNumTarjeta.ReadOnly = True
        Me.ClienteNumTarjeta.Width = 70
        '
        'ClienteCategoriaId
        '
        Me.ClienteCategoriaId.DataPropertyName = "ClienteCategoriaId"
        Me.ClienteCategoriaId.HeaderText = "ClienteCategoriaId"
        Me.ClienteCategoriaId.Name = "ClienteCategoriaId"
        Me.ClienteCategoriaId.ReadOnly = True
        Me.ClienteCategoriaId.Visible = False
        '
        'TicketsTotal
        '
        Me.TicketsTotal.DataPropertyName = "TicketsTotal"
        Me.TicketsTotal.HeaderText = "Tickets"
        Me.TicketsTotal.Name = "TicketsTotal"
        Me.TicketsTotal.ReadOnly = True
        Me.TicketsTotal.Width = 50
        '
        'TicketsImpresos
        '
        Me.TicketsImpresos.DataPropertyName = "TicketsImpresos"
        Me.TicketsImpresos.HeaderText = "TicketsImpresos"
        Me.TicketsImpresos.Name = "TicketsImpresos"
        Me.TicketsImpresos.ReadOnly = True
        Me.TicketsImpresos.Visible = False
        '
        'TicketsPendientes
        '
        Me.TicketsPendientes.DataPropertyName = "TicketsPendientes"
        Me.TicketsPendientes.HeaderText = "TicketsPendientes"
        Me.TicketsPendientes.Name = "TicketsPendientes"
        Me.TicketsPendientes.ReadOnly = True
        Me.TicketsPendientes.Visible = False
        '
        'TicketsNumInicial
        '
        Me.TicketsNumInicial.DataPropertyName = "TicketsNumInicial"
        Me.TicketsNumInicial.HeaderText = "TicketsNumInicial"
        Me.TicketsNumInicial.Name = "TicketsNumInicial"
        Me.TicketsNumInicial.ReadOnly = True
        Me.TicketsNumInicial.Visible = False
        '
        'TicketsNumImpresiones
        '
        Me.TicketsNumImpresiones.DataPropertyName = "TicketsNumImpresiones"
        Me.TicketsNumImpresiones.HeaderText = "TicketsNumImpresiones"
        Me.TicketsNumImpresiones.Name = "TicketsNumImpresiones"
        Me.TicketsNumImpresiones.ReadOnly = True
        Me.TicketsNumImpresiones.Visible = False
        '
        'TicketsFechaImpresion
        '
        Me.TicketsFechaImpresion.DataPropertyName = "TicketsFechaImpresion"
        Me.TicketsFechaImpresion.HeaderText = "TicketsFechaImpresion"
        Me.TicketsFechaImpresion.Name = "TicketsFechaImpresion"
        Me.TicketsFechaImpresion.ReadOnly = True
        Me.TicketsFechaImpresion.Visible = False
        '
        'TicketsImpresionEstadoId
        '
        Me.TicketsImpresionEstadoId.DataPropertyName = "TicketsImpresionEstadoId"
        Me.TicketsImpresionEstadoId.HeaderText = "TicketsImpresionEstadoId"
        Me.TicketsImpresionEstadoId.Name = "TicketsImpresionEstadoId"
        Me.TicketsImpresionEstadoId.ReadOnly = True
        Me.TicketsImpresionEstadoId.Visible = False
        '
        'AudUsuarioId
        '
        Me.AudUsuarioId.DataPropertyName = "AudUsuarioId"
        Me.AudUsuarioId.HeaderText = "AudUsuarioId"
        Me.AudUsuarioId.Name = "AudUsuarioId"
        Me.AudUsuarioId.ReadOnly = True
        Me.AudUsuarioId.Visible = False
        '
        'TicketsGUID
        '
        Me.TicketsGUID.DataPropertyName = "TicketsGUID"
        Me.TicketsGUID.HeaderText = "TicketsGUID"
        Me.TicketsGUID.Name = "TicketsGUID"
        Me.TicketsGUID.ReadOnly = True
        Me.TicketsGUID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "N° Tarjeta"
        '
        'txtBuscarNumTarjeta
        '
        Me.txtBuscarNumTarjeta.Location = New System.Drawing.Point(350, 91)
        Me.txtBuscarNumTarjeta.Name = "txtBuscarNumTarjeta"
        Me.txtBuscarNumTarjeta.Size = New System.Drawing.Size(77, 20)
        Me.txtBuscarNumTarjeta.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Apellido/Nombre"
        '
        'txtBuscarApeNom
        '
        Me.txtBuscarApeNom.Location = New System.Drawing.Point(100, 91)
        Me.txtBuscarApeNom.Name = "txtBuscarApeNom"
        Me.txtBuscarApeNom.Size = New System.Drawing.Size(183, 20)
        Me.txtBuscarApeNom.TabIndex = 17
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(433, 89)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(39, 23)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgClientes
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 26)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Buscar Clientes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblMensaje})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 491)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(485, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslblMensaje
        '
        Me.tsslblMensaje.Name = "tsslblMensaje"
        Me.tsslblMensaje.Size = New System.Drawing.Size(51, 17)
        Me.tsslblMensaje.Text = "Mensaje"
        '
        'frmClienteTicketBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(485, 513)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscarApeNom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBuscarNumTarjeta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmClienteTicketBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarNumTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarApeNom As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslblMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ClienteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoJuegoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteNumDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteNumTarjeta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCategoriaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketsTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketsImpresos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketsPendientes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketsNumInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketsNumImpresiones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketsFechaImpresion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketsImpresionEstadoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudUsuarioId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketsGUID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
