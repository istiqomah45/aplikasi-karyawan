﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_lembur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_lembur))
        Me.ComboBoxidjabat = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TextBoxTot = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxUangLem = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxjamlem = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxnamakar = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Buttonout = New System.Windows.Forms.Button
        Me.Buttondel = New System.Windows.Forms.Button
        Me.Buttonedit = New System.Windows.Forms.Button
        Me.Buttonsave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBoxNIK = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxidjabat
        '
        Me.ComboBoxidjabat.FormattingEnabled = True
        Me.ComboBoxidjabat.Location = New System.Drawing.Point(210, 125)
        Me.ComboBoxidjabat.Name = "ComboBoxidjabat"
        Me.ComboBoxidjabat.Size = New System.Drawing.Size(135, 21)
        Me.ComboBoxidjabat.TabIndex = 85
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(66, 314)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(655, 186)
        Me.DataGridView1.TabIndex = 82
        '
        'TextBoxTot
        '
        Me.TextBoxTot.Location = New System.Drawing.Point(499, 125)
        Me.TextBoxTot.Name = "TextBoxTot"
        Me.TextBoxTot.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxTot.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(383, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "TTL UANG LEMBUR"
        '
        'TextBoxUangLem
        '
        Me.TextBoxUangLem.Location = New System.Drawing.Point(499, 87)
        Me.TextBoxUangLem.Name = "TextBoxUangLem"
        Me.TextBoxUangLem.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxUangLem.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(383, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "UANG LEMBUR"
        '
        'TextBoxjamlem
        '
        Me.TextBoxjamlem.Location = New System.Drawing.Point(499, 53)
        Me.TextBoxjamlem.Name = "TextBoxjamlem"
        Me.TextBoxjamlem.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxjamlem.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "JML JAM LEMBUR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "ID JABATAN"
        '
        'TextBoxnamakar
        '
        Me.TextBoxnamakar.Location = New System.Drawing.Point(210, 87)
        Me.TextBoxnamakar.Name = "TextBoxnamakar"
        Me.TextBoxnamakar.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxnamakar.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "NAMA KARYAWAN"
        '
        'Buttonout
        '
        Me.Buttonout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Buttonout.Image = CType(resources.GetObject("Buttonout.Image"), System.Drawing.Image)
        Me.Buttonout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonout.Location = New System.Drawing.Point(526, 253)
        Me.Buttonout.Name = "Buttonout"
        Me.Buttonout.Size = New System.Drawing.Size(101, 38)
        Me.Buttonout.TabIndex = 54
        Me.Buttonout.Text = "KELUAR"
        Me.Buttonout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Buttonout.UseVisualStyleBackColor = False
        '
        'Buttondel
        '
        Me.Buttondel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Buttondel.Image = CType(resources.GetObject("Buttondel.Image"), System.Drawing.Image)
        Me.Buttondel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttondel.Location = New System.Drawing.Point(396, 253)
        Me.Buttondel.Name = "Buttondel"
        Me.Buttondel.Size = New System.Drawing.Size(96, 38)
        Me.Buttondel.TabIndex = 53
        Me.Buttondel.Text = "HAPUS"
        Me.Buttondel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Buttondel.UseVisualStyleBackColor = False
        '
        'Buttonedit
        '
        Me.Buttonedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Buttonedit.Image = CType(resources.GetObject("Buttonedit.Image"), System.Drawing.Image)
        Me.Buttonedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonedit.Location = New System.Drawing.Point(258, 253)
        Me.Buttonedit.Name = "Buttonedit"
        Me.Buttonedit.Size = New System.Drawing.Size(85, 38)
        Me.Buttonedit.TabIndex = 52
        Me.Buttonedit.Text = "EDIT"
        Me.Buttonedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Buttonedit.UseVisualStyleBackColor = False
        '
        'Buttonsave
        '
        Me.Buttonsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Buttonsave.Image = CType(resources.GetObject("Buttonsave.Image"), System.Drawing.Image)
        Me.Buttonsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonsave.Location = New System.Drawing.Point(112, 253)
        Me.Buttonsave.Name = "Buttonsave"
        Me.Buttonsave.Size = New System.Drawing.Size(89, 38)
        Me.Buttonsave.TabIndex = 51
        Me.Buttonsave.Text = "SIMPAN"
        Me.Buttonsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Buttonsave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "TGL LEMBUR"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(210, 162)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(135, 20)
        Me.DateTimePicker1.TabIndex = 83
        '
        'TextBoxNIK
        '
        Me.TextBoxNIK.Location = New System.Drawing.Point(210, 56)
        Me.TextBoxNIK.Name = "TextBoxNIK"
        Me.TextBoxNIK.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxNIK.TabIndex = 86
        '
        'Form_lembur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(820, 536)
        Me.Controls.Add(Me.TextBoxNIK)
        Me.Controls.Add(Me.ComboBoxidjabat)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxTot)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxUangLem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxjamlem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxnamakar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buttonout)
        Me.Controls.Add(Me.Buttondel)
        Me.Controls.Add(Me.Buttonedit)
        Me.Controls.Add(Me.Buttonsave)
        Me.Name = "Form_lembur"
        Me.Text = "Form_lembur"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxidjabat As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxTot As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUangLem As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxjamlem As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnamakar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Buttonout As System.Windows.Forms.Button
    Friend WithEvents Buttondel As System.Windows.Forms.Button
    Friend WithEvents Buttonedit As System.Windows.Forms.Button
    Friend WithEvents Buttonsave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxNIK As System.Windows.Forms.TextBox
End Class
