Namespace OOP
	Public Class Person
		' Contoh Class & Object
		Public Name As String
		Public Age As Integer

		Public Sub New(ByVal name As String, ByVal age As Integer)
			Me.Name = name
			Me.Age = age
		End Sub

		Public Function GetAge() As Integer
			Return Me.Age
		End Function

		Public Function GetName() As String
			Return Me.Name
		End Function
	End Class
End NameSpace