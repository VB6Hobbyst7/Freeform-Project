Public Class Form1
    Public Tim As Integer = 60
    Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
        TimTime.Enabled = True

        TimTime.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Stopbtn.Click
        TimTime.Stop()
    End Sub

    Private Sub TimTime_Tick(sender As Object, e As EventArgs) Handles TimTime.Tick
        ' If Timerlbl.Text = 0 Then
        '  TimTime.Stop()
        ' End If
        changeTime()
        While Tim < 54
            If Tim < 54 Then
                Tim = 60
            End If
        End While

    End Sub
    Sub changeTime()
        Tim -= 1
        Select Case Tim
            Case 59
                Timerlbl.Text = "I"
            Case 58
                Timerlbl.Text = "Need"
            Case 57
                Timerlbl.Text = "you"
            Case 56
                Timerlbl.Text = "to"
            Case 55
                Timerlbl.Text = "pay"
            Case 54
                Timerlbl.Text = "close"
            Case 53
                Timerlbl.Text = "attention"
            Case -1
                TimTime.Stop()
            Case Else
                Timerlbl.Text = Tim
        End Select
    End Sub
    Sub ResetTime()
        Do While Timerlbl.Text <= 51
            If Timerlbl.Text < 51 Then
                Timerlbl.Text = 60
            End If
        Loop
    End Sub
End Class
