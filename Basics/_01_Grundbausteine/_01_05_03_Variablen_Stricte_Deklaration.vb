Option Explicit On
Option Strict On
Option Infer Off
Public Module _01_05_03_Variablen_Stricte_Deklaration
    Sub exe()
        ' Explizite Deklaration von Variablen, erfodern Datentypen wg. strict
        Dim meineVariable As Double = 0
        Dim deineVariable As Double = 0
        'Dim eureVariable = 0

        '…

        ' Fehler ! Buchstabendreher führt zum impliziten Deklarieren einer neuen Variable
        meineVariable = deineVariable + 1

        ' Option Strict überwacht strenge Typisierung
        'meineVariable = "2"
        meineVariable = Double.Parse("3,2")

        Try
            meineVariable = Double.Parse("3.2")
            meineVariable = Double.Parse("3X")
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

        ' Das US- Format erzwingen

        ' Aktuelle Kultureinstellungen sichern
        Dim cultBackup As System.Globalization.CultureInfo
        cultBackup = System.Threading.Thread.CurrentThread.CurrentCulture

        ' US- Kultur  einstellen
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        meineVariable = Double.Parse("3.2")
        meineVariable = Double.Parse("4,5", cultBackup.NumberFormat)

        ' Wieder auf alte Kultur zurückstellen

        System.Threading.Thread.CurrentThread.CurrentCulture = cultBackup

        Dim chKultur As System.Globalization.CultureInfo = New System.Globalization.CultureInfo("de-CH")

        Dim einSchweizerWert As Double

        einSchweizerWert = Double.Parse("1'324.56", chKultur.NumberFormat)








        ' Ausgegeben wird im Direktfenster "Wert von meineVariable: 0" !
        Debug.Print("Wert von meineVariable: " & meineVariable)


    End Sub

End Module
