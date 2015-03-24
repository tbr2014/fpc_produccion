<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte7
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboTipoJuego = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboPit = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGenerarRpt = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.txtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.crvResultados = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crRatingPit1 = New bddc.Win.crRatingPit
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Rating de Clientes (por Pit)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(314, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Inicio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTipoJuego)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboPit)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnGenerarRpt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFechaFin)
        Me.GroupBox1.Controls.Add(Me.txtFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 37)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'cboTipoJuego
        '
        Me.cboTipoJuego.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboTipoJuego.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoJuego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoJuego.FormattingEnabled = True
        Me.cboTipoJuego.Location = New System.Drawing.Point(188, 10)
        Me.cboTipoJuego.MaxLength = 100
        Me.cboTipoJuego.Name = "cboTipoJuego"
        Me.cboTipoJuego.Size = New System.Drawing.Size(109, 21)
        Me.cboTipoJuego.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Juego"
        '
        'cboPit
        '
        Me.cboPit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPit.FormattingEnabled = True
        Me.cboPit.Location = New System.Drawing.Point(31, 11)
        Me.cboPit.MaxLength = 100
        Me.cboPit.Name = "cboPit"
        Me.cboPit.Size = New System.Drawing.Size(109, 21)
        Me.cboPit.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Pit"
        '
        'btnGenerarRpt
        '
        Me.btnGenerarRpt.Location = New System.Drawing.Point(669, 10)
        Me.btnGenerarRpt.Name = "btnGenerarRpt"
        Me.btnGenerarRpt.Size = New System.Drawing.Size(80, 23)
        Me.btnGenerarRpt.TabIndex = 66
        Me.btnGenerarRpt.Text = "Generar"
        Me.btnGenerarRpt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(487, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Fecha Final"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFin.Location = New System.Drawing.Point(555, 11)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaFin.TabIndex = 64
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaIni.Location = New System.Drawing.Point(385, 11)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaIni.TabIndex = 63
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(12, 558)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(74, 13)
        Me.lblMensaje.TabIndex = 64
        Me.lblMensaje.Text = "<Mensajes>"
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
        'crvResultados
        '
        Me.crvResultados.ActiveViewIndex = -1
        Me.crvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvResultados.DisplayGroupTree = False
        Me.crvResultados.Location = New System.Drawing.Point(13, 118)
        Me.crvResultados.Name = "crvResultados"
        Me.crvResultados.SelectionFormula = ""
        Me.crvResultados.ShowCloseButton = False
        Me.crvResultados.ShowGroupTreeButton = False
        Me.crvResultados.ShowRefreshButton = False
        Me.crvResultados.Size = New System.Drawing.Size(754, 394)
        Me.crvResultados.TabIndex = 66
        Me.crvResultados.ViewTimeSelectionFormula = ""
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImage = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.Location = New System.Drawing.Point(714, 523)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 53)
        Me.btnSalir.TabIndex = 70
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmReporte7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(779, 588)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.crvResultados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReporte7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rating de Clientes (por Pit)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerarRpt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents crvResultados As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cboPit As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoJuego As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents crRatingPit1 As bddc.Win.crRatingPit
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
