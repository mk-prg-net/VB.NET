Imports System.Text

<TestClass()>
Public Class Kombinatorik


    <TestMethod()>
    Public Sub FakultaetTest()

        Assert.AreEqual(1, Permutationen.Fact(0))
        Assert.AreEqual(1, Permutationen.Fact(1))
        Assert.AreEqual(2, Permutationen.Fact(2))
        Assert.AreEqual(6, Permutationen.Fact(3))
        Assert.AreEqual(24, Permutationen.Fact(1))

    End Sub

    <TestMethod()>
    Public Sub PermutationenTest()
        Dim p0 = Permutationen.Permutationen(0)
        Dim p1 = Permutationen.Permutationen(1)
        Dim p2 = Permutationen.Permutationen(2)
        Dim p3 = Permutationen.Permutationen(3)
        Dim p4 = Permutationen.Permutationen(4)
    End Sub

End Class
