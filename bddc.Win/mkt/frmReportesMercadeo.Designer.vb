<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesMercadeo
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
        Me.btnBoton3 = New System.Windows.Forms.Button
        Me.btnBoton4 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbClientesMercadeo = New System.Windows.Forms.GroupBox
        Me.btnVolver = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRptClientes_Mesas = New System.Windows.Forms.Button
        Me.btnRptClientes_Slots = New System.Windows.Forms.Button
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.gbClientesMercadeo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBoton3
        '
        Me.btnBoton3.Location = New System.Drawing.Point(9, 19)
        Me.btnBoton3.Name = "btnBoton3"
        Me.btnBoton3.Size = New System.Drawing.Size(207, 23)
        Me.btnBoton3.TabIndex = 2
        Me.btnBoton3.Text = "Clientes por Juegos"
        Me.btnBoton3.UseVisualStyleBackColor = True
        '
        'btnBoton4
        '
        Me.btnBoton4.Location = New System.Drawing.Point(249, 19)
        Me.btnBoton4.Name = "btnBoton4"
        Me.btnBoton4.Size = New System.Drawing.Size(207, 23)
        Me.btnBoton4.TabIndex = 3
        Me.btnBoton4.Text = "Lista de Cumpleaños"
        Me.btnBoton4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Lista de Reportes - Mercadeo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbClientesMercadeo
        '
        Me.gbClientesMercadeo.Controls.Add(Me.btnBoton4)
        Me.gbClientesMercadeo.Controls.Add(Me.btnBoton3)
        Me.gbClientesMercadeo.Location = New System.Drawing.Point(9, 88)
        Me.gbClientesMercadeo.Name = "gbClientesMercadeo"
        Me.gbClientesMercadeo.Size = New System.Drawing.Size(466, 55)
        Me.gbClientesMercadeo.TabIndex = 21
        Me.gbClientesMercadeo.TabStop = False
        Me.gbClientesMercadeo.Text = "Información para Mercadeo"
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Location = New System.Drawing.Point(422, 235)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(53, 53)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgReportes
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRptClientes_Mesas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.btnRptClientes_Slots)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 84)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Clientes para Promociones"
        '
        'btnRptClientes_Mesas
        '
        Me.btnRptClientes_Mesas.Location = New System.Drawing.Point(249, 50)
        Me.btnRptClientes_Mesas.Name = "btnRptClientes_Mesas"
        Me.btnRptClientes_Mesas.Size = New System.Drawing.Size(207, 23)
        Me.btnRptClientes_Mesas.TabIndex = 4
        Me.btnRptClientes_Mesas.Text = "Clientes de Mesas"
        Me.btnRptClientes_Mesas.UseVisualStyleBackColor = True
        '
        'btnRptClientes_Slots
        '
        Me.btnRptClientes_Slots.Location = New System.Drawing.Point(249, 21)
        Me.btnRptClientes_Slots.Name = "btnRptClientes_Slots"
        Me.btnRptClientes_Slots.Size = New System.Drawing.Size(207, 23)
        Me.btnRptClientes_Slots.TabIndex = 3
        Me.btnRptClientes_Slots.Text = "Clientes de Slots"
        Me.btnRptClientes_Slots.UseVisualStyleBackColor = True
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(27, 53)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(79, 20)
        Me.dtpFechaIni.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "De:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Hasta:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(147, 53)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(79, 20)
        Me.dtpFechaFin.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Antes extraer datos de Table Trac"
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMensaje})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 291)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(480, 22)
        Me.statusStrip1.TabIndex = 93
        Me.statusStrip1.Text = "StatusStrip1"
        '
        'tssMensaje
        '
        Me.tssMensaje.Name = "tssMensaje"
        Me.tssMensaje.Size = New System.Drawing.Size(51, 17)
        Me.tssMensaje.Text = "Mensaje"
        '
        'frmReportesMercadeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(480, 313)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbClientesMercadeo)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReportesMercadeo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes - Mercadeo"
        Me.gbClientesMercadeo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBoton3 As System.Windows.Forms.Button
    Friend WithEvents btnBoton4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents gbClientesMercadeo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRptClientes_Mesas As System.Windows.Forms.Button
    Friend WithEvents btnRptClientes_Slots As System.Windows.Forms.Button
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMensaje As System.Windows.Forms.ToolStripStatusLabel
End Class
