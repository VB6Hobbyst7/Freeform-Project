Public Class Form1
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles Income.TextChanged, Debt.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Debt.Text / Income.Text) * 100 <= 35 Then
            MessageBox.Show("You are eligible for a Loan.")
        ElseIf (Debt.Text / Income.Text) * 100 > 35 Then
            MessageBox.Show("You are NOT eligible for a Loan.")
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
