Public Class Main_Menu
    Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
        Me.Hide()
        Dim Game = New Form1
        AddHandler Game.FormClosed, AddressOf CloseMe
        Game.Show()
    End Sub

    Sub CloseMe()
        Close()
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Close()
    End Sub
End Class