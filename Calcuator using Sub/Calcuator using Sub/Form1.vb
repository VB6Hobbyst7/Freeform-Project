Public Class Form1
    Private Sub TextNum1_TextChanged(sender As Object, e As EventArgs) Handles TextNum1.TextChanged
    End Sub
    Sub Add(ByVal NumOne As Integer, NumTwo As Integer)
        Ans.Text = NumOne + NumTwo
    End Sub
    Sub Min(ByVal NumOne As Integer, NumTwo As Integer)
        Ans.Text = NumOne - NumTwo
    End Sub
    Sub Div(ByVal NumOne As Integer, NumTwo As Integer)
        Ans.Text = NumOne / NumTwo
    End Sub
    Sub Mult(ByVal NumOne As Integer, NumTwo As Integer)
        Ans.Text = NumOne * NumTwo
    End Sub
    Private Sub Calcbtn_Click(sender As Object, e As EventArgs) Handles Calcbtn.Click
        If Operationcbo.Text.Equals("+") Then
            Add(TextNum1.Text, TextNum2.Text)
        ElseIf Operationcbo.Text.Equals("-") Then
            Min(TextNum1.Text, TextNum2.Text)
        ElseIf Operationcbo.Text.Equals("*") Then
            Mult(TextNum1.Text, TextNum2.Text)
        ElseIf Operationcbo.Text.Equals("/") Then
            Div(TextNum1.Text, TextNum2.Text)
        End If

        If Operationcbo.Text = ("") Then
            MessageBox.Show("Dont forget to select an Operation")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Operationcbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Operationcbo.SelectedIndexChanged
    End Sub

    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        TextNum1.Clear()
        TextNum2.Clear()
        Ans.Text = 0
    End Sub
End Class

