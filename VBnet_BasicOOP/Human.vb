Public Class Human
	' Contoh Encapsulation, Get, Set
	Private _job As String
	Private _salary As Integer

	Public Property Job() As String
		Get
			Return _job
		End Get
		Set(ByVal value As String)
			_job = value
		End Set
	End Property

	Public Property Salary() As Integer
		Get
			Return _salary
		End Get
		Set(ByVal value As Integer)
			If value >= 0 Then
				_salary = value
			Else
				Console.WriteLine("Salary cannot be negative/ zero")
			End If
		End Set
	End Property


End Class
