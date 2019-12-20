Imports CrystalDecisions.CrystalReports.Engine

Public Class rekapGaji

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Dim Report_detail As New ReportDocument
        Report_detail.Load("..\..\CrystalReport2.rpt")

        Report_detail.SetParameterValue("dari", dtpDari.Text)
        Report_detail.SetParameterValue("sampai", dtpSampai.Text)

        frm_CetakRekapGaji.CrystalReportViewer1.ReportSource = Report_detail
        frm_CetakRekapGaji.CrystalReportViewer1.Refresh()
        frm_CetakRekapGaji.Show()
    End Sub
End Class