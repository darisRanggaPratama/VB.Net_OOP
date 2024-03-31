' Abstract class
Public MustInherit Class Shapes
    Public MustOverride Function CalculateArea() As Double ' Metode abstrak untuk menghitung luas
    Public MustOverride Function CalculatePerimeter() As Double ' Metode abstrak untuk menghitung keliling
End Class

' Kelas turunan yang mengimplementasikan Abstract Class
Public Class Rectangle
    Inherits Shapes

    Private _length As Double
    Private _width As Double

    Public Sub New(ByVal length As Double, ByVal width As Double)
        _length = length
        _width = width
    End Sub

    Public Overrides Function CalculateArea() As Double
        Return _length * _width
    End Function

    Public Overrides Function CalculatePerimeter() As Double
        Return 2 * (_length + _width)
    End Function
End Class

' Kelas turunan lain yang mengimplementasikan Abstract Class
Public Class Circles
    Inherits Shapes

    Private _radius As Double

    Public Sub New(ByVal radius As Double)
        _radius = radius
    End Sub

    Public Overrides Function CalculateArea() As Double
        Return (22 / 7) * _radius * _radius
    End Function

    Public Overrides Function CalculatePerimeter() As Double
        Return 2 * (22 / 7) * _radius
    End Function
End Class



