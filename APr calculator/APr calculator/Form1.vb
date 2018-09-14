Public Class Form1
    Public Score As Integer
    Public Credit As Integer
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Credscore.TextChanged
        If Credit = Int(720 - 850) * -1 Then
            Score = 3.719
        ElseIf Credit = Int(690 - 719) * -1 Then
            Score = 5.071



        End If

    End Sub

    Private Sub APR_TextChanged(sender As Object, e As EventArgs) Handles APR.TextChanged
    End Sub

    Private Sub APRbtn_Click(sender As Object, e As EventArgs) Handles APRbtn.Click
        APR.Text = Score
    End Sub
End Class
