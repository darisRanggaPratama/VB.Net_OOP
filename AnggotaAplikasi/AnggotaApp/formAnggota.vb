Imports System.Data.Odbc

Public Class formAnggota
	Dim connect As OdbcConnection
	Dim dataAdapt As OdbcDataAdapter
	Dim dataSet As DataSet
	Dim myDB As String

	Sub connecting()
		'Cara lain
		'myDB = "DSN=db32local;Uid=rangga;Pwd=rangga;"
		myDB = "Driver={MySQL ODBC 8.0 Unicode Driver};Database=db_aplikasi;Server=localhost;User=rangga;Password=rangga;Option=3;"
		connect = New OdbcConnection(myDB)
		If connect.State = ConnectionState.Closed Then connect.Open()

		'cara lain
		'Using connection As New OdbcConnection(myDB)
           ' Try
               ' connection.Open()
             '   Console.WriteLine("Koneksi berhasil!")
          '  Catch ex As OdbcException
              '  Console.WriteLine("Terjadi kesalahan: " & ex.Message)
          '  End Try
        'End Using
		

	End Sub

	Private Sub formAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call connecting()
		dataAdapt = New OdbcDataAdapter("SELECT * FROM anggota",connect)
		dataSet = New DataSet
		dataSet.Clear()
		dataAdapt.Fill(dataSet, "anggota")
		dataGridAnggota.DataSource = (dataSet.Tables("anggota"))

	End Sub
End Class
