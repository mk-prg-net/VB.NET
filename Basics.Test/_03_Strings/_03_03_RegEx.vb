Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports System.Text.RegularExpressions

<TestClass> _
Public Class _03_03_RegEx
    <TestMethod> _
    Public Sub _03_03_RegExTest()
        Try
            ' (3*(5+2))*2
            ' Ergebnis: 42
            ' Darstellung in umgegehrt poln. Notation
            ' ((3 (54 2)+)* 2)*

            Dim term As String = "((3 (5 2)+)* 2)*"
            Debug.WriteLine(term)

            ' Separation der Symbole
            term = Regex.Replace(term, "\(", " ( ")
            term = Regex.Replace(term, "\)", " ) ")

            Debug.WriteLine(term)
            ' Achtung: TrimStart verandert nicht die Instanz, sondern gibt
            ' den geänderten Wert der Instanz zurück
            term = term.TrimStart()

            Dim symbole As String() = Regex.Split(term, "\s+")

            For Each symbol As String In symbole
                Debug.Write(symbol & Convert.ToString(", "))
            Next


            Dim stack As New Stack(Of String)()

            ' Einkellern aller Symbole bis zur ersten schließenden Klammer

            Dim akt_pos As Integer = 0

            Do
                ' Einkellern bis zur schließenden Klammmer
                While symbole(akt_pos) <> ")" AndAlso akt_pos < symbole.Length
                    stack.Push(symbole(akt_pos))
                    akt_pos += 1
                End While

                ' Prüfen, ob kein Fehler im Ausdruck vorliegt
                If symbole.Length > 1 AndAlso akt_pos = symbole.Length Then
                    Throw New Exception("SyntaxError")
                End If

                ' Auswerten bis zur öffnenden Klammer

                ' Operationssymbol bestimmen
                akt_pos += 1
                Dim OpSym As String = symbole(akt_pos)

                Select Case OpSym
                    Case "+"
                        Addiere(stack)
                        Exit Select
                    Case "*"
                        Multipliziere(stack)
                        Exit Select
                    Case Else
                        Exit Select
                End Select


                akt_pos += 1
            Loop While akt_pos < symbole.Length

            Debug.WriteLine("Ergebnis= " + stack.Peek())

            Assert.AreEqual(42, Convert.ToInt32(stack.Peek()))
        Catch ex As Exception
            Assert.IsTrue(False)
        End Try

    End Sub

    Private Shared Sub Addiere(stack As Stack(Of String))
        Dim summe As Integer = 0

        While stack.Peek() <> "("
            Dim summand As Integer = Int32.Parse(stack.Pop())
            summe += summand
        End While

        ' Öffnende Klammer durch Ergebnis der Addition ersetzen
        stack.Pop()
        stack.Push(summe.ToString())
    End Sub

    Private Shared Sub Multipliziere(stack As Stack(Of String))
        Dim produkt As Integer = 1

        While stack.Peek() <> "("
            Dim faktor As Integer = Int32.Parse(stack.Pop())
            produkt *= faktor
        End While

        ' Öffnende Klammer durch Ergebnis der Addition ersetzen
        stack.Pop()
        stack.Push(produkt.ToString())
    End Sub

End Class

