Public Class Form1
    Public Score As Double
    Public Credit As Integer
    Public CarVal As Integer
    Public TotalInterest As Double
    Public TotCost As Double
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles Income.TextChanged, Debt.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Debt.Text / Income.Text) * 100 <= 35 Then
            MessageBox.Show("You are eligible for a Loan.")
            Credscore.Enabled = True
            CarValue.Enabled = True
            yearbox.Enabled = True
        ElseIf (Debt.Text / Income.Text) * 100 > 35 Then
            MessageBox.Show("You are NOT eligible for a Loan.")
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Credscore.TextChanged
        Credit = Credscore.Text
        If Credit >= 720 And Credit <= 850 Then
            Score = 3.719
        ElseIf Credit >= 690 And Credit <= 719 Then
            Score = 5.071
        ElseIf Credit >= 660 And Credit <= 689 Then
            Score = 7.139
        ElseIf Credit >= 620 And Credit <= 659 Then
            Score = 9.882
        ElseIf Credit >= 590 And Credit <= 619 Then
            Score = 14.135
        ElseIf Credit >= 500 And Credit <= 589 Then
            Score = 15.297
        End If

    End Sub
    Private Sub APR_TextChanged(sender As Object, e As EventArgs) Handles APR.TextChanged
    End Sub

    Private Sub Calcbtn_Click(sender As Object, e As EventArgs) Handles Calcbtn.Click
        APR.Text = Score
        CarVal = CarValue.Text

        TotalInt(Score, yearbox.Text)

        TotalCost()

        Monthlycost(yearbox.Text)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Monthlypaytxt_TextChanged(sender As Object, e As EventArgs) Handles Monthlypaytxt.TextChanged

    End Sub
    Sub TotalInt(ByVal apr As Double, numMo As Integer)
        numMo = numMo \ 12
        TotalInterest = apr * numMo
        TotInt.Text = TotalInterest
    End Sub
    Sub TotalCost()
        TotalInterest = TotalInterest * 0.01 + 1
        TotCost = TotalInterest * CarVal
        Totalcostbox.Text = TotCost
    End Sub

    Sub Monthlycost(ByVal numMo2)
        Monthlypaytxt.Text = TotCost / numMo2
    End Sub
End Class
