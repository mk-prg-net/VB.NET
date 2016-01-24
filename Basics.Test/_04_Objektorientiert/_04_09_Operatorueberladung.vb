Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_09_Operatorueberladung

    <TestMethod> _
       Public Sub _04_OperatorueberladungTest()
        Dim a = New Romzahl("MDCLXVI")
        Dim b = New Romzahl("XIII")

        ' Explizite Wandlung mit Konvertierungsoperator
        Dim MDCLXVI As Long = CLng(a)
        Assert.AreEqual(MDCLXVI, 1666)

        ' Aufruf des selbstdefinierten Additionsoperators für Romzahlen
        Dim RomSumme = a + b
        Dim LongSumme As Long = CLng(RomSumme)
        Assert.AreEqual(LongSumme, 1679)

    End Sub
End Class