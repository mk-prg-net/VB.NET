Option Explicit On
Option Strict On
Option Infer Off
Public Module _01_05_03_Variablen_Stricte_Deklaration
    Sub exe()
        ' Explizite Deklaration von Variablen, erfodern Datentypen wg. strict
        Dim meineVariable As Integer = 0
        Dim deineVariable As Integer = 0
        'Dim eureVariable = 0

        '…

        ' Fehler ! Buchstabendreher führt zum impliziten Deklarieren einer neuen Variable
        meineVariable = deineVariable + 1

        ' Option Strict überwacht strenge Typisierung
        ' meineVariable = "2"
        meineVariable = Integer.Parse("2")

        Try
            meineVariable = Integer.Parse("2X")
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try


        ' Ausgegeben wird im Direktfenster "Wert von meineVariable: 0" !
        Debug.Print("Wert von meineVariable: " & meineVariable)


    End Sub

End Module
