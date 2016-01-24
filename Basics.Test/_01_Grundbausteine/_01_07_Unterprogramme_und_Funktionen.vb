Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Ctx = Basics._01_07_Unterprogramme_und_Funktionen


<TestClass()> Public Class _01_07_Unterprogramme_und_Funktionen

    <TestMethod> _
    Public Sub _01_07_Unterprogramme_und_FunktionenTest()
        Dim a As Basics.Point = New Point() With { _
            .X = 10, _
            .Y = 20 _
        }
        Dim b As Basics.Point = New Point() With { _
            .X = -5, _
            .Y = 3 _
        }

        Dim c As Basics.Point = Ctx.Add(a, b)
        Assert.IsTrue(Ctx.Equal(c, New Point() With { _
            .X = 5, _
            .Y = 23 _
        }, 0.01))


        Dim posFlugzeug As Point = Ctx.PolarToCartesian(Math.Sqrt(2) * 1000, Math.PI / 4.0)
        Assert.IsTrue(Math.Abs(posFlugzeug.X - posFlugzeug.Y) < 0.01)
        Assert.AreEqual(1000.0, posFlugzeug.Y, 0.01)


        ' Unterprogramm mit ref- Parameter
        Dim abstand As Double, hoehe As Double
        Ctx.PolarToCartesian(Math.Sqrt(2) * 1000, Math.PI / 4.0, abstand, hoehe)


        ' Parameterarray

        Dim liste() = {3.0, 5.0, 7.0, 11.0, 13.0}
        Dim SumListe = Ctx.Sum(liste)

        ' Dank ParamArray- Zusatz in der Parameterliste wird die Liste 1, 2, ...
        ' vom Compiler automatisch in ein Array verpackt
        Dim summe As Double = Ctx.Sum(1, 2, 3, 4, 5, 6)
        summe = Ctx.Sum(1, 2, 3)
        Assert.AreEqual(6.0, summe)

        Dim mulSum As Double = Ctx.MulSum(2, 1, 2, 3)
        Assert.AreEqual(12.0, mulSum)


        ' Benannte Parameter, sinnvoll bei langen Parameterlisten
        Dim Erde = CreatePlanet(Name:="Erde", _
                                DiameterInKm:=12756, _
                                GravityInMeterPerSec:=9.81)

        ' Optionale Parameter: 2. Paramter ist in der Funktion Kilometer ein optionaler. Wird er weggelassen, dann 
        ' sind die Angaben immer in Meter, Kilometer oder AU
        Assert.AreEqual(1.0, Meter(1.0))
        Assert.AreEqual(1.0, Kilometer(1.0))
        Assert.AreEqual(1.0, AU(1.0))

        Assert.AreEqual(149597870700.0, Meter(1.0, EnumUnitLength.AU))
        Assert.AreEqual(149597870.7, Kilometer(1.0, EnumUnitLength.AU))

        Dim Erddurchmesser As Double = Kilometer(12756)
        Dim Jupiterdurchmesser As Double = Kilometer(142984)

        ' Hier wird der optionale Parameter explizit gesetzt, um darzustellen, dass die nummerische Angabe
        ' sich auf eine Maßeinheit <> Defaulteinheit sind.
        Dim ErddurchmesserInVielfachenVomAbstandErdeSonne = AU(Erddurchmesser, EnumUnitLength.Kilometer)
        Dim JupiterdurchmesserInMeter = Meter(Jupiterdurchmesser, EnumUnitLength.Kilometer)
        Dim JupiterdurchmesserInErddurchmesser = Jupiterdurchmesser / Erddurchmesser
    End Sub

End Class