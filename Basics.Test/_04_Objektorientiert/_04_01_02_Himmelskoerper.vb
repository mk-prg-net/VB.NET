Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_01_02_Himmelskoerper

    <TestMethod()> Public Sub Galaxien_und_Sterne_Test()

        Dim Sonne As New astro.Stern
        Dim Beteigeuze As New astro.Stern

        Sonne.Masse_in_Sonnenmassen = 1
        Beteigeuze.Masse_in_Sonnenmassen = 20

        Dim Milchstrasse As New astro.Galaxie

        Dim alleSterne(1) As astro.Stern
        alleSterne(0) = Sonne
        alleSterne(1) = Beteigeuze

        'Dim alleSterne = New astro.Stern() {Sonne, Beteigeuze}

        Milchstrasse.Sterne = alleSterne

        Assert.AreEqual(21.0, Milchstrasse.Masse_in_Sonnenmassen)

        ' Compiler wandelt um in Milchstrasse.SetMasse_in_Sonnenmassen(100)
        Milchstrasse.Masse_in_Sonnenmassen = 100




    End Sub

End Class