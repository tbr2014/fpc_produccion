<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFecha
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(3, 3)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFecha.MaxLength = 10
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(70, 20)
        Me.txtFecha.TabIndex = 89
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(72, 3)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(19, 20)
        Me.dtpFecha.TabIndex = 88
        '
        'ucFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Name = "ucFecha"
        Me.Size = New System.Drawing.Size(96, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker

End Class
