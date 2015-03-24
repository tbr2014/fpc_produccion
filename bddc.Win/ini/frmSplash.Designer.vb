<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.btnEstimados = New System.Windows.Forms.Button
        Me.btnAuditoria = New System.Windows.Forms.Button
        Me.btnImpresion = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnClientes = New System.Windows.Forms.Button
        Me.btnRating = New System.Windows.Forms.Button
        Me.btnReportes = New System.Windows.Forms.Button
        Me.btnSistema = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(124, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 91)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fiesta Cash Club"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(124, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fiesta Casino Benavides"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(124, 234)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(208, 29)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "Versión"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEstimados
        '
        Me.btnEstimados.BackColor = System.Drawing.Color.Beige
        Me.btnEstimados.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgEstimadoMesa
        Me.btnEstimados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEstimados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstimados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstimados.Location = New System.Drawing.Point(225, 475)
        Me.btnEstimados.Name = "btnEstimados"
        Me.btnEstimados.Size = New System.Drawing.Size(92, 84)
        Me.btnEstimados.TabIndex = 22
        Me.btnEstimados.Text = "Mesas x Hora"
        Me.btnEstimados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEstimados.UseVisualStyleBackColor = False
        '
        'btnAuditoria
        '
        Me.btnAuditoria.BackColor = System.Drawing.Color.Beige
        Me.btnAuditoria.BackgroundImage = CType(resources.GetObject("btnAuditoria.BackgroundImage"), System.Drawing.Image)
        Me.btnAuditoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAuditoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAuditoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuditoria.Location = New System.Drawing.Point(519, 475)
        Me.btnAuditoria.Name = "btnAuditoria"
        Me.btnAuditoria.Size = New System.Drawing.Size(92, 84)
        Me.btnAuditoria.TabIndex = 20
        Me.btnAuditoria.Text = "Auditoría"
        Me.btnAuditoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAuditoria.UseVisualStyleBackColor = False
        '
        'btnImpresion
        '
        Me.btnImpresion.BackColor = System.Drawing.Color.Beige
        Me.btnImpresion.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgImpresion
        Me.btnImpresion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImpresion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImpresion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpresion.Location = New System.Drawing.Point(658, 475)
        Me.btnImpresion.Name = "btnImpresion"
        Me.btnImpresion.Size = New System.Drawing.Size(92, 84)
        Me.btnImpresion.TabIndex = 18
        Me.btnImpresion.Text = "Impresión"
        Me.btnImpresion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImpresion.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Beige
        Me.btnSalir.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgSalir
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(756, 475)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(92, 84)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Beige
        Me.btnClientes.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgClientes
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Location = New System.Drawing.Point(30, 475)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(92, 84)
        Me.btnClientes.TabIndex = 15
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnRating
        '
        Me.btnRating.BackColor = System.Drawing.Color.Beige
        Me.btnRating.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgRuleta
        Me.btnRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRating.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRating.Location = New System.Drawing.Point(128, 475)
        Me.btnRating.Name = "btnRating"
        Me.btnRating.Size = New System.Drawing.Size(92, 84)
        Me.btnRating.TabIndex = 13
        Me.btnRating.Text = "Rating"
        Me.btnRating.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRating.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.Beige
        Me.btnReportes.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgReportes
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.Location = New System.Drawing.Point(323, 475)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(92, 84)
        Me.btnReportes.TabIndex = 12
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnSistema
        '
        Me.btnSistema.BackColor = System.Drawing.Color.Beige
        Me.btnSistema.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgSistema
        Me.btnSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSistema.Location = New System.Drawing.Point(421, 475)
        Me.btnSistema.Name = "btnSistema"
        Me.btnSistema.Size = New System.Drawing.Size(92, 84)
        Me.btnSistema.TabIndex = 11
        Me.btnSistema.Text = "Parámetros"
        Me.btnSistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSistema.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(818, 442)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 576)
        Me.Controls.Add(Me.btnEstimados)
        Me.Controls.Add(Me.btnAuditoria)
        Me.Controls.Add(Me.btnImpresion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnRating)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.btnSistema)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiesta Cash Club"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnSistema As System.Windows.Forms.Button
    Friend WithEvents btnReportes As System.Windows.Forms.Button
    Friend WithEvents btnRating As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnImpresion As System.Windows.Forms.Button
    Friend WithEvents btnAuditoria As System.Windows.Forms.Button
    Friend WithEvents btnEstimados As System.Windows.Forms.Button
End Class
