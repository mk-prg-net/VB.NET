Public Module NumberTheory
    Public Function IsPrime(z As Long) As Boolean
        ' Entscheidungen für Sonderfälle wie 1 und 2 werden direkt getroffen
        ' Für alle anderen werte wird mittels Rekursion die Probe auf Teilbarkeit 
        ' mit allen möglichen Teilern durchgeführt
        Return z = 2 OrElse (z <> 1) AndAlso (z Mod 2 <> 0 AndAlso IsNotFactor(z, 3, z / 2))
    End Function

    Private Function IsNotFactor(z As Long, factor As Long, maxPossibleFactor As Long) As Boolean
        If factor >= maxPossibleFactor Then
            ' Fall: alle möglichen Prüfungen auf Teilbarkeit blieben erfolglos
            Return True
        Else
            ' Fall: eine Prüfung wird durchgeführt und das Prüfergebnis mit
            ' den Ergebnissen aus den restlichen noch anstehenden Prüfungen 
            ' logisch UND verknüpft.
            Return z Mod factor <> 0 AndAlso IsNotFactor(z, factor + 2, maxPossibleFactor)
        End If
    End Function

    ''' <summary>
    ''' Erzeugt eine Liste aller Primzahlen im Intervall [a, b]
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    Public Function PrimeScan(a As Long, b As Long) As IEnumerable(Of Long)
        If a > b Then
            Return LISP.L(Of Long)()
        ElseIf IsPrime(a) Then
            ' Primzahliste besteht aus a und den restlichen Primzahlen zw. [a+1, b]
            Return LISP.Concat(LISP.L(a), PrimeScan(a + 1, b))
        Else
            ' Primzahliste besteht aus den restlichen Primzahlen zw. [a+1, b]
            Return PrimeScan(a + 1, b)
        End If
    End Function

End Module


