Public Class Form1
    Public moveRight As Boolean
    Public moveLeft As Boolean
    Public moveUp As Boolean
    Public moveDown As Boolean
    Public Anichar As Integer = 4

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = True
                Animation.Enabled = True
            Case Keys.Up
                moveUp = True
                Animation.Enabled = True
            Case Keys.Left
                moveLeft = True
                Animation.Enabled = True
            Case Keys.Down
                moveDown = True
                Animation.Enabled = True
        End Select
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = False
                Animation.Enabled = False
                'C1.Image = My.Resources.mario1
            Case Keys.Up
                moveUp = False
                Animation.Enabled = False
                'C1.Image = My.Resources.mario1
            Case Keys.Left
                moveLeft = False
                Animation.Enabled = False
                'C1.Image = My.Resources.mario1
            Case Keys.Down
                moveDown = False
                Animation.Enabled = False
                'C1.Image = My.Resources.mario1
        End Select
    End Sub
    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click

    End Sub

    Private Sub movement_Tick(sender As Object, e As EventArgs) Handles movement.Tick
        If moveRight = True Then
            C1.Left = C1.Left + 5
        End If

        If moveLeft = True Then
            C1.Left = C1.Left - 5
        End If

        If moveUp = True Then
            C1.Top = C1.Top - 5
        End If

        If moveDown = True Then
            C1.Top = C1.Top + 5
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        movement.Start()
        Animation.Enabled = False
    End Sub
    Sub AnimationChar()
        Anichar -= 1
        Select Case Anichar
            Case 3
                C1.Image = My.Resources.mario1
            Case 2
                C1.Image = My.Resources.mario2
            Case 1
                C1.Image = My.Resources.mario3
        End Select
    End Sub

    Private Sub Animation_Tick(sender As Object, e As EventArgs) Handles Animation.Tick
        AnimationChar()
        While Anichar < 1
            If Anichar < 1 Then
                Anichar = 4
            End If
        End While
    End Sub
End Class
