Public Class Form1

    ' Eventhandler für Ausgabe von Fehlern in Messagebox
    Sub MsgBoxHandler(userid As String, info As mko.Log.ILogInfo)
        MessageBox.Show(info.Message, IIf(info.LogType = mko.Log.EnumLogType.Error, "Fehler", "Info"), _
                        MessageBoxButtons.OK, _
                        IIf(info.LogType = mko.Log.EnumLogType.Error, MessageBoxIcon.Error, MessageBoxIcon.Information))
    End Sub

    Private Sub btnErzeugeFehler_Click(sender As Object, e As EventArgs) Handles btnErzeugeFehler.Click
        Log.Log(mko.Log.RC.CreateError("Eine Testfehlermeldung"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub btnAddMessageBoxFehlerMeldung_Click(sender As Object, e As EventArgs) Handles btnAddMessageBoxFehlerMeldung.Click
        ' Einen weitern Eventhandler für das EventError- Event vom Log Objekt registrieren
        AddHandler Log.EventLog, AddressOf MsgBoxHandler
    End Sub

    Private Sub btnRemoveMEssageBoxFEhlerMeldung_Click(sender As Object, e As EventArgs) Handles btnRemoveMEssageBoxFEhlerMeldung.Click
        RemoveHandler Log.EventLog, AddressOf MsgBoxHandler
    End Sub
End Class
