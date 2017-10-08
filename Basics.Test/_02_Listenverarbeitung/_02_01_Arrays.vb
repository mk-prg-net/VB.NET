Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting




<TestClass()> Public Class _02_01_Arrays

    Function CreatePunktwolke(srcWolke As Point()) As Point()

        Dim Kopie(srcWolke.GetUpperBound(0)) As Point

        For i As Integer = 0 To Kopie.GetUpperBound(0)
            Kopie(i) = Point.Create(srcWolke(i))
        Next

        Return Kopie
    End Function

    <TestMethod> _
    Public Sub _02_01_01_ArraysIntroTests()
        ' Ein 1d Array, das durch eine Liste initialisiert wird
        Dim primzahlen As Integer() = {2, 3, 5, 7, 11, 13}

        Dim summePrim As Integer = 0
        For i As Integer = 0 To primzahlen.Length - 1
            summePrim += primzahlen(i)
        Next

        ' GetUpperBound liefert den größten Index in der gegeben Dimension
        For i As Integer = 0 To primzahlen.GetUpperBound(0)
            summePrim += primzahlen(i)
        Next

        ' Achtrung: beim Instanziieren ist die größte Platznummer
        ' festzulegen = Anz. Elemente - 1
        Dim Messwerte(9) As Double

        ' Schleife, die alle Elemente in einem Array besucht
        summePrim = 0
        For Each p As Integer In primzahlen
            summePrim += p
        Next

        ' Kopieren und Clonen
        Dim prim2 As Integer() = primzahlen

        summePrim = 0
        For Each p As Integer In prim2
            summePrim += p
        Next

        prim2(1) = 53

        ' Beide zeigen auf dasselbe Array !
        Assert.AreEqual(primzahlen(1), prim2(1))

        ' Clonen
        Dim primClone As Integer() = CType(primzahlen.Clone(), Integer())
        primClone(1) = 99

        Dim Punktwolke() As Point = {
            New Point(1, 2), _
            New Point(1, 2), _
            New Point(1, 2) _
            }

        Dim PunktwolkeClone = CType(Punktwolke.Clone(), Point())

        Punktwolke(0).X *= 100
        Assert.AreEqual(Punktwolke(0).X, PunktwolkeClone(0).X, "Geklont worden sind nur die Referenzen")

        ' Kopieren mittels Klassenfabrik
        Dim PunktwolkeAusKlassenfabrik = CreatePunktwolke(Punktwolke)
        PunktwolkeAusKlassenfabrik(0).X *= 100
        Assert.AreNotEqual(Punktwolke(0).X, PunktwolkeAusKlassenfabrik(0).X, "Geklont worden sind nun auch die Werte, da Strukturen Wertetypen sind")

        Dim pA As Point
        Dim sA As SPoint

        Try
            sA.X = 99
            pA.X = 99
        Catch ex As Exception

        End Try


        Dim StruktPunktwolke() As SPoint = {
            New SPoint(1, 2), _
            New SPoint(1, 2), _
            New SPoint(1, 2) _
        }

        Dim StruktPunktwolkeClone = CType(StruktPunktwolke.Clone(), SPoint())

        StruktPunktwolke(0).X *= 100
        Assert.AreNotEqual(StruktPunktwolke(0).X, StruktPunktwolkeClone(0).X, "Geklont worden sind nun auch die Werte, da Strukturen Wertetypen sind")



        Assert.AreNotEqual(primzahlen(1), primClone(1))

        ' Wert einer Iterationsvariable p in einer foreach- Schleife darf nicht verändert werden
        'foreach (int p in primzahlen)
        '    p++;

        ' Ein 2d Array mit 3 Zeilen und 2 Spalten
        Dim stDiagramm As Double(,) = New Double(2, 1) {}

        ' 1. Spalte = Zeit, 2. Spalte = zurückgelegter Weg
        stDiagramm(0, 0) = 1
        stDiagramm(0, 1) = 0.5

        stDiagramm(1, 0) = 2
        stDiagramm(1, 1) = 1.0

        stDiagramm(2, 0) = 3
        stDiagramm(2, 1) = 1.5

        Try

            stDiagramm(3, 2) = 99.0
        Catch ex As Exception

        End Try


        ' Anzahl der Dimensionen von stDiagramm: 2
        Assert.AreEqual(2, stDiagramm.Rank)

        Dim vtDiagramm As Double(,) = New Double(1, 1) {}


        For i As Integer = 0 To vtDiagramm.GetUpperBound(0)
            vtDiagramm(i, 0) = stDiagramm(i, 0)
            vtDiagramm(i, 1) = (stDiagramm(i + 1, 1) - stDiagramm(i, 1)) / (stDiagramm(i + 1, 0) - stDiagramm(i, 0))
        Next

        ' 2D- Array mit Initialisierungsliste anlegen
        Dim vt2 As Double(,) = {{1.0, 2.0}, {2.0, 3.9}, {3.0, 4.8}}
        Assert.AreEqual(vt2.GetUpperBound(0), 2)
        Assert.AreEqual(vt2.GetUpperBound(1), 1)
        Assert.AreEqual(vt2.Rank, 2)
        Assert.AreEqual(vt2.Length, 6)
    End Sub

    <TestMethod> _
    Public Sub _02_01_02_ArraysSortTest()
        Try
            ' Sortieren eingebauter Datentypen

            Dim primz As Integer() = {19, 2, 41, 37, 17, 19, 13, 5, 7, 3, 11}
            Array.Sort(primz)


            Dim planeten As String() = {"Merkur", "Venus", "Erde", "Mars", "Jupiter", "Saturn"}
            Array.Sort(planeten)

            ' Absteigend sortieren
            Array.Reverse(planeten)



            ' Preisliste anlegen
            Dim Preisliste As Preis() = {New Preis(5, 99), New Preis(3, 49), New Preis(1, 99), New Preis(0, 99), New Preis(4, 49)}

            ' Preisliste sortierbar, da Preis die IComparable- Schnittstelle implementiert
            Array.Sort(Preisliste)


            Dim Preisliste_sortiert = Preisliste.OrderBy(Function(preis) preis.FixpointValue)
            Dim Preisliste_sortiert_desc = Preisliste.OrderByDescending(Function(preis) preis.FixpointValue)

            Dim Preisliste_gefiltert_und_sortiert = Preisliste.Where(Function(preis) preis.GetEuro() >= 1 AndAlso preis.GetEuro() < 5) _
                                                    .OrderBy(Function(preis) preis.FixpointValue).ToArray()

            Dim Preisliste_in_Dollar_gefiltert_und_sortiert = Preisliste.Where(Function(preis) preis.GetEuro() >= 1 AndAlso preis.GetEuro() < 5) _
                                                              .OrderBy(Function(preis) preis.FixpointValue) _
                                                              .[Select](Function(preis) (CDbl(preis.FixpointValue) / 100.0) * 1.37).ToArray()




            '---------------------------------------------------------------------
            ' Alternative zum Erweitern sortierender Objekte mit IComparable:
            ' IComparer

            Dim Punkte As PointWithProperties() = {New PointWithProperties(3, 5), New PointWithProperties(1, 2), New PointWithProperties(4, 4), New PointWithProperties(2, 2), New PointWithProperties(3, 2), New PointWithProperties(-2, -8)}


            System.Array.Sort(Punkte, New PointVergleicher())
        Catch ex As Exception
            Assert.IsTrue(False)
        End Try


    End Sub
End Class