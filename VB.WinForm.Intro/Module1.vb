Module Module1

    Sub VerarbeiteEingaben(Eingabe As String)
        Debug.WriteLine(mko.TraceHlp.FormatInfoMsg("Module1", "VerarbeiteEingaben", "Eingabe", Eingabe))
    End Sub

    ''' <summary>
    ''' Folgende Eingaben werden verarbeitet:
    ''' [Operator] [Wert1] [Wert2]
    ''' z.B. + 2,3 4,6 -> 6,9
    ''' </summary>
    ''' <param name="Eingabe"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function VerarbeiteEingabeZuErgebnis(Eingabe As String) As Double



    End Function

End Module
