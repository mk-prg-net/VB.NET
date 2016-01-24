Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Ctx = Basics._01_08_Delegates_und_Lambda

<TestClass()> Public Class _01_08_Delegates_und_Lambda_Tests

    Sub MeldeFunktion1(meldung As String)
        Debug.WriteLine("Meldungsart1: " & meldung)
    End Sub


    Sub MeldeFunktion2(meldung As String)
        Debug.WriteLine("Meldungsart2: " & meldung)
    End Sub

    ''' <summary>
    ''' Unterprogramm mit Callback: ein Teil der funktionalität im 
    ''' Unterprogramm ist über die Parameterliste konfigurierbar
    ''' </summary>
    ''' <param name="job"></param>
    ''' <param name="fertigmeldung"></param>
    ''' <remarks></remarks>
    Sub Jobverarbeitung(job As String, fertigmeldung As Action(Of String))

        Debug.WriteLine("Job " & job & " wird ausgeführt...")

        fertigmeldung.Invoke(job & " ist fertig")

    End Sub


    <TestMethod()> Public Sub _01_08_01_DelegatesTest()

        MeldeFunktion1("Hallo Welt")

        Dim MeldeAction As Action(Of String)

        MeldeAction = AddressOf MeldeFunktion1

        MeldeAction.Invoke("Eine Meldung um " & Date.Now)

        MeldeAction = AddressOf MeldeFunktion2

        MeldeAction.Invoke("Eine Meldung um " & Date.Now)

        Jobverarbeitung("Abwaschen", AddressOf MeldeFunktion1)

        Jobverarbeitung("Abtrocknen", AddressOf MeldeFunktion2)

        Dim myDg = New Ctx.DGBinOp(AddressOf Ctx.Add)

        Dim res As Double = myDg.Invoke(1, 2)
        Assert.AreEqual(3.0, res)

        ' Kurzschreibweise
        res = myDg(3, 6)
        Assert.AreEqual(9.0, res)

        ' Ein Delegate kann n Einsprungadressen aufnehmen
        myDg = System.Delegate.Combine(myDg, New DGBinOp(AddressOf Ctx.Mul))
        'AddHandler myDg, AddressOf Ctx.Mul


        ' Eine etwas sinnlose Anwendung von Delegates
        res = myDg.Invoke(3, 6)
        Assert.AreEqual(18.0, res)

        ' Einen Einsprungpunkt aus der Liste entfernen
        myDg = System.Delegate.Remove(myDg, New DGBinOp(AddressOf Ctx.Mul))

        res = myDg.Invoke(3, 6)
        Assert.AreEqual(9.0, res)

        'res = Ctx.Calculator(2, 7, New Ctx.DGBinOp(AddressOf Ctx.Add))
        res = Ctx.Calculator(2, 7, AddressOf Ctx.Add)
        Assert.AreEqual(9.0, res)

        res = Ctx.Calculator(2, 7, AddressOf Ctx.Mul)
        Assert.AreEqual(14.0, res)

        ' Berechnung der Summe 1 + 2 + 3 + ...
        res = Ctx.Akku(0.0, AddressOf Ctx.Add, 1, 2, 3, 4, 5, 6)
        Assert.AreEqual(21.0, res)

        ' Berechnung des Produktes 1 * 2 * 3 * ... = N!
        res = Ctx.Akku(1.0, AddressOf Ctx.Mul, 1, 2, 3, 4, 5, 6)
        Assert.AreEqual(720.0, res)

    End Sub

    <TestMethod()> Public Sub _01_08_02_LambdaTest()

        Dim res As Double

        ' Lambdaausdruck als Sprachmittel, um inline Funktionen/Unterprogramme zu definieren

        ' Ausführlicher Lambdaausdruck
        res = Ctx.Calculator(2, 7, Function(a As Double, b As Double) As Double
                                       Dim summe = a + b
                                       Return 5 * summe
                                   End Function)

        ' Durch Typinferenz kann auf die Typen der Parameter verzichtet werden
        res = Ctx.Calculator(2, 7, Function(a, b)
                                       Dim summe = a + b
                                       Return 5 * summe
                                   End Function)

        ' Zusammenfassen der beiden Anweisungen im Rumpf der Lambdafunktion zu einem Ausdruck
        res = Ctx.Calculator(2, 7, Function(a, b)
                                       Return 5 * (a + b)
                                   End Function)

        ' Wenn der Rumpf nur noch aus einem Ausdruck besteht, dann können die {...} Blockklammern
        ' weggelassen werden. Auch return kann entfallen- es erfolgt implizit.
        ' C#: (a, b) => 5*(a+b)
        res = Ctx.Calculator(2, 7, Function(a, b) 5 * (a + b))
        Assert.AreEqual(45.0, res)


    End Sub


End Class