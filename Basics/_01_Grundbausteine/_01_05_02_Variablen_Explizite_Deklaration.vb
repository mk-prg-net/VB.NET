Option Explicit On
Option Infer Off
Public Module _01_05_02_Variablen_Explizite_Deklaration

    Sub exe()
        ' impizite Deklaration von Variablen
        Dim meineVariable = 0
        Dim deineVariable = 0

        '…

        ' Fehler ! Buchstabendreher führt zum impliziten Deklarieren einer neuen Variable
        'meineVariabel = deineVariable + 1

        deineVariable = "3,2"

        ' Ausgegeben wird im Direktfenster "Wert von meineVariable: 0" !
        Debug.Print("Wert von meineVariable: " & meineVariable)

        meineVariable = deineVariable + 1
        Debug.Print("Wert von meineVariable: " & meineVariable)
    End Sub

End Module
