Imports System.Data.Odbc
Public Class FormSearch	
	Dim connect As OdbcConnection
	Dim cmd As OdbcCommand	
	Dim dataAdapt As OdbcDataAdapter	
	Dim myDB As String

	Sub connecting()
		myDB = "Driver={MySQL ODBC 8.0 Unicode Driver};Database=db_kampus;Server=localhost;User=rangga;Password=rangga;Option=3;"
		connect = New OdbcConnection(myDB)
		If connect.State = ConnectionState.Closed Then connect.Open()
	End Sub

	Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		FilterData("")
	End Sub

	Public sub FilterData(valueToSearch As string)
		Call connecting()
		'SELECT * FROM mahasiswa WHERE CONCAT(nim, nama, alamat) LIKE '%F%'
		Dim searchQuery As String = "SELECT * FROM mahasiswa WHERE CONCAT(nim, nama, alamat, nohp) LIKE '%" & valueToSearch & "%'"

		cmd = New OdbcCommand(searchQuery, connect)
		dataAdapt = New odbcDataAdapter(cmd)
		Dim table as New DataTable()

		dataAdapt.Fill(table)
		gridViewSearch.DataSource = table
	End sub

	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		FilterData(txtSearch.Text)
	End Sub

	Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
		FilterData(txtSearch.Text)
	End Sub
End Class