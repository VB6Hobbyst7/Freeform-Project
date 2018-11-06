'imports varibales from Form1
Imports SpriteMovement.Form1.GlobalVariables
Class Gameover
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Gameover_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblscoregameover.Text = Score
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        Restartbuttonpush = True
        enemycount = -1
        enemycountarray = -1
        enemycountarray2 = -1
        enemycount2 = -1
        enemycountarray3 = -1
        enemycount3 = -1
        enemycountarray4 = -1
        enemycount4 = -1
        enemycountarray5 = -1
        enemycount5 = -1
        enemycountarray6 = -1
        enemycount6 = -1
        enemycountarray7 = -1
        enemycount7 = -1
        enemycountarray8 = -1
        enemycount8 = -1
        enemycountarray9 = -1
        enemycount9 = -1
        Me.Hide()


    End Sub
End Class