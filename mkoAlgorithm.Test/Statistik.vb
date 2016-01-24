Imports System.Text

<TestClass()>
Public Class Statistik

    <TestMethod()>
    Public Sub MinimumsucheTest()
        Dim m = StatFunktional.Min({3, 9, 1, 7, -1, 0})
        Assert.AreEqual(-1, m)
    End Sub

End Class
