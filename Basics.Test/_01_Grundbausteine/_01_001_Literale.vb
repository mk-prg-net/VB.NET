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

        ' Gleitkommawert genau
        Dim e As Double = 2.7182818284590451

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
