Imports System.Data.OleDb

Module Module1
	Public cmd As OleDbCommand
	Public conn As OleDbConnection
	Public rd As OleDbDataReader

	Sub koneksi()
		conn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source=db_penjualan.accdb")
		If conn.State = ConnectionState.Closed Then
			conn.Open()
		End If

		MessageBox.Show("Koneksi berhasil: " & conn.ToString)
	End Sub

End Module
