Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_08_Erweiterungsmethoden

    <TestMethod()> Public Sub TestMethod1()

        Dim z As Long = 3

        Assert.IsTrue(z.IsOdd())

        ' Compiler wandelt um in LongExtensions.IsPrime(z)
        Assert.IsTrue(z.IsPrime())



    End Sub

End Class