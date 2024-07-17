Namespace OOP
	Public Class Worker
		Public Name, Address As String

		Public Sub New(ByVal name As String, ByVal address As String)
			Me.Name = name
			Me.Address = address
		End Sub

		Public Overridable Sub Write()
			Console.WriteLine(vbCrLf & $"Nama: {Name} " & vbCrLf & $"Alamat: {Address}")
		End Sub

	End Class
End NameSpace