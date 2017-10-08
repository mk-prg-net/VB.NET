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

        Dim inIrgendetwas = _01_05_06_Datentypen.ConvertToKompliziert(132.77, "CM")

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


        ' Strenge Typisierung wird auch zur LAufzeit überwacht
        Dim p As New Basics.Point(2, 3)

        ' semantisch korrekter Aufruf 
        Konfig(p)

        ' semantisch korrekter Aufruf 
        Konfig("(99, 77)")

    End Sub

    Sub Konfig(p As Object)

        Dim pTypisiert = CType(p, Basics.Point)
        pTypisiert.X *= 10
        pTypisiert.Y *= 10


    End Sub


    <TestMethod()> Public Sub _01_05_Typinfos()

        Dim i As Integer
        Dim i_type As Type = i.GetType() ' Typinfo- Objekt zum i Objekt
        Dim ii_type As Type = GetType(Integer) ' Typinfo- Objekt zum Datentypen Integer

        Assert.AreEqual(i_type, ii_type)

        Assert.AreEqual("Int32", i_type.Name)

        Dim u As New Uri("http://mk-prg-net.de")

        If Not TypeOf u Is Uri Then
            Assert.Fail()
        End If

    End Sub

    <TestMethod()> Public Sub _01_05_StatischeVariablenTest()


        Dim id1 As Long = _01_05_05_Variablen_Sichtbarkeiten.MakeID()
        Dim id2 As Long = _01_05_05_Variablen_Sichtbarkeiten.MakeID()

        Assert.IsTrue(id1 + 1 = id2)

    End Sub



End Class