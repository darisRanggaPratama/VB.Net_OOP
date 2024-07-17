' Base class with a method that calculates the area of a shape
Namespace OOP
	Public Class Shape
		Public Overridable Function CalculateArea() As Double
			Return 0
		End Function
	End Class

' Derived class that inherits from Shape and overrides the CalculateArea method
	Public Class Square
		Inherits Shape
		Private _sideLength As Double

		Public Sub New(ByVal sideLength As Double)
			_sideLength = sideLength
		End Sub

		Public Overrides Function CalculateArea() As Double
			Return _sideLength * _sideLength
		End Function
	End Class

' Another derived class that inherits from Shape and overloads the CalculateArea method
	Public Class Circle
		Inherits Shape
		Private _radius As Double

		Public Sub New(ByVal radius As Double)
			_radius = radius
		End Sub

		Public Overloads Function CalculateArea() As Double
			Return (22 / 7) * _radius * _radius
		End Function

		Public Overloads Function CalculateArea(ByVal height As Double) As Double
			Return (22 / 7) * _radius * _radius * height
		End Function
	End Class

End NameSpace