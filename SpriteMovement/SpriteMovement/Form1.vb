Public Class Form1
    Public moveRight As Boolean
    Public moveLeft As Boolean
    Public moveUp As Boolean
    Public moveDown As Boolean
    Public Anichar_Right As Integer = 4
    Public Anichar_Up As Integer = 4
    Public Anichar_Down As Integer = 4
    Public Anichar_Left As Integer = 4
    Public Shoot As Integer
    Public Shoot2 As Integer
    Public BulletarrayRight() As PictureBox
    Public BulletNumberRight As Integer = -1

#Region "Movement & Animation"
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = True
                Animation_Right.Enabled = True
            Case Keys.Up
                moveUp = True
                Animation_Up.Enabled = True
            Case Keys.Left
                moveLeft = True
                Animation_Left.Enabled = True
            Case Keys.Down
                moveDown = True
                Animation_Down.Enabled = True
            Case Keys.Space
                Shootright()
        End Select
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = False
                Animation_Right.Enabled = False
                C1.Image = My.Resources.Pokemon_right_1
            Case Keys.Up
                moveUp = False
                Animation_Up.Enabled = False
                C1.Image = My.Resources.Pokemon_Up_1
            Case Keys.Left
                moveLeft = False
                Animation_Left.Enabled = False
                C1.Image = My.Resources.Pokemon_Left_1
            Case Keys.Down
                moveDown = False
                Animation_Down.Enabled = False
                C1.Image = My.Resources.Pokemon_Down_1
        End Select
    End Sub
    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click

    End Sub

    Private Sub movement_Tick(sender As Object, e As EventArgs) Handles movement.Tick
        If moveRight = True Then
            C1.Left = C1.Left + 3
        End If

        If moveLeft = True Then
            C1.Left = C1.Left - 3
        End If

        If moveUp = True Then
            C1.Top = C1.Top - 3
        End If

        If moveDown = True Then
            C1.Top = C1.Top + 3
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        movement.Start()
        Animation_Right.Enabled = False
        Animation_Up.Enabled = False
        Animation_Down.Enabled = False
        Animation_Left.Enabled = False
        bullet_movement.Enabled = False
    End Sub
    Sub AnimationChar_right()
        Anichar_Right -= 1
        Select Case Anichar_Right
            Case 4
                C1.Image = My.Resources.Pokemon_right_1
            Case 3
                C1.Image = My.Resources.Pokemon_right_2
            Case 2
                C1.Image = My.Resources.Pokemon_right_3
            Case 1
                C1.Image = My.Resources.Pokemon_right_4
        End Select
    End Sub

    Private Sub Animation_right_Tick(sender As Object, e As EventArgs) Handles Animation_Right.Tick
        AnimationChar_right()
        While Anichar_Right < 1
            If Anichar_Right < 1 Then
                Anichar_Right = 4
            End If
        End While
    End Sub

    Private Sub Animation_Up_Tick(sender As Object, e As EventArgs) Handles Animation_Up.Tick
        AnimationChar_Up()
        While Anichar_Up < 1
            If Anichar_Up < 1 Then
                Anichar_Up = 4
            End If
        End While
    End Sub
    Sub AnimationChar_Up()
        Anichar_Up -= 1
        Select Case Anichar_Up
            Case 4
                C1.Image = My.Resources.Pokemon_Up_1
            Case 3
                C1.Image = My.Resources.Pokemon_Up_2
            Case 2
                C1.Image = My.Resources.Pokemon_Up_3
            Case 1
                C1.Image = My.Resources.Pokemon_Up_4
        End Select
    End Sub

    Private Sub Animation_Down_Tick(sender As Object, e As EventArgs) Handles Animation_Down.Tick
        AnimationChar_Down()
        While Anichar_Down < 1
            If Anichar_Down < 1 Then
                Anichar_Down = 4
            End If
        End While
    End Sub
    Sub AnimationChar_Down()
        Anichar_Down -= 1
        Select Case Anichar_Down
            Case 4
                C1.Image = My.Resources.Pokemon_Down_1
            Case 3
                C1.Image = My.Resources.Pokemon_Down_2
            Case 2
                C1.Image = My.Resources.Pokemon_Down_3
            Case 1
                C1.Image = My.Resources.Pokemon_Down_4
        End Select
    End Sub

    Private Sub Animation_Left_Tick(sender As Object, e As EventArgs) Handles Animation_Left.Tick
        animationChar_Left()
        While Anichar_Left < 1
            If Anichar_Left < 1 Then
                Anichar_Left = 4
            End If
        End While
    End Sub
    Sub animationChar_Left()
        Anichar_Left -= 1
        Select Case Anichar_Left
            Case 4
                C1.Image = My.Resources.Pokemon_Left_1
            Case 3
                C1.Image = My.Resources.Pokemon_Left_2
            Case 2
                C1.Image = My.Resources.Pokemon_Left_3
            Case 1
                C1.Image = My.Resources.Pokemon_Left_4
        End Select
    End Sub
#End Region

    Private Sub Right_bounds_Tick(sender As Object, e As EventArgs) Handles Right_bounds.Tick
        If C1.Bounds.IntersectsWith(Right_boundary.Bounds) Then
            C1.Left = C1.Left - 3
        End If
        Shoot = C1.Top + 10
        Shoot2 = C1.Left + 50
    End Sub
    Private Sub Left_bounds_Tick(sender As Object, e As EventArgs) Handles Left_bounds.Tick
        If C1.Bounds.IntersectsWith(Left_boundary.Bounds) Then
            C1.Left = C1.Left + 3
        End If
    End Sub
    Private Sub Top_bounds_Tick(sender As Object, e As EventArgs) Handles Top_bounds.Tick
        If C1.Bounds.IntersectsWith(Top_boundary.Bounds) Then
            C1.Top = C1.Top + 3
        End If
    End Sub

    Private Sub Bottom_bounds_Tick(sender As Object, e As EventArgs) Handles Bottom_bounds.Tick
        If C1.Bounds.IntersectsWith(Bottom_boundary.Bounds) Then
            C1.Top = C1.Top - 3
        End If
    End Sub
    Sub Shootright()
        Dim Shoot_right As New PictureBox
        Shoot_right.Top = Shoot
        Shoot_Right.Left = Shoot2
        Shoot_Right.Size = New Size(10, 10)
        Shoot_Right.BackColor = Color.Blue
        Controls.Add(Shoot_Right)
        bullet_movement.Start()
        BulletNumberRight += 1
        ReDim Preserve BulletarrayRight(BulletNumberRight)
        BulletarrayRight(BulletNumberRight) = Shoot_right
    End Sub

    Private Sub bullet_movement_Tick(sender As Object, e As EventArgs) Handles bullet_movement.Tick
        Dim I As Integer
        For I = 0 To BulletNumberRight
            BulletarrayRight(I).Left += 10
            If BulletarrayRight(I).Bounds.IntersectsWith(Right_boundary.Bounds) Then
                Me.Controls.Remove(BulletarrayRight(I))
            End If
        Next
    End Sub
End Class