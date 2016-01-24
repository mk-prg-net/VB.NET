Public Class Form1

    Private Sub BeeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Dim primzahlen As New List(Of Long)

    Private Sub btnStartScan_Click(sender As Object, e As EventArgs) Handles btnStartScan.Click
        Try

            Dim von As Long
            Dim bis As Long

            ' Einelsen der Daten aus den Steuerelementen

            If Long.TryParse(tbxVon.Text, von) Then
                If Long.TryParse(tbxBis.Text, bis) Then

                    ' Alte Ergebnisse löschen
                    primzahlen.Clear()

                    ' Primzahlensuche starten
                    mkoAlgorithm.findenIn(von, bis, primzahlen)

                    ' Anzahl gefundener Primzahlen ausgeben
                    lblCountPrim.Text = primzahlen.Count.ToString()

                End If
            Else
                MessageBox.Show("von muss eine Zahl sein")
            End If

        Catch ex As Exception

        End Try
    End Sub


    Dim scanAction As Action(Of Long, Long, List(Of Long))

    Dim ares As IAsyncResult


    Sub Rückmeldung(ares As IAsyncResult)
        MessageBox.Show("Bin fertig")
    End Sub

    Sub Rückmeldung2(ares As IAsyncResult)
        MessageBox.Show("Bin fertig 2")
    End Sub


    Private Sub btnStartScanAsynchron_Click(sender As Object, e As EventArgs) Handles btnStartScanAsynchron.Click
        Try

            Dim von As Long
            Dim bis As Long

            ' Einelsen der Daten aus den Steuerelementen

            If Long.TryParse(tbxVon.Text, von) Then
                If Long.TryParse(tbxBis.Text, bis) Then

                    ' Alte Ergebnisse löschen
                    primzahlen.Clear()

                    scanAction = AddressOf mkoAlgorithm.findenIn

                    ares = scanAction.BeginInvoke(von, bis, primzahlen, AddressOf Rückmeldung, Nothing)

                    Debug.WriteLine("Primzahlsuche gestartet")
                    ToolStripStatusLabel1.Text = "Primzahlsuche gestartet"

                End If
            Else
                MessageBox.Show("von muss eine Zahl sein")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Function Inc(ByRef z As Long) As Long
        z += 1
        Return z
    End Function

    Private Sub btnStatusAbrufen_Click(sender As Object, e As EventArgs) Handles btnStatusAbrufen.Click
        If Not ares Is Nothing Then
            If ares.IsCompleted Then
                scanAction.EndInvoke(ares)

                ToolStripStatusLabel1.Text = "Scan ist fertig"
                lblCountPrim.Text = primzahlen.Count.ToString()

                ' Ausgabe der Primzahlen als Tabelle durch zuweisen an die DataSource- Eigenschaft
                Dim zähler As Long
                BindingSource1.DataSource = primzahlen.Select(Function(r) New PrimZahl() With {.Nr = Inc(zähler), .Zahl = r}).ToArray()
                BindingSource1.ResetBindings(False)

                Me.Refresh()

                ares = Nothing
            Else

                ToolStripStatusLabel1.Text = "Scan läuft noch..."
            End If
        Else
            ToolStripStatusLabel1.Text = "Kein asynchrone Scan gestartet"
        End If

    End Sub


    Dim ares2 As IAsyncResult
    Private Sub btnStartScanAsynchron2Threads_Click(sender As Object, e As EventArgs) Handles btnStartScanAsynchron2Threads.Click
        Try

            Dim von As Long
            Dim bis As Long

            ' Einelsen der Daten aus den Steuerelementen

            If Long.TryParse(tbxVon.Text, von) Then
                If Long.TryParse(tbxBis.Text, bis) Then

                    ' Alte Ergebnisse löschen
                    primzahlen.Clear()

                    scanAction = AddressOf mkoAlgorithm.findenIn

                    Dim diameter = bis - von

                    ares = scanAction.BeginInvoke(von, von + diameter / 2, primzahlen, AddressOf Rückmeldung, Nothing)
                    ares2 = scanAction.BeginInvoke(bis - diameter / 2, bis, primzahlen, AddressOf Rückmeldung2, Nothing)

                    Debug.WriteLine("Primzahlsuche gestartet")
                    ToolStripStatusLabel1.Text = "Primzahlsuche gestartet"

                End If
            Else
                MessageBox.Show("von muss eine Zahl sein")
            End If

        Catch ex As Exception

        End Try

    End Sub


    Dim test() As String = {"Hallo", "Welt"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
