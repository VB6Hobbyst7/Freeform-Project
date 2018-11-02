'"random" code is in system
Imports System
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
#Region "Animation Pictures"
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
#End Region
    Public enemycountarray As Integer = -1
    Public enemycount As Integer = -1
    Public Enemyarray(7) As PictureBox
    Public enemycountarray2 As Integer = -1
    Public enemycount2 As Integer = -1
    Public Enemyarray2(7) As PictureBox
    Public enemycountarray3 As Integer = -1
    Public enemycount3 As Integer = -1
    Public Enemyarray3(7) As PictureBox
    Public enemycountarray4 As Integer = -1
    Public enemycount4 As Integer = -1
    Public Enemyarray4(7) As PictureBox
    Public enemycountarray5 As Integer = -1
    Public enemycount5 As Integer = -1
    Public Enemyarray5(7) As PictureBox
    Public enemycountarray6 As Integer = -1
    Public enemycount6 As Integer = -1
    Public Enemyarray6(7) As PictureBox
    Public enemycountarray7 As Integer = -1
    Public enemycount7 As Integer = -1
    Public Enemyarray7(7) As PictureBox
    Public enemycountarray8 As Integer = -1
    Public enemycount8 As Integer = -1
    Public Enemyarray8(7) As PictureBox
    Public enemycountarray9 As Integer = -1
    Public enemycount9 As Integer = -1
    Public Enemyarray9(7) As PictureBox
#Region "Enemy Names"
    Public Enemy00 As New PictureBox
    Public Enemy01 As New PictureBox
    Public Enemy02 As New PictureBox
    Public Enemy03 As New PictureBox
    Public Enemy04 As New PictureBox
    Public Enemy05 As New PictureBox
    Public Enemy06 As New PictureBox
    Public Enemy07 As New PictureBox
    Public Enemy2_00 As New PictureBox
    Public Enemy2_01 As New PictureBox
    Public Enemy2_02 As New PictureBox
    Public Enemy2_03 As New PictureBox
    Public Enemy2_04 As New PictureBox
    Public Enemy2_05 As New PictureBox
    Public Enemy2_06 As New PictureBox
    Public Enemy2_07 As New PictureBox
    Public Enemy3_00 As New PictureBox
    Public Enemy3_01 As New PictureBox
    Public Enemy3_02 As New PictureBox
    Public Enemy3_03 As New PictureBox
    Public Enemy3_04 As New PictureBox
    Public Enemy3_05 As New PictureBox
    Public Enemy3_06 As New PictureBox
    Public Enemy3_07 As New PictureBox
    Public Enemy4_00 As New PictureBox
    Public Enemy4_01 As New PictureBox
    Public Enemy4_02 As New PictureBox
    Public Enemy4_03 As New PictureBox
    Public Enemy4_04 As New PictureBox
    Public Enemy4_05 As New PictureBox
    Public Enemy4_06 As New PictureBox
    Public Enemy4_07 As New PictureBox
    Public Enemy5_00 As New PictureBox
    Public Enemy5_01 As New PictureBox
    Public Enemy5_02 As New PictureBox
    Public Enemy5_03 As New PictureBox
    Public Enemy5_04 As New PictureBox
    Public Enemy5_05 As New PictureBox
    Public Enemy5_06 As New PictureBox
    Public Enemy5_07 As New PictureBox
    Public Enemy6_00 As New PictureBox
    Public Enemy6_01 As New PictureBox
    Public Enemy6_02 As New PictureBox
    Public Enemy6_03 As New PictureBox
    Public Enemy6_04 As New PictureBox
    Public Enemy6_05 As New PictureBox
    Public Enemy6_06 As New PictureBox
    Public Enemy6_07 As New PictureBox
    Public Enemy7_00 As New PictureBox
    Public Enemy7_01 As New PictureBox
    Public Enemy7_02 As New PictureBox
    Public Enemy7_03 As New PictureBox
    Public Enemy7_04 As New PictureBox
    Public Enemy7_05 As New PictureBox
    Public Enemy7_06 As New PictureBox
    Public Enemy7_07 As New PictureBox
    Public Enemy8_00 As New PictureBox
    Public Enemy8_01 As New PictureBox
    Public Enemy8_02 As New PictureBox
    Public Enemy8_03 As New PictureBox
    Public Enemy8_04 As New PictureBox
    Public Enemy8_05 As New PictureBox
    Public Enemy8_06 As New PictureBox
    Public Enemy8_07 As New PictureBox
#End Region
    Dim GameOverIsOpen As Boolean = False
    Public spacecounter As Integer = 0
    Public Class GlobalVariables
        Public Shared moveRight As Boolean
        Public Shared moveLeft As Boolean
        Public Shared moveUp As Boolean
        Public Shared moveDown As Boolean
        Public Shared Anichar_Right As Integer = 4
        Public Shared Anichar_Up As Integer = 4
        Public Shared Anichar_Down As Integer = 4
        Public Shared Anichar_Left As Integer = 4
        Public Shared BulletarrayRight() As PictureBox
        Public Shared BulletNumberRight As Integer = -1
        Public Shared Bullet_arrayLeft() As PictureBox
        Public Shared BulletNumberLeft As Integer = -1
        Public Shared Bullet_arrayUp() As PictureBox
        Public Shared BulletNumberUp As Integer = -1
        Public Shared Bullet_arrayDown() As PictureBox
        Public Shared BulletNumberDown As Integer = -1
#Region "Animation Pictures"
        Public Shared PokRight As Image = My.Resources.Pokemon_right_1
        Public Shared PokRight2 As Image = My.Resources.Pokemon_right_2
        Public Shared PokRight3 As Image = My.Resources.Pokemon_right_3
        Public Shared PokRight4 As Image = My.Resources.Pokemon_right_4
        Public Shared PokLeft As Image = My.Resources.Pokemon_Left_1
        Public Shared PokLeft2 As Image = My.Resources.Pokemon_Left_2
        Public Shared PokLeft3 As Image = My.Resources.Pokemon_Left_3
        Public Shared PokLeft4 As Image = My.Resources.Pokemon_Left_4
        Public Shared PokDown As Image = My.Resources.Pokemon_Down_1
        Public Shared PokDown2 As Image = My.Resources.Pokemon_Down_2
        Public Shared PokDown3 As Image = My.Resources.Pokemon_Down_3
        Public Shared PokDown4 As Image = My.Resources.Pokemon_Down_4
        Public Shared PokUp As Image = My.Resources.Pokemon_Up_1
        Public Shared PokUp2 As Image = My.Resources.Pokemon_Up_2
        Public Shared PokUp3 As Image = My.Resources.Pokemon_Up_3
        Public Shared PokUp4 As Image = My.Resources.Pokemon_Up_4
#End Region
        Public Shared enemycountarray As Integer = -1
        Public Shared enemycount As Integer = -1
        Public Shared Enemyarray(7) As PictureBox
        Public Shared enemycountarray2 As Integer = -1
        Public Shared enemycount2 As Integer = -1
        Public Shared Enemyarray2(7) As PictureBox
        Public Shared enemycountarray3 As Integer = -1
        Public Shared enemycount3 As Integer = -1
        Public Shared Enemyarray3(7) As PictureBox
        Public Shared enemycountarray4 As Integer = -1
        Public Shared enemycount4 As Integer = -1
        Public Shared Enemyarray4(7) As PictureBox
        Public Shared enemycountarray5 As Integer = -1
        Public Shared enemycount5 As Integer = -1
        Public Shared Enemyarray5(7) As PictureBox
        Public Shared enemycountarray6 As Integer = -1
        Public Shared enemycount6 As Integer = -1
        Public Shared Enemyarray6(7) As PictureBox
        Public Shared enemycountarray7 As Integer = -1
        Public Shared enemycount7 As Integer = -1
        Public Shared Enemyarray7(7) As PictureBox
        Public Shared enemycountarray8 As Integer = -1
        Public Shared enemycount8 As Integer = -1
        Public Shared Enemyarray8(7) As PictureBox
        Public Shared enemycountarray9 As Integer = -1
        Public Shared enemycount9 As Integer = -1
        Public Shared Enemyarray9(7) As PictureBox
#Region "Enemy Names"
        Public Shared Enemy00 As New PictureBox
        Public Shared Enemy01 As New PictureBox
        Public Shared Enemy02 As New PictureBox
        Public Shared Enemy03 As New PictureBox
        Public Shared Enemy04 As New PictureBox
        Public Shared Enemy05 As New PictureBox
        Public Shared Enemy06 As New PictureBox
        Public Shared Enemy07 As New PictureBox
        Public Shared Enemy2_00 As New PictureBox
        Public Shared Enemy2_01 As New PictureBox
        Public Shared Enemy2_02 As New PictureBox
        Public Shared Enemy2_03 As New PictureBox
        Public Shared Enemy2_04 As New PictureBox
        Public Shared Enemy2_05 As New PictureBox
        Public Shared Enemy2_06 As New PictureBox
        Public Shared Enemy2_07 As New PictureBox
        Public Shared Enemy3_00 As New PictureBox
        Public Shared Enemy3_01 As New PictureBox
        Public Shared Enemy3_02 As New PictureBox
        Public Shared Enemy3_03 As New PictureBox
        Public Shared Enemy3_04 As New PictureBox
        Public Shared Enemy3_05 As New PictureBox
        Public Shared Enemy3_06 As New PictureBox
        Public Shared Enemy3_07 As New PictureBox
        Public Shared Enemy4_00 As New PictureBox
        Public Shared Enemy4_01 As New PictureBox
        Public Shared Enemy4_02 As New PictureBox
        Public Shared Enemy4_03 As New PictureBox
        Public Shared Enemy4_04 As New PictureBox
        Public Shared Enemy4_05 As New PictureBox
        Public Shared Enemy4_06 As New PictureBox
        Public Shared Enemy4_07 As New PictureBox
        Public Shared Enemy5_00 As New PictureBox
        Public Shared Enemy5_01 As New PictureBox
        Public Shared Enemy5_02 As New PictureBox
        Public Shared Enemy5_03 As New PictureBox
        Public Shared Enemy5_04 As New PictureBox
        Public Shared Enemy5_05 As New PictureBox
        Public Shared Enemy5_06 As New PictureBox
        Public Shared Enemy5_07 As New PictureBox
        Public Shared Enemy6_00 As New PictureBox
        Public Shared Enemy6_01 As New PictureBox
        Public Shared Enemy6_02 As New PictureBox
        Public Shared Enemy6_03 As New PictureBox
        Public Shared Enemy6_04 As New PictureBox
        Public Shared Enemy6_05 As New PictureBox
        Public Shared Enemy6_06 As New PictureBox
        Public Shared Enemy6_07 As New PictureBox
        Public Shared Enemy7_00 As New PictureBox
        Public Shared Enemy7_01 As New PictureBox
        Public Shared Enemy7_02 As New PictureBox
        Public Shared Enemy7_03 As New PictureBox
        Public Shared Enemy7_04 As New PictureBox
        Public Shared Enemy7_05 As New PictureBox
        Public Shared Enemy7_06 As New PictureBox
        Public Shared Enemy7_07 As New PictureBox
        Public Shared Enemy8_00 As New PictureBox
        Public Shared Enemy8_01 As New PictureBox
        Public Shared Enemy8_02 As New PictureBox
        Public Shared Enemy8_03 As New PictureBox
        Public Shared Enemy8_04 As New PictureBox
        Public Shared Enemy8_05 As New PictureBox
        Public Shared Enemy8_06 As New PictureBox
        Public Shared Enemy8_07 As New PictureBox
#End Region
        Dim GameOverIsOpen As Boolean = False
        Public Shared spacecounter As Integer = 0
    End Class


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
                spacecounter += 1
                If C1.Image Is PokRight Or C1.Image Is PokRight2 Or C1.Image Is PokRight3 Or C1.Image Is PokRight4 Then
                    If spacecounter = 1 Then
                        Shootright()
                    End If
                End If
                If C1.Image Is PokLeft Or C1.Image Is PokLeft2 Or C1.Image Is PokLeft3 Or C1.Image Is PokLeft4 Then
                    If spacecounter = 1 Then
                        Shootleft()
                    End If
                End If
                If C1.Image Is PokDown Or C1.Image Is PokDown2 Or C1.Image Is PokDown3 Or C1.Image Is PokDown4 Then
                    If spacecounter = 1 Then
                        Shootdown()
                    End If
                End If
                If C1.Image Is PokUp Or C1.Image Is PokUp2 Or C1.Image Is PokUp3 Or C1.Image Is PokUp4 Then
                    If spacecounter = 1 Then
                        Shootup()
                    End If
                End If
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
            Case Keys.Space
                spacecounter = 0
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
    Sub setArray()
        Enemy00 = Enemyarray(0)
        Enemy01 = Enemyarray(1)
        Enemy02 = Enemyarray(2)
        Enemy03 = Enemyarray(3)
        Enemy04 = Enemyarray(4)
        Enemy05 = Enemyarray(5)
        Enemy06 = Enemyarray(6)
        Enemy07 = Enemyarray(7)
        Enemy2_00 = Enemyarray2(0)
        Enemy2_01 = Enemyarray2(1)
        Enemy2_02 = Enemyarray2(2)
        Enemy2_03 = Enemyarray2(3)
        Enemy2_04 = Enemyarray2(4)
        Enemy2_05 = Enemyarray2(5)
        Enemy2_06 = Enemyarray2(6)
        Enemy2_07 = Enemyarray2(7)
        Enemy3_00 = Enemyarray3(0)
        Enemy3_01 = Enemyarray3(1)
        Enemy3_02 = Enemyarray3(2)
        Enemy3_03 = Enemyarray3(3)
        Enemy3_04 = Enemyarray3(4)
        Enemy3_05 = Enemyarray3(5)
        Enemy3_06 = Enemyarray3(6)
        Enemy3_07 = Enemyarray3(7)
        Enemy4_00 = Enemyarray4(0)
        Enemy4_01 = Enemyarray4(1)
        Enemy4_02 = Enemyarray4(2)
        Enemy4_03 = Enemyarray4(3)
        Enemy4_04 = Enemyarray4(4)
        Enemy4_05 = Enemyarray4(5)
        Enemy4_06 = Enemyarray4(6)
        Enemy4_07 = Enemyarray4(7)
        Enemy5_00 = Enemyarray5(0)
        Enemy5_01 = Enemyarray5(1)
        Enemy5_02 = Enemyarray5(2)
        Enemy5_03 = Enemyarray5(3)
        Enemy5_04 = Enemyarray5(4)
        Enemy5_05 = Enemyarray5(5)
        Enemy5_06 = Enemyarray5(6)
        Enemy5_07 = Enemyarray5(7)
        Enemy6_00 = Enemyarray6(0)
        Enemy6_01 = Enemyarray6(1)
        Enemy6_02 = Enemyarray6(2)
        Enemy6_03 = Enemyarray6(3)
        Enemy6_04 = Enemyarray6(4)
        Enemy6_05 = Enemyarray6(5)
        Enemy6_06 = Enemyarray6(6)
        Enemy6_07 = Enemyarray6(7)
        Enemy7_00 = Enemyarray7(0)
        Enemy7_01 = Enemyarray7(1)
        Enemy7_02 = Enemyarray7(2)
        Enemy7_03 = Enemyarray7(3)
        Enemy7_04 = Enemyarray7(4)
        Enemy7_05 = Enemyarray7(5)
        Enemy7_06 = Enemyarray7(6)
        Enemy7_07 = Enemyarray7(7)

        If enemycount >= 0 Then
            Enemy00 = Enemyarray(0)
            If C1.Bounds.IntersectsWith(Enemy00.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount >= 1 Then
            Enemy01 = Enemyarray(1)
            If C1.Bounds.IntersectsWith(Enemy01.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount >= 2 Then
            Enemy02 = Enemyarray(2)
            If C1.Bounds.IntersectsWith(Enemy02.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount >= 3 Then
            Enemy03 = Enemyarray(3)
            If C1.Bounds.IntersectsWith(Enemy03.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount >= 4 Then
            Enemy04 = Enemyarray(4)
            If C1.Bounds.IntersectsWith(Enemy04.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount >= 5 Then
            Enemy05 = Enemyarray(5)
            If C1.Bounds.IntersectsWith(Enemy05.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount >= 6 Then
            Enemy06 = Enemyarray(6)
            If C1.Bounds.IntersectsWith(Enemy06.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount >= 7 Then
            Enemy07 = Enemyarray(7)
            If C1.Bounds.IntersectsWith(Enemy07.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount2 >= 0 Then
            Enemy2_00 = Enemyarray2(0)
            If C1.Bounds.IntersectsWith(Enemy2_00.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount2 >= 1 Then
            Enemy2_01 = Enemyarray2(1)
            If C1.Bounds.IntersectsWith(Enemy2_01.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount2 >= 2 Then
            Enemy2_02 = Enemyarray2(2)
            If C1.Bounds.IntersectsWith(Enemy2_02.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount2 >= 3 Then
            Enemy2_03 = Enemyarray2(3)
            If C1.Bounds.IntersectsWith(Enemy2_03.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount2 >= 4 Then
            Enemy2_04 = Enemyarray2(4)
            If C1.Bounds.IntersectsWith(Enemy2_04.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount2 >= 5 Then
            Enemy2_05 = Enemyarray2(5)
            If C1.Bounds.IntersectsWith(Enemy2_05.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount2 >= 6 Then
            Enemy2_06 = Enemyarray2(6)
            If C1.Bounds.IntersectsWith(Enemy2_06.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount2 >= 7 Then
            Enemy2_07 = Enemyarray2(7)
            If C1.Bounds.IntersectsWith(Enemy2_07.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount3 >= 0 Then
            Enemy3_00 = Enemyarray3(0)
            If C1.Bounds.IntersectsWith(Enemy3_00.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount3 >= 1 Then
            Enemy3_01 = Enemyarray3(1)
            If C1.Bounds.IntersectsWith(Enemy3_01.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount3 >= 2 Then
            Enemy3_02 = Enemyarray3(2)
            If C1.Bounds.IntersectsWith(Enemy3_02.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount3 >= 3 Then
            Enemy3_03 = Enemyarray3(3)
            If C1.Bounds.IntersectsWith(Enemy3_03.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount3 >= 4 Then
            Enemy3_04 = Enemyarray3(4)
            If C1.Bounds.IntersectsWith(Enemy3_04.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount3 >= 5 Then
            Enemy3_05 = Enemyarray3(5)
            If C1.Bounds.IntersectsWith(Enemy3_05.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount3 >= 6 Then
            Enemy3_06 = Enemyarray3(6)
            If C1.Bounds.IntersectsWith(Enemy3_06.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount3 >= 7 Then
            Enemy3_07 = Enemyarray3(7)
            If C1.Bounds.IntersectsWith(Enemy3_07.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount4 >= 0 Then
            Enemy4_00 = Enemyarray4(0)
            If C1.Bounds.IntersectsWith(Enemy4_00.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount4 >= 1 Then
            Enemy4_01 = Enemyarray4(1)
            If C1.Bounds.IntersectsWith(Enemy4_01.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount4 >= 2 Then
            Enemy4_02 = Enemyarray4(2)
            If C1.Bounds.IntersectsWith(Enemy4_02.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount4 >= 3 Then
            Enemy4_03 = Enemyarray4(3)
            If C1.Bounds.IntersectsWith(Enemy4_03.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount4 >= 4 Then
            Enemy4_04 = Enemyarray4(4)
            If C1.Bounds.IntersectsWith(Enemy4_04.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount4 >= 5 Then
            Enemy4_05 = Enemyarray4(5)
            If C1.Bounds.IntersectsWith(Enemy4_05.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount4 >= 6 Then
            Enemy4_06 = Enemyarray4(6)
            If C1.Bounds.IntersectsWith(Enemy4_06.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount4 >= 7 Then
            Enemy4_07 = Enemyarray4(7)
            If C1.Bounds.IntersectsWith(Enemy4_07.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount5 >= 0 Then
            Enemy5_00 = Enemyarray5(0)
            If C1.Bounds.IntersectsWith(Enemy5_00.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount5 >= 1 Then
            Enemy5_01 = Enemyarray5(1)
            If C1.Bounds.IntersectsWith(Enemy5_01.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount5 >= 2 Then
            Enemy5_02 = Enemyarray5(2)
            If C1.Bounds.IntersectsWith(Enemy5_02.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount5 >= 3 Then
            Enemy5_03 = Enemyarray5(3)
            If C1.Bounds.IntersectsWith(Enemy5_03.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount5 >= 4 Then
            Enemy5_04 = Enemyarray5(4)
            If C1.Bounds.IntersectsWith(Enemy5_04.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount5 >= 5 Then
            Enemy5_05 = Enemyarray5(5)
            If C1.Bounds.IntersectsWith(Enemy5_05.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount5 >= 6 Then
            Enemy5_06 = Enemyarray5(6)
            If C1.Bounds.IntersectsWith(Enemy5_06.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount5 >= 7 Then
            Enemy5_07 = Enemyarray5(7)
            If C1.Bounds.IntersectsWith(Enemy5_07.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount6 >= 0 Then
            Enemy6_00 = Enemyarray6(0)
            If C1.Bounds.IntersectsWith(Enemy6_00.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount6 >= 1 Then
            Enemy6_01 = Enemyarray6(1)
            If C1.Bounds.IntersectsWith(Enemy6_01.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount6 >= 2 Then
            Enemy6_02 = Enemyarray6(2)
            If C1.Bounds.IntersectsWith(Enemy6_02.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount6 >= 3 Then
            Enemy6_03 = Enemyarray6(3)
            If C1.Bounds.IntersectsWith(Enemy6_03.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount6 >= 4 Then
            Enemy6_04 = Enemyarray6(4)
            If C1.Bounds.IntersectsWith(Enemy6_04.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount6 >= 5 Then
            Enemy6_05 = Enemyarray6(5)
            If C1.Bounds.IntersectsWith(Enemy6_05.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount6 >= 6 Then
            Enemy6_06 = Enemyarray6(6)
            If C1.Bounds.IntersectsWith(Enemy6_06.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount6 >= 7 Then
            Enemy6_07 = Enemyarray6(7)
            If C1.Bounds.IntersectsWith(Enemy6_07.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount7 >= 0 Then
            Enemy7_00 = Enemyarray7(0)
            If C1.Bounds.IntersectsWith(Enemy7_00.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount7 >= 1 Then
            Enemy7_01 = Enemyarray7(1)
            If C1.Bounds.IntersectsWith(Enemy7_01.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount7 >= 2 Then
            Enemy7_02 = Enemyarray7(2)
            If C1.Bounds.IntersectsWith(Enemy7_02.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount7 >= 3 Then
            Enemy7_03 = Enemyarray7(3)
            If C1.Bounds.IntersectsWith(Enemy7_03.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount7 >= 4 Then
            Enemy7_04 = Enemyarray7(4)
            If C1.Bounds.IntersectsWith(Enemy7_04.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount7 >= 5 Then
            Enemy7_05 = Enemyarray7(5)
            If C1.Bounds.IntersectsWith(Enemy7_05.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount7 >= 6 Then
            Enemy7_06 = Enemyarray7(6)
            If C1.Bounds.IntersectsWith(Enemy7_06.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
        If enemycount7 >= 7 Then
            Enemy7_07 = Enemyarray7(7)
            If C1.Bounds.IntersectsWith(Enemy7_07.Bounds) Then
                Dim GameOverForm As Gameover = New Gameover
                GameOverForm.Show()
                C1.Location = New Point(15000, 15000)
                Spawn.Enabled = False
                CreateEnemy.Enabled = False
                movement.Enabled = False
            End If
        End If
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
        setArray()
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
#Region "Enemy1 right"
            If enemycount >= 0 Then
                Enemy00 = Enemyarray(0)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy00.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy00.Visible = False
                    Enemy00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 1 Then
                Enemy01 = Enemyarray(1)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy01.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy01.Visible = False
                    Enemy01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 2 Then
                Enemy02 = Enemyarray(2)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy02.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy02.Visible = False
                    Enemy02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 3 Then
                Enemy03 = Enemyarray(3)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy03.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy03.Visible = False
                    Enemy03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 4 Then
                Enemy04 = Enemyarray(4)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy04.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy04.Visible = False
                    Enemy04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 5 Then
                Enemy05 = Enemyarray(5)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy05.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy05.Visible = False
                    Enemy05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 6 Then
                Enemy06 = Enemyarray(6)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy06.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy06.Visible = False
                    Enemy06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 7 Then
                Enemy07 = Enemyarray(7)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy07.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy07.Visible = False
                    Enemy07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy2 right"
            If enemycount2 >= 0 Then
                Enemy2_00 = Enemyarray2(0)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy2_00.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy2_00.Visible = False
                    Enemy2_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 1 Then
                Enemy2_01 = Enemyarray2(1)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy2_01.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy2_01.Visible = False
                    Enemy2_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 2 Then
                Enemy2_02 = Enemyarray2(2)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy2_02.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy2_02.Visible = False
                    Enemy2_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 3 Then
                Enemy2_03 = Enemyarray2(3)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy2_03.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy2_03.Visible = False
                    Enemy2_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 4 Then
                Enemy2_04 = Enemyarray2(4)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy2_04.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy2_04.Visible = False
                    Enemy2_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 5 Then
                Enemy2_05 = Enemyarray2(5)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy2_05.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy2_05.Visible = False
                    Enemy2_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 6 Then
                Enemy2_06 = Enemyarray2(6)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy2_06.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy2_06.Visible = False
                    Enemy2_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 7 Then
                Enemy2_07 = Enemyarray2(7)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy2_07.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy2_07.Visible = False
                    Enemy2_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy3 right"
            If enemycount3 >= 0 Then
                Enemy3_00 = Enemyarray3(0)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy3_00.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy3_00.Visible = False
                    Enemy3_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 1 Then
                Enemy3_01 = Enemyarray3(1)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy3_01.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy3_01.Visible = False
                    Enemy3_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 2 Then
                Enemy3_02 = Enemyarray3(2)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy3_02.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy3_02.Visible = False
                    Enemy3_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 3 Then
                Enemy3_03 = Enemyarray3(3)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy3_03.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy3_03.Visible = False
                    Enemy3_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 4 Then
                Enemy3_04 = Enemyarray3(4)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy3_04.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy3_04.Visible = False
                    Enemy3_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 5 Then
                Enemy3_05 = Enemyarray3(5)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy3_05.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy3_05.Visible = False
                    Enemy3_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 6 Then
                Enemy3_06 = Enemyarray3(6)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy3_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy3_06.Visible = False
                    Enemy3_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 7 Then
                Enemy3_07 = Enemyarray3(7)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy3_07.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy3_07.Visible = False
                    Enemy3_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy4 right"
            If enemycount4 >= 0 Then
                Enemy4_00 = Enemyarray4(0)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy4_00.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy4_00.Visible = False
                    Enemy4_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 1 Then
                Enemy4_01 = Enemyarray4(1)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy4_01.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy4_01.Visible = False
                    Enemy4_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 2 Then
                Enemy4_02 = Enemyarray4(2)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy4_02.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy4_02.Visible = False
                    Enemy4_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 3 Then
                Enemy4_03 = Enemyarray4(3)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy4_03.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy4_03.Visible = False
                    Enemy4_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 4 Then
                Enemy4_04 = Enemyarray4(4)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy4_04.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy4_04.Visible = False
                    Enemy4_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 5 Then
                Enemy4_05 = Enemyarray4(5)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy4_05.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy4_05.Visible = False
                    Enemy4_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 6 Then
                Enemy4_06 = Enemyarray4(6)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy4_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy4_06.Visible = False
                    Enemy4_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 7 Then
                Enemy4_07 = Enemyarray4(7)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy4_07.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy4_07.Visible = False
                    Enemy4_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy5 right"
            If enemycount5 >= 0 Then
                Enemy5_00 = Enemyarray5(0)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy5_00.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy5_00.Visible = False
                    Enemy5_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 1 Then
                Enemy5_01 = Enemyarray5(1)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy5_01.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy5_01.Visible = False
                    Enemy5_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 2 Then
                Enemy5_02 = Enemyarray5(2)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy5_02.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy5_02.Visible = False
                    Enemy5_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 3 Then
                Enemy5_03 = Enemyarray5(3)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy5_03.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy5_03.Visible = False
                    Enemy5_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 4 Then
                Enemy5_04 = Enemyarray5(4)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy5_04.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy5_04.Visible = False
                    Enemy5_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 5 Then
                Enemy5_05 = Enemyarray5(5)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy5_05.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy5_05.Visible = False
                    Enemy5_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 6 Then
                Enemy5_06 = Enemyarray5(6)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy5_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy5_06.Visible = False
                    Enemy5_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 7 Then
                Enemy5_07 = Enemyarray5(7)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy5_07.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy5_07.Visible = False
                    Enemy5_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy6 right"
            If enemycount6 >= 0 Then
                Enemy6_00 = Enemyarray6(0)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy6_00.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy6_00.Visible = False
                    Enemy6_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 1 Then
                Enemy6_01 = Enemyarray6(1)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy6_01.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy6_01.Visible = False
                    Enemy6_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 2 Then
                Enemy6_02 = Enemyarray6(2)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy6_02.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy6_02.Visible = False
                    Enemy6_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 3 Then
                Enemy6_03 = Enemyarray6(3)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy6_03.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy6_03.Visible = False
                    Enemy6_03.Location = New Point(20000, 20000)
                End If
            End If
            'make all of these 6
            If enemycount6 >= 4 Then
                Enemy6_04 = Enemyarray6(4)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy6_04.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy6_04.Visible = False
                    Enemy6_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 5 Then
                Enemy6_05 = Enemyarray6(5)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy6_05.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy6_05.Visible = False
                    Enemy6_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 6 Then
                Enemy6_06 = Enemyarray6(6)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy6_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy6_06.Visible = False
                    Enemy6_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 7 Then
                Enemy6_07 = Enemyarray6(7)
                If BulletarrayRight(A).Bounds.IntersectsWith(Enemy6_07.Bounds) Then
                    Me.Controls.Remove(BulletarrayRight(A))
                    BulletarrayRight(A).Left = 2000
                    BulletarrayRight(A).Top = 2000
                    Enemy6_07.Visible = False
                    Enemy6_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
        Next
        '-------------------------------------------------------------------------------
        Dim B As Integer
        For B = 0 To BulletNumberLeft
            Bullet_arrayLeft(B).Left -= 10
            If Bullet_arrayLeft(B).Bounds.IntersectsWith(Left_boundary.Bounds) Then
                Me.Controls.Remove(Bullet_arrayLeft(B))
            End If
#Region "Enemy1 left"
            If enemycount >= 0 Then
                Enemy00 = Enemyarray(0)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy00.Visible = False
                    Enemy00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 1 Then
                Enemy01 = Enemyarray(1)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy01.Visible = False
                    Enemy01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 2 Then
                Enemy02 = Enemyarray(2)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy02.Visible = False
                    Enemy02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 3 Then
                Enemy03 = Enemyarray(3)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy03.Visible = False
                    Enemy03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 4 Then
                Enemy04 = Enemyarray(4)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy04.Visible = False
                    Enemy04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 5 Then
                Enemy05 = Enemyarray(5)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy05.Visible = False
                    Enemy05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 6 Then
                Enemy06 = Enemyarray(6)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy06.Visible = False
                    Enemy06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 7 Then
                Enemy07 = Enemyarray(7)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy07.Visible = False
                    Enemy07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy2 left"
            If enemycount2 >= 0 Then
                Enemy2_00 = Enemyarray2(0)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy2_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy2_00.Visible = False
                    Enemy2_00.Left = 20000
                    Enemy2_00.Top = 20000
                End If
            End If
            If enemycount2 >= 1 Then
                Enemy2_01 = Enemyarray2(1)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy2_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy2_01.Visible = False
                    Enemy2_01.Left = 20000
                    Enemy2_01.Top = 20000
                End If
            End If
            If enemycount2 >= 2 Then
                Enemy2_02 = Enemyarray2(2)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy2_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy2_02.Visible = False
                    Enemy2_02.Left = 20000
                    Enemy2_02.Top = 20000
                End If
            End If
            If enemycount2 >= 3 Then
                Enemy2_03 = Enemyarray2(3)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy2_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy2_03.Visible = False
                    Enemy2_03.Left = 20000
                    Enemy2_03.Top = 20000
                End If
            End If
            If enemycount2 >= 4 Then
                Enemy2_04 = Enemyarray2(4)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy2_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy2_04.Visible = False
                    Enemy2_04.Left = 20000
                    Enemy2_04.Top = 20000
                End If
            End If
            If enemycount2 >= 5 Then
                Enemy2_05 = Enemyarray2(5)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy2_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy2_05.Visible = False
                    Enemy2_05.Left = 20000
                    Enemy2_05.Top = 20000
                End If
            End If
            If enemycount2 >= 6 Then
                Enemy2_06 = Enemyarray2(6)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy2_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy2_06.Visible = False
                    Enemy2_06.Left = 20000
                    Enemy2_06.Top = 20000
                End If
            End If
            If enemycount2 >= 7 Then
                Enemy2_07 = Enemyarray2(7)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy2_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy2_07.Visible = False
                    Enemy2_07.Left = 20000
                    Enemy2_07.Top = 20000
                End If
            End If

#End Region
#Region "Enemy3 left"
            If enemycount3 >= 0 Then
                Enemy3_00 = Enemyarray3(0)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy3_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy3_00.Visible = False
                    Enemy3_00.Left = 20000
                    Enemy3_00.Top = 20000
                End If
            End If
            If enemycount3 >= 1 Then
                Enemy3_01 = Enemyarray3(1)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy3_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy3_01.Visible = False
                    Enemy3_01.Left = 20000
                    Enemy3_01.Top = 20000
                End If
            End If
            If enemycount3 >= 2 Then
                Enemy3_02 = Enemyarray3(2)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy3_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy3_02.Visible = False
                    Enemy3_02.Left = 20000
                    Enemy3_02.Top = 20000
                End If
            End If
            If enemycount3 >= 3 Then
                Enemy3_03 = Enemyarray3(3)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy3_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy3_03.Visible = False
                    Enemy3_03.Left = 20000
                    Enemy3_03.Top = 20000
                End If
            End If
            If enemycount3 >= 4 Then
                Enemy3_04 = Enemyarray3(4)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy3_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy3_04.Visible = False
                    Enemy3_04.Left = 20000
                    Enemy3_04.Top = 20000
                End If
            End If
            If enemycount3 >= 5 Then
                Enemy3_05 = Enemyarray3(5)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy3_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy3_05.Visible = False
                    Enemy3_05.Left = 20000
                    Enemy3_05.Top = 20000
                End If
            End If
            If enemycount3 >= 6 Then
                Enemy3_06 = Enemyarray3(6)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy3_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy3_06.Visible = False
                    Enemy3_06.Left = 20000
                    Enemy3_06.Top = 20000
                End If
            End If
            If enemycount3 >= 7 Then
                Enemy3_07 = Enemyarray3(7)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy3_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy3_07.Visible = False
                    Enemy3_07.Left = 20000
                    Enemy3_07.Top = 20000
                End If
            End If
#End Region
#Region "Enemy4 left"
            If enemycount4 >= 0 Then
                Enemy4_00 = Enemyarray4(0)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy4_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy4_00.Visible = False
                    Enemy4_00.Left = 20000
                    Enemy4_00.Top = 20000
                End If
            End If
            If enemycount4 >= 1 Then
                Enemy4_01 = Enemyarray4(1)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy4_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy4_01.Visible = False
                    Enemy4_01.Left = 20000
                    Enemy4_01.Top = 20000
                End If
            End If
            If enemycount4 >= 2 Then
                Enemy4_02 = Enemyarray4(2)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy4_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy4_02.Visible = False
                    Enemy4_02.Left = 20000
                    Enemy4_02.Top = 20000
                End If
            End If
            If enemycount4 >= 3 Then
                Enemy4_03 = Enemyarray4(3)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy4_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy4_03.Visible = False
                    Enemy4_03.Left = 20000
                    Enemy4_03.Top = 20000
                End If
            End If
            If enemycount4 >= 4 Then
                Enemy4_04 = Enemyarray4(4)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy4_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy4_04.Visible = False
                    Enemy4_04.Left = 20000
                    Enemy4_04.Top = 20000
                End If
            End If
            If enemycount4 >= 5 Then
                Enemy4_05 = Enemyarray4(5)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy4_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy4_05.Visible = False
                    Enemy4_05.Left = 20000
                    Enemy4_05.Top = 20000
                End If
            End If
            If enemycount4 >= 6 Then
                Enemy4_06 = Enemyarray4(6)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy4_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy4_06.Visible = False
                    Enemy4_06.Left = 20000
                    Enemy4_06.Top = 20000
                End If
            End If
            If enemycount4 >= 7 Then
                Enemy4_07 = Enemyarray4(7)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy4_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy4_07.Visible = False
                    Enemy4_07.Left = 20000
                    Enemy4_07.Top = 20000
                End If
            End If
#End Region
#Region "Enemy5 left"
            If enemycount5 >= 0 Then
                Enemy5_00 = Enemyarray5(0)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy5_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy5_00.Visible = False
                    Enemy5_00.Left = 20000
                    Enemy5_00.Top = 20000
                End If
            End If
            If enemycount5 >= 1 Then
                Enemy5_01 = Enemyarray5(1)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy5_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy5_01.Visible = False
                    Enemy5_01.Left = 20000
                    Enemy5_01.Top = 20000
                End If
            End If
            If enemycount5 >= 2 Then
                Enemy5_02 = Enemyarray5(2)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy5_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy5_02.Visible = False
                    Enemy5_02.Left = 20000
                    Enemy5_02.Top = 20000
                End If
            End If
            If enemycount5 >= 3 Then
                Enemy5_03 = Enemyarray5(3)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy5_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy5_03.Visible = False
                    Enemy5_03.Left = 20000
                    Enemy5_03.Top = 20000
                End If
            End If
            If enemycount5 >= 4 Then
                Enemy5_04 = Enemyarray5(4)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy5_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy5_04.Visible = False
                    Enemy5_04.Left = 20000
                    Enemy5_04.Top = 20000
                End If
            End If
            If enemycount5 >= 5 Then
                Enemy5_05 = Enemyarray5(5)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy5_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy5_05.Visible = False
                    Enemy5_05.Left = 20000
                    Enemy5_05.Top = 20000
                End If
            End If
            If enemycount5 >= 6 Then
                Enemy5_06 = Enemyarray5(6)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy5_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy5_06.Visible = False
                    Enemy5_06.Left = 20000
                    Enemy5_06.Top = 20000
                End If
            End If
            If enemycount5 >= 7 Then
                Enemy5_07 = Enemyarray5(7)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy5_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy5_07.Visible = False
                    Enemy5_07.Left = 20000
                    Enemy5_07.Top = 20000
                End If
            End If
#End Region
#Region "Enemy6 left"
            If enemycount6 >= 0 Then
                Enemy6_00 = Enemyarray6(0)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy6_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy6_00.Visible = False
                    Enemy6_00.Left = 20000
                    Enemy6_00.Top = 20000
                End If
            End If
            If enemycount6 >= 1 Then
                Enemy6_01 = Enemyarray6(1)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy6_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy6_01.Visible = False
                    Enemy6_01.Left = 20000
                    Enemy6_01.Top = 20000
                End If
            End If
            If enemycount6 >= 2 Then
                Enemy6_02 = Enemyarray6(2)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy6_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy6_02.Visible = False
                    Enemy6_02.Left = 20000
                    Enemy6_02.Top = 20000
                End If
            End If
            If enemycount6 >= 3 Then
                Enemy6_03 = Enemyarray6(3)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy6_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy6_03.Visible = False
                    Enemy6_03.Left = 20000
                    Enemy6_03.Top = 20000
                End If
            End If
            If enemycount6 >= 4 Then
                Enemy6_04 = Enemyarray6(4)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy6_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy6_04.Visible = False
                    Enemy6_04.Left = 20000
                    Enemy6_04.Top = 20000
                End If
            End If
            If enemycount6 >= 5 Then
                Enemy6_05 = Enemyarray6(5)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy6_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy6_05.Visible = False
                    Enemy6_05.Left = 20000
                    Enemy6_05.Top = 20000
                End If
            End If
            If enemycount6 >= 6 Then
                Enemy6_06 = Enemyarray6(6)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy6_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy6_06.Visible = False
                    Enemy6_06.Left = 20000
                    Enemy6_06.Top = 20000
                End If
            End If
            If enemycount6 >= 7 Then
                Enemy6_07 = Enemyarray6(7)
                If Bullet_arrayLeft(B).Bounds.IntersectsWith(Enemy6_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayLeft(B))
                    Bullet_arrayLeft(B).Left = 2000
                    Bullet_arrayLeft(B).Top = 2000
                    Enemy6_07.Visible = False
                    Enemy6_07.Left = 20000
                    Enemy6_07.Top = 20000
                End If
            End If
#End Region
        Next
        '--------------------------------------------------------------------------
        Dim C As Integer
        For C = 0 To BulletNumberDown
            Bullet_arrayDown(C).Top += 10
            If Bullet_arrayDown(C).Bounds.IntersectsWith(Bottom_boundary.Bounds) Then
                Me.Controls.Remove(Bullet_arrayDown(C))
            End If
#Region "Enemy1 down"
            If enemycount >= 0 Then
                Enemy00 = Enemyarray(0)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy00.Visible = False
                    Enemy00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 1 Then
                Enemy01 = Enemyarray(1)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy01.Visible = False
                    Enemy01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 2 Then
                Enemy02 = Enemyarray(2)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy02.Visible = False
                    Enemy02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 3 Then
                Enemy03 = Enemyarray(3)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy03.Visible = False
                    Enemy03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 4 Then
                Enemy04 = Enemyarray(4)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy04.Visible = False
                    Enemy04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 5 Then
                Enemy05 = Enemyarray(5)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy05.Visible = False
                    Enemy05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 6 Then
                Enemy06 = Enemyarray(6)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy06.Visible = False
                    Enemy06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 7 Then
                Enemy07 = Enemyarray(7)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy07.Visible = False
                    Enemy07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy2 down"
            If enemycount2 >= 0 Then
                Enemy2_00 = Enemyarray2(0)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy2_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy2_00.Visible = False
                    Enemy2_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 1 Then
                Enemy2_01 = Enemyarray2(1)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy2_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy2_01.Visible = False
                    Enemy2_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 2 Then
                Enemy2_02 = Enemyarray2(2)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy2_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy2_02.Visible = False
                    Enemy2_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 3 Then
                Enemy2_03 = Enemyarray2(3)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy2_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy2_03.Visible = False
                    Enemy2_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 4 Then
                Enemy2_04 = Enemyarray2(4)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy2_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy2_04.Visible = False
                    Enemy2_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 5 Then
                Enemy2_05 = Enemyarray2(5)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy2_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy2_05.Visible = False
                    Enemy2_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 6 Then
                Enemy2_06 = Enemyarray2(6)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy2_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy2_06.Visible = False
                    Enemy2_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 7 Then
                Enemy2_07 = Enemyarray2(7)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy2_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy2_07.Visible = False
                    Enemy2_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy3 down"
            If enemycount3 >= 0 Then
                Enemy3_00 = Enemyarray3(0)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy3_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy3_00.Visible = False
                    Enemy3_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 1 Then
                Enemy3_01 = Enemyarray3(1)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy3_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy3_01.Visible = False
                    Enemy3_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 2 Then
                Enemy3_02 = Enemyarray3(2)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy3_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy3_02.Visible = False
                    Enemy3_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 3 Then
                Enemy3_03 = Enemyarray3(3)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy3_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy3_03.Visible = False
                    Enemy3_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 4 Then
                Enemy3_04 = Enemyarray3(4)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy3_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy3_04.Visible = False
                    Enemy3_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 5 Then
                Enemy3_05 = Enemyarray3(5)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy3_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy3_05.Visible = False
                    Enemy3_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 6 Then
                Enemy3_06 = Enemyarray3(6)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy3_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy3_06.Visible = False
                    Enemy3_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 7 Then
                Enemy3_07 = Enemyarray3(7)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy3_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy3_07.Visible = False
                    Enemy3_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy4 down"
            If enemycount4 >= 0 Then
                Enemy4_00 = Enemyarray4(0)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy4_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy4_00.Visible = False
                    Enemy4_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 1 Then
                Enemy4_01 = Enemyarray4(1)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy4_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy4_01.Visible = False
                    Enemy4_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 2 Then
                Enemy4_02 = Enemyarray4(2)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy4_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy4_02.Visible = False
                    Enemy4_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 3 Then
                Enemy4_03 = Enemyarray4(3)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy4_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy4_03.Visible = False
                    Enemy4_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 4 Then
                Enemy4_04 = Enemyarray4(4)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy4_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy4_04.Visible = False
                    Enemy4_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 5 Then
                Enemy4_05 = Enemyarray4(5)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy4_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy4_05.Visible = False
                    Enemy4_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 6 Then
                Enemy4_06 = Enemyarray4(6)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy4_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy4_06.Visible = False
                    Enemy4_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 7 Then
                Enemy4_07 = Enemyarray4(7)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy4_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy4_07.Visible = False
                    Enemy4_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy5 down"
            If enemycount5 >= 0 Then
                Enemy5_00 = Enemyarray5(0)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy5_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy5_00.Visible = False
                    Enemy5_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 1 Then
                Enemy5_01 = Enemyarray5(1)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy5_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy5_01.Visible = False
                    Enemy5_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 2 Then
                Enemy5_02 = Enemyarray5(2)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy5_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy5_02.Visible = False
                    Enemy5_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 3 Then
                Enemy5_03 = Enemyarray5(3)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy5_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy5_03.Visible = False
                    Enemy5_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 4 Then
                Enemy5_04 = Enemyarray5(4)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy5_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy5_04.Visible = False
                    Enemy5_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 5 Then
                Enemy5_05 = Enemyarray5(5)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy5_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy5_05.Visible = False
                    Enemy5_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 6 Then
                Enemy5_06 = Enemyarray5(6)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy5_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy5_06.Visible = False
                    Enemy5_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 7 Then
                Enemy5_07 = Enemyarray5(7)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy5_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy5_07.Visible = False
                    Enemy5_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy6 down"
            If enemycount6 >= 0 Then
                Enemy6_00 = Enemyarray6(0)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy6_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy6_00.Visible = False
                    Enemy6_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 1 Then
                Enemy6_01 = Enemyarray6(1)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy6_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy6_01.Visible = False
                    Enemy6_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 2 Then
                Enemy6_02 = Enemyarray6(2)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy6_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy6_02.Visible = False
                    Enemy6_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 3 Then
                Enemy6_03 = Enemyarray6(3)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy6_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy6_03.Visible = False
                    Enemy6_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 4 Then
                Enemy6_04 = Enemyarray6(4)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy6_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy6_04.Visible = False
                    Enemy6_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 5 Then
                Enemy6_05 = Enemyarray6(5)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy6_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy6_05.Visible = False
                    Enemy6_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 6 Then
                Enemy6_06 = Enemyarray6(6)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy6_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy6_06.Visible = False
                    Enemy6_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 7 Then
                Enemy6_07 = Enemyarray6(7)
                If Bullet_arrayDown(C).Bounds.IntersectsWith(Enemy6_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayDown(C))
                    Bullet_arrayDown(C).Left = 2000
                    Bullet_arrayDown(C).Top = 2000
                    Enemy6_07.Visible = False
                    Enemy6_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
        Next
        '------------------------------------------------------------------------------------
        Dim D As Integer
        For D = 0 To BulletNumberUp
            Bullet_arrayUp(D).Top -= 10
            If Bullet_arrayUp(D).Bounds.IntersectsWith(Top_boundary.Bounds) Then
                Me.Controls.Remove(Bullet_arrayUp(D))
            End If
#Region "Enemy1 up"
            If enemycount >= 0 Then
                Enemy00 = Enemyarray(0)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy00.Visible = False
                    Enemy00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 1 Then
                Enemy01 = Enemyarray(1)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy01.Visible = False
                    Enemy01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 2 Then
                Enemy02 = Enemyarray(2)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy02.Visible = False
                    Enemy02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 3 Then
                Enemy03 = Enemyarray(3)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy03.Visible = False
                    Enemy03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 4 Then
                Enemy04 = Enemyarray(4)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy04.Visible = False
                    Enemy04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 5 Then
                Enemy05 = Enemyarray(5)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy05.Visible = False
                    Enemy05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 6 Then
                Enemy06 = Enemyarray(6)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy06.Visible = False
                    Enemy06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount >= 7 Then
                Enemy07 = Enemyarray(7)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy07.Visible = False
                    Enemy07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy2 up"
            If enemycount2 >= 0 Then
                Enemy2_00 = Enemyarray2(0)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy2_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy2_00.Visible = False
                    Enemy2_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 1 Then
                Enemy2_01 = Enemyarray2(1)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy2_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy2_01.Visible = False
                    Enemy2_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 2 Then
                Enemy2_02 = Enemyarray2(2)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy2_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy2_02.Visible = False
                    Enemy2_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 3 Then
                Enemy2_03 = Enemyarray2(3)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy2_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy2_03.Visible = False
                    Enemy2_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 4 Then
                Enemy2_04 = Enemyarray2(4)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy2_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy2_04.Visible = False
                    Enemy2_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 5 Then
                Enemy2_05 = Enemyarray2(5)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy2_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy2_05.Visible = False
                    Enemy2_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 6 Then
                Enemy2_06 = Enemyarray2(6)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy2_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy2_06.Visible = False
                    Enemy2_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount2 >= 7 Then
                Enemy2_07 = Enemyarray2(7)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy2_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy2_07.Visible = False
                    Enemy2_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy3 up"
            If enemycount3 >= 0 Then
                Enemy3_00 = Enemyarray3(0)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy3_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy3_00.Visible = False
                    Enemy3_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 1 Then
                Enemy3_01 = Enemyarray3(1)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy3_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy3_01.Visible = False
                    Enemy3_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 2 Then
                Enemy3_02 = Enemyarray3(2)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy3_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy3_02.Visible = False
                    Enemy3_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 3 Then
                Enemy3_03 = Enemyarray3(3)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy3_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy3_03.Visible = False
                    Enemy3_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 4 Then
                Enemy3_04 = Enemyarray3(4)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy3_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy3_04.Visible = False
                    Enemy3_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 5 Then
                Enemy3_05 = Enemyarray3(5)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy3_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy3_05.Visible = False
                    Enemy3_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 6 Then
                Enemy3_06 = Enemyarray3(6)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy3_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy3_06.Visible = False
                    Enemy3_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount3 >= 7 Then
                Enemy3_07 = Enemyarray3(7)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy3_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy3_07.Visible = False
                    Enemy3_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy4 up"
            If enemycount4 >= 0 Then
                Enemy4_00 = Enemyarray4(0)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy4_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy4_00.Visible = False
                    Enemy4_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 1 Then
                Enemy4_01 = Enemyarray4(1)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy4_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy4_01.Visible = False
                    Enemy4_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 2 Then
                Enemy4_02 = Enemyarray4(2)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy4_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy4_02.Visible = False
                    Enemy4_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 3 Then
                Enemy4_03 = Enemyarray4(3)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy4_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy4_03.Visible = False
                    Enemy4_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 4 Then
                Enemy4_04 = Enemyarray4(4)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy4_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy4_04.Visible = False
                    Enemy4_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 5 Then
                Enemy4_05 = Enemyarray4(5)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy4_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy4_05.Visible = False
                    Enemy4_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 6 Then
                Enemy4_06 = Enemyarray4(6)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy4_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy4_06.Visible = False
                    Enemy4_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount4 >= 7 Then
                Enemy4_07 = Enemyarray4(7)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy4_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy4_07.Visible = False
                    Enemy4_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy5 up"
            If enemycount5 >= 0 Then
                Enemy5_00 = Enemyarray5(0)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy5_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy5_00.Visible = False
                    Enemy5_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 1 Then
                Enemy5_01 = Enemyarray5(1)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy5_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy5_01.Visible = False
                    Enemy5_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 2 Then
                Enemy5_02 = Enemyarray5(2)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy5_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy5_02.Visible = False
                    Enemy5_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 3 Then
                Enemy5_03 = Enemyarray5(3)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy5_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy5_03.Visible = False
                    Enemy5_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 4 Then
                Enemy5_04 = Enemyarray5(4)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy5_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy5_04.Visible = False
                    Enemy5_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 5 Then
                Enemy5_05 = Enemyarray5(5)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy5_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy5_05.Visible = False
                    Enemy5_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 6 Then
                Enemy5_06 = Enemyarray5(6)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy5_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy5_06.Visible = False
                    Enemy5_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount5 >= 7 Then
                Enemy5_07 = Enemyarray5(7)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy5_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy5_07.Visible = False
                    Enemy5_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
#Region "Enemy6 up"
            If enemycount6 >= 0 Then
                Enemy6_00 = Enemyarray6(0)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy6_00.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy6_00.Visible = False
                    Enemy6_00.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 1 Then
                Enemy6_01 = Enemyarray6(1)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy6_01.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy6_01.Visible = False
                    Enemy6_01.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 2 Then
                Enemy6_02 = Enemyarray6(2)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy6_02.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy6_02.Visible = False
                    Enemy6_02.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 3 Then
                Enemy6_03 = Enemyarray6(3)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy6_03.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy6_03.Visible = False
                    Enemy6_03.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 4 Then
                Enemy6_04 = Enemyarray6(4)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy6_04.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy6_04.Visible = False
                    Enemy6_04.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 5 Then
                Enemy6_05 = Enemyarray6(5)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy6_05.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy6_05.Visible = False
                    Enemy6_05.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 6 Then
                Enemy6_06 = Enemyarray6(6)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy6_06.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy6_06.Visible = False
                    Enemy6_06.Location = New Point(20000, 20000)
                End If
            End If
            If enemycount6 >= 7 Then
                Enemy6_07 = Enemyarray6(7)
                If Bullet_arrayUp(D).Bounds.IntersectsWith(Enemy6_07.Bounds) Then
                    Me.Controls.Remove(Bullet_arrayUp(D))
                    Bullet_arrayUp(D).Left = 2000
                    Bullet_arrayUp(D).Top = 2000
                    Enemy6_07.Visible = False
                    Enemy6_07.Location = New Point(20000, 20000)
                End If
            End If
#End Region
        Next
    End Sub
#End Region

    Private Sub Spawn_Tick(sender As Object, e As EventArgs) Handles Spawn.Tick
        Dim Number As Integer
        Dim Rng As Random = New Random()
        Number = Rng.Next(1, 8)
        'Number = 7
        If Number = 1 Then
            Pos1()
        ElseIf Number = 2 Then
            Pos2()
        ElseIf Number = 3 Then
            Pos3()
        ElseIf Number = 4 Then
            Pos4()
        ElseIf Number = 5 Then
            Pos5()
        ElseIf Number = 6 Then
            Pos6()
        ElseIf Number = 7 Then
            Pos7()
        End If
    End Sub
    Sub Pos1()
        Dim Enemy1 As New PictureBox
        enemycount += 1
        Testenemycount()
        If enemycountarray < 7 Then
            Enemy1.Location = New Point(15, 30)
            Enemy1.Size = New Size(36, 50)
            Enemy1.Image = My.Resources.mario1
            Enemy1.SizeMode = PictureBoxSizeMode.StretchImage
            Enemy1.BackColor = Color.Transparent
            Controls.Add(Enemy1)
            CreateEnemy.Start()
            enemycountarray += 1
            Enemyarray(enemycountarray) = Enemy1
        End If
    End Sub
    Sub Testenemycount()
        If enemycount = 8 Then
            Enemy00 = Enemyarray(0)
            Enemy00.Visible = True
            Enemy00.Location = New Point(15, 30)
        End If
        If enemycount = 9 Then
            Enemy01 = Enemyarray(1)
            Enemy01.Visible = True
            Enemy01.Location = New Point(15, 30)
        End If
        If enemycount = 10 Then
            Enemy02 = Enemyarray(2)
            Enemy02.Visible = True
            Enemy02.Location = New Point(15, 30)
        End If
        If enemycount = 11 Then
            Enemy03 = Enemyarray(3)
            Enemy03.Visible = True
            Enemy03.Location = New Point(15, 30)
        End If
        If enemycount = 12 Then
            Enemy04 = Enemyarray(4)
            Enemy04.Visible = True
            Enemy04.Location = New Point(15, 30)
        End If
        If enemycount = 13 Then
            Enemy05 = Enemyarray(5)
            Enemy05.Visible = True
            Enemy05.Location = New Point(15, 30)
        End If
        If enemycount = 14 Then
            Enemy06 = Enemyarray(6)
            Enemy06.Visible = True
            Enemy06.Location = New Point(15, 30)
        End If
        If enemycount = 15 Then
            Enemy07 = Enemyarray(7)
            Enemy07.Visible = True
            Enemy07.Location = New Point(15, 30)
        End If
        If enemycount = 15 Then
            enemycount = 7
        End If
    End Sub
    Sub Pos2()
        Dim Enemy2 As New PictureBox
        enemycount2 += 1
        Testenemycount2()
        If enemycountarray2 < 7 Then
            Enemy2.Location = New Point(30, 200)
            Enemy2.Size = New Size(36, 50)
            Enemy2.Image = My.Resources.mario1
            Enemy2.BackColor = Color.Transparent
            Enemy2.SizeMode = PictureBoxSizeMode.StretchImage
            Controls.Add(Enemy2)
            CreateEnemy.Start()
            enemycountarray2 += 1
            Enemyarray2(enemycountarray2) = Enemy2
        End If
    End Sub
    Sub Testenemycount2()
        If enemycount2 = 8 Then
            Enemy2_00 = Enemyarray2(0)
            Enemy2_00.Visible = True
            Enemy2_00.Location = New Point(30, 200)
        End If
        If enemycount2 = 9 Then
            Enemy2_01 = Enemyarray2(1)
            Enemy2_01.Visible = True
            Enemy2_01.Location = New Point(30, 200)
        End If
        If enemycount2 = 10 Then
            Enemy2_02 = Enemyarray2(2)
            Enemy2_02.Visible = True
            Enemy2_02.Location = New Point(30, 200)
        End If
        If enemycount2 = 11 Then
            Enemy2_03 = Enemyarray2(3)
            Enemy2_03.Visible = True
            Enemy2_03.Location = New Point(30, 200)
        End If
        If enemycount2 = 12 Then
            Enemy2_04 = Enemyarray2(4)
            Enemy2_04.Visible = True
            Enemy2_04.Location = New Point(30, 200)
        End If
        If enemycount2 = 13 Then
            Enemy2_05 = Enemyarray2(5)
            Enemy2_05.Visible = True
            Enemy2_01.Location = New Point(30, 200)
        End If
        If enemycount2 = 14 Then
            Enemy2_06 = Enemyarray2(6)
            Enemy2_06.Visible = True
            Enemy2_06.Location = New Point(30, 200)
        End If
        If enemycount2 = 15 Then
            Enemy2_07 = Enemyarray2(7)
            Enemy2_07.Visible = True
            Enemy2_07.Location = New Point(30, 200)
        End If
        If enemycount2 = 15 Then
            enemycount2 = 7
        End If
    End Sub
    Sub Pos3()
        Dim Enemy3 As New PictureBox
        enemycount3 += 1
        Testenemycount3()
        If enemycountarray3 < 7 Then
            Enemy3.Location = New Point(30, 400)
            Enemy3.Size = New Size(36, 50)
            Enemy3.Image = My.Resources.mario1
            Enemy3.SizeMode = PictureBoxSizeMode.StretchImage
            Enemy3.BackColor = Color.Transparent
            Controls.Add(Enemy3)
            CreateEnemy.Start()
            enemycountarray3 += 1
            Enemyarray3(enemycountarray3) = Enemy3
        End If
    End Sub
    Sub Testenemycount3()
        If enemycount3 = 8 Then
            Enemy3_00 = Enemyarray3(0)
            Enemy3_00.Visible = True
            Enemy3_00.Location = New Point(30, 400)
        End If
        If enemycount3 = 9 Then
            Enemy3_01 = Enemyarray3(1)
            Enemy3_01.Visible = True
            Enemy3_01.Location = New Point(30, 400)
        End If
        If enemycount3 = 10 Then
            Enemy3_02 = Enemyarray3(2)
            Enemy3_02.Visible = True
            Enemy3_02.Location = New Point(30, 400)
        End If
        If enemycount3 = 11 Then
            Enemy3_03 = Enemyarray3(3)
            Enemy3_03.Visible = True
            Enemy3_03.Location = New Point(30, 400)
        End If
        If enemycount3 = 12 Then
            Enemy3_04 = Enemyarray3(4)
            Enemy3_04.Visible = True
            Enemy3_04.Location = New Point(30, 400)
        End If
        If enemycount3 = 13 Then
            Enemy3_05 = Enemyarray3(5)
            Enemy3_05.Visible = True
            Enemy3_05.Location = New Point(30, 400)
        End If
        If enemycount3 = 14 Then
            Enemy3_06 = Enemyarray3(6)
            Enemy3_06.Visible = True
            Enemy3_06.Location = New Point(30, 400)
        End If
        If enemycount3 = 15 Then
            Enemy3_07 = Enemyarray3(7)
            Enemy3_07.Visible = True
            Enemy3_07.Location = New Point(30, 400)
        End If
        If enemycount3 = 15 Then
            enemycount3 = 7
        End If
    End Sub
    Sub Pos4()
        Dim Enemy4 As New PictureBox
        enemycount4 += 1
        Testenemycount4()
        If enemycountarray4 < 7 Then
            Enemy4.Location = New Point(60, 400)
            Enemy4.Size = New Size(36, 50)
            Enemy4.Image = My.Resources.mario1
            Enemy4.SizeMode = PictureBoxSizeMode.StretchImage
            Enemy4.BackColor = Color.Transparent
            Controls.Add(Enemy4)
            CreateEnemy.Start()
            enemycountarray4 += 1
            Enemyarray4(enemycountarray4) = Enemy4
        End If
    End Sub
    Sub Testenemycount4()
        If enemycount4 = 8 Then
            Enemy4_00 = Enemyarray4(0)
            Enemy4_00.Visible = True
            Enemy4_00.Location = New Point(60, 400)
        End If
        If enemycount4 = 9 Then
            Enemy4_01 = Enemyarray4(1)
            Enemy4_01.Visible = True
            Enemy4_01.Location = New Point(60, 400)
        End If
        If enemycount4 = 10 Then
            Enemy4_02 = Enemyarray4(2)
            Enemy4_02.Visible = True
            Enemy4_02.Location = New Point(60, 400)
        End If
        If enemycount4 = 11 Then
            Enemy4_03 = Enemyarray4(3)
            Enemy4_03.Visible = True
            Enemy4_03.Location = New Point(60, 400)
        End If
        If enemycount4 = 12 Then
            Enemy4_04 = Enemyarray4(4)
            Enemy4_04.Visible = True
            Enemy4_04.Location = New Point(60, 400)
        End If
        If enemycount4 = 13 Then
            Enemy4_05 = Enemyarray4(5)
            Enemy4_05.Visible = True
            Enemy4_05.Location = New Point(60, 400)
        End If
        If enemycount4 = 14 Then
            Enemy4_06 = Enemyarray4(6)
            Enemy4_06.Visible = True
            Enemy4_06.Location = New Point(60, 400)
        End If
        If enemycount4 = 15 Then
            Enemy4_07 = Enemyarray4(7)
            Enemy4_07.Visible = True
            Enemy4_07.Location = New Point(60, 400)
        End If
        If enemycount4 = 15 Then
            enemycount4 = 7
        End If
    End Sub
    Sub Pos5()
        Dim Enemy5 As New PictureBox
        enemycount5 += 1
        Testenemycount5()
        If enemycountarray5 < 7 Then
            Enemy5.Location = New Point(382, 400)
            Enemy5.Size = New Size(36, 50)
            Enemy5.Image = My.Resources.mario1
            Enemy5.SizeMode = PictureBoxSizeMode.StretchImage
            Enemy5.BackColor = Color.Transparent
            Controls.Add(Enemy5)
            CreateEnemy.Start()
            enemycountarray5 += 1
            Enemyarray5(enemycountarray5) = Enemy5
        End If
    End Sub
    Sub Testenemycount5()
        If enemycount5 = 8 Then
            Enemy5_00 = Enemyarray5(0)
            Enemy5_00.Visible = True
            Enemy5_00.Location = New Point(382, 400)
        End If
        If enemycount5 = 9 Then
            Enemy5_01 = Enemyarray5(1)
            Enemy5_01.Visible = True
            Enemy5_01.Location = New Point(382, 400)
        End If
        If enemycount5 = 10 Then
            Enemy5_02 = Enemyarray5(2)
            Enemy5_02.Visible = True
            Enemy5_02.Location = New Point(382, 400)
        End If
        If enemycount5 = 11 Then
            Enemy5_03 = Enemyarray5(3)
            Enemy5_03.Visible = True
            Enemy5_03.Location = New Point(382, 400)
        End If
        If enemycount5 = 12 Then
            Enemy5_04 = Enemyarray5(4)
            Enemy5_04.Visible = True
            Enemy5_04.Location = New Point(382, 400)
        End If
        If enemycount5 = 13 Then
            Enemy5_05 = Enemyarray5(5)
            Enemy5_05.Visible = True
            Enemy5_05.Location = New Point(382, 400)
        End If
        If enemycount5 = 14 Then
            Enemy5_06 = Enemyarray5(6)
            Enemy5_06.Visible = True
            Enemy5_06.Location = New Point(382, 400)
        End If
        If enemycount5 = 15 Then
            Enemy5_07 = Enemyarray5(7)
            Enemy5_07.Visible = True
            Enemy5_07.Location = New Point(382, 400)
        End If
        If enemycount5 = 15 Then
            enemycount5 = 7
        End If
    End Sub
    Sub Pos6()
        Dim Enemy6 As New PictureBox
        enemycount6 += 1
        Testenemycount6()
        If enemycountarray6 < 7 Then
            Enemy6.Location = New Point(715, 400)
            Enemy6.Size = New Size(36, 50)
            Enemy6.Image = My.Resources.mario1
            Enemy6.SizeMode = PictureBoxSizeMode.StretchImage
            Enemy6.BackColor = Color.Transparent
            Controls.Add(Enemy6)
            CreateEnemy.Start()
            enemycountarray6 += 1
            Enemyarray6(enemycountarray6) = Enemy6
        End If
    End Sub
    Sub Testenemycount6()
        If enemycount6 = 8 Then
            Enemy6_00 = Enemyarray6(0)
            Enemy6_00.Visible = True
            Enemy6_00.Location = New Point(715, 400)
        End If
        If enemycount6 = 9 Then
            Enemy6_01 = Enemyarray6(1)
            Enemy6_01.Visible = True
            Enemy6_01.Location = New Point(715, 400)
        End If
        If enemycount6 = 10 Then
            Enemy6_02 = Enemyarray6(2)
            Enemy6_02.Visible = True
            Enemy6_02.Location = New Point(715, 400)
        End If
        If enemycount6 = 11 Then
            Enemy6_03 = Enemyarray6(3)
            Enemy6_03.Visible = True
            Enemy6_03.Location = New Point(715, 400)
        End If
        If enemycount6 = 12 Then
            Enemy6_04 = Enemyarray6(4)
            Enemy6_04.Visible = True
            Enemy6_04.Location = New Point(715, 400)
        End If
        If enemycount6 = 13 Then
            Enemy6_05 = Enemyarray6(5)
            Enemy6_05.Visible = True
            Enemy6_05.Location = New Point(715, 400)
        End If
        If enemycount6 = 14 Then
            Enemy6_06 = Enemyarray6(6)
            Enemy6_06.Visible = True
            Enemy6_06.Location = New Point(715, 400)
        End If
        If enemycount6 = 15 Then
            Enemy6_07 = Enemyarray6(7)
            Enemy6_07.Visible = True
            Enemy6_07.Location = New Point(715, 400)
        End If
        If enemycount6 = 15 Then
            enemycount6 = 7
        End If
    End Sub
    Sub Pos7()
        Dim Enemy7 As New PictureBox
        enemycount7 += 1
        Testenemycount7()
        If enemycountarray7 < 7 Then
            Enemy7.Location = New Point(715, 110)
            Enemy7.Size = New Size(36, 50)
            Enemy7.Image = My.Resources.mario1
            Enemy7.SizeMode = PictureBoxSizeMode.StretchImage
            Enemy7.BackColor = Color.Transparent
            Controls.Add(Enemy7)
            CreateEnemy.Start()
            enemycountarray7 += 1
            Enemyarray7(enemycountarray7) = Enemy7
        End If
    End Sub
    Sub Testenemycount7()
        If enemycount7 = 8 Then
            Enemy7_00 = Enemyarray7(0)
            Enemy7_00.Visible = True
            Enemy7_00.Location = New Point(715, 400)
        End If
        If enemycount7 = 9 Then
            Enemy7_01 = Enemyarray7(1)
            Enemy7_01.Visible = True
            Enemy7_01.Location = New Point(715, 400)
        End If
        If enemycount7 = 10 Then
            Enemy7_02 = Enemyarray7(2)
            Enemy7_02.Visible = True
            Enemy7_02.Location = New Point(715, 400)
        End If
        If enemycount7 = 11 Then
            Enemy7_03 = Enemyarray7(3)
            Enemy7_03.Visible = True
            Enemy7_03.Location = New Point(715, 400)
        End If
        If enemycount7 = 12 Then
            Enemy7_04 = Enemyarray7(4)
            Enemy7_04.Visible = True
            Enemy7_04.Location = New Point(715, 400)
        End If
        If enemycount7 = 13 Then
            Enemy7_05 = Enemyarray7(5)
            Enemy7_05.Visible = True
            Enemy7_05.Location = New Point(715, 400)
        End If
        If enemycount7 = 14 Then
            Enemy7_06 = Enemyarray7(6)
            Enemy7_06.Visible = True
            Enemy7_06.Location = New Point(715, 400)
        End If
        If enemycount7 = 15 Then
            Enemy7_07 = Enemyarray7(7)
            Enemy7_07.Visible = True
            Enemy7_07.Location = New Point(715, 400)
        End If
        If enemycount7 = 15 Then
            enemycount7 = 7
        End If
    End Sub
    Private Sub CreateEnemy_Tick(sender As Object, e As EventArgs) Handles CreateEnemy.Tick
        Dim F As Integer
        Dim Z As Integer = 1
        Dim Y As Integer = 1



        For F = 0 To enemycountarray
            If F = 0 Then
                Enemyarray(0).Left += Z
            End If
        Next
        For F = 1 To enemycountarray
            If F = 1 Then
                Enemyarray(1).Left += Z
            End If
        Next
        For F = 2 To enemycountarray
            If F = 2 Then
                Enemyarray(2).Left += Z
            End If
        Next
        For F = 3 To enemycountarray
            If F = 3 Then
                Enemyarray(3).Left += Z
            End If
        Next
        For F = 4 To enemycountarray
            If F = 4 Then
                Enemyarray(4).Left += Z
            End If
        Next
        For F = 5 To enemycountarray
            If F = 5 Then
                Enemyarray(5).Left += Z
            End If
        Next
        For F = 6 To enemycountarray
            If F = 6 Then
                Enemyarray(6).Left += Z
            End If
        Next
        For F = 7 To enemycountarray
            If F = 7 Then
                Enemyarray(7).Left += Z
            End If
        Next



        Dim G As Integer
        For G = 0 To enemycountarray2
            If G = 0 Then
                Enemyarray2(0).Left += Z
            End If
        Next
        For G = 1 To enemycountarray2
            If G = 1 Then
                Enemyarray2(1).Left += Z
            End If
        Next
        For G = 2 To enemycountarray2
            If G = 2 Then
                Enemyarray2(2).Left += Z
            End If
        Next
        For G = 3 To enemycountarray2
            If G = 3 Then
                Enemyarray2(3).Left += Z
            End If
        Next
        For G = 4 To enemycountarray2
            If G = 4 Then
                Enemyarray2(4).Left += Z
            End If
        Next
        For G = 5 To enemycountarray2
            If G = 5 Then
                Enemyarray2(5).Left += Z
            End If
        Next
        For G = 6 To enemycountarray2
            If G = 6 Then
                Enemyarray2(6).Left += Z
            End If
        Next
        For G = 7 To enemycountarray2
            If G = 7 Then
                Enemyarray2(7).Left += Z
            End If
        Next




        Dim H As Integer
        For H = 0 To enemycountarray3
            If H = 0 Then
                Enemyarray3(0).Left += Z
            End If
        Next
        For H = 1 To enemycountarray3
            If H = 1 Then
                Enemyarray3(1).Left += Z
            End If
        Next
        For H = 2 To enemycountarray3
            If H = 2 Then
                Enemyarray3(2).Left += Z
            End If
        Next
        For H = 3 To enemycountarray3
            If H = 3 Then
                Enemyarray3(3).Left += Z
            End If
        Next
        For H = 4 To enemycountarray3
            If H = 4 Then
                Enemyarray3(4).Left += Z
            End If
        Next
        For H = 5 To enemycountarray3
            If H = 5 Then
                Enemyarray3(5).Left += Z
            End If
        Next
        For H = 6 To enemycountarray3
            If H = 6 Then
                Enemyarray3(6).Left += Z
            End If
        Next
        For H = 7 To enemycountarray3
            If H = 7 Then
                Enemyarray3(7).Left += Z
            End If
        Next

        Dim I As Integer
        For I = 0 To enemycountarray4
            If I = 0 Then
                Enemyarray4(0).Top -= Y
            End If
        Next
        For I = 1 To enemycountarray4
            If I = 1 Then
                Enemyarray4(1).Top -= Y
            End If
        Next
        For I = 2 To enemycountarray4
            If I = 2 Then
                Enemyarray4(2).Top -= Y
            End If
        Next
        For I = 3 To enemycountarray4
            If I = 3 Then
                Enemyarray4(3).Top -= Y
            End If
        Next
        For I = 4 To enemycountarray4
            If I = 4 Then
                Enemyarray4(4).Top -= Y
            End If
        Next
        For I = 5 To enemycountarray4
            If I = 5 Then
                Enemyarray4(5).Top -= Y
            End If
        Next
        For I = 6 To enemycountarray4
            If I = 6 Then
                Enemyarray4(6).Top -= Y
            End If
        Next
        For I = 7 To enemycountarray4
            If I = 7 Then
                Enemyarray4(7).Top -= Y
            End If
        Next

        Dim J As Integer
        For J = 0 To enemycountarray5
            If J = 0 Then
                Enemyarray5(0).Top -= Y
            End If
        Next
        For J = 1 To enemycountarray5
            If J = 1 Then
                Enemyarray5(1).Top -= Y
            End If
        Next
        For J = 2 To enemycountarray5
            If J = 2 Then
                Enemyarray5(2).Top -= Y
            End If
        Next
        For J = 3 To enemycountarray5
            If J = 3 Then
                Enemyarray5(3).Top -= Y
            End If
        Next
        For J = 4 To enemycountarray5
            If J = 4 Then
                Enemyarray5(4).Top -= Y
            End If
        Next
        For J = 5 To enemycountarray5
            If J = 5 Then
                Enemyarray5(5).Top -= Y
            End If
        Next
        For J = 6 To enemycountarray5
            If J = 6 Then
                Enemyarray5(6).Top -= Y
            End If
        Next
        For J = 7 To enemycountarray5
            If J = 7 Then
                Enemyarray5(7).Top -= Y
            End If
        Next

        Dim K As Integer
        For K = 0 To enemycountarray6
            If K = 0 Then
                Enemyarray6(0).Top -= Y
            End If
        Next
        For K = 1 To enemycountarray6
            If K = 1 Then
                Enemyarray6(1).Top -= Y
            End If
        Next
        For K = 2 To enemycountarray6
            If K = 2 Then
                Enemyarray6(2).Top -= Y
            End If
        Next
        For K = 3 To enemycountarray6
            If K = 3 Then
                Enemyarray6(3).Top -= Y
            End If
        Next
        For K = 4 To enemycountarray6
            If K = 4 Then
                Enemyarray6(4).Top -= Y
            End If
        Next
        For K = 5 To enemycountarray6
            If K = 5 Then
                Enemyarray6(5).Top -= Y
            End If
        Next
        For K = 6 To enemycountarray6
            If K = 6 Then
                Enemyarray6(6).Top -= Y
            End If
        Next
        For K = 7 To enemycountarray6
            If K = 7 Then
                Enemyarray6(7).Top -= Y
            End If
        Next

        Dim L As Integer
        For L = 0 To enemycountarray7
            If L = 0 Then
                Enemyarray7(0).Left -= Y
            End If
        Next
        For L = 1 To enemycountarray7
            If L = 1 Then
                Enemyarray7(1).Left -= Y
            End If
        Next
        For L = 2 To enemycountarray7
            If L = 2 Then
                Enemyarray7(2).Left -= Y
            End If
        Next
        For L = 3 To enemycountarray7
            If L = 3 Then
                Enemyarray7(3).Left -= Y
            End If
        Next
        For L = 4 To enemycountarray7
            If L = 4 Then
                Enemyarray7(4).Left -= Y
            End If
        Next
        For L = 5 To enemycountarray7
            If L = 5 Then
                Enemyarray7(5).Left -= Y
            End If
        Next
        For L = 6 To enemycountarray7
            If L = 6 Then
                Enemyarray7(6).Left -= Y
            End If
        Next
        For L = 7 To enemycountarray7
            If L = 7 Then
                Enemyarray7(7).Left -= Y
            End If
        Next

    End Sub
End Class