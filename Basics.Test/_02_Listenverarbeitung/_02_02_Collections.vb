Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _02_02_Collections

    <TestMethod> _
    Public Sub _02_02_CollectionsGrundlagenTest()
        Try

            ' Ein Primlist- Objekt erzeugen
            Dim Von1bis1000 = New PrimSet(1, 1000)

            ' manuell über die IEnumerable- Schnittstelle das Objekt steuern

            Dim Enum1_1000 = Von1bis1000.GetEnumerator()

            Enum1_1000.Reset()
            If Enum1_1000.MoveNext() Then
                '1. Primzahl: 
                Dim p1 As Long = Enum1_1000.Current
                Assert.AreEqual(3L, p1)
                If Enum1_1000.MoveNext() Then
                    ' 2. Primzahl:
                    Dim p2 As Long = Enum1_1000.Current
                    Assert.AreEqual(5L, p2)
                End If
            End If


            ' Mittels forEach- Schleife alle Primzahlen aus dem definierten Bereich auslesen
            Dim pSumme As Long = 0
            For Each p As Long In Von1bis1000
                pSumme += p
            Next
        Catch ex As Exception
            Assert.IsTrue(False)
        End Try

        Try
            Dim PL1bis1000 = New PrimList(1, 1000)

            Dim halbeanz As Integer = PL1bis1000.Count / 2

            ' Indexer austesten
            ' Primzahl in der Mitte: 
            Dim pMitte As Long = PL1bis1000(halbeanz)

            PL1bis1000(halbeanz) = 17

            ' Auch forEach funktioniert
            Dim i As Integer = 0
            Dim pSumme As Long = 0
            For Each p As Long In PL1bis1000
                pSumme += p

            Next
        Catch ex As Exception
            Assert.IsTrue(False)
        End Try

    End Sub

    <TestMethod> _
    Public Sub _02_02_CollectionsGenerischTest()
        Dim meinArray = New ArrayInt(5)

        ' Compiler wandelt folgende Zeile um in
        ' meinArray.Item(0).Set(2)
        meinArray(0) = 2
        meinArray(1) = 3
        meinArray(2) = 5
        meinArray(3) = 7
        meinArray(4) = 11

        For i As Integer = 0 To meinArray.Length - 1
            meinArray(i) = i * 10
        Next

        Dim sum As Integer = 0
        For i As Integer = 0 To meinArray.Length - 1
            ' Compiler wandelt folgende Zeile um in
            ' meinArray.Item[i].Get()
            sum += meinArray(i)
        Next

        ' jetzt den generischen Typ nutzen

        Dim deinArray = New ArrayGenerisch(Of Double)(3)

        deinArray(0) = 3.1400000000000001
        deinArray(1) = 2.7200000000000002
        deinArray(2) = 9.8100000000000005

        ' deinArray ist streng typisiert
        'deinArray[2] = "Hallo";

        Dim dblSum As Double = 0
        For i As Integer = 0 To deinArray.Length - 1
            dblSum += deinArray(i)
        Next

        ' EuklidischerRaum: Demo generischer Methoden

        Dim vektor1 = EuklidischerRaumGenerisch.CreateTupel(Of Integer)(1, 2, 3)

        ' Bei Methoden kann der Compiler die Typparameterliste aus den 
        ' Parametern rekonstruieren
        Dim vektor2 = EuklidischerRaumGenerisch.CreateTupel(1.0, 2.0, 3.0)

        Dim vektor3 = EuklidischerRaumGenerisch.CreateTupel("1.0", "2.0", "3.0")

        ' Arbeiten mit der vordefinierten gen. Tupelklasse
        Dim point2d = New Tuple(Of Double, Double)(3.2, 4.9)

        ' Tupel bietet  eine Klassenfabrik an, um Tupel einfacher zu erstellen
        Dim point2d_2 = Tuple.Create(3.2, 4.9)




        ' Vorgefertigte generische Collections einsetzen

        ' 1) List- ein dynamischer Ersatz für Arrays
        Dim Preisliste = New List(Of Preis)(10)

        Preisliste.Add(New Preis(3, 99))
        Preisliste.Add(New Preis(1, 49))

        Dim arrPreis() As Preis = {New Preis(12, 45), New Preis(8, 20), New Preis(15, 99)}
        Preisliste.AddRange(arrPreis)
        Preisliste.AddRange(New Preis() {New Preis(12, 45), New Preis(8, 20), New Preis(15, 99)})

        ' Compiler wandelt folgenden Aufruf um in
        ' Preisliste.this[3].get()
        Dim preis3 = Preisliste(3)
        Assert.AreEqual(8, preis3.GetEuro())
        Assert.AreEqual(8, Preisliste(3).GetEuro())

        ' Ein Objekt aus der Liste nehmen: Objektreferenz wird übergeben
        Preisliste.Remove(preis3)
        Preisliste.RemoveAt(5)

        ' Einfügen
        Preisliste.Insert(3, New Preis(7, 33))



        Dim AktuellePreise = New LinkedList(Of String)()
        For Each p As Preis In Preisliste
            AktuellePreise.AddLast(p.ToString())
        Next

        ' Iterieren über die LinkedList vorwärts
        Dim actNode As LinkedListNode(Of String) = Nothing
        actNode = AktuellePreise.First
        While actNode IsNot Nothing

            Debug.WriteLine("preis: " + actNode.Value)
            ' Da Next ein VB- Schlüsselwort ist, wird es in eckige Klammern
            ' gesetzt = begrenzter Bezeichner
            actNode = actNode.[Next]
        End While

        ' Iterieren über die LinkedList rückwärts
        actNode = AktuellePreise.Last
        While actNode IsNot Nothing

            Debug.WriteLine("preis: " + actNode.Value)
            actNode = actNode.Previous
        End While


        ' 2 PReise entfernen
        Preisliste.Remove(New Preis(12, 45))

        ' den 3. Preis entfernen
        Preisliste.RemoveAt(3)


        AktuellePreise.Clear()
        For Each p As Preis In Preisliste
            AktuellePreise.AddLast(p.ToString())
        Next

        ' Telefonbuch
        Dim telBuch = New Dictionary(Of String, Integer)()

        telBuch.Add("Anton", 4711)

        ' Zugriff auf den Telefonbucheintrag
        Assert.AreEqual(4711, telBuch("Anton"))

        ' neuer Eintrag hinzugefügt, da noch nicht unter dem Schlüssel vorhanden
        ' Folgeder Indexeraufruf entspricht telbuch.Add("Berta", 6969);
        telBuch("Berta") = 6969

        ' Eintrag geändert
        telBuch("Berta") = 7766

        If Not telBuch.ContainsKey("Berta") Then
            telBuch.Add("Berta", 12345)
        End If
        'telBuch.Add("Berta", 12345)

        telBuch("Cäsar") = 3344

        ' Iterieren durch Dictionary 1
        Dim telBuchListe = New LinkedList(Of String)()
        For Each k As String In telBuch.Keys
            telBuchListe.AddLast(k + ": " + telBuch(k))
        Next

        ' Iterieren durch Dictionary 2
        telBuchListe.Clear()
        For Each pair As KeyValuePair(Of String, Integer) In telBuch
            telBuchListe.AddLast(pair.Key + ": " + pair.Value)
        Next

        Dim telBuchInvers As New Dictionary(Of Integer, String)

        telBuchInvers(4711) = "Anton"



        ' Queue

        Dim Warteschlange = New Queue(Of Tuple(Of Integer, String))()


        ' Aufträge in Warteschlange einstellen
        Warteschlange.Enqueue(Tuple.Create(99, "Abwaschen"))
        Warteschlange.Enqueue(Tuple.Create(77, "Abtrocknen"))
        Warteschlange.Enqueue(Tuple.Create(66, "Wegräumen"))

        ' Jobverarbeitung schaltet sich ein
        Dim Auftragsprotokoll = New LinkedList(Of String)()
        Dim Auftrag = Warteschlange.Dequeue()
        Auftragsprotokoll.AddLast("Führe aus: " + Auftrag.Item2)

        Warteschlange.Enqueue(Tuple.Create(55, "Zumachen"))

        Auftrag = Warteschlange.Dequeue()
        Auftragsprotokoll.AddLast("Führe aus: " + Auftrag.Item2)

        ' Alle restlichen verarbeiten
        While Warteschlange.Count > 0
            Auftrag = Warteschlange.Dequeue()
            Auftragsprotokoll.AddLast("Führe aus: " + Auftrag.Item2)
        End While

    End Sub


End Class