Public Class WTmplForm

    Protected Log As New mko.Log.LogServer()

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        ' Beendet eine WinForm- Anwendung
        Application.Exit()
    End Sub

    Private Sub WTmplForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lbxLogHnd As New mko.Log.WinFormListBoxLogHnd(LbxWTmplLog)
        Log.registerLogHnd(lbxLogHnd)

    End Sub

    Private Sub btnWTmplLogTest_Click(sender As Object, e As EventArgs) Handles btnWTmplLogTest.Click
        Log.Log(mko.Log.RC.CreateMsg("Eine Testnachricht"))
    End Sub

    Private Sub btnWTmplLogClear_Click(sender As Object, e As EventArgs) Handles btnWTmplLogClear.Click
        LbxWTmplLog.Items.Clear()
    End Sub
End Class
