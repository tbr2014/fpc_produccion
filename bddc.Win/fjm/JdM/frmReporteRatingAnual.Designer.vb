<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteRatingAnual
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnGenerarRpt = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.XmlWinLossAnual = New bddc.Win.xmlWinLossAnual
        Me.Winloss_añosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Winloss_añosTableAdapter = New bddc.Win.xmlWinLossAnualTableAdapters.winloss_añosTableAdapter
        Me.TableAdapterManager = New bddc.Win.xmlWinLossAnualTableAdapters.TableAdapterManager
        Me.cbAño = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XmlWinLossAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winloss_añosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbAño)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnGenerarRpt)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 37)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Seleccione el año:"
        '
        'btnGenerarRpt
        '
        Me.btnGenerarRpt.Location = New System.Drawing.Point(649, 10)
        Me.btnGenerarRpt.Name = "btnGenerarRpt"
        Me.btnGenerarRpt.Size = New System.Drawing.Size(99, 23)
        Me.btnGenerarRpt.TabIndex = 4
        Me.btnGenerarRpt.Text = "Generar"
        Me.btnGenerarRpt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 28)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Reporte Raing Total Anual"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgReportes
        Me.PictureBox2.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(15, 665)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(57, 13)
        Me.lblMensaje.TabIndex = 19
        Me.lblMensaje.Text = "lblMensaje"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 109)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(999, 548)
        Me.ReportViewer1.TabIndex = 20
        '
        'XmlWinLossAnual
        '
        Me.XmlWinLossAnual.DataSetName = "xmlWinLossAnual"
        Me.XmlWinLossAnual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Winloss_añosBindingSource
        '
        Me.Winloss_añosBindingSource.DataMember = "winloss_años"
        Me.Winloss_añosBindingSource.DataSource = Me.XmlWinLossAnual
        '
        'Winloss_añosTableAdapter
        '
        Me.Winloss_añosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = bddc.Win.xmlWinLossAnualTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cbAño
        '
        Me.cbAño.DataSource = Me.Winloss_añosBindingSource
        Me.cbAño.DisplayMember = "_YEAR"
        Me.cbAño.FormattingEnabled = True
        Me.cbAño.Location = New System.Drawing.Point(104, 11)
        Me.cbAño.Name = "cbAño"
        Me.cbAño.Size = New System.Drawing.Size(121, 21)
        Me.cbAño.TabIndex = 67
        Me.cbAño.ValueMember = "_YEAR"
        '
        'frmReporteRatingAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 685)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmReporteRatingAnual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReporteRatingAnual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XmlWinLossAnual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winloss_añosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarRpt As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents XmlWinLossAnual As bddc.Win.xmlWinLossAnual
    Friend WithEvents Winloss_añosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Winloss_añosTableAdapter As bddc.Win.xmlWinLossAnualTableAdapters.winloss_añosTableAdapter
    Friend WithEvents TableAdapterManager As bddc.Win.xmlWinLossAnualTableAdapters.TableAdapterManager
    Friend WithEvents cbAño As System.Windows.Forms.ComboBox
End Class
