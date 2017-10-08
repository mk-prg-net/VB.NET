Option Explicit On
Option Strict On
Option Infer On
Public Module _01_05_04_Variablen_Typinferenz

    Sub exe()
        ' Typinferenz: trotz strict kann auf den Datentypen verzichtet werden.
        ' Wird aus dem Typ des zugewiesenen Wertes hergeleitet
        Dim meineVariableStrict As Double = 0.0
        Dim meineVariable = 2.5
        Dim deineVariable = 0
        Dim eureVariable = "0"

        'deineVariable = 5.8
        deineVariable = CInt(5.8)

        ' Typinferenz verwässert die strengen Typisirungsregeln nicht !
        ' meineVariable = "1,2"

        ' Fehler ! Buchstabendreher führt zum impliziten Deklarieren einer neuen Variable
        meineVariable = deineVariable + 1

        ' Ausgegeben wird im Direktfenster "Wert von meineVariable: 0" !
        Debug.Print("Wert von meineVariable: " & meineVariable)
    End Sub

End Module
