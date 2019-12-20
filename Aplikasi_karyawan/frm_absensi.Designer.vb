<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_absensi
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtNik = New System.Windows.Forms.TextBox
        Me.lblTglSekarang = New System.Windows.Forms.Label
        Me.lblJamSekarang = New System.Windows.Forms.Label
        Me.lblNIK = New System.Windows.Forms.Label
        Me.lblInfo = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(30, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 261)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtNik
        '
        Me.txtNik.Location = New System.Drawing.Point(30, 316)
        Me.txtNik.Name = "txtNik"
        Me.txtNik.Size = New System.Drawing.Size(212, 20)
        Me.txtNik.TabIndex = 1
        '
        'lblTglSekarang
        '
        Me.lblTglSekarang.AutoSize = True
        Me.lblTglSekarang.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglSekarang.Location = New System.Drawing.Point(341, 73)
        Me.lblTglSekarang.Name = "lblTglSekarang"
        Me.lblTglSekarang.Size = New System.Drawing.Size(74, 22)
        Me.lblTglSekarang.TabIndex = 2
        Me.lblTglSekarang.Text = "Label1"
        '
        'lblJamSekarang
        '
        Me.lblJamSekarang.AutoSize = True
        Me.lblJamSekarang.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamSekarang.Location = New System.Drawing.Point(341, 95)
        Me.lblJamSekarang.Name = "lblJamSekarang"
        Me.lblJamSekarang.Size = New System.Drawing.Size(74, 22)
        Me.lblJamSekarang.TabIndex = 3
        Me.lblJamSekarang.Text = "Label2"
        '
        'lblNIK
        '
        Me.lblNIK.AutoSize = True
        Me.lblNIK.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIK.Location = New System.Drawing.Point(341, 126)
        Me.lblNIK.Name = "lblNIK"
        Me.lblNIK.Size = New System.Drawing.Size(74, 22)
        Me.lblNIK.TabIndex = 4
        Me.lblNIK.Text = "Label3"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(341, 158)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(74, 22)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Text = "Label4"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 479)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblNIK)
        Me.Controls.Add(Me.lblJamSekarang)
        Me.Controls.Add(Me.lblTglSekarang)
        Me.Controls.Add(Me.txtNik)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_absensi"
        Me.Text = "Absensi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNik As System.Windows.Forms.TextBox
    Friend WithEvents lblTglSekarang As System.Windows.Forms.Label
    Friend WithEvents lblJamSekarang As System.Windows.Forms.Label
    Friend WithEvents lblNIK As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
