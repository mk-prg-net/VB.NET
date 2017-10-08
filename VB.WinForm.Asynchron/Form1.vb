Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "gestartet am " & Now.ToShortDateString()
    End Sub


    Sub LongTerm(ByVal Duration As Integer, ByVal symbol As String)

        Dim increment As Double = 100.0 / Duration
        Dim processed As Double = 0.0

        For i As Integer = 0 To Duration
            Debug.Write(symbol)

            processed += increment

            If StatusStrip1.InvokeRequired() Then
                StatusStrip1.Invoke(Sub() MeinProgressBar.Value = CInt(Math.Min(processed, MeinProgressBar.Maximum)))
            Else
                MeinProgressBar.Value = CInt(Math.Min(processed, MeinProgressBar.Maximum))
                Application.DoEvents()
            End If

            System.Threading.Thread.Sleep(500)
        Next

    End Sub

    ' Longterm als asynchrone Methode kennzeichnen mittels neuem ASYNC- Schlüsselwort (ab 4.0)
    Sub Job(ByVal Duration As Integer, ByVal symbol As String)

        Dim increment As Double = 100.0 / Duration
        Dim processed As Double = 0.0

        For i As Integer = 0 To Duration
            Debug.Write(symbol)

            processed += increment
            If StatusStrip1.InvokeRequired Then
                StatusStrip1.Invoke(Sub() MeinProgressBar.Value = CInt(processed))
            End If

            System.Threading.Thread.Sleep(500)
        Next

    End Sub

    Async Function LongTerm2(ByVal Duration As Integer, ByVal symbol As String) As System.Threading.Tasks.Task

        Await System.Threading.Tasks.Task.Run(
        Sub()
            LongTerm(Duration, symbol)
        End Sub)

    End Function




    Sub BinFertig(ares As IAsyncResult)

        ' Anderungen an der Oberfläche dürfen nur im Haupthread erfolgen (wo die Nachritenwarteschlange läuft)
        ' -> Aufgabe an den Hauptthread delegieren
        If tbxDisplay.InvokeRequired Then
            ' Aufgabe muss delegiert werden
            ' Delegation erfolgt durch verpacken des Arbeitsauftrages in einem Unterprogramm,
            ' dessen Einsprungadresse an den HAuptthread übermittelt wird
            tbxDisplay.Invoke(Sub() tbxDisplay.Text = "Bin fertig geworden um " & Now.ToLongTimeString())
        End If


    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tbxDisplay.Text = "Die neue Berechnung startet synchron"
        LongTerm(10, "X")
        tbxDisplay.Text = "Fertig mit synchronem Aufruf um " & Now.ToLongTimeString()

    End Sub

    Private Sub btnStartAsyncMitDelegate_Click(sender As Object, e As EventArgs) Handles btnStartAsyncMitDelegate.Click
        tbxDisplay.Text = "Die neue Berechnung startet asynchron"
        Dim dg As Action(Of Integer, String) = AddressOf LongTerm
        dg.BeginInvoke(10, "Y", AddressOf BinFertig, Nothing)

    End Sub

    Private Async Sub btnStartAsyncAwait_Click(sender As Object, e As EventArgs) Handles btnStartAsyncAwait.Click

        tbxDisplay.Text = "Die neue Berechnung startet asynchron mittels await"

        Await LongTerm2(10, "Z")

        ' Alles was hier folgt, wird in einem abgespaltenen Thread ausgeführt
        tbxDisplay.Text = "Fertig mit Async Await " & Now.ToLongTimeString()

    End Sub


End Class
