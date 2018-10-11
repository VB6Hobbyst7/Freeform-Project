Public Class Form1
    Public moveRight As Boolean
    Public moveLeft As Boolean
    Public moveUp As Boolean
    Public moveDown As Boolean
    Public Anichar_Right As Integer = 4
    Public Anichar_Up As Integer = 4
    Public Anichar_Down As Integer = 4
    Public Anichar_Left As Integer = 4
    Public BulletarrayRight() As PictureBox
    Public BulletNumberRight As Integer = -1
    Public Bullet_arrayLeft() As PictureBox
    Public BulletNumberLeft As Integer = -1
    Public Bullet_arrayUp() As PictureBox
    Public BulletNumberUp As Integer = -1
    Public Bullet_arrayDown() As PictureBox
    Public BulletNumberDown As Integer = -1
    Public PokRight As Image = My.Resources.Pokemon_right_1
    Public PokRight2 As Image = My.Resources.Pokemon_right_2
    Public PokRight3 As Image = My.Resources.Pokemon_right_3
    Public PokRight4 As Image = My.Resources.Pokemon_right_4
    Public PokLeft As Image = My.Resources.Pokemon_Left_1
    Public PokLeft2 As Image = My.Resources.Pokemon_Left_2
    Public PokLeft3 As Image = My.Resources.Pokemon_Left_3
    Public PokLeft4 As Image = My.Resources.Pokemon_Left_4
    Public PokDown As Image = My.Resources.Pokemon_Down_1
    Public PokDown2 As Image = My.Resources.Pokemon_Down_2
    Public PokDown3 As Image = My.Resources.Pokemon_Down_3
    Public PokDown4 As Image = My.Resources.Pokemon_Down_4
    Public PokUp As Image = My.Resources.Pokemon_Up_1
    Public PokUp2 As Image = My.Resources.Pokemon_Up_2
    Public PokUp3 As Image = My.Resources.Pokemon_Up_3
    Public PokUp4 As Image = My.Resources.Pokemon_Up_4
    Public enemycount As Integer = -1
    Public Enemyarray() As PictureBox
    Public F As Integer
    Public Shoot_Left As New PictureBox
    Public Enemy1 As New PictureBox


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DoubleBuffered = True
    End Sub

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
                If C1.Image Is PokRight Or C1.Image Is PokRight2 Or C1.Image Is PokRight3 Or C1.Image Is PokRight4 Then
                    Shootright()
                End If
                If C1.Image Is PokLeft Or C1.Image Is PokLeft2 Or C1.Image Is PokLeft3 Or C1.Image Is PokLeft4 Then
                    Shootleft()
                End If
                If C1.Image Is PokDown Or C1.Image Is PokDown2 Or C1.Image Is PokDown3 Or C1.Image Is PokDown4 Then
                    Shootdown()
                End If
                If C1.Image Is PokUp Or C1.Image Is PokUp2 Or C1.Image Is PokUp3 Or C1.Image Is PokUp4 Then
                    Shootup()
                End If
                'e.SuppressKeyPress = True

        End Select
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = False
                Animation_Right.Enabled = False
                C1.Image = PokRight
            Case Keys.Up
                moveUp = False
                Animation_Up.Enabled = False
                C1.Image = PokUp
            Case Keys.Left
                moveLeft = False
                Animation_Left.Enabled = False
                C1.Image = PokLeft
            Case Keys.Down
                moveDown = False
                Animation_Down.Enabled = False
                C1.Image = PokDown
                'Case Keys.Space
                'e.SuppressKeyPress = False
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
        C1.Image = PokDown
        movement.Start()
        Animation_Right.Enabled = False
        Animation_Up.Enabled = False
        Animation_Down.Enabled = False
        Animation_Left.Enabled = False
        bullet_movement.Enabled = False
        Spawn.Start()

    End Sub
    Sub AnimationChar_right()
        Anichar_Right -= 1
        Select Case Anichar_Right
            Case 4
                C1.Image = PokRight
            Case 3
                C1.Image = PokRight2
            Case 2
                C1.Image = PokRight3
            Case 1
                C1.Image = PokRight4
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
                C1.Image = PokUp
            Case 3
                C1.Image = PokUp2
            Case 2
                C1.Image = PokUp3
            Case 1
                C1.Image = PokUp4
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
                C1.Image = PokDown
            Case 3
                C1.Image = PokDown2
            Case 2
                C1.Image = PokDown3
            Case 1
                C1.Image = PokDown4
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
                C1.Image = PokLeft
            Case 3
                C1.Image = PokLeft2
            Case 2
                C1.Image = PokLeft3
            Case 1
                C1.Image = PokLeft4
        End Select
    End Sub
#End Region

    Private Sub Bounds_Tick(sender As Object, e As EventArgs) Handles Bounds.Tick
        If C1.Bounds.IntersectsWith(Right_boundary.Bounds) Then
            C1.Left = C1.Left - 3
        End If

        If C1.Bounds.IntersectsWith(Left_boundary.Bounds) Then
            C1.Left = C1.Left + 3
        End If

        If C1.Bounds.IntersectsWith(Top_boundary.Bounds) Then
            C1.Top = C1.Top + 3
        End If

        If C1.Bounds.IntersectsWith(Bottom_boundary.Bounds) Then
            C1.Top = C1.Top - 3
        End If
    End Sub
#Region "Shooting"
    Sub Shootright()
        Dim Shoot_right As New PictureBox
        Shoot_right.Top = C1.Top + 15
        Shoot_right.Left = C1.Left + 15
        Shoot_right.Size = New Size(10, 10)
        Shoot_right.BackColor = Color.Blue
        Controls.Add(Shoot_right)
        bullet_movement.Start()
        BulletNumberRight += 1
        ReDim Preserve BulletarrayRight(BulletNumberRight)
        BulletarrayRight(BulletNumberRight) = Shoot_right
    End Sub
    Sub Shootleft()
        Dim Shoot_Left As New PictureBox
        Shoot_Left.Top = C1.Top + 15
        Shoot_Left.Left = C1.Left - 15
        Shoot_Left.Size = New Size(10, 10)
        Shoot_Left.BackColor = Color.Blue
        Controls.Add(Shoot_Left)
        bullet_movement.Start()
        BulletNumberLeft += 1
        ReDim Preserve Bullet_arrayLeft(BulletNumberLeft)
        Bullet_arrayLeft(BulletNumberLeft) = Shoot_Left
    End Sub
    Sub Shootdown()
        Dim Shoot_Down As New PictureBox
        Shoot_Down.Top = C1.Top + 15
        Shoot_Down.Left = C1.Left + 10
        Shoot_Down.Size = New Size(10, 10)
        Shoot_Down.BackColor = Color.Blue
        Controls.Add(Shoot_Down)
        bullet_movement.Start()
        BulletNumberDown += 1
        ReDim Preserve Bullet_arrayDown(BulletNumberDown)
        Bullet_arrayDown(BulletNumberDown) = Shoot_Down
    End Sub
    Sub Shootup()
        Dim Shoot_Up As New PictureBox
        Shoot_Up.Top = C1.Top + 15
        Shoot_Up.Left = C1.Left + 10
        Shoot_Up.Size = New Size(10, 10)
        Shoot_Up.BackColor = Color.Blue
        Controls.Add(Shoot_Up)
        bullet_movement.Start()
        BulletNumberUp += 1
        ReDim Preserve Bullet_arrayUp(BulletNumberUp)
        Bullet_arrayUp(BulletNumberUp) = Shoot_Up
    End Sub
    Private Sub bullet_movement_Tick(sender As Object, e As EventArgs) Handles bullet_movement.Tick
        Dim A As Integer
        For A = 0 To BulletNumberRight
            BulletarrayRight(A).Left += 10
            If BulletarrayRight(A).Bounds.IntersectsWith(Right_boundary.Bounds) Then
                Me.Controls.Remove(BulletarrayRight(A))
            End If
            If BulletarrayRight(A).Bounds.IntersectsWith(Test.Bounds) Then
                Me.Controls.Remove(BulletarrayRight(BulletNumberRight))
                Me.Controls.Remove(Test)
            End If
        Next
        Dim B As Integer
        For B = 0 To BulletNumberLeft
            Bullet_arrayLeft(B).Left -= 10
            If Bullet_arrayLeft(B).Bounds.IntersectsWith(Left_boundary.Bounds) Then
                Me.Controls.Remove(Bullet_arrayLeft(B))
            End If
            If enemycount >= 1 Then
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemyarray(enemycount).Bounds) Then
                    'MessageBox.Show("hi")

                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Me.Controls.Remove(Enemyarray(enemycount))
                    enemycount = enemycount - 1
                End If
            End If
        Next
        Dim C As Integer
        For C = 0 To BulletNumberDown
            Bullet_arrayDown(C).Top += 10
            If Bullet_arrayDown(C).Bounds.IntersectsWith(Bottom_boundary.Bounds) Then
                Me.Controls.Remove(Bullet_arrayDown(C))
            End If
        Next
        Dim D As Integer
        For D = 0 To BulletNumberUp
            Bullet_arrayUp(D).Top -= 10
            If Bullet_arrayUp(D).Bounds.IntersectsWith(Top_boundary.Bounds) Then
                Me.Controls.Remove(Bullet_arrayUp(D))
            End If
        Next
    End Sub
#End Region

    Private Sub Spawn_Tick(sender As Object, e As EventArgs) Handles Spawn.Tick
        Dim Number As Integer
        Number = 1
        ' Number = Int((1 - 2 * -1) * Rnd())
        If Number = 1 Then
            Pos1()
        End If
    End Sub
    Sub Pos1()
        Dim Enemy1 As New PictureBox
        Enemy1.Top = +15
        Enemy1.Left = +30
        Enemy1.Size = New Size(36, 50)
        Enemy1.Image = My.Resources.mario1
        Enemy1.SizeMode = PictureBoxSizeMode.StretchImage
        Controls.Add(Enemy1)
        CreateEnemy.Start()
        enemycount += 1
        ReDim Preserve Enemyarray(enemycount)
        Enemyarray(enemycount) = Enemy1
    End Sub

    Private Sub CreateEnemy_Tick(sender As Object, e As EventArgs) Handles CreateEnemy.Tick
        For F = 0 To enemycount
            Enemyarray(F).Left += 1

        Next

    End Sub
End Class