Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form_Lap_Jual_Tahun
	Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
		Try
			Dim cryRpt As New ReportDocument
			Dim cryTableLogonInfos As New TableLogOnInfos
			Dim cryTableLogonInfo As New TableLogOnInfo
			Dim cryConnectInfo As New ConnectionInfo
			Dim cryTables As Tables
			Dim cryTable As Table
			Dim lapBarang As new Lap_Jual_Tahun

			cryRpt = lapBarang
			With cryConnectInfo
				.ServerName = Application.StartupPath & "\db_penjualan.accdb"
				.DatabaseName = Application.StartupPath & "\db_penjualan.accdb"
				.UserID = ""
.Password = ""
			End With

			cryTables = cryRpt.Database.Tables
			For each cryTable In cryTables
				cryTableLogonInfo = cryTable.LogOnInfo
				cryTableLogonInfo.ConnectionInfo = cryConnectInfo
cryTable.ApplyLogOnInfo(cryTableLogonInfo)
Next
			crystalTahun.SelectionFormula = "Year({tbl_jual.tgl_jual})="& Val(comTahun.Text)
			crystalTahun.ReportSource = cryRpt
			crystalTahun.Refresh()
			crystalTahun.RefreshReport()
		Catch ex As Exception
			MessageBox.Show("Fail to load report: " & ex.ToString)
		End Try
	End Sub

	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
		crystalTahun.PrintReport()
	End Sub

	Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
		crystalTahun.ExportReport()
	End Sub
End Class