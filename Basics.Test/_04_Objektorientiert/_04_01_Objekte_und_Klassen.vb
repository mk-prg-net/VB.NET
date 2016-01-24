Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_01_Objekte_und_Klassen

    <TestMethod()> Public Sub _04_01_Objekte_und_Klassen_Test()

        ' Ein paar Autos anlegen
        Dim FredsFerrari As Basics.Auto
        Dim SusisEnte As Basics.Auto
        Dim HugosSchrottkiste As Basics.Auto

        FredsFerrari = New Auto("Ferrari", "F40")
        SusisEnte = New Auto("Citroen", "2Cv")
        HugosSchrottkiste = New Auto("Audi", "80")

        FredsFerrari.EntfernungVonStuttgartInKm = 100
        SusisEnte.EntfernungVonStuttgartInKm = 105
        HugosSchrottkiste.EntfernungVonStuttgartInKm = 106

        For i As Integer = 0 To 100

            ' Einen Simulationsschritt durchführen
            FredsFerrari.fahre(100, 1)
            SusisEnte.fahre(20, 1)
            HugosSchrottkiste.fahre(30, 1)

            Debug.Print("Position von " & FredsFerrari.Marke & ": " & FredsFerrari.EntfernungVonStuttgartInKm)
            Debug.Print("Position von " & SusisEnte.Marke & ": " & SusisEnte.EntfernungVonStuttgartInKm)
            Debug.Print("Position von " & HugosSchrottkiste.Marke & ": " & HugosSchrottkiste.EntfernungVonStuttgartInKm)

        Next


    End Sub

End Class