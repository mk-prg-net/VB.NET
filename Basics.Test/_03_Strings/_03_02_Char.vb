Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _03_02_Char

    <TestMethod> _
    Public Sub _03_02_CharTest()
        ' char verarbeiten Unicode- Zeichen
        Dim c1 As Char, c2 As Char, c3 As Char, c4 As Char, c5 As Char, c6 As Char, _
            c7 As Char

        c1 = "Л"c
        c2 = "Ю"c
        c3 = "Б"c
        c4 = "О"c
        c5 = "В"c
        c6 = "Ь"c

        ' Anwendung der Zeichenklassenprädikate
        If Char.IsLetter(c1) Then
            Debug.WriteLine(c1.ToString() + " ist ein Buchstabe")
        End If


        Dim str = ""

        str += c1.ToString() + c2.ToString() + c3.ToString() + c4.ToString() + c5.ToString() + c6.ToString()

        Debug.WriteLine(str)

    End Sub
End Class