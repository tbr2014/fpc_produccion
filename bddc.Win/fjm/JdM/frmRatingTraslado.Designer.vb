<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRatingTraslado
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBuscarClienteOrigen = New System.Windows.Forms.Button
        Me.ddlClienteOrigen = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnBuscarClienteDestino = New System.Windows.Forms.Button
        Me.ddlClienteDestino = New System.Windows.Forms.ComboBox
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.btnVolver = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tsslblMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarClienteOrigen)
        Me.GroupBox1.Controls.Add(Me.ddlClienteOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente Origen"
        '
        'btnBuscarClienteOrigen
        '
        Me.btnBuscarClienteOrigen.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.btnBuscarClienteOrigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscarClienteOrigen.Location = New System.Drawing.Point(373, 17)
        Me.btnBuscarClienteOrigen.Name = "btnBuscarClienteOrigen"
        Me.btnBuscarClienteOrigen.Size = New System.Drawing.Size(39, 23)
        Me.btnBuscarClienteOrigen.TabIndex = 19
        Me.btnBuscarClienteOrigen.UseVisualStyleBackColor = True
        '
        'ddlClienteOrigen
        '
        Me.ddlClienteOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ddlClienteOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ddlClienteOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ddlClienteOrigen.FormattingEnabled = True
        Me.ddlClienteOrigen.Location = New System.Drawing.Point(6, 19)
        Me.ddlClienteOrigen.MaxLength = 100
        Me.ddlClienteOrigen.Name = "ddlClienteOrigen"
        Me.ddlClienteOrigen.Size = New System.Drawing.Size(361, 21)
        Me.ddlClienteOrigen.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscarClienteDestino)
        Me.GroupBox2.Controls.Add(Me.ddlClienteDestino)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 56)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente Destino"
        '
        'btnBuscarClienteDestino
        '
        Me.btnBuscarClienteDestino.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.btnBuscarClienteDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscarClienteDestino.Location = New System.Drawing.Point(373, 17)
        Me.btnBuscarClienteDestino.Name = "btnBuscarClienteDestino"
        Me.btnBuscarClienteDestino.Size = New System.Drawing.Size(39, 23)
        Me.btnBuscarClienteDestino.TabIndex = 20
        Me.btnBuscarClienteDestino.UseVisualStyleBackColor = True
        '
        'ddlClienteDestino
        '
        Me.ddlClienteDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ddlClienteDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ddlClienteDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ddlClienteDestino.FormattingEnabled = True
        Me.ddlClienteDestino.Location = New System.Drawing.Point(6, 19)
        Me.ddlClienteDestino.MaxLength = 100
        Me.ddlClienteDestino.Name = "ddlClienteDestino"
        Me.ddlClienteDestino.Size = New System.Drawing.Size(361, 21)
        Me.ddlClienteDestino.TabIndex = 0
        '
        'btnAplicar
        '
        Me.btnAplicar.Image = Global.bddc.Win.My.Resources.Resources.imgTrasladoRating
        Me.btnAplicar.Location = New System.Drawing.Point(319, 137)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(53, 53)
        Me.btnAplicar.TabIndex = 2
        Me.btnAplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Location = New System.Drawing.Point(378, 137)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(53, 53)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblMensaje})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 197)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(443, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslblMensaje
        '
        Me.tsslblMensaje.Name = "tsslblMensaje"
        Me.tsslblMensaje.Size = New System.Drawing.Size(51, 17)
        Me.tsslblMensaje.Text = "Mensaje"
        '
        'frmRatingTraslado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 219)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRatingTraslado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado de Rating de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslblMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnBuscarClienteOrigen As System.Windows.Forms.Button
    Friend WithEvents btnBuscarClienteDestino As System.Windows.Forms.Button
    Friend WithEvents ddlClienteOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents ddlClienteDestino As System.Windows.Forms.ComboBox
End Class
