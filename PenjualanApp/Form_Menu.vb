Public Class Form_Menu
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		End
	End Sub

	Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
		Form_Barang.ShowDialog()
	End Sub

	Private Sub btnLapHarian_Click(sender As Object, e As EventArgs) Handles btnLapHarian.Click
		Form_Lap_Jual_Harian.ShowDialog()
	End Sub

	Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
		Form_Penjualan.ShowDialog()
	End Sub

	Private Sub btnLapBulanan_Click(sender As Object, e As EventArgs) Handles btnLapBulanan.Click
		Form_Lap_Jual_Bulan.ShowDialog()
	End Sub

	Private Sub btnLapTahunan_Click(sender As Object, e As EventArgs) Handles btnLapTahunan.Click
		Form_Lap_Jual_Tahun.ShowDialog()
	End Sub

	Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

	End Sub

	Private Sub btnLapBarang_Click(sender As Object, e As EventArgs) Handles btnLapBarang.Click
		Form_Lap_Barang.ShowDialog()
	End Sub
End Class