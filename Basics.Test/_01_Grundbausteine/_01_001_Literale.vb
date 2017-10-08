Option Strict On
<TestClass> _
Public Class _01_001_Literale

    <TestMethod> _
    Public Sub Literale()

        Dim fix As Integer

        ' Dezimal
        fix = 255

        ' Hexadezimal
        fix = &HFF

        ' Oktal
        fix = &O400

        ' Gleitkommawerte, einfachgenau (Suffix F)
        Dim pi As Single = 3.14159274F

        ' Hier ist der VB.NET Compiler ungenau !
        pi = 1.23456789012345

        ' Gleitkommawert genau
        Dim e As Double = 2.7182818284590451

        Dim dblOhneNachkomma As Double = 99.0R

        Dim dblMitVielenStellen As Double = 123456789.01234567

        ' Das automatische Anpassen von Literalen durch den Editor kann man durch 
        ' geeignete Lieterale verhindern 
        dblMitVielenStellen = 123456789.0123456789012D


        ' Festkommawerte mit 30 Stellen Genauigkeit
        Dim StaatsschuldenD As Decimal = 2188211635948123456.123D
        Dim StaatschuldenGR As Decimal = 316465821900D

        ' Gleitkommawert Wissenschaftlich, entspricht 1,49 * 10^30
        Dim MasseSonne As Double = 1.49E+30

        ' Logische Werte
        Dim Ich_habe_einen_Fahrschein As Boolean = True
        Dim Ich_fahre_Bahn As Boolean = False

        ' Zeichenketten
        Dim txt As String = "Hallo Welt"

        ' Einzelne Zeichen
        Dim digit As Char = "€"c

        ' Datumskonstanten (Achtung: amerikanische Notation Monat/Tag/Jahr
        Dim Ostern As Date = #4/5/2015#

        ' Ein Referenztyp, der noch nicht auf ein gültiges Objekt zeigt
        Dim Star As Object = Nothing



    End Sub


End Class
