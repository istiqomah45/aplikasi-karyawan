﻿
Public Class Form_gaji

    Sub auto_slip()
        Dim no_slip As String = "TR" + Format(Now, "yyMMdd-hhmmss")
        TextBoxnoslip.Text = no_slip
    End Sub


    Private Sub Form_gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call auto_slip()
        da = New Odbc.OdbcDataAdapter("select * from gaji", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "gaji")
        DataGridView1.DataSource = (ds.Tables("gaji"))

        Call jabatan()
    End Sub
    Sub jabatan()
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

    Private Sub ComboBoxidjabat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxidjabat.SelectedIndexChanged
        cmd = New Odbc.OdbcCommand("SELECT nama_jabatan, gaji_pokok from jabatan WHERE id_jabatan = '" & ComboBoxidjabat.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBoxnamajabat.Text = rd(0).ToString
            TextBoxgapok.Text = rd(1).ToString
        End If
    End Sub
    Sub kosongkan()
        TextBoxnoslip.Clear()
        TextNIK.Text = ""
        DateTimePicker1.Text = ""
        ComboBoxidjabat.Text = ""
        TextBoxnamajabat.Clear()
        TextBoxgapok.Clear()
        TextBoxtunjang.Clear()
        TextBoxlembur.Clear()
        TextBoxbpjskes.Clear()
        TextBoxbpjsket.Clear()
        TextBoxpotlain.Clear()
        TextBoxnorek.Clear()
        TextBoxnamarek.Clear()
        TextBoxbank.Clear()
        TextBoxtotal.Clear()

    End Sub
    Private Sub form_edit(ByVal x As Integer)
        Try
            TextBoxnoslip.Text = DataGridView1.Rows(x).Cells(1).Value
            TextNIK.Text = DataGridView1.Rows(x).Cells(2).Value
            DateTimePicker1.Text = DataGridView1.Rows(x).Cells(3).Value
            ComboBoxidjabat.Text = DataGridView1.Rows(x).Cells(4).Value
            TextBoxnamajabat.Text = DataGridView1.Rows(x).Cells(5).Value
            TextBoxgapok.Text = DataGridView1.Rows(x).Cells(6).Value
            TextBoxtunjang.Text = DataGridView1.Rows(x).Cells(7).Value
            TextBoxlembur.Text = DataGridView1.Rows(x).Cells(8).Value
            TextBoxbpjskes.Text = DataGridView1.Rows(x).Cells(9).Value
            TextBoxbpjsket.Text = DataGridView1.Rows(x).Cells(10).Value
            TextBoxpotlain.Text = DataGridView1.Rows(x).Cells(11).Value
            TextBoxnorek.Text = DataGridView1.Rows(x).Cells(12).Value
            TextBoxnamarek.Text = DataGridView1.Rows(x).Cells(13).Value
            TextBoxbank.Text = DataGridView1.Rows(x).Cells(14).Value
            TextBoxtotal.Text = DataGridView1.Rows(x).Cells(15).Value
        Catch ex As Exception
        End Try
    End Sub
    Sub datauser()

        da = New Odbc.OdbcDataAdapter("select * from gaji", conn)
        ds = New DataSet
        da.Fill(ds, "gaji")
        DataGridView1.DataSource = ds.Tables("gaji")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Buttonsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsave.Click
        Call konek()
        strcon = "INSERT INTO gaji " _
        + "VALUES (''," _
        + "'" & TextBoxnoslip.Text & "'," _
        + "'" & TextNIK.Text & "'," _
        + "'" & DateTimePicker1.Text & "'," _
        + "'" & ComboBoxidjabat.Text & "'," _
        + "'" & TextBoxnamajabat.Text & "'," _
        + "'" & TextBoxgapok.Text & "'," _
        + "'" & TextBoxtunjang.Text & "'," _
        + "'" & TextBoxlembur.Text & "'," _
        + "'" & TextBoxbpjskes.Text & "'," _
        + "'" & TextBoxbpjsket.Text & "'," _
        + "'" & TextBoxpotlain.Text & "'," _
        + "'" & TextBoxnorek.Text & "'," _
        + "'" & TextBoxnamarek.Text & "'," _
        + "'" & TextBoxbank.Text & "'," _
        + "'" & TextBoxtotal.Text & "')"

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        Call datauser()
        'MsgBox("Data Berhasil Disimpan", MsgBoxStyle.OkOnly)
        Dim pesan As Integer
        pesan = MsgBox("Data Berhasil Disimpan, " + "Apakah Anda akan mencetak transaksi . . ?? " + TextBoxnoslip.Text, vbExclamation + vbYesNo, "Cetak Transaksi")
        If pesan = vbNo Then
            Exit Sub
        Else
            Call cetak_slipGaji()
        End If
    End Sub
    Private Sub cetak_slipGaji()
        Form2.CrystalReportViewer1.SelectionFormula = " {gaji.nomor_slip} = '" & TextBoxnoslip.Text & "'"
        Form2.Show()
    End Sub
    Private Sub Buttonedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonedit.Click
        Call konek()
        strcon = "UPDATE gaji SET nomor_slip = '" & TextBoxnoslip.Text & "'," & _
        "nik = '" & TextNIK.Text & "'," & _
        "tgl_gaji = '" & DateTimePicker1.Text & "'," & _
        "id_jabatan = '" & ComboBoxidjabat.Text & "'," & _
        "nama_jabatan = '" & TextBoxnamajabat.Text & "'," & _
        "gaji_pokok = '" & TextBoxgapok.Text & "'," & _
        "tunjangan = '" & TextBoxtunjang.Text & "'," & _
        "lembur = '" & TextBoxlembur.Text & "'," & _
        "pot_bpjs_kes = '" & TextBoxbpjskes.Text & "'," & _
        "pot_bpjs_ket = '" & TextBoxbpjsket.Text & "'," & _
        "pot_lain = '" & TextBoxpotlain.Text & "'," & _
        "no_rekening = '" & TextBoxnorek.Text & "'," & _
        "nama_rekening = '" & TextBoxnamarek.Text & "'," & _
        "nama_bank = '" & TextBoxbank.Text & "'," & _
        "total_gaji = '" & TextBoxtotal.Text & "'" & _
        "WHERE id_gaji = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        Call datauser()
        MsgBox("Data Berhasil Diupdate", MsgBoxStyle.OkOnly)
        kosongkan()
    End Sub

    Private Sub Buttondel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttondel.Click
        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM gaji WHERE id_gaji = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

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

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        form_edit(e.RowIndex)
    End Sub

    Public Sub hitung_gaji()
        Dim jum_gaji As Integer
        Dim jum_potongan As Integer

        jum_gaji = Val(TextBoxgapok.Text) + Val(TextBoxtunjang.Text) + Val(TextBoxlembur.Text)
        jum_potongan = Val(TextBoxbpjskes.Text) + Val(TextBoxbpjsket.Text) + Val(TextBoxpotlain.Text)
        TextBoxtotal.Text = jum_gaji - jum_potongan
    End Sub

    Private Sub TextBoxgapok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxgapok.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub TextBoxtunjang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxtunjang.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub TextBoxlembur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxlembur.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub TextBoxbpjskes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxbpjskes.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub TextBoxbpjsket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxbpjsket.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub TextBoxpotlain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxpotlain.TextChanged
        Call hitung_gaji()
    End Sub
End Class