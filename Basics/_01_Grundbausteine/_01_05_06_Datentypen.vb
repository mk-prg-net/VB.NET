'Option Explicit On
Option Strict On

Public Class _01_05_06_Datentypen

    ' Abbildung von Euro, Cent auf Preis
    ' (Codiert einen Preis)
    Shared Function Preis(Euro As Integer, Cent As Integer) As Integer
        Return Euro * 100 + Cent
    End Function

    Shared Function Euro(preis As Integer) As Integer
        Return preis \ 100
    End Function

    Shared Function Cent(preis As Integer) As Integer
        Return preis - Euro(preis) * 100
    End Function

    Public Shared Sub Festkommatypen()

        ' Preise als Festkommawerte darstellen
        ' 3,99 € => als ganze Zahl kodieren: 3,99 * 100 = 399
        ' 1,01 € => 1,01 * 100 = 101
        ' 3,99 € + 1,01 € => 399 +101 = 500 => 500 / 100 => 5,00 €

        Dim preis1 = 3.99
        Dim preis2 = 1.49

        ' IN Festkommadarstellung umwandeln
        Dim preis1FK As Integer = CInt(preis1 * 100)
        Dim preis2FK As Integer = CInt(preis2 * 100)

        Dim summFK As Integer = preis1FK + preis2FK

        ' Aus der Festkommadarstellung den Euro-, und den CEntanteil 
        ' bestimmen

        ' Teilen mit Integerdivision (Nachkommastellen werden verworfen)
        Dim preisEuro As Integer = summFK \ 100
        Dim preisCent As Integer = summFK - preisEuro * 100

        ' Die gleiche Rechnung, nun mit den Funktionen vereinfacht
        preis1FK = Preis(3, 99)
        preis2FK = Preis(1, 49)

        summFK = preis1FK + preis2FK

        preisEuro = Euro(summFK)
        preisCent = Cent(summFK)

        Debug.Print("Summe Preis: " & Euro(summFK) & "," & Cent(summFK))


        Dim summe2 = Preis(1, 99) + Preis(3, 49) + Preis(2, 29)

        Debug.Print("Summe Preis: " & Euro(summe2) & "," & Cent(summe2))


        ' Division durch 0 im Festkommabereich nicht zulässig
        Dim Nenner As Integer = 0
        Dim Zähler As Integer = 1

        Try
            Dim Quotient As Integer = CInt(Zähler / Nenner)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

        Try
            Dim Quotient As Integer = Zähler \ Nenner
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try



    End Sub


    Public Shared Sub Konvertieren()

        ' Achtung: folgende Zeile ist bezüglich korrektheit abhängig von
        ' Option Strict = on/off
        Dim res As Double = 3.14 + CDbl("5,24")

        ' Achtung: beim Konvertieren aus String spielen die Regions- und Sprachoptionen
        ' des Host-Systems eine Rolle!
        Dim res2 As Double = 3.14 + CType("5.24", Double)


        ' Sauber aus einem Text einen Zahlenwert einlesen
        Dim res3 As Double
        If Not Double.TryParse("5,24", res3) Then
            Debug.WriteLine("5,24 konnte nicht konvertiert werden")
        End If

        If Not Double.TryParse("5.24", res3) Then
            Debug.WriteLine("5.24 konnte nicht konvertiert werden")
        End If


        ' Fall: Die werte werden z.B. aus einer Datei eingelesen, in der sie im 
        ' US- Format vorliegen

        ' Einen formatprovider für die US- Kultur anlegen
        Dim cultUS = New System.Globalization.CultureInfo("en-US")
        Double.TryParse("5.24", System.Globalization.NumberStyles.Number, cultUS, res3)
        Debug.Assert(res3 = 5.24)

        ' Den Kulturkontext des aktuellen Threads ändern
        Dim oldCultInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = cultUS

        Dim res4 As Double = 0.0 + CDbl("5.24")
        Debug.Assert(res4 = 5.24)

        Dim res5 As Double
        If Not Double.TryParse("5.24", res5) Then
            Debug.WriteLine("5.24 konnte nicht konvertiert werden")
        End If
        Debug.Assert(res5 = 5.24)



    End Sub

    ' Konvertiert aus C# mit http://converter.telerik.com/


    ''' <summary>
    ''' Spezielle Artihmetik mit double
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Function DoubleArithmetik() As Boolean

        Try

            Dim Nenner As Double = 0.0
            Dim Zähler As Double = 1.0
            Dim Quotient As Double = Zähler / Nenner

            Debug.Assert(Double.IsInfinity(Quotient))
            Zähler = -1.0

            Quotient = Zähler / Nenner
            Debug.Assert(Double.IsNegativeInfinity(Quotient))

            Zähler = 0.0
            Quotient = Zähler / Nenner
            Debug.Assert(Double.IsNaN(Quotient))


            Dim AbstandErdeRakete As Single = 29999998.0F
            'Dim AbstandErdeRakete As Double = 29999998.0

            For i As Integer = 0 To 1000

                'AbstandErdeRakete = AbstandErdeRakete + 1
                ' folgende Anweisung hat die gleiche Bedeutung
                ' wie die vorausgegangene
                AbstandErdeRakete += 1

            Next


            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function




    Public Shared id As Integer = 0

    Public Shared Function MakeID() As Integer
        id += 1
        Return id

    End Function


    ''' <summary>
    ''' Motivation für Enums: Definieren einer Zieleinheit als String- 
    ''' Nachteile: Ressourcenverschwendung, unsicher
    ''' </summary>
    ''' <param name="MesswertInMeter"></param>
    ''' <param name="ZielEinheit"></param>
    ''' <returns></returns>
    Public Shared Function ConvertToKompliziert(MesswertInMeter As Double, ZielEinheit As String) As Double

        ' Resistent gegen Groß/Kleinschreibung
        If ZielEinheit.ToLower() = "cm" Then
            Return 100.0 * MesswertInMeter
        ElseIf ZielEinheit = "dm" Then
            Return 10.0 * MesswertInMeter
        ElseIf ZielEinheit = "km" Then
            Return 0.001 * MesswertInMeter
        ElseIf ZielEinheit = "m" Then
            Return 1.0 * MesswertInMeter
        ElseIf ZielEinheit = "mm" Then
            Return 1000.0 * MesswertInMeter
        Else
            Return -1.0
        End If
    End Function

    ''' <summary>
    ''' Enum für Längeneinheiten = Untertyp von int
    ''' </summary>
    Public Enum LaengenEinheiten
        mm = 1
        cm = 2
        dm = 3
        m = 4
        km = 5
    End Enum

    ''' <summary>
    ''' Verbesserung: Zieleinheit als Enum. Schon Ressourcen und ist sicher !
    ''' </summary>
    ''' <param name="MesswertInMeter"></param>
    ''' <param name="ZielEinheit"></param>
    ''' <returns></returns>
    Public Shared Function ConvertTo(MesswertInMeter As Double, ZielEinheit As LaengenEinheiten) As Double

        If ZielEinheit = LaengenEinheiten.cm Then
            Return 100.0 * MesswertInMeter
        End If

        If ZielEinheit = LaengenEinheiten.dm Then
            Return 10.0 * MesswertInMeter
        End If

        If ZielEinheit = LaengenEinheiten.km Then
            Return 0.001 * MesswertInMeter
        End If

        If ZielEinheit = LaengenEinheiten.m Then
            Return 1.0 * MesswertInMeter
        End If

        If ZielEinheit = LaengenEinheiten.mm Then
            Return 1000.0 * MesswertInMeter
        End If

        Return -1.0
    End Function

    Public Shared Function ConvertTo2(MesswertInMeter As Double, ZielEinheit As LaengenEinheiten) As Double
        Select Case ZielEinheit

            Case LaengenEinheiten.cm
                Return 100.0 * MesswertInMeter
            Case LaengenEinheiten.dm
                Return 10.0 * MesswertInMeter
            Case LaengenEinheiten.km
                Return 1000.0 * MesswertInMeter

            Case Else


                'if (ZielEinheit == LaengenEinheiten.km)
                '{
                '    return 0.001 * MesswertInMeter;
                '}

                'if (ZielEinheit == LaengenEinheiten.m)
                '{
                '    return 1.0 * MesswertInMeter;
                '}

                'if (ZielEinheit == LaengenEinheiten.mm)
                '{
                '    return 1000.0 * MesswertInMeter;
                '}
                If True Then
                    Return -1.0
                End If
        End Select


    End Function


    ''' <summary>
    ''' Funktion dient zur Demo der Typprüfung zur Laufzeit
    ''' </summary>
    ''' <param name="a">Erster Summand</param>
    ''' <param name="b">Zweiter Summand</param>
    ''' <returns></returns>
    Public Shared Function AddUntypisiert(a As Object, b As Object) As Double
        ' Achtung: a und b werden als Objektboxen übergeben.
        ' Wenn b ein integer war, und nun als integerobjektbox übergeben wurde,
        ' dann ist dafür kein (double) Konvertierungsop. definiert
        ' => Unboxing durchführen in             

        Return Unboxing(a) + Unboxing(b)
    End Function


    Public Shared Sub Boxing_unboxing()
        ' Über eine Double- Konstante eine Methode aufrufen -> Boxing
        Dim txtVal = (3.14).ToString()

        Dim dblVal = 3.14

        ' Boxing beim upcast
        Dim objVal As Object = dblVal
        txtVal = objVal.ToString()

        ' Unboxing beim downcast
        Dim dblVal2 = CDbl(objVal)

        ' Scheitern, da Unboxing kann nur in einen Typ erfolgen, der
        ' er ursprünglich war
        Dim sngVal2 = CInt(objVal)

        ' Boxing/Unboxing implizit
        txtVal = dblVal.ToString()

    End Sub

    Public Shared Function Unboxing(box As Object) As Double
        ' Kann man auch mit Convert.ToDouble(box) realisieren

        Return CDbl(box)

        If TypeOf box Is Integer Then
            Return CDbl(CInt(box))
        ElseIf TypeOf box Is Short Then
            Return CDbl(CInt(box))
        End If
        If TypeOf box Is Double Then
            Return CDbl(box)
        Else
            Throw New InvalidCastException()
        End If

    End Function

    ' Überladene Funktionen lösen das Problem besser
    Public Shared Function AddT(a As Double, b As Double) As Double
        Return a + b
    End Function

    Public Shared Function AddT(a As Integer, b As Integer) As Double
        Return a + b
    End Function

    Public Shared Function AddT(a As Short, b As Short) As Double
        Return a + b
    End Function

    Public Shared Function AddT(a As String, b As String) As Double
        Return CDbl(a + b)
    End Function




End Class
