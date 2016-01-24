Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_00_Class_vs_Module

    <TestMethod()> Public Sub _04_00_Class_vs_Module_Test()

        Basics.ModulAlsContainerFuerFunktionen.Faktor = 2
        Dim sum1 = Basics.ModulAlsContainerFuerFunktionen.Add(2, 4)

        Assert.AreEqual(12.0, sum1)

        Basics.ModulAlsContainerFuerFunktionen.Faktor = 1
        Dim sum2 = Basics.ModulAlsContainerFuerFunktionen.Add(2, 4)

        Assert.AreEqual(6.0, sum2)


        ' Das ganze nun mit Klassen
        Basics.ClassAlsContainerFuerFunktionen.FaktorAll = 2

        Dim obj1 = New Basics.ClassAlsContainerFuerFunktionen

        obj1.Faktor = 3
        Dim sum3 = obj1.Add(2, 3)

        Dim obj2 = New Basics.ClassAlsContainerFuerFunktionen

        obj2.Faktor = 4
        Dim sum4 = obj2.Add(2, 3)

        Dim sum5 = obj1.Add(2, 3)




    End Sub

End Class