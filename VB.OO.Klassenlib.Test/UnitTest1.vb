Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class AutoTests

    <TestMethod()> Public Sub AutoEigenschaftenTest()

        ' Referenzvariable anlegen
        Dim FredsFerrari As VB.OO.Klassenlib.Auto

        ' Objekt erzeugen
        FredsFerrari = New VB.OO.Klassenlib.Auto()

        FredsFerrari.EntfernungABStartInKm = 100

        Dim EntefernungInMeter = FredsFerrari.EntfernungAbStartInMeter


        ' Gas geben
        FredsFerrari.Beschleunigen(3, 2)

        ' Rollen lassen
        FredsFerrari.Fahren(1.0)

        ' Bremsen
        FredsFerrari.Bremsen(2, 1)

        Dim neuePosition = FredsFerrari.EntfernungABStartInKm

        ' Ein weiteres Auto mit einem anderen Konstruktor erzeugen
        Dim SusisEnte = New VB.OO.Klassenlib.Auto("S EN 9911", 50, 20)

        With SusisEnte
            Assert.AreEqual(.Kennzeichen, "S EN 9911")
            Assert.AreEqual(.VinKmh, 50.0)
        End With

    End Sub

End Class