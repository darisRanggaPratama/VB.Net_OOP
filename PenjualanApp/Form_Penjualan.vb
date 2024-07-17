Imports System.Data.OleDb

Public Class Form_Penjualan
	Sub noFaktur()
		cmd = New OleDbCommand("SELECT * FROM tbl_jual WHERE faktur_jual IN (SELECT MAX(faktur_jual) FROM tbl_jual) ORDER BY faktur_jual DESC", conn)
		rd = cmd.ExecuteReader()
		rd.Read()
		If Not rd.HasRows Then
			txtNoFaktur.Text = Format(Now, "yyMMdd") + "0001"
		Else
			If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
				txtNoFaktur.Text = Format(Now, "yyMMdd") + "0001"
			Else
				txtNoFaktur.Text = rd.Item("faktur_jual") + 1
			End If
		End If
	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub Form_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call koneksi()
		Call noFaktur()
		txtKodeBarang.Focus()
		txtDibayar.Text = 0
		txtKembalian.Text = 0
		Call grandTotal()

	End Sub

	Private Sub timerJam_Tick(sender As Object, e As EventArgs) Handles timerJam.Tick
		txtTanggal.Text = Format(Now, "MM/dd/yyyy")
		txtJam.Text = Format(Now, "HH:mm:ss")
	End Sub

	Private Sub txtKodeBarang_KeyPress(sender As Object, key As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
		if key.KeyChar = ControlChars.Cr Then
			cmd = New OleDbCommand("SELECT * FROM tbl_barang WHERE kode_barang = '" & txtKodeBarang.Text & "'", conn)
			rd = cmd.ExecuteReader
			rd.Read()
			If rd.HasRows = True Then
				txtNamaBarang.Text = rd.Item("nama_barang")
				txtJenisBarang.Text = rd.Item("jenis_barang")
				txtSatuan.Text = rd.Item("satuan_barang")
				txtHargaJual.Text = rd.Item("harga_jual")
				txtQuantity.Focus()

			Else
				txtNamaBarang.Text = ""
				txtJenisBarang.Text = ""
				txtSatuan.Text = ""
				txtHargaJual.Text = ""
				txtKodeBarang.Focus()
				MessageBox.Show("Kode barang tidak ditemukan di database")
			End If
		End If
	End Sub

	Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
		Try
			txtTotalHarga.Text = Val(txtHargaJual.Text) * Val(txtQuantity.Text)
		Catch ex As Exception
			txtTotalHarga.Text = ""
		End Try
	End Sub

	Private Sub txtQuantity_KeyPress(sender As Object, key As KeyPressEventArgs) Handles txtQuantity.KeyPress

		If key.KeyChar = ControlChars.Cr Then
			dataGridViewPenjualan.VirtualMode = False
			dataGridViewPenjualan.Rows.Add(txtKodeBarang.Text, txtNamaBarang.Text, txtJenisBarang.Text, txtSatuan.Text, txtHargaJual.Text, txtQuantity.Text, txtTotalHarga.Text)
			Call bersihBarang()
			Call grandTotal()
		End If

	End Sub

	Sub bersihBarang()
		txtKodeBarang.Text = ""
		txtNamaBarang.Text = ""
		txtJenisBarang.Text = ""
		txtSatuan.Text = ""
		txtHargaJual.Text = ""
		txtQuantity.Text = ""
		txtTotalHarga.Text = ""
		txtKodeBarang.Focus()
	End Sub

	Sub grandTotal()
		Dim jumlah As Decimal = 0
		For i as integer = 0 to dataGridViewPenjualan.Rows.Count - 1
			jumlah = jumlah + dataGridViewPenjualan.Rows(i).Cells(6).Value
			txtGrandTotal.Text = jumlah
		Next
		If txtGrandTotal.Text = "" Then
			txtGrandTotal.Text = 0
		End If
	End Sub

	Private Sub txtDibayar_TextChanged(sender As Object, e As EventArgs) Handles txtDibayar.TextChanged
		Try
			txtKembalian.Text = Val(txtDibayar.Text) - Val(txtGrandTotal.Text)
		Catch ex As Exception
			txtKembalian.Text = 0
		End Try
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		If txtGrandTotal.Text = 0 Then
			MessageBox.Show("Tidak ada transaksi/ data diinput")
		Else If val(txtDibayar.Text) < Val(txtGrandTotal.Text) then
			MessageBox.Show("Kurang dibayar")
		Else
			' Save data ke table barang
			Call koneksi()
			cmd = New OleDbCommand("INSERT INTO tbl_jual(faktur_jual, tgl_jual, jam, grand_total, dibayar, kembalian, kasir) VALUES('" & txtNoFaktur.Text & "', '" & txtTanggal.Text & "', '" & txtJam.Text & "', '" & txtGrandTotal.Text & "', '" & txtDibayar.Text & "', '" & txtKembalian.Text & "', '" & txtKasir.Text & "')", conn)
			cmd.ExecuteNonQuery()
			' Save detail transaction
			For baris As Integer = 0 To dataGridViewPenjualan.Rows.Count - 2
				cmd = New OleDbCommand("INSERT INTO tbl_rinci_jual VALUES('" & txtNoFaktur.Text & "', '" & dataGridViewPenjualan.Rows(baris).Cells(0).Value & "', '" & dataGridViewPenjualan.Rows(baris).Cells(5).Value & "', '" & dataGridViewPenjualan.Rows(baris).Cells(6).Value & "' )", conn)
				cmd.ExecuteNonQuery()
				' Pengurangan Stok barang
				cmd = New OleDbCommand("SELECT * FROM tbl_barang WHERE kode_barang = '" & dataGridViewPenjualan.Rows(baris).Cells(0).Value & "'", conn)
				rd = cmd.ExecuteReader()
				rd.Read()
				If rd.HasRows = True Then
					cmd = New OleDbCommand("UPDATE tbl_barang SET stok = '" & rd.Item("stok") - Val(dataGridViewPenjualan.Rows(baris).Cells(5).Value) & "' WHERE kode_barang = '" & dataGridViewPenjualan.Rows(baris).Cells(0).Value & "'", conn)
					cmd.ExecuteNonQuery()
				End If
			Next
			' Clear transaction record
			MessageBox.Show("Save transaction record")
			dataGridViewPenjualan.Rows.Clear()
			txtGrandTotal.Text = "0"
			txtDibayar.Text = "0"
			txtKembalian.Text = "0"
			Call noFaktur()
			Call bersihBarang()
		End If
	End Sub

	Private Sub dataGridViewPenjualan_KeyPress(sender As Object, key As KeyPressEventArgs) Handles dataGridViewPenjualan.KeyPress
		If key.KeyChar = Chr(27) Then 'Chr(27) kode ASCII escape
			dim baris As Integer
			baris = dataGridViewPenjualan.CurrentCell.RowIndex
			Try
				dataGridViewPenjualan.Rows.RemoveAt(baris)
				Call grandTotal()
			Catch ex As Exception
				MessageBox.Show("Tidak dapat hapus baris transaksi")
			End Try
		End If
	End Sub
End Class