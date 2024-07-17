Imports System.Data.OleDb

Public Class Form_Barang
	Sub tampil_barang()
		cmd = New OleDbCommand("SELECT * FROM tbl_barang", conn)
		rd = cmd.ExecuteReader
		dataGridViewBarang.Rows.Clear()
		Do While rd.Read = True
			dataGridViewBarang.Rows.Add(
				rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
		Loop

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub Form_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call koneksi()
		Call tampil_barang()
	End Sub

	Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
		cmd = New OleDbCommand("SELECT * FROM tbl_barang WHERE nama_barang LIKE '%" & txtSearch.Text & "%'", conn)
		rd = cmd.ExecuteReader
		dataGridViewBarang.Rows.Clear()
		Do While rd.Read = True
			dataGridViewBarang.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
		Loop
	End Sub

	Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
		Form_Input_Barang.ShowDialog()
	End Sub


End Class