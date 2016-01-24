Public Class Form1

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "MyArtikelDBInstance.Lieferanten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.LieferantenTableAdapter.Fill(Me.MyArtikelDBInstance.Lieferanten)

    End Sub

    Private Sub ÄnderungenSpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÄnderungenSpeichernToolStripMenuItem.Click
        Me.LieferantenTableAdapter.Update(Me.MyArtikelDBInstance.Lieferanten)
    End Sub

    Private Sub AlleMitPlz7xxxxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlleMitPlz7xxxxToolStripMenuItem.Click
        Me.MyArtikelDBInstance.Lieferanten.Clear()

        Me.LieferantenTableAdapter.FillByPlz(MyArtikelDBInstance.Lieferanten, "7%")
    End Sub
End Class
