Imports System.Text

<TestClass()>
Public Class Listenoperatoren

   

    <TestMethod()>
    Public Sub EqualsTest()
        Assert.IsTrue(Equal({1, 2, 3, 4}, {1, 2, 3, 4}))
        Assert.IsFalse(Equal({1, 2, 3}, {1, 2, 3, 4}))
        Assert.IsFalse(Equal({1, 2, 2, 4}, {1, 2, 3, 4}))
    End Sub


    <TestMethod()>
    Public Sub NummernlisteErzeugenTest()
        Dim list = Permutationen.PTupelStart(4)
        Assert.IsTrue(Equal(list, {1, 2, 3, 4}))
    End Sub



End Class
