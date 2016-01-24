Option Explicit Off
Public Module _01_05_01_Variablen_Implizite_Deklaration

    Sub exe()
        ' impizite Deklaration von Variablen
        meineVariable = 0.0
        deineVariable = 0

        '…

        ' Fehler ! Buchstabendreher führt zum impliziten Deklarieren einer neuen Variable
        meineVariabel = deineVariable + 1

        ' Datentyp mal kurz ändern ...
        deineVariable = "1,2"

        ' Ausgegeben wird im Direktfenster "Wert von meineVariable: 0" !
        Debug.Print("Wert von meineVariable: " & meineVariable)

        meineVariable = deineVariable + 3
    End Sub

End Module
