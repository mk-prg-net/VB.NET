Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Basics

<TestClass()> Public Class _01_06_Referenztypen_vs_Wertetypen_Tests

    Dim P1 As Point
    Dim P2 As SPoint

    <TestMethod()> Public Sub _01_06_01_Referenztypen_vs_WertetypenTest()
        ' Eine Double- Konstante verhält sich wie ein Objekt -> Konsequenz aus der Aussage: im Kern ist 

        Dim txt = (3.1400000000000001).ToString()

        Dim arrObj(2) As Object

        ' Beim Zuweisen wird jeder Wert eines Wertetyps in eine Objektbox verpackt
        arrObj(0) = 3.1400000000000001
        arrObj(1) = 314
        arrObj(1) = "3,14"



        ' P1 hat jetzt den Wert Nothing <=> noch kein Objekt vorhanden !
        Assert.IsNull(P1)

        ' Folgende Anweisung führt zu einem Laufzeitfehler
        Try
            P1.X = 20.0

        Catch ex As Exception
        End Try

        'Objekt im Heapspeicher mittels New- Operator erzeugen
        P1 = New Point()

        ' Jetzt zeigt p1 auf was ...
        Assert.IsNotNull(P1)

        ' ... und der Zugriff gelingt
        P1.X = 10.0
        P1.Y = 20.0

        ' Achtung: hier entsteht keine Kopie: P1_Kopie und P1 zeigen auf dasselbe Objekt
        Dim P1_Kopie As Point = P1

        P1_Kopie.X += 100
        Assert.AreEqual(P1_Kopie.X, P1.X)

        ' Anlegen der Kopie "zu Fuss"
        P1_Kopie = New Point()
        P1_Kopie.X = P1.X
        P1_Kopie.Y = P1.Y

        ' ... automatisiert mit Clone- Methode

        Dim PClonbar = New PointClonbar(33, 44)

        Dim PClonbar_Kopie As PointClonbar = DirectCast(PClonbar.Clone(), PointClonbar)


        ' Aber !!!
        ' p2 zeigt auf was, obwohl kein Objekt mittels New angelegt wurde (Automatik)
        ' Das ist der Unterschied zwischen Class und Structure !
        Assert.IsNotNull(P2)
        P2.X = -20.0

        ' Strukturen können wie Klassen über mehrere Konstruktoren verfügen
        Dim P3 As SPoint
        P3.X = 33
        P3.Y = 44
        P3.Y += P2.X

        ' Zuweisung bei Strukturen ist kein Adresstausch,
        ' sondern tatsächlich eine bitweise Kopie des Inhalts
        Dim P4 As SPoint = P2
        P4.X += 100

        Assert.IsTrue(P2.X = -20)
        Assert.IsTrue(P4.X = 80)

    End Sub

End Class