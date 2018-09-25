Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                movement.Enabled = True
                C1.Top -= 10
                C2.Top -= 10
                C3.Top -= 10
            Case Keys.Down
                movement.Enabled = True
                C1.Top += 10
                C2.Top += 10
                C3.Top += 10
            Case Keys.Right
                movement.Enabled = True
                C1.Left += 10
                C2.Left += 10
                C3.Left += 10
            Case Keys.Left
                movement.Enabled = True
                C1.Left -= 10
                C2.Left -= 10
                C3.Left -= 10
        End Select
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click

    End Sub

    Private Sub movement_Tick(sender As Object, e As EventArgs) Handles movement.Tick
        If C1.Visible = True Then
            C1.Visible = False
            C2.Visible = True
        ElseIf C2.Visible = True Then
            C2.Visible = False
            C3.Visible = True
        ElseIf C3.Visible = True Then
            C3.Visible = False
            C1.Visible = True
        End If
    End Sub
End Class
