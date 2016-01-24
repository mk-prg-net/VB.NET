Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Ctx = Basics._01_04_Operatoren


<TestClass()> Public Class _01_04_Operatoren



    Public Sub _01_04_Operatoren_LogikopsTest()
        Assert.IsTrue(Ctx.Logische_Operatoren_in_Aussagen())
    End Sub


    <TestMethod> _
    Public Sub Kombinierte_Operatoren()

        Dim zaehler As Integer

        ' Ausführliche (klassische) Form des hochzählens
        zaehler = zaehler + 1
        Debug.Assert(zaehler = 1)

        ' Vereinfachte (moderne Form) des Hochzählens
        zaehler += 1
        Debug.Assert(zaehler = 2)

        ' Kombinierte Operatoren kann man auch mit -, *, / bilden
        zaehler -= 2    ' <=> zaehler = zaehler - 2
        Debug.Assert(zaehler = 0)

        zaehler = 100
        zaehler *= 2    ' <=> zaehler = zaehler * 2
        Debug.Assert(zaehler = 200)

        zaehler /= 2    ' <=> zaehler = zaehler / 2
        Debug.Assert(zaehler = 100)

    End Sub


    <TestMethod> _
    Public Sub _01_04_Operatoren_FestkommaoperatorenTest()

        ' Einfache Festkommaoperationen
        Dim A, B, C As Integer
        A = 100
        B = 99
        C = A + B
        C = A - B
        C = B * 100 + 33
        C = (B * 100 + 33) / 100
        C = (B * 100 + 33) \ 100

        C = 13 Mod 3

        Assert.IsTrue(Ctx.Gepruefte_Festkommaoperatoren())
        Assert.IsTrue(Ctx.Ungepruefte_Festkommaoperatoren())

        ' Bsp.: Preise durch Festkommawerte darstellen, indem 2 stellen Fest für die 
        ' Cents definiert sind

        Dim preis1 As Integer = 9950
        ' Entspricht 99,50 €
        Dim preis2 As Integer = 38560
        ' Entspricht 385,60 €
        Dim Gesamtpreis As Integer = preis1 + preis2

        ' Für die Ausgabe sollten die Vor und Nachkommastellen Isoliert werden, um sie 
        ' getrennt auszugeben

        ' a / b ergibt als Ergebnis einen Double- Wert
        ' a \ b ergibt als Ergebnis einen Integer- Wert
        Dim GesamtpreisEuro As Integer = Gesamtpreis \ 100
        Dim GesamtpreisCent As Integer = Gesamtpreis - GesamtpreisEuro * 100

        Assert.AreEqual(485, GesamtpreisEuro)
        Assert.AreEqual(10, GesamtpreisCent)


        ' Vereinfachen der Festkommarechnung für Preise mittels Hilfsfunktionen
        Dim preis3 As Integer = Ctx.Preis(99, 50)
        Dim preis4 As Integer = Ctx.Preis(385, 60)

        Dim Gesamtpreis2 As Integer = preis3 + preis4

        Assert.AreEqual(485, Ctx.PreisEuroAnteil(Gesamtpreis2))
        Assert.AreEqual(10, Ctx.PreisCentAnteil(Gesamtpreis2))

    End Sub

    <TestMethod> _
    Public Sub _01_04_Operatoren_GleitkommaoperatorenTest()
        Dim dPReis1 As Double = 99.5
        Dim dPreis2 As Double = 385.6

        Dim dGesamt As Double = dPReis1 + dPreis2
        Assert.AreEqual("485,10", dGesamt.ToString("N2"))

        ' Jedoch können in Gleitkommarechnungen Rundungsfehler erbarmungslos zuschlagen
        'float EntfernungRaketeVonErde = (float)19999998.0; // f;
        Dim EntfernungRaketeVonErde As Single = 19999998.0F

        For i As Integer = 1 To 10
            EntfernungRaketeVonErde += 1.0F
        Next

        Assert.AreEqual(Math.Round(20000000.0, 7), Math.Round(EntfernungRaketeVonErde, 7))

        ' Rechnen mit großen Messwerten (Sternenmassen)
        Dim MasseSonneKg As Double = 1.989E+30
        Dim MasseBeteigeuzeKg As Double = 1.531E+31
        Dim MasseRiegelKg As Double = 3.88E+31
        Dim MasseCanisMajorisKg As Double = 5.967E+31

        Dim Verhältnis As Double = MasseCanisMajorisKg / MasseSonneKg

    End Sub


    <TestMethod> _
    Public Sub Zeichenkettenoperatoren()
        Dim txt, frag1, frag2 As String

        ' Zeichkettenverkettung mit +
        frag1 = "Hallo"
        frag2 = "Welt"
        txt = frag1 + " " + frag2

        ' Probleme, wenn nummerische Werte an Zeichenkette angehangen werden sollen
        Try
            txt = 99 + " Euro"
        Catch ex As Exception
            Debug.WriteLine("Ausnahme beim Verketten mit +" + ex.ToString())
        End Try

        Try
            txt = "SFr " + 99
        Catch ex As Exception
            Debug.WriteLine("Ausnahme beim Verketten mit +" + ex.ToString())
        End Try


        ' Lösung: & anstatt +: Alles, was rechts von & steht, wird automat. mittels ToString() in eine Zeichenkette gewandelt
        txt = 99 & " Euro"
        txt = "SFr " & 99

    End Sub

    <TestMethod> _
    Public Sub _01_04_Operatoren_BitopsTest()
        Dim dz As String = Ctx.In_Dualzahl_konvertieren_mit_Bitops(8)
        Assert.AreEqual(dz, "OOOOOOOOOOOOOOOOOOOOOOOOOOOOLOOO")

        dz = Ctx.In_Dualzahl_konvertieren_mit_Bitops(&HFFFFFFFFUI)
        Assert.AreEqual(dz, "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL")

        dz = Ctx.In_Dualzahl_konvertieren_mit_Bitops(12345)
        Trace.WriteLine(Convert.ToString("12345 in Dual = ") & dz)
    End Sub


End Class