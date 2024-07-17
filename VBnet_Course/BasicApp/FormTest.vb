Public Class formTest
	Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
		MsgBox("Hello Universe")

		dim name As string
		name = InputBox("Insert your name:")

		MessageBox.Show($"Your name {name}")

		Dim salary As Integer
		salary = txtSalary.Text

		MessageBox.Show($"Your Salary {salary}")

		Dim mark As String
		mark = listLaptop.SelectedItem

		MessageBox.Show($"You Laptop {mark}")

	End Sub

	Private Sub formTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		listLaptop.Items.Add("Fujitsu")
		listLaptop.Items.Add("Toshiba")
		listLaptop.Items.Add("Gateway")


	End Sub
End Class
