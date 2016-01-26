Public Module _01_07_Unterprogramme_und_Funktionen
    ''' <summary>
    ''' Berechnet den Abstand vom Nullpunkt
    ''' </summary>
    ''' <param name="a"></param>
    ''' <returns></returns>
    Public Function Length(a As Point) As Double
        Return Math.Sqrt(a.X * a.X + a.Y * a.Y)
    End Function

    ''' <summary>
    ''' Prüft zwei Punkte auf Identität
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <param name="delta">maximal, durch Unschärfe bedingter Abstand für zwei identische Punkte</param>
    ''' <returns></returns>
    Public Function Equal(a As Point, b As Point, delta As Double) As Boolean
        Dim diff As New Point() With { _
             .X = a.X - b.X, _
             .Y = a.Y - b.Y _
        }

        Return delta > Length(diff)

    End Function

    ''' <summary>
    ''' Addition von zwei Punkten, realisiert als Funktion
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    Public Function Add(a As Point, b As Point) As Point
        Return New Point() With { _
             .X = a.X + b.X, _
             .Y = a.Y + b.Y _
        }
    End Function

    ''' <summary>
    ''' Umrechnung, als Funktion implementiert, wodurch der Aufruf zu einem Ausdruck wird
    ''' </summary>
    ''' <param name="r"></param>
    ''' <param name="phi_in_rad"></param>
    ''' <returns></returns>
    Public Function PolarToCartesian(r As Double, phi_in_rad As Double) As Point
        'Return New Point() With { _
        '     .X = r * Math.Sin(phi_in_rad), _
        '     .Y = r * Math.Cos(phi_in_rad) _
        '}

        'Dim p As New Point(99, 33)
        Dim p As New Point
        'Dim pArr(5) As Point
        'Dim pArr2 As Point()
        p.X = r * Math.Sin(phi_in_rad)
        p.Y = r * Math.Cos(phi_in_rad)

        Return p
    End Function

    ''' <summary>
    ''' Alternative Umrechung von Polar- in Kartesischsche Koordinaten - realisiert als Unterprogramm
    ''' </summary>
    ''' <param name="r"></param>
    ''' <param name="phi_in_rad"></param>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    Public Sub PolarToCartesian(ByVal r As Double, phi_in_rad As Double, ByRef x As Double, ByRef y As Double)
        x = r * Math.Sin(phi_in_rad)
        y = r * Math.Cos(phi_in_rad)
    End Sub

    ''' <summary>
    ''' Achtung: Referenztypen werden immer "ByRef" übergeben
    ''' </summary>
    ''' <param name="r"></param>
    ''' <param name="phi_in_rad"></param>
    ''' <param name="p"></param>
    ''' <remarks></remarks>
    Public Sub PolarToCartesian(ByVal r As Double, phi_in_rad As Double, p As Point)
        p.X = r * Math.Sin(phi_in_rad)
        p.Y = r * Math.Cos(phi_in_rad)
    End Sub

    ''' <summary>
    ''' Demo Paramarray
    ''' </summary>
    ''' <param name="summanden"></param>
    ''' <returns></returns>
    Public Function Sum(ParamArray summanden As Double()) As Double
        Dim _sum As Double = 0

        For Each s As Double In summanden
            _sum += s
        Next

        Return _sum
    End Function

    ''' <summary>
    ''' Vor dem Param- Array dürfen noch weitere Paramter stehen. Hier factor.
    ''' </summary>
    ''' <param name="factor"></param>
    ''' <param name="summanden"></param>
    ''' <returns></returns>
    Public Function MulSum(factor As Double, ParamArray summanden As Double()) As Double
        Dim _sum As Double = 0

        For Each s As Double In summanden
            _sum += s
        Next

        Return factor * _sum
    End Function

    ''' <summary>
    ''' Funktion zum demonsiteren benannter Parameter
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <param name="DiameterInKm"></param>
    ''' <param name="GravityInMeterPerSec"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CreatePlanet(Name As String, DiameterInKm As Double, GravityInMeterPerSec As Double) As Planet
        Return New Planet With { _
            .Name = Name, _
            .DiameterInKm = DiameterInKm, _
            .GravityInMeterPerSec = GravityInMeterPerSec _
        }
    End Function


    Public Function Terraforming(p As Planet) As Planet
        p.GravityInMeterPerSec = 9.81
        Return p
    End Function

    ''' <summary>
    ''' Kombination aus benannten Parametern und Optionalen Parametern
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <param name="DiameterInKm"></param>
    ''' <param name="GravityInMeterPerSec"></param>
    ''' <param name="Zentralkörper"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CreatePlanet2(Name As String, DiameterInKm As Double, GravityInMeterPerSec As Double, Optional Zentralkörper As String = "Sonne") As Planet
        Return New Planet With { _
            .Name = Name, _
            .DiameterInKm = DiameterInKm, _
            .GravityInMeterPerSec = GravityInMeterPerSec _
        }
    End Function

    ''' <summary>
    ''' Beispielprogramm mit Optionalen Paramter
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <param name="Unit"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Meter(Value As Double, Optional Unit As EnumUnitLength = EnumUnitLength.Meter) As Double

        Select Case Unit
            Case EnumUnitLength.Centimeter
                Return Value / 100
            Case EnumUnitLength.Decimeter
                Return Value / 10
            Case EnumUnitLength.Kilometer
                Return Value * 1000
            Case EnumUnitLength.Meter
                Return Value
            Case EnumUnitLength.Millimeter
                Return Value / 1000
            Case EnumUnitLength.AU
                Return Value * 149597870700
            Case Else
                Throw New IndexOutOfRangeException("Unbekannte Wegeinheit " & Unit)
        End Select

    End Function

    ''' <summary>
    ''' Beispielprogramm mit Optionalen Paramter
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <param name="Unit"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Kilometer(Value As Double, Optional Unit As EnumUnitLength = EnumUnitLength.Kilometer) As Double

        Return Meter(Value, Unit) / 1000

    End Function

    ''' <summary>
    ''' Beispielprogramm mit Optionalen Paramter
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <param name="Unit"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Millimeter(Value As Double, Optional Unit As EnumUnitLength = EnumUnitLength.Millimeter) As Double

        Return Meter(Value, Unit) * 1000

    End Function

    ''' <summary>
    ''' Beispielprogramm mit Optionalen Paramter
    ''' AU ist die astronomische Einheit = Abstand Erde Sonne
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <param name="Unit"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AU(Value As Double, Optional Unit As EnumUnitLength = EnumUnitLength.AU) As Double

        Return Meter(Value, Unit) / 149597870700.0

    End Function


End Module
