Imports System.Data.OleDb

Public Class Form_Input_Barang
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		Call clear()
	End Sub

	Sub clear
		txtKodeBarang.Clear()
		txtNamaBarang.Clear()
		txtHargaBeli.Clear()
		txtHargaJual.Clear()
		txtStok.Clear()
		cboxJenis.Text = ""
		cboxSatuan.Text = ""
		txtKodeBarang.Focus()
	End Sub

	Private Sub Form_Input_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call koneksi()
		Call clear()
		txtKodeBarang.Focus()
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHargaBeli.Text = "" Or txtHargaJual.Text = "" Or txtStok.Text = "" Or cboxJenis.Text = "" Or cboxSatuan.Text = "" then
			MessageBox.Show("Semua Data wajib diisi!")
		Else
			' Cek data ke database apakah kode barang sudah ada
			cmd = New OleDbCommand("SELECT * FROM tbl_barang WHERE kode_barang = '" & txtKodeBarang.Text & "' ", conn)
			rd = cmd.ExecuteReader
			rd.Read()
			If rd.HasRows = False Then
				' Simpan data ke database
				cmd = New OleDbCommand("INSERT INTO tbl_barang VALUES('" & txtKodeBarang.Text & "', '" & txtNamaBarang.Text & "', '" & cboxJenis.Text & "', '" & cboxSatuan.Text & "', '" & txtHargaBeli.Text & "', '" & txtHargaJual.Text & "', '" & txtStok.Text & "')", conn)
				cmd.ExecuteNonQuery()
				MessageBox.Show("Saving data successfully.")
				Call clear()
				Call Form_Barang.tampil_barang()
			Else
				' Edit data berdasarkan kode barang
				cmd = New OleDbCommand("UPDATE tbl_barang SET nama_barang = '" & txtNamaBarang.Text & "', jenis_barang = '" & cboxJenis.Text & "', satuan_barang = '" & cboxSatuan.Text & "', harga_beli = '" & txtHargaBeli.Text & "', harga_jual = '" & txtHargaJual.Text & "', stok = '" & txtStok.Text & "' WHERE kode_barang = '" & txtKodeBarang.Text & "'", conn)
				cmd.ExecuteNonQuery()
				MessageBox.Show("Update data successfully")
				Call clear()
				Call Form_Barang.tampil_barang()

			End If

		End If
	End Sub

	Private Sub txtKodeBarang_TextChanged(sender As Object, e As EventArgs) Handles txtKodeBarang.TextChanged
		' Ambil nama barang berdasarkan kode barang
		cmd = New OleDbCommand("SELECT * FROM tbl_barang WHERE kode_barang = '" & txtKodeBarang.Text & "'", conn)
		rd = cmd.ExecuteReader
		rd.Read()
		If rd.HasRows = True Then
			txtNamaBarang.Text = rd(1)
			cboxJenis.Text = rd(2)
			cboxSatuan.Text = rd(3)
			txtHargaBeli.Text = rd(4)
			txtHargaJual.Text = rd(5)
			txtStok.Text = rd(6)
		Else
			txtNamaBarang.Clear()
			cboxJenis.Text = ""
			cboxJenis.Text = ""
			txtHargaBeli.Clear()
			txtHargaJual.Clear()
			txtStok.Clear()
		End If
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		If MessageBox.Show("Yakin, hapus data?", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
			cmd = New OleDbCommand("DELETE FROM tbl_barang WHERE kode_barang = '" & txtKodeBarang.Text & "'", conn)
			cmd.ExecuteNonQuery()
			MessageBox.Show("Delete record successfully")
			Call clear()
			Call Form_Barang.tampil_barang()
		End If
	End Sub
End Class