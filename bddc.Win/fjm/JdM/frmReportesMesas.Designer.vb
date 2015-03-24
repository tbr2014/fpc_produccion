<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesMesas
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
        Me.btnBoton1 = New System.Windows.Forms.Button
        Me.btnBoton2 = New System.Windows.Forms.Button
        Me.btnBoton5 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBoton6 = New System.Windows.Forms.Button
        Me.gbRatingCierre = New System.Windows.Forms.GroupBox
        Me.btnRecalcular = New System.Windows.Forms.Button
        Me.ucFechaProceso = New bddc.Win.ucFecha
        Me.lblEstadoCierre = New System.Windows.Forms.Label
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbRatingReportes = New System.Windows.Forms.GroupBox
        Me.btnRCTBacarat = New System.Windows.Forms.Button
        Me.btnBoton8 = New System.Windows.Forms.Button
        Me.btnBoton7 = New System.Windows.Forms.Button
        Me.gbRatingPitboss = New System.Windows.Forms.GroupBox
        Me.btnVolver = New System.Windows.Forms.Button
        Me.pbCierreOk = New System.Windows.Forms.PictureBox
        Me.pbCierreNo = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnRatinTotalAnual = New System.Windows.Forms.Button
        Me.gbRatingCierre.SuspendLayout()
        Me.gbRatingReportes.SuspendLayout()
        Me.gbRatingPitboss.SuspendLayout()
        CType(Me.pbCierreOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCierreNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBoton1
        '
        Me.btnBoton1.Location = New System.Drawing.Point(9, 19)
        Me.btnBoton1.Name = "btnBoton1"
        Me.btnBoton1.Size = New System.Drawing.Size(271, 23)
        Me.btnBoton1.TabIndex = 3
        Me.btnBoton1.Text = "Rating de Clientes (Total)"
        Me.btnBoton1.UseVisualStyleBackColor = True
        '
        'btnBoton2
        '
        Me.btnBoton2.Location = New System.Drawing.Point(9, 48)
        Me.btnBoton2.Name = "btnBoton2"
        Me.btnBoton2.Size = New System.Drawing.Size(271, 23)
        Me.btnBoton2.TabIndex = 4
        Me.btnBoton2.Text = "Rating de Clientes (Detallado)"
        Me.btnBoton2.UseVisualStyleBackColor = True
        '
        'btnBoton5
        '
        Me.btnBoton5.Location = New System.Drawing.Point(9, 102)
        Me.btnBoton5.Name = "btnBoton5"
        Me.btnBoton5.Size = New System.Drawing.Size(271, 23)
        Me.btnBoton5.TabIndex = 5
        Me.btnBoton5.Text = "Puntaje de Clientes"
        Me.btnBoton5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Lista de Reportes - Mesas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBoton6
        '
        Me.btnBoton6.Location = New System.Drawing.Point(9, 161)
        Me.btnBoton6.Name = "btnBoton6"
        Me.btnBoton6.Size = New System.Drawing.Size(271, 23)
        Me.btnBoton6.TabIndex = 7
        Me.btnBoton6.Text = "Calendario de Puntajes por Jugador"
        Me.btnBoton6.UseVisualStyleBackColor = True
        '
        'gbRatingCierre
        '
        Me.gbRatingCierre.Controls.Add(Me.btnRecalcular)
        Me.gbRatingCierre.Controls.Add(Me.ucFechaProceso)
        Me.gbRatingCierre.Controls.Add(Me.lblEstadoCierre)
        Me.gbRatingCierre.Controls.Add(Me.pbCierreOk)
        Me.gbRatingCierre.Controls.Add(Me.pbCierreNo)
        Me.gbRatingCierre.Controls.Add(Me.btnAplicar)
        Me.gbRatingCierre.Controls.Add(Me.Label1)
        Me.gbRatingCierre.Location = New System.Drawing.Point(12, 146)
        Me.gbRatingCierre.Name = "gbRatingCierre"
        Me.gbRatingCierre.Size = New System.Drawing.Size(297, 72)
        Me.gbRatingCierre.TabIndex = 14
        Me.gbRatingCierre.TabStop = False
        Me.gbRatingCierre.Text = "Cierre del día"
        '
        'btnRecalcular
        '
        Me.btnRecalcular.Location = New System.Drawing.Point(202, 42)
        Me.btnRecalcular.Name = "btnRecalcular"
        Me.btnRecalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnRecalcular.TabIndex = 95
        Me.btnRecalcular.Text = "Recalcular"
        Me.btnRecalcular.UseVisualStyleBackColor = True
        Me.btnRecalcular.Visible = False
        '
        'ucFechaProceso
        '
        Me.ucFechaProceso.Location = New System.Drawing.Point(49, 15)
        Me.ucFechaProceso.Name = "ucFechaProceso"
        Me.ucFechaProceso.Size = New System.Drawing.Size(96, 25)
        Me.ucFechaProceso.TabIndex = 94
        '
        'lblEstadoCierre
        '
        Me.lblEstadoCierre.AutoSize = True
        Me.lblEstadoCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCierre.Location = New System.Drawing.Point(31, 53)
        Me.lblEstadoCierre.Name = "lblEstadoCierre"
        Me.lblEstadoCierre.Size = New System.Drawing.Size(118, 13)
        Me.lblEstadoCierre.TabIndex = 5
        Me.lblEstadoCierre.Text = "<Estado del Cierre>"
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(155, 15)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(121, 23)
        Me.btnAplicar.TabIndex = 2
        Me.btnAplicar.Text = "Extraer Datos"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'gbRatingReportes
        '
        Me.gbRatingReportes.Controls.Add(Me.btnRatinTotalAnual)
        Me.gbRatingReportes.Controls.Add(Me.btnRCTBacarat)
        Me.gbRatingReportes.Controls.Add(Me.btnBoton8)
        Me.gbRatingReportes.Controls.Add(Me.btnBoton6)
        Me.gbRatingReportes.Controls.Add(Me.btnBoton1)
        Me.gbRatingReportes.Controls.Add(Me.btnBoton5)
        Me.gbRatingReportes.Controls.Add(Me.btnBoton2)
        Me.gbRatingReportes.Location = New System.Drawing.Point(12, 224)
        Me.gbRatingReportes.Name = "gbRatingReportes"
        Me.gbRatingReportes.Size = New System.Drawing.Size(297, 245)
        Me.gbRatingReportes.TabIndex = 15
        Me.gbRatingReportes.TabStop = False
        Me.gbRatingReportes.Text = "Reportes Consolidados"
        '
        'btnRCTBacarat
        '
        Me.btnRCTBacarat.Location = New System.Drawing.Point(9, 131)
        Me.btnRCTBacarat.Name = "btnRCTBacarat"
        Me.btnRCTBacarat.Size = New System.Drawing.Size(271, 23)
        Me.btnRCTBacarat.TabIndex = 6
        Me.btnRCTBacarat.Text = "Comisiones de Baccarat"
        Me.btnRCTBacarat.UseVisualStyleBackColor = True
        '
        'btnBoton8
        '
        Me.btnBoton8.Location = New System.Drawing.Point(9, 190)
        Me.btnBoton8.Name = "btnBoton8"
        Me.btnBoton8.Size = New System.Drawing.Size(271, 23)
        Me.btnBoton8.TabIndex = 8
        Me.btnBoton8.Text = "Resumen de Puntaje de Jugador por Juego"
        Me.btnBoton8.UseVisualStyleBackColor = True
        '
        'btnBoton7
        '
        Me.btnBoton7.Location = New System.Drawing.Point(9, 19)
        Me.btnBoton7.Name = "btnBoton7"
        Me.btnBoton7.Size = New System.Drawing.Size(271, 23)
        Me.btnBoton7.TabIndex = 1
        Me.btnBoton7.Text = "Rating de Clientes (por Pit)"
        Me.btnBoton7.UseVisualStyleBackColor = True
        '
        'gbRatingPitboss
        '
        Me.gbRatingPitboss.Controls.Add(Me.btnBoton7)
        Me.gbRatingPitboss.Location = New System.Drawing.Point(12, 86)
        Me.gbRatingPitboss.Name = "gbRatingPitboss"
        Me.gbRatingPitboss.Size = New System.Drawing.Size(297, 54)
        Me.gbRatingPitboss.TabIndex = 20
        Me.gbRatingPitboss.TabStop = False
        Me.gbRatingPitboss.Text = "Reporte del Pitboss"
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Location = New System.Drawing.Point(256, 508)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(53, 53)
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'pbCierreOk
        '
        Me.pbCierreOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCierreOk.Image = Global.bddc.Win.My.Resources.Resources.btnOk
        Me.pbCierreOk.Location = New System.Drawing.Point(9, 50)
        Me.pbCierreOk.Name = "pbCierreOk"
        Me.pbCierreOk.Size = New System.Drawing.Size(16, 16)
        Me.pbCierreOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbCierreOk.TabIndex = 4
        Me.pbCierreOk.TabStop = False
        '
        'pbCierreNo
        '
        Me.pbCierreNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCierreNo.Image = Global.bddc.Win.My.Resources.Resources.btnNo
        Me.pbCierreNo.Location = New System.Drawing.Point(9, 50)
        Me.pbCierreNo.Name = "pbCierreNo"
        Me.pbCierreNo.Size = New System.Drawing.Size(16, 16)
        Me.pbCierreNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbCierreNo.TabIndex = 3
        Me.pbCierreNo.TabStop = False
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
        'btnRatinTotalAnual
        '
        Me.btnRatinTotalAnual.Location = New System.Drawing.Point(9, 75)
        Me.btnRatinTotalAnual.Name = "btnRatinTotalAnual"
        Me.btnRatinTotalAnual.Size = New System.Drawing.Size(271, 23)
        Me.btnRatinTotalAnual.TabIndex = 9
        Me.btnRatinTotalAnual.Text = "Rating Total Anual"
        Me.btnRatinTotalAnual.UseVisualStyleBackColor = True
        '
        'frmReportesMesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(318, 573)
        Me.Controls.Add(Me.gbRatingPitboss)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.gbRatingReportes)
        Me.Controls.Add(Me.gbRatingCierre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReportesMesas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Reportes - Mesas"
        Me.gbRatingCierre.ResumeLayout(False)
        Me.gbRatingCierre.PerformLayout()
        Me.gbRatingReportes.ResumeLayout(False)
        Me.gbRatingPitboss.ResumeLayout(False)
        CType(Me.pbCierreOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCierreNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBoton1 As System.Windows.Forms.Button
    Friend WithEvents btnBoton2 As System.Windows.Forms.Button
    Friend WithEvents btnBoton5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBoton6 As System.Windows.Forms.Button
    Friend WithEvents gbRatingCierre As System.Windows.Forms.GroupBox
    Friend WithEvents pbCierreNo As System.Windows.Forms.PictureBox
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbCierreOk As System.Windows.Forms.PictureBox
    Friend WithEvents lblEstadoCierre As System.Windows.Forms.Label
    Friend WithEvents gbRatingReportes As System.Windows.Forms.GroupBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnBoton7 As System.Windows.Forms.Button
    Friend WithEvents gbRatingPitboss As System.Windows.Forms.GroupBox
    Friend WithEvents btnBoton8 As System.Windows.Forms.Button
    Friend WithEvents ucFechaProceso As bddc.Win.ucFecha
    Friend WithEvents btnRCTBacarat As System.Windows.Forms.Button
    Friend WithEvents btnRecalcular As System.Windows.Forms.Button
    Friend WithEvents btnRatinTotalAnual As System.Windows.Forms.Button
End Class
