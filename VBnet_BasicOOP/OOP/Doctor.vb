Namespace OOP
	Public Class Doctor
		Inherits Worker

		Public Property Salary() As Integer

		Public Sub New(name As String, address As String)
			MyBase.New(name, address)
		End Sub

		Public Overrides Sub Write()
			MyBase.Write()
			Console.WriteLine($"Gaji: {Salary}")
		End Sub
	End Class
End NameSpace