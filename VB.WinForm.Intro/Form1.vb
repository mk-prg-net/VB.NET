Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine(mko.TraceHlp.FormatInfoMsg(Me, "Form_Load"))

        OpSelectionListBindingSource.DataSource = Calculator.OpSelectionList

        ProtocolBindingSource.DataSource = Calculator.Protocol
    End Sub
    
    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click

        Dim Op As Calculator.Operatoren = CType(cmbxOpSelection.SelectedValue, Calculator.Operatoren)
        Dim A As Decimal
        If Not Decimal.TryParse(tbxA.Text, A) Then
            MessageBox.Show(tbxA.Text & " ist keine Zahl")
            Exit Sub
        End If

        Dim B As Decimal
        If Not Decimal.TryParse(tbxB.Text, B) Then
            MessageBox.Show(tbxB.Text & " ist keine Zahl")
            Exit Sub
        End If


        Select Case Op
            Case Calculator.Operatoren.Add
                tbxResult.Text = Calculator.ADD(A, B).ToString()
            Case Calculator.Operatoren.Subtract
                tbxResult.Text = Calculator.Subtract(A, B).ToString()
            Case Calculator.Operatoren.Mul
                tbxResult.Text = Calculator.Mul(A, B).ToString()
            Case Calculator.Operatoren.Div
                tbxResult.Text = Calculator.Div(A, B).ToString()
            Case Else
                MessageBox.Show("Unbekannte Operation")
        End Select

        ProtocolBindingSource.DataSource = Calculator.Protocol.ToArray()


    End Sub
End Class
