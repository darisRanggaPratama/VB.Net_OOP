Namespace OOP
	Public Interface ICircle
		Function HitungVolume() As Double
		Function HitungPermukaan() As Double
	End Interface

	Public Class Bola
		Implements ICircle

		Private _jari As Double

		Public Sub New(ByVal jari As Double)
			_jari = jari
		End Sub

		Public Function HitungPermukaan() As Double Implements ICircle.HitungPermukaan
			Return 4 * (22 / 7) * _jari ^ 2
		End Function

		Public Function HitungVolume() As Double Implements ICircle.HitungVolume
			Return (4 / 3) * (22 / 7) * _jari ^ 3
		End Function
	End Class

	Public Class Tabung
		Implements ICircle

		Private _jari As Double
		Private _tinggi As Double

		Public Sub New(ByVal jari As Double, ByVal tinggi As Double)
			_jari = jari
			_tinggi = tinggi
		End Sub

		Public Function HitungVolume() As Double Implements ICircle.HitungVolume
			Return (22 / 7) * _jari ^ 2 * _tinggi
		End Function

		Public Function HitungPermukaan() As Double Implements ICircle.HitungPermukaan
			Return 2 * (22 / 7) * _jari * (_jari + _tinggi)
		End Function
	End Class
End NameSpace