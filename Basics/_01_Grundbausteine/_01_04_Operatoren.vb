Public Module _01_04_Operatoren

    ' Logische Basisfunktionen (analog Grundrechenarten in der Arithmetik): log. UND, log. ODER, log. NICHT
    '
    ' AND  | true  | false
    '------+-------+-------
    ' true | true  | false
    ' false| false | false
    '
    ' OR   | true  | false
    '------+-------+-------
    ' true | true  | true 
    ' false| true  | false
    '
    ' NOT  |              
    '------+-------        
    ' true | false        
    ' false| true      


    Public Function In_Dualzahl_konvertieren_mit_Bitops(Zahl As UInteger) As String
        Dim Bitmaske As UInteger = &H80000000UI
        'uint Bitmaske = 0xFFFFFFFFu;
        Dim dual As String = ""

        For i As Integer = 0 To 31
            ' 2) Höchste Bitstelle überprüfen auf 0 oder 1
            If (Zahl And Bitmaske) <> 0 Then
                ' 2.a) Höchste Bitstelle ist 1-> ein L ausgeben
                dual += "L"
            Else
                ' 2.b) sonst ein O ausgeben
                dual += "O"
            End If

            ' 3) Schiebe um ein Bit nach links (Richtung niederwertiger Bits -> Littel Endian !)

            ' Weiter bei 2, solange nicht alle Bits verarbeitet wurden
            Zahl <<= 1
        Next

        Return dual

    End Function

    Public Function Logische_Operatoren_in_Aussagen() As Boolean
        ' Fakten
        Dim Ich_gucke_ARD As Boolean = False
        Dim Ich_habe_ein_Fernsehgerät As Boolean = True
        Dim Ich_habe_schon_GEZahlt As Boolean = False
        Dim Ich_habe_Langeweile As Boolean = True

        ' Regeln

        ' Implikation (siehe https://de.wikipedia.org/wiki/Logische_Verkn%C3%BCpfung)
        Dim Mir_droht_der_Gerichtsvollzieher As Boolean = Ich_habe_ein_Fernsehgerät And Not Ich_habe_schon_GEZahlt

        ' Logisches ODER
        Dim Ich_gucke_fern As Boolean = Ich_habe_schon_GEZahlt Or Ich_habe_Langeweile

        Return Mir_droht_der_Gerichtsvollzieher And Ich_gucke_fern

    End Function



    Public Function Gepruefte_Festkommaoperatoren() As Boolean
        Try

            Dim x As Integer = Integer.MaxValue
            x += 1

            Return True
        Catch ex As OverflowException
            Return True
        End Try
    End Function

    Public Function Ungepruefte_Festkommaoperatoren() As Boolean
        Try
            Dim x As Integer = Integer.MaxValue
            Dim y As UInteger = UInteger.MaxValue
            x += 1
            y += 1

            Return True
        Catch ex As OverflowException
            Return False
        End Try
    End Function


    ''' <summary>
    ''' Codiert in einen Integer den Euro- und Centanteil eines Preises
    ''' </summary>
    ''' <param name="euro"></param>
    ''' <param name="cent"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Preis(euro As Integer, cent As Integer) As Integer
        'Return euro * 100 + cent
        Dim p As Integer = 0
        p = euro * 100 + cent
        Return p
    End Function

    ''' <summary>
    ''' Dekodiert aus einem Integer den Euroanteil eines Preises
    ''' </summary>
    ''' <param name="preis"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PreisEuroAnteil(preis As Integer) As Integer
        ' \ ist die INtegerdivision (keine NAchkommastellen) 
        ' / ist die Gleitkommadivision (Ergebnis ist ein double)
        Return preis \ 100
    End Function

    ''' <summary>
    ''' Dekodiert aus einem INteger den Centanteil eines Preises
    ''' </summary>
    ''' <param name="preis"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PreisCentAnteil(preis As Integer) As Integer
        Return preis - preis \ 100 * 100
    End Function


End Module
