Public Class Form1

    Dim ctx As New DBArtikelORMDataContext()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LieferantenBindingSource.DataSource = ctx.Lieferanten

    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Try
            ctx.SubmitChanges()
        Catch ex As Exception
            Log.Log(mko.Log.RC.CreateError(ex.Message))
        End Try

    End Sub
End Class
