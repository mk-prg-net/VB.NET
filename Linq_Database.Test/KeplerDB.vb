Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class KeplerDB

    <TestMethod()> Public Sub Abfragen_Test()

        Dim ctx = New Linq_Database.KeplerDBEntities

        ' Alle Planeten auflisten
        Dim planeten = ctx.HimmelskoerperTab.Where(Function(r) r.HimmelskoerperTypenTab.Name = "Planet") _
                       .Select(Function(r) r.Name).ToArray()


        Dim planetenSortiert = ctx.HimmelskoerperTab _
                               .Where(Function(r) r.HimmelskoerperTypenTab.Name = "Planet") _
                               .OrderByDescending(Function(r) r.Umlaufbahn.Laenge_grosse_Halbachse_in_km) _
                               .Select(Function(r) r.Name).ToArray()


    End Sub

End Class