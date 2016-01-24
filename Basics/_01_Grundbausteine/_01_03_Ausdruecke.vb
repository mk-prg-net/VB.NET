Public Module _01_03_Ausdruecke

    ''' <summary>
    ''' Pi aus einem Kettenbruch errechnen: https://de.wikipedia.org/wiki/Kreiszahl#Kettenbruchentwicklung 
    ''' </summary>
    ''' <returns></returns>
    Function F_Pi_Kettenbruch() As Double

        Return 3.0 + (1.0 / (7.0 + 1.0 / (15.0 + 1.0 / (1.0 + 1.0 / 292.0 + 1.0 / (1.0 + 1.0 / (1.0 + 1.0 / (1.0 + 1.0 / (2.0 + 1.0 / (1.0 + 1.0 / (3.0 + 1.0 / (1.0 + 1.0 / (14.0 + 1.0 / (2.0 + 1.0 / (1.0 + 1.0 / (1.0 + 1.0 / 2.0)))))))))))))))
    End Function

    Public Function F_Pi_Kettenbruch2() As Double

        ' Die lange Kettenbruchberechnung wird auf mehrere Zeilen verteilt
        Return 3.0 + (1.0 / (7.0 + 1.0 / (15.0 + 1.0 / _
                (1.0 + 1.0 / 292.0 + 1.0 / (1.0 + 1.0 / _
                (1.0 + 1.0 / (1.0 + 1.0 / (2.0 + 1.0 / _
                (1.0 + 1.0 / (3.0 + 1.0 / (1.0 + 1.0 / _
                (14.0 + 1.0 / (2.0 + 1.0 / (1.0 + 1.0 / _
                (1.0 + 1.0 / 2.0)))))))))))))))
    End Function



    Public Sub F_Mathemat_Funktionen()

        Dim res = Math.Sin(Math.PI / 2)

    End Sub

    ''' <summary>
    ''' Grössten gemeinsamen Teiler zweier Ganzer Zahlen mittels Euklidischen Algorithmus berechnen
    ''' Siehe https://de.wikipedia.org/wiki/Euklidischer_Algorithmus
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    Public Function GGT(a As Integer, b As Integer) As Integer
        ' Kombinierter Einstaz von ternären Operator und der Identität
        Return IIf(b = 0, a, GGT(b, a Mod b))
    End Function


    Public Function GGT2(a As Integer, b As Integer) As Integer
        ' Anstatt ternärer Operator der If- Block
        If b = 0 Then
            Return a
        Else
            Return GGT2(b, a Mod b)
        End If

    End Function


End Module
