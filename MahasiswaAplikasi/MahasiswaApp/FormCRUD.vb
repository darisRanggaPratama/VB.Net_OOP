Imports System.Data.Odbc

Public Class form_crud
	Dim connect As OdbcConnection
	Dim cmd As OdbcCommand
	Dim dataSet As DataSet
	Dim dataAdapt As OdbcDataAdapter
	Dim dataRead As OdbcDataReader
	Dim myDB As String

	Sub connecting()
		myDB = "Driver={MySQL ODBC 8.0 Unicode Driver};Database=db_kampus;Server=localhost;User=rangga;Password=rangga;Option=3;"
		connect = New OdbcConnection(myDB)
		If connect.State = ConnectionState.Closed Then connect.Open()
	End Sub

	Private Sub form_crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call KondisiAwal()
	End Sub

	Sub KondisiAwal()
		txtNIM.Text = ""
		txtNama.Text = ""
		txtAlamat.Text = ""
		txtHP.Text = ""

		txtNIM.Enabled = False
		txtNama.Enabled = False
		txtAlamat.Enabled = False
		txtHP.Enabled = False

		txtNIM.MaxLength = 6

		btnSave.Text = "INPUT"
		btnEdit.Text = "EDIT"
		btnDelete.Text = "DELETE"
		btnClose.Text = "EXIT"

		btnSave.Enabled = True
		btnEdit.Enabled = True
		btnDelete.Enabled = True
		btnClose.Enabled = True

		Call connecting()
		dataAdapt = New OdbcDataAdapter("SELECT * FROM mahasiswa", connect)
		dataSet = New DataSet
		dataAdapt.Fill(dataSet, "mahasiswa")
		gridViewMahasiswa.DataSource = dataSet.Tables("mahasiswa")
	End Sub

	Sub ActivateField()
		txtNIM.Enabled = True
		txtNama.Enabled = True
		txtAlamat.Enabled = True
		txtHP.Enabled = True
		txtNIM.Focus()
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		If btnSave.Text = "INPUT" Then
			btnSave.Text = "SAVE"
			btnEdit.Enabled = False
			btnDelete.Enabled = False
			btnClose.Text = "CANCEL"
			Call ActivateField()
		Else
			If txtNIM.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or txtHP.Text = "" Then
				MessageBox.Show("Isi semua kolom")
			Else
				Call connecting()
				Dim inputData As String = "INSERT INTO mahasiswa VALUES ('" & txtNIM.Text & "', '" & txtNama.Text & "', '" & txtAlamat.Text & "', '" & txtHP.Text & "')"
				cmd = New OdbcCommand(inputData, connect)
				cmd.ExecuteNonQuery()
				MessageBox.Show("Input data berhasil")
				Call KondisiAwal()
			End If
		End if
	End Sub

	Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
		If txtNIM.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or txtHP.Text = "" Then
			MessageBox.Show("Isi semua kolom")
		Else
			Call connecting()
			Dim editData As String = "UPDATE mahasiswa SET nama = '" & txtNama.Text & "', alamat = '" & txtAlamat.Text & "', nohp = '" & txtHP.Text & "' WHERE nim = '" & txtNIM.Text & "'"
			cmd = New OdbcCommand(editData, connect)
			cmd.ExecuteNonQuery()
			MessageBox.Show("Edit data berhasil")
			Call KondisiAwal()
		End If
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		If txtNIM.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or txtHP.Text = "" Then
			MessageBox.Show("Data yang dihapus tidak boleh kosong")
		Else
			Call connecting()
			Dim deleteData As String = "DELETE FROM mahasiswa WHERE nim = '" & txtNIM.Text & "'"
			cmd = New OdbcCommand(deleteData, connect)
			cmd.ExecuteNonQuery()
			MessageBox.Show("Data berhasil dihapus")
			Call KondisiAwal()
		End If
	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		If btnClose.Text = "EXIT" Then
			End
		Else
			call KondisiAwal()
		End If
	End Sub

	Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
		If e.KeyChar = Convert.ToChar(Keys.Enter) Then
			Call connecting()
			cmd = New OdbcCommand("SELECT * FROM mahasiswa WHERE nim = '" & txtNIM.Text & "'", connect)
			dataRead = cmd.ExecuteReader()
			dataRead.Read()
			If dataRead.HasRows Then
				txtNama.Text = dataRead.Item("nama")
				txtAlamat.Text = dataRead.Item("alamat")
				txtHP.Text = dataRead.Item("nohp")
			Else
				MessageBox.Show("Data tidak ada")
			End If
		End If
	End Sub

	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		FormSearch.ShowDialog()
	End Sub
End Class
