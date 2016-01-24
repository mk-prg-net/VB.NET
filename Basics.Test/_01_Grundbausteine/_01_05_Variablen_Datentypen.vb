Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _01_05_Variablen_Datentypen

    <TestMethod()> Public Sub _01_05_Deklarationen()

        Basics._01_05_01_Variablen_Implizite_Deklaration.exe()

        Basics._01_05_02_Variablen_Explizite_Deklaration.exe()

        Basics._01_05_03_Variablen_Stricte_Deklaration.exe()

        Basics._01_05_04_Variablen_Typinferenz.exe()

    End Sub

    <TestMethod()> Public Sub _01_05_FestkommaArithmetikTest()

        Basics._01_05_06_Datentypen.Festkommatypen()

    End Sub


    <TestMethod()> Public Sub _01_05_DoubleArithmetikTest()

        Assert.IsTrue(Basics._01_05_06_Datentypen.DoubleArithmetik())

    End Sub


    <TestMethod()> Public Sub _01_05_Enums()

        Dim inCm = _01_05_06_Datentypen.ConvertToKompliziert(123.456, "cm")

        inCm = _01_05_06_Datentypen.ConvertTo(123.456, _01_05_06_Datentypen.LaengenEinheiten.cm)

    End Sub



    <TestMethod()> Public Sub _01_05_KonvertierenTest()


        Basics._01_05_06_Datentypen.Boxing_unboxing()
        Basics._01_05_06_Datentypen.Konvertieren()

        Dim sum3 = Basics._01_05_06_Datentypen.AddT(3.1, 4.2)
        Dim sum4 = Basics._01_05_06_Datentypen.AddT(3, 4)
        Dim sum5 = Basics._01_05_06_Datentypen.AddT("3", "4")


        Dim sum1 = Basics._01_05_06_Datentypen.AddUntypisiert(3.0, 4.0)
        Dim sum2 = Basics._01_05_06_Datentypen.AddUntypisiert(3, 4)





    End Sub

    <TestMethod()> Public Sub _01_05_StatischeVariablenTest()


        Dim id1 As Long = _01_05_05_Variablen_Sichtbarkeiten.MakeID()
        Dim id2 As Long = _01_05_05_Variablen_Sichtbarkeiten.MakeID()

        Assert.IsTrue(id1 + 1 = id2)

    End Sub



End Class