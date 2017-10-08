Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

' Achtung: Beim Einsatz von Linq muss immer System.Linq importiert werden !
Imports System.Linq

<TestClass()> Public Class _02_04_Linq_LISP

    Private Sub printListe(liste As IEnumerable(Of Integer))
        For Each el As Integer In liste
            Debug.Write(el & ", ")
        Next
    End Sub



    <TestMethod()> Public Sub _02_04_LISP_Intro_Test()

        Dim liste As Integer() = {2, 3, 5, 7, 11, 13}

        ' Zugriff auf einzelnes Listenelement mittels Indexer (<Indexnummer>)
        ' (Beachte, dass die Indizes mit 0 beginnen !)
        Dim el4 = liste(3)
        Debug.WriteLine("4. Element in der Liste hat den Wert: " & el4)

        ' Zuweisen eines neuen Wertes an ein Listenelement
        liste(3) = 37
        'Debug.WriteLine("4. Element in der Liste hat nun den Wert: " + liste(3));

        ' Durchlaufen aller Listenelemente
        'Debug.WriteLine("Alle Listenelemente");
        printListe(liste)

        ' Liste erweitern
        Dim liste2 = liste.Concat(New Integer() {17, 19, 23, 29, 31})
        Debug.WriteLine("")
        Debug.WriteLine("Alle Listenelemente nach Erweiterung")
        printListe(liste2)

        ' In Liste2 steht keine Liste sondern ein "Abfrage", die das Ergebnis liefert
        ' => Ändern sich die INhalte der "Quellen" der Abfrage, dann ändert sich 
        ' auch das Abfrageergebnis
        Debug.WriteLine("")
        Debug.WriteLine("Alle Listenelemente nach Erweiterung und Änderung in der Quellliste")
        liste(0) = 47
        printListe(liste2)

        ' Fixiren der Resultate einer Abfrage gelingt mit der ToArray- Methode
        Dim liste2Fix = liste.Concat(New Integer() {17, 19, 23, 29, 31}).ToArray()
        Debug.WriteLine("")
        Debug.WriteLine("Alle Listenelemente nach Erweiterung mit Fixierung")
        printListe(liste2Fix)

        liste(0) = 53
        Debug.WriteLine("")
        Debug.WriteLine("Alle Listenelemente der fixierten Liste (nochmal)")
        printListe(liste2Fix)


        ' Liste am Kopf erweitern
        Dim liste2_1 = New Integer() {-5, -3, -2}.Concat(liste2)
        Debug.WriteLine("")
        Debug.WriteLine("Vorne erweiterte Liste")
        printListe(liste2_1)


        ' Kopf der Liste (ersten 3 Elemente) abschneiden
        Dim listeKopflos = liste2.Skip(3)

        Debug.WriteLine("")
        Debug.WriteLine("Liste ohne Kopf")
        printListe(listeKopflos)

        ' Schwanz der Liste abschneiden
        Dim listeSchwanzlos = liste2.Take(3)
        Debug.WriteLine("")
        Debug.WriteLine("Liste ohne Schwanz")
        printListe(listeSchwanzlos)

        ' Ein Stück aus der Mitte herausschneiden
        Dim Mittelstück = liste2.Skip(3).Take(3)
        Debug.WriteLine("")
        Debug.WriteLine("Mittelstück")
        printListe(Mittelstück)

        Dim Mittelstück2 = liste2.Skip(12).Take(3)
        'Debug.WriteLine("");
        'Debug.WriteLine("Mittelstück");
        printListe(Mittelstück2)

        ' Prüfen, ob Liste leer
        If Not liste2.Any() Then
            Debug.WriteLine("Liste liste2 ist leer")
        Else
            Debug.WriteLine("Liste liste2 ist nicht leer")
        End If

        ' Prüfen, ob Liste leer
        If Not Mittelstück2.Any() Then
            Debug.WriteLine("Liste Mittelstück2 ist leer")
        Else
            Debug.WriteLine("Liste Mittelstück2 ist nicht leer")
        End If

        Dim umgedrehteListe = liste2_1.Reverse()

        Dim erstesElement = liste2_1.First()
        Dim letztesElement = liste2_1.Last()


    End Sub


    Function TesteAufTeilbarkeitDurchDrei(kandidat As Long) As Boolean
        Return kandidat Mod 3 = 0
    End Function


    <TestMethod()> Public Sub _02_04_Linq_Intro_Test()

        Dim listeA As Long() = {3, 5, 9, 12, 15, 19}
        Dim listeB As Long() = {13, 15, 19, 25, 39, 45}

        ' Listen zu einer großen Zusammenfassen (mit Duplikate)
        Dim alle = listeA.Concat(listeB)

        ' ... ohne Duplikate
        Dim alleOhneDuplikate = listeA.Union(listeB)

        ' Schnittmenge
        Dim Schnittmenge = listeA.Intersect(listeB)

        Assert.AreEqual(alle.Count() - Schnittmenge.Count(), alleOhneDuplikate.Count())

        ' Alle Elemente zählen
        Dim anzAlle As Integer = alle.Count()

        ' Zählen aller durch 3 teilbaren in listeA
        Dim anzHabenTeiler3 As Integer = alle.Count(AddressOf TesteAufTeilbarkeitDurchDrei)

        ' Teilbarkeit mittels Lambda prüfen
        Dim anzHabenTeiler3_2 As Integer = alle.Count(Function(z) z Mod 3 = 0)

        ' Filtern der Listen mittels Where - Algo
        Dim habenTeiler3 = alle.Where(Function(z) z Mod 3 = 0)
        Dim habenTeiler5 = alle.Where(Function(z) z Mod 5 = 0)

        Dim AllePrimzahlen = alleOhneDuplikate.Where(Function(z) z.IsPrime())


        ' Linq mit komplexeren Daten
        Dim Preisliste As Preis() = {New Preis(5, 99), New Preis(3, 49), New Preis(1, 99), New Preis(0, 99), New Preis(4, 49)}

        Dim x As Integer = 99


        Dim Preisliste_sortiert = Preisliste.OrderBy(Function(r) r.Preis_as_Dbl)
        Dim Preisliste_sortiert_desc = Preisliste.OrderByDescending(Function(r) r.Preis_as_Dbl)


        Dim Preisliste_gefiltert_und_sortiert = Preisliste.Where(Function(r) 1.0 <= r.Preis_as_Dbl And r.Preis_as_Dbl <= 5.0) _
                                                .OrderBy(Function(r) r.Preis_as_Dbl).ToArray()

        Dim Preisliste_in_Dollar_gefiltert_und_sortiert = Preisliste _
                                                          .Where(Function(r) 1.0 <= r.Preis_as_Dbl And r.Preis_as_Dbl <= 5.0) _
                                                          .OrderBy(Function(r) r.Preis_as_Dbl) _
                                                          .Select(Function(r) r.Preis_as_Dbl * 1.05).ToArray()


        Dim aufsteigendSortiert = Preisabfragen.AufsteigendSortiert(Preisliste)

        Dim alleGrößer3Euro = Preisabfragen.PreiseGrößerXEuro(Preisliste, New Preis(3, 0)).ToArray()

    End Sub



End Class