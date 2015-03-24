<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesoTT
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.txtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnVolver = New System.Windows.Forms.Button
        Me.statusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Final"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFin.Location = New System.Drawing.Point(55, 45)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(80, 20)
        Me.txtFechaFin.TabIndex = 72
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaIni.Location = New System.Drawing.Point(55, 19)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(80, 20)
        Me.txtFechaIni.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Inicio"
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(23, 71)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(112, 23)
        Me.btnProcesar.TabIndex = 74
        Me.btnProcesar.Text = "Extraer Datos"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMensaje})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 177)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(186, 22)
        Me.statusStrip1.TabIndex = 77
        Me.statusStrip1.Text = "StatusStrip1"
        '
        'tssMensaje
        '
        Me.tssMensaje.Name = "tssMensaje"
        Me.tssMensaje.Size = New System.Drawing.Size(51, 17)
        Me.tssMensaje.Text = "Mensaje"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProcesar)
        Me.GroupBox2.Controls.Add(Me.txtFechaIni)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtFechaFin)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 105)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas"
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.Location = New System.Drawing.Point(121, 121)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(53, 53)
        Me.btnVolver.TabIndex = 94
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmProcesoTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 199)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.statusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProcesoTT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proceso Table Trac"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
