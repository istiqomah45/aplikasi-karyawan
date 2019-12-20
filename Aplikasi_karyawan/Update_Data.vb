Public Class Update_Data

    Private Sub edit_karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call update_karyawan()
    End Sub

    Sub update_karyawan()
        txtnik.Enabled = False
        Call konek()
        cmd = New Odbc.OdbcCommand("SELECT* FROM t_karyawan WHERE nik='" & txtnik.Text & "'", conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtnama.Text = rd(1).ToString
            txttempatlahir.Text = rd(2).ToString
            DateTimePicker1.Text = rd(3).ToString
            cmbagama.Text = rd(4).ToString
            cmbstatus.Text = rd(5).ToString
            cmbkewarganegaraan.Text = rd(6).ToString
            txtnohp.Text = rd(7).ToString
            txtemail.Text = rd(8).ToString
            txtalamat.Text = rd(9).ToString
            cmbpendidikanakhir.Text = rd(10).ToString
            txtpttrakhir.Text = rd(11).ToString
            txtjabatan.Text = rd(12).ToString
            DateTimePicker2.Text = rd(13).ToString
            txtbagian.Text = rd(14).ToString
            txtgaji.Text = rd(15).ToString
            cmbstatuskaryawan.Text = rd(16).ToString
            cmbstatuskerja.Text = rd(17).ToString
        Else
            Exit Sub
            MsgBox("Tidak ditemukan")
        End If

    End Sub


    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Call konek()
        strcon = "UPDATE t_karyawan SET nama='" & txtnama.Text & "'," & _
                "tempat_lahir = '" & txttempatlahir.Text & "'," & _
                "tgl_lahir = '" & DateTimePicker1.Text & "'," & _
                "agama = '" & cmbagama.Text & "'," & _
                "status = '" & cmbstatus.Text & "'," & _
                "kewarganegaraan = '" & cmbkewarganegaraan.Text & "'," & _
                "no_hp = '" & txtnohp.Text & "'," & _
                "email = '" & txtemail.Text & "'," & _
                "alamat = '" & txtalamat.Text & "'," & _
                "pendidikan_terakhir = '" & cmbpendidikanakhir.Text & "'," & _
                "pt_terakhir = '" & txtpttrakhir.Text & "'," & _
                "jabatan = '" & txtjabatan.Text & "'," & _
                "tgl_masuk = '" & DateTimePicker2.Text & "'," & _
                "bagian = '" & txtbagian.Text & "'," & _
                "gaji = '" & txtgaji.Text & "'," & _
                "status_karyawan = '" & cmbstatuskaryawan.Text & "'," & _
                "status_kerja = '" & cmbstatuskerja.Text & "'" & _
                "WHERE nik ='" & txtnik.Text & "'"

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Sudah Diupdate", MsgBoxStyle.Information)

    End Sub
    Sub datauser()
        da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn)
        ds = New DataSet
        da.Fill(ds, "t_karyawan")
        Form1.DataGridView1.DataSource = ds.Tables("t_karyawan")
        Form1.DataGridView1.ReadOnly = True
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        Form1.Show()
        Call datauser()
    End Sub
End Class