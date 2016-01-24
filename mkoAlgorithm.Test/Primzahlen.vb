Imports System.Text
Imports mkoAlgorithm
Imports System.Runtime.CompilerServices

<TestClass()>
Public Class Primzahlen

    <TestMethod()>
    Public Sub TestExtensions()
        Dim z As Long = 7
        Assert.AreEqual(True, z.IsPrim())

    End Sub

    <TestMethod()>
    Public Sub TestFaktorisierung()
        Dim z As Long = 45

        Dim pfl As New List(Of Long)
        Primfaktoren(z, pfl)

        Dim res As Long = 1
        pfl.ForEach(Sub(p) res *= p)

        Assert.AreEqual(res, z)

        z = 109275
        pfl.Clear()

        Primfaktoren(z, pfl)

        res = 1
        pfl.ForEach(Sub(p) res *= p)

        Assert.AreEqual(res, z)

    End Sub

    <TestMethod()>
    Sub TestPrimzahlscannerFunktional()
        Assert.IsTrue(PrimzahlScannerFunktional.IstPrimzahl(13))
        Assert.IsFalse(PrimzahlScannerFunktional.IstPrimzahl(221))

        Dim prim = PrimzahlScannerFunktional.AllePrimzahlenIn(1, 20)

        ' Erwartetes Ergebnis       
        Dim gegenüberstellung = mkoAlgorithm.ListenoperatorenFunktional.TupleCombiner({2, 3, 5, 7, 11, 13, 17, 19}, prim)
        Assert.IsTrue(gegenüberstellung.All(Function(p) p.Item1 = p.Item2))




    End Sub

End Class
