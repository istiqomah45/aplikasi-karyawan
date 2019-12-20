<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insert_Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Insert_Data))
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.txttempatlahir = New System.Windows.Forms.TextBox
        Me.txtnohp = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtgaji = New System.Windows.Forms.TextBox
        Me.txtbagian = New System.Windows.Forms.TextBox
        Me.txtjabatan = New System.Windows.Forms.TextBox
        Me.txtalamat = New System.Windows.Forms.TextBox
        Me.cmbagama = New System.Windows.Forms.ComboBox
        Me.cmbstatus = New System.Windows.Forms.ComboBox
        Me.cmbkewarganegaraan = New System.Windows.Forms.ComboBox
        Me.cmbpendidikanakhir = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.txtpttrakhir = New System.Windows.Forms.TextBox
        Me.cmbstatuskaryawan = New System.Windows.Forms.ComboBox
        Me.cmbstatuskerja = New System.Windows.Forms.ComboBox
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.btnback = New System.Windows.Forms.Button
        Me.pctGbr = New System.Windows.Forms.PictureBox
        Me.btnPilih = New System.Windows.Forms.Button
        Me.lblPath = New System.Windows.Forms.Label
        Me.txtNamaGbr = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.pctGbr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(205, 39)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(152, 20)
        Me.txtnik.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(205, 138)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(59, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TEMPAT KELAHIRAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TANGGAL LAHIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "AGAMA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "STATUS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "KEWARGANEGARAAN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "NOMOR HP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "EMAIL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(60, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "ALAMAT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(485, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "PENDIDIKAN TERAKHIR"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(485, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "PT TERAKHIR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(485, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "JABATAN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(485, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "TANGGAL MASUK"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(485, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "BAGIAN"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(485, 247)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "GAJI"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(485, 284)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "STATUS KARYAWAN"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(485, 326)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "STATUS KERJA"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(205, 72)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(152, 20)
        Me.txtnama.TabIndex = 21
        '
        'txttempatlahir
        '
        Me.txttempatlahir.Location = New System.Drawing.Point(205, 106)
        Me.txttempatlahir.Name = "txttempatlahir"
        Me.txttempatlahir.Size = New System.Drawing.Size(152, 20)
        Me.txttempatlahir.TabIndex = 22
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(205, 278)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(152, 20)
        Me.txtnohp.TabIndex = 23
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(205, 320)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(152, 20)
        Me.txtemail.TabIndex = 24
        '
        'txtgaji
        '
        Me.txtgaji.Location = New System.Drawing.Point(626, 244)
        Me.txtgaji.Name = "txtgaji"
        Me.txtgaji.Size = New System.Drawing.Size(152, 20)
        Me.txtgaji.TabIndex = 25
        '
        'txtbagian
        '
        Me.txtbagian.Location = New System.Drawing.Point(626, 208)
        Me.txtbagian.Name = "txtbagian"
        Me.txtbagian.Size = New System.Drawing.Size(152, 20)
        Me.txtbagian.TabIndex = 26
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(626, 125)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(152, 20)
        Me.txtjabatan.TabIndex = 27
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(205, 364)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtalamat.Size = New System.Drawing.Size(201, 42)
        Me.txtalamat.TabIndex = 28
        '
        'cmbagama
        '
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Items.AddRange(New Object() {"Islam", "Kristen", "Katholik", "Hindu", "Buddha", "Kong Hu Cu"})
        Me.cmbagama.Location = New System.Drawing.Point(205, 172)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(152, 21)
        Me.cmbagama.TabIndex = 29
        '
        'cmbstatus
        '
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Belum Menikah", "Sudah Menikah"})
        Me.cmbstatus.Location = New System.Drawing.Point(205, 207)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(152, 21)
        Me.cmbstatus.TabIndex = 30
        '
        'cmbkewarganegaraan
        '
        Me.cmbkewarganegaraan.FormattingEnabled = True
        Me.cmbkewarganegaraan.Items.AddRange(New Object() {"WNI", "WNA"})
        Me.cmbkewarganegaraan.Location = New System.Drawing.Point(205, 240)
        Me.cmbkewarganegaraan.Name = "cmbkewarganegaraan"
        Me.cmbkewarganegaraan.Size = New System.Drawing.Size(152, 21)
        Me.cmbkewarganegaraan.TabIndex = 31
        '
        'cmbpendidikanakhir
        '
        Me.cmbpendidikanakhir.FormattingEnabled = True
        Me.cmbpendidikanakhir.Items.AddRange(New Object() {"SD", "SMP", "SMA", "D1", "D2", "D3", "S1", "S2", "S3"})
        Me.cmbpendidikanakhir.Location = New System.Drawing.Point(626, 36)
        Me.cmbpendidikanakhir.Name = "cmbpendidikanakhir"
        Me.cmbpendidikanakhir.Size = New System.Drawing.Size(152, 21)
        Me.cmbpendidikanakhir.TabIndex = 32
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(626, 165)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker2.TabIndex = 34
        '
        'txtpttrakhir
        '
        Me.txtpttrakhir.Location = New System.Drawing.Point(626, 84)
        Me.txtpttrakhir.Name = "txtpttrakhir"
        Me.txtpttrakhir.Size = New System.Drawing.Size(152, 20)
        Me.txtpttrakhir.TabIndex = 36
        '
        'cmbstatuskaryawan
        '
        Me.cmbstatuskaryawan.FormattingEnabled = True
        Me.cmbstatuskaryawan.Items.AddRange(New Object() {"AKTIF", "NONAKTIF"})
        Me.cmbstatuskaryawan.Location = New System.Drawing.Point(626, 281)
        Me.cmbstatuskaryawan.Name = "cmbstatuskaryawan"
        Me.cmbstatuskaryawan.Size = New System.Drawing.Size(152, 21)
        Me.cmbstatuskaryawan.TabIndex = 37
        '
        'cmbstatuskerja
        '
        Me.cmbstatuskerja.FormattingEnabled = True
        Me.cmbstatuskerja.Items.AddRange(New Object() {"KONTRAK", "TETAP"})
        Me.cmbstatuskerja.Location = New System.Drawing.Point(626, 323)
        Me.cmbstatuskerja.Name = "cmbstatuskerja"
        Me.cmbstatuskerja.Size = New System.Drawing.Size(152, 21)
        Me.cmbstatuskerja.TabIndex = 38
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.Location = New System.Drawing.Point(683, 474)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(95, 38)
        Me.btnsimpan.TabIndex = 39
        Me.btnsimpan.Text = "SAVE"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnback.Location = New System.Drawing.Point(784, 474)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(95, 38)
        Me.btnback.TabIndex = 117
        Me.btnback.Text = "BACK"
        Me.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnback.UseVisualStyleBackColor = False
        '
        'pctGbr
        '
        Me.pctGbr.Location = New System.Drawing.Point(491, 352)
        Me.pctGbr.Name = "pctGbr"
        Me.pctGbr.Size = New System.Drawing.Size(125, 126)
        Me.pctGbr.TabIndex = 118
        Me.pctGbr.TabStop = False
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPilih.Image = CType(resources.GetObject("btnPilih.Image"), System.Drawing.Image)
        Me.btnPilih.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPilih.Location = New System.Drawing.Point(626, 409)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(75, 34)
        Me.btnPilih.TabIndex = 119
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(623, 393)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(45, 13)
        Me.lblPath.TabIndex = 120
        Me.lblPath.Text = "Label19"
        '
        'txtNamaGbr
        '
        Me.txtNamaGbr.Location = New System.Drawing.Point(626, 360)
        Me.txtNamaGbr.Name = "txtNamaGbr"
        Me.txtNamaGbr.Size = New System.Drawing.Size(152, 20)
        Me.txtNamaGbr.TabIndex = 121
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Insert_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 534)
        Me.Controls.Add(Me.txtNamaGbr)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.pctGbr)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.cmbstatuskerja)
        Me.Controls.Add(Me.cmbstatuskaryawan)
        Me.Controls.Add(Me.txtpttrakhir)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.cmbpendidikanakhir)
        Me.Controls.Add(Me.cmbkewarganegaraan)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.cmbagama)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtjabatan)
        Me.Controls.Add(Me.txtbagian)
        Me.Controls.Add(Me.txtgaji)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txttempatlahir)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtnik)
        Me.Name = "Insert_Data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tambah_karyawan"
        CType(Me.pctGbr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtgaji As System.Windows.Forms.TextBox
    Friend WithEvents txtbagian As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents cmbagama As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbkewarganegaraan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbpendidikanakhir As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpttrakhir As System.Windows.Forms.TextBox
    Friend WithEvents cmbstatuskaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatuskerja As System.Windows.Forms.ComboBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents pctGbr As System.Windows.Forms.PictureBox
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents txtNamaGbr As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
