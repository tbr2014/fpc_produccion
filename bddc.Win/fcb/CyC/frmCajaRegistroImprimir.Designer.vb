<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaRegistroImprimir
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
        Me.crvResultados = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crOperacionCajaRegistro1 = New bddc.Win.crOperacionCajaRegistro
        Me.SuspendLayout()
        '
        'crvResultados
        '
        Me.crvResultados.ActiveViewIndex = -1
        Me.crvResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvResultados.DisplayGroupTree = False
        Me.crvResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvResultados.Location = New System.Drawing.Point(0, 0)
        Me.crvResultados.Name = "crvResultados"
        Me.crvResultados.SelectionFormula = ""
        Me.crvResultados.ShowCloseButton = False
        Me.crvResultados.ShowGotoPageButton = False
        Me.crvResultados.ShowGroupTreeButton = False
        Me.crvResultados.ShowTextSearchButton = False
        Me.crvResultados.Size = New System.Drawing.Size(733, 602)
        Me.crvResultados.TabIndex = 0
        Me.crvResultados.ViewTimeSelectionFormula = ""
        '
        'frmCajaRegistroImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 602)
        Me.Controls.Add(Me.crvResultados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCajaRegistroImprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Operaciones - Vista Previa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvResultados As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crOperacionCajaRegistro1 As bddc.Win.crOperacionCajaRegistro
End Class
