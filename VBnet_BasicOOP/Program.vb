Imports System.Formats.Asn1
Imports VB_BasicOOP.OOP

Module Program
	Sub Main()
		OOPrun()

	End Sub

	Private Sub OOPrun()
		KelasObjek()

		Encap()

		InheritAnimal()

		InheritOverride()

		InheritOverrideOverload()

		AbstractClass()

		InterfaceShape()
	End Sub

	Private Sub KelasObjek()
		Dim jhon As New Person("Tama", 36)

		Console.WriteLine(vbCrLf & $"Nama: {jhon.GetName()} " & vbCrLf & $"Umur : {jhon.GetAge()}")
	End Sub

	Private Sub Encap()
		Dim human As New Human()

		human.Job = "Doctor"
		human.Salary = 10000000

		Console.WriteLine(vbCrLf & $"Job: {human.Job} " & vbCrLf & $"Salary : {human.Salary}")
	End Sub

	Private Sub InheritAnimal()
		Dim animal As New Animal
		animal.Color = "black"
		Console.WriteLine(vbCrLf & $"Color: {animal.Color}")
		animal.Sound()

		Dim cat As New Cat
		cat.Color = "white"
		Console.WriteLine(vbCrLf & $"Color: {cat.Color}")
		cat.Sound()

		Dim cow As New Cow
		cow.Age = 2
		Console.WriteLine(vbCrLf & $"Age: {cow.Age}")
		cow.Sound()
	End Sub

	Private Sub InheritOverride()
		Dim worker As New Worker("Toni", "Bogor")
		worker.Write()

		Dim doctor As New Doctor("Bagas", "Jakarta")
		doctor.Salary = 7000000
		doctor.Write()
	End Sub

	Private Sub InheritOverrideOverload()
		' Example usage of the Shape, Square, and Circle classes

		Dim shape As Shape = New Shape()
		Dim square As Square = New Square(5)
		Dim circle As Circle = New Circle(7)

		Console.WriteLine(vbCrLf & "Area of shape: " & shape.CalculateArea())
		Console.WriteLine("Area of square: " & square.CalculateArea())
		Console.WriteLine("Area of circle: " & circle.CalculateArea())
		Console.WriteLine("Volume of tube: " & circle.CalculateArea(10))
	End Sub

	Private Sub AbstractClass()
		' Main class untuk menjalankan program

		Dim rectangle As New Rectangle(5, 3)
		Dim circle As New Circles(7)

		Console.WriteLine(vbCrLf & "Rectangle Area: " & rectangle.CalculateArea())
		Console.WriteLine("Rectangle Perimeter: " & rectangle.CalculatePerimeter())

		Console.WriteLine("Circle Area: " & circle.CalculateArea())
		Console.WriteLine("Circle Perimeter: " & circle.CalculatePerimeter())
	End Sub

	Private Sub InterfaceShape()
		Dim bola As New Bola(6)
		Console.WriteLine(vbCrLf & $"Volume Bola: {bola.HitungVolume()}")
		Console.WriteLine($"Luas Permukaan Bola: {bola.HitungPermukaan()}")

		Dim tabung As New Tabung(5, 10)
		Console.WriteLine(vbCrLf & $"Volume Tabung: {tabung.HitungVolume()}")
		Console.WriteLine($"Luas Permukaan Tabung: {tabung.HitungPermukaan()}")
	End Sub
End Module
