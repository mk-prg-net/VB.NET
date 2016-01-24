Imports mko.VB.Db
Public Class Form1

    Dim Lfc As New LieferantenViewCollection()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using orm As New VB.Func.EntityFramework.DBArtikelEntities1

            Lfc.LoadEntites(orm.Lieferanten.Where(Function(r) r.plz.StartsWith("5")))

            LieferantenBindingSource.DataSource = Lfc

        End Using

    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        Using orm As New VB.Func.EntityFramework.DBArtikelEntities1
            ' Aktualisieren der Entitycollection im ORM mit den an den EntityViews vorgenommenene
            ' Änderungen
            'UpdateWithObservableViewCollection(orm.Lieferanten, Lfc)

            ' Änderungen mit der Datenbank synchronisieren
            orm.SaveChanges()

        End Using

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Using orm As New VB.Func.EntityFramework.DBArtikelEntities1
            ' Alte Einträge löschen
            Lfc.Clear()

            ' Alle Lieferanten laden
            Lfc.LoadEntites(orm.Lieferanten)

            ' BindingSOurce muss (darf!) hier nicht erneut gesetzt werden
            'LieferantenBindingSource.DataSource = Lfc
        End Using
        ' Trotzdem muss die Aktualisierung der Bindingsource manuell angestossen werden
        LieferantenBindingSource.ResetBindings(False)
    End Sub

    Private Sub btnPLZ50000_Click(sender As Object, e As EventArgs) Handles btnPLZ50000.Click

        Using orm As New VB.Func.EntityFramework.DBArtikelEntities1
            ' Alte Einträge löschen
            Lfc.Clear()

            ' Alle Lieferanten laden
            Lfc.LoadEntites(orm.Lieferanten.Where(Function(r) r.plz < 50000))

            ' BindingSOurce muss (darf!) hier nicht erneut gesetzt werden
            'LieferantenBindingSource.DataSource = Lfc
        End Using
        ' Trotzdem muss die Aktualisierung der Bindingsource manuell angestossen werden
        LieferantenBindingSource.ResetBindings(False)

    End Sub
End Class
