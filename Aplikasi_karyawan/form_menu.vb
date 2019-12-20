Public Class form_menu

    Private Sub DataKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub LemburToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LemburToolStripMenuItem.Click
        Form_lembur.Show()
    End Sub

    Private Sub JabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JabatanToolStripMenuItem.Click
        Form_Jabatan.Show()
    End Sub

    Private Sub GajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GajiToolStripMenuItem.Click
        Form_gaji.Show()
    End Sub

    Private Sub JabatanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JabatanToolStripMenuItem1.Click
        frm_cetak_jabatan.Show()
    End Sub

    Private Sub RekapGajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RekapGajiToolStripMenuItem.Click
        rekapGaji.Show()
    End Sub

    Private Sub AbsenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsenToolStripMenuItem.Click
        frm_absensi.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class