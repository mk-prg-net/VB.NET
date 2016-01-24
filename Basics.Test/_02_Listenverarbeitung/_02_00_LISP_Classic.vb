Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports mkoAlgorithm.ListenoperatorenFunktional

<TestClass()> Public Class _02_00_LISP_Classic

    <TestMethod()> Public Sub _02_00_LISP_Classic()

        Dim primList = {2, 3, 5, 7, 11, 13, 17, 19, 23}

        Assert.AreEqual(9, Count(primList))

        Dim x = Take(primList, 3)
        Dim y = Skip(primList, 3)

        Dim xy = Concat(x, y)
        Assert.IsTrue(mkoAlgorithm.ListenoperatorenFunktional.Equal(primList, xy))


        ' Indexer kann durch Kombination aus Skip und Take
        ' realisiert werden 
        Dim z = First(Take(Skip(primList, 3), 1)) ' <=> primList(3)
        Assert.AreEqual(z, primList(3))




    End Sub

End Class