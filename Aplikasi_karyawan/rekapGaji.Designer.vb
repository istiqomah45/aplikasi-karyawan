<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rekapGaji
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rekapGaji))
        Me.dtpDari = New System.Windows.Forms.DateTimePicker
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCetak = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dtpDari
        '
        Me.dtpDari.CustomFormat = "yyyy-MM-dd"
        Me.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDari.Location = New System.Drawing.Point(37, 42)
        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Size = New System.Drawing.Size(200, 20)
        Me.dtpDari.TabIndex = 0
        '
        'dtpSampai
        '
        Me.dtpSampai.CustomFormat = "yyyy-MM-dd"
        Me.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSampai.Location = New System.Drawing.Point(37, 103)
        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Size = New System.Drawing.Size(200, 20)
        Me.dtpSampai.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sampai"
        '
        'btnCetak
        '
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCetak.Location = New System.Drawing.Point(152, 153)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(85, 29)
        Me.btnCetak.TabIndex = 4
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'rekapGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 202)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpSampai)
        Me.Controls.Add(Me.dtpDari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "rekapGaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cetak Rekap Gaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDari As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCetak As System.Windows.Forms.Button
End Class
