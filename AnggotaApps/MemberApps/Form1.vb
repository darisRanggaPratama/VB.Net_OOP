Imports System.Data.Odbc

Public Class formMember
	Dim connect As OdbcConnection
		Dim dataAdapt as OdbcDataAdapter
		Dim dataSet As DataSet
		Dim myDB As String
	Sub connecting()
		myDB = "DSN=db32local;Uid=rangga;Pwd=rangga;"
		Using connection As New OdbcConnection(myDB)
			Try
				connect = New OdbcConnection(myDB)
				connection.Open()
				Console.WriteLine("Koneksi Berhasil")
				MessageBox.Show("database connected")
			Catch ex As Exception
				Console.WriteLine("Error: " & ex.Message)
				MessageBox.Show("Error: " & ex.Message)
			End Try
		End Using
	End Sub

	Private Sub formMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call connecting()
		dataAdapt = New OdbcDataAdapter("SELECT * FROM anggota", connect)
		dataSet = New DataSet
		dataSet.Clear()
		dataAdapt.Fill(dataSet, "anggota")
		gridMember.DataSource = (dataSet.Tables("anggota"))
	End Sub
End Class
