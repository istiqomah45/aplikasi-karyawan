Public Class Form_lembur

    Private Sub Form_lembur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from lembur", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "lembur")
        DataGridView1.DataSource = (ds.Tables("lembur"))

        Call lembur()
    End Sub
    Sub lembur()
        'da = New Odbc.OdbcDataAdapter("select id_jabatan from jabatan", conn)
        'ds = New DataSet
        'da.Fill(ds, "jabatan")

        'ComboBoxidjabat.DataSource = (ds.Tables("jabatan"))
        'ComboBoxidjabat.ValueMember = "id_jabatan"
        'ComboBoxidjabat.DisplayMember = "id_jabatan"



        strcon = "select id_jabatan from jabatan"
        cmd = New Odbc.OdbcCommand(strcon, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                ComboBoxidjabat.Items.Add(rd("id_jabatan"))
            Loop
        End If

    End Sub

    Sub kosongkan()
        TextBoxNIK.Clear()
        TextBoxnamakar.Clear()
        ComboBoxidjabat.Text = ""
        DateTimePicker1.Text = ""
        TextBoxjamlem.Clear()
        TextBoxUangLem.Clear()
        TextBoxTot.Clear()

    End Sub

    Private Sub ComboBoxidjabat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxidjabat.SelectedIndexChanged
        cmd = New Odbc.OdbcCommand("SELECT nama_jabatan, gaji_pokok from jabatan WHERE id_jabatan = '" & ComboBoxidjabat.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        ' If rd.HasRows Then
        '  TextBoxjamlem.Text = rd(0).ToString
        '  TextBoxUangLem.Text = rd(1).ToString
        ' End If
    End Sub
    Sub datauser()

        da = New Odbc.OdbcDataAdapter("select * from lembur", conn)
        ds = New DataSet
        da.Fill(ds, "lembur")
        DataGridView1.DataSource = ds.Tables("lembur")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Buttondel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttondel.Click
        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM gaji WHERE id_lembur& DataGridView1.CurrentRow.Cells(0).Value.ToString & " '"

            Dim cmd As New Odbc.OdbcCommand
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            conn.Close()

            Call datauser()
            MsgBox("Data Sudah Dihapus", vbInformation)
        Else
        End If
    End Sub

    Private Sub Buttonsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsave.Click
        Call konek()
        strcon = "INSERT INTO lembur " _
        + "VALUES (''," _
        + "'" & TextBoxNIK.Text & "'," _
        + "'" & TextBoxnamakar.Text & "'," _
        + "'" & ComboBoxidjabat.Text & "'," _
        + "'" & DateTimePicker1.Text & "'," _
        + "'" & TextBoxjamlem.Text & "'," _
        + "'" & TextBoxUangLem.Text & "'," _
        + "'" & TextBoxTot.Text & "')"

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        Call datauser()
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.OkOnly)
        kosongkan()
    End Sub
    Private Sub form_edit(ByVal x As Integer)
        Try
            TextBoxNIK.Text = DataGridView1.Rows(x).Cells(1).Value
            TextBoxnamakar.Text = DataGridView1.Rows(x).Cells(2).Value
            ComboBoxidjabat.Text = DataGridView1.Rows(x).Cells(3).Value
            DateTimePicker1.Text = DataGridView1.Rows(x).Cells(4).Value
            TextBoxjamlem.Text = DataGridView1.Rows(x).Cells(5).Value
            TextBoxUangLem.Text = DataGridView1.Rows(x).Cells(6).Value
            TextBoxTot.Text = DataGridView1.Rows(x).Cells(7).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Buttonedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonedit.Click
        Call konek()
        strcon = "UPDATE gaji SET nik = '" & TextBoxNIK.Text & "'," & _
        "nama_karyawan = '" & TextBoxnamakar.Text & "'," & _
        "id_jabatan = '" & ComboBoxidjabat.Text & "'," & _
        "tgl_lembur = '" & DateTimePicker1.Text & "'," & _
        "jml_lembur = '" & TextBoxjamlem.Text & "'," & _
        "uang_lembur = '" & TextBoxUangLem.Text & "'," & _
        "ttl_uang_lembur = '" & TextBoxTot.Text & "'" & _
        "WHERE id_lembur = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        Call datauser()
        MsgBox("Data Berhasil Diupdate", MsgBoxStyle.OkOnly)
        kosongkan()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        form_edit(e.RowIndex)
    End Sub

    Private Sub TextBoxNIK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNIK.KeyPress
        If (e.KeyChar = Chr(13)) Then
            konek()
            cmd = New Odbc.OdbcCommand("SELECT * FROM t_karyawan WHERE nik='" & TextBoxNIK.Text & "'", conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                TextBoxnamakar.Text = rd(1).ToString
                ComboBoxidjabat.Text = rd(12).ToString
            Else
                'exit sub
                MsgBox("Tidak Ditemukan")
                TextBoxNIK.Focus()
                TextBoxNIK.Clear()
            End If
            'textnamakar.focus()
        End If
    End Sub

    Private Sub TextBoxUangLem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxUangLem.TextChanged
        TextBoxTot.Text = Val(TextBoxjamlem.Text) * Val(TextBoxUangLem.Text)
    End Sub

    Private Sub TextBoxTot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxTot.TextChanged
        TextBoxTot.Text = Val(TextBoxjamlem.Text) * Val(TextBoxUangLem.Text)
    End Sub
End Class