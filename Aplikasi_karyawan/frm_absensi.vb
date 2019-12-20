Imports System.Data.Odbc

Public Class frm_absensi

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTglSekarang.Text = Format(Now, "yyyy-MM-dd")
        lblJamSekarang.Text = Format(Now, "HH:mm:ss")

    End Sub

    Private Sub txtNik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNik.KeyPress
        Dim jam_masuk, jam_kerja As DateTime
        Dim jam_pulang As String
        Dim a1, a2 As String
        Dim tgl As String
        If (e.KeyChar = Chr(13)) Then
            konek()
            strcon = "select * from t_karyawan where nik='" & txtNik.Text & "'"
            cmd = New Odbc.OdbcCommand(strcon, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                lblNIK.Text = rd.Item("nik")
                PictureBox1.ImageLocation = rd.Item("lokasi_gambar")
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                '=================Code Simpan============================================'
                jam_masuk = Format(Now, "HH:mm:ss")
                jam_kerja = "07:00:00"

                a1 = Format(Now, "HH:mm:ss")
                a2 = "07:00:00"

                jam_pulang = Format(Now, "HH:mm:ss")
                tgl = Format(Now, "yyyy-MM-dd")
                Dim selisih As TimeSpan = New TimeSpan
                selisih = jam_masuk - jam_kerja

                lblInfo.Text = selisih.ToString

                strcon = "Insert into absen (id_absen,nik,jam_masuk,jam_kerja,tgl_kerja,jam_pulang,telat_masuk)values(?,?,?,?,?,?,?)"
                Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
                With mycomm.Parameters
                    .Add("?", OdbcType.VarChar, 20).Value = Microsoft.VisualBasic.Left(txtNik.Text, 3) & Format(Now, "yyMMdd-HHmmss")
                    .Add("?", OdbcType.VarChar, 20).Value = txtNik.Text.Trim
                    .Add("?", OdbcType.VarChar, 15).Value = a1
                    .Add("?", OdbcType.VarChar, 15).Value = a2
                    .Add("?", OdbcType.Date).Value = tgl
                    .Add("?", OdbcType.VarChar, 15).Value = jam_pulang
                    .Add("?", OdbcType.VarChar, 10).Value = selisih.ToString
                End With

                mycomm.ExecuteNonQuery()
                mycomm = Nothing
                MsgBox("Menyimpan", MsgBoxStyle.MsgBoxSetForeground, "save")
                '========================End Kode====================================='
            Else
                txtNik.Clear()
                PictureBox1.Hide()
            End If
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub txtNik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNik.TextChanged
        
    End Sub

    Private Sub lblInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInfo.Click

    End Sub
End Class