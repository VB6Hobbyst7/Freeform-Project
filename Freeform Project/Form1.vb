Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Rbtn.Click
        Dim number As Integer
        If selectbox.SelectedItem = "Numbers" Then
            Randomize()
            number = Int((NBox1.Text - NBox2.Text * -1) * Rnd()) + 1

            MessageBox.Show(number)

        ElseIf selectbox.SelectedItem = "Input" Then
            Randomize()

            Dim rgn As New Random()
            Dim RAND(3) As String

            RAND(0) = Box1.Text
            RAND(1) = Box2.Text
            RAND(2) = Box3.Text
            RAND(3) = Box4.Text

            MessageBox.Show(RAND(Rnd))

        End If
        Call Randomize()



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles resbtn.Click
        Box1.Clear()
        Box2.Clear()
        Box3.Clear()
        Box4.Clear()
        NBox1.Clear()
        NBox2.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectbox.SelectedIndexChanged
        If selectbox.SelectedItem = "Input" Then
            Box1.Visible = True
            Box2.Visible = True
            Box3.Visible = True
            Box4.Visible = True
            NBox1.Visible = False
            NBox2.Visible = False
            Min.Visible = False
            Max.Visible = False
            Rbtn.Enabled = True
        ElseIf selectbox.SelectedItem = "Numbers" Then
            NBox1.Visible = True
            NBox2.Visible = True
            Box1.Visible = False
            Box2.Visible = False
            Box3.Visible = False
            Box4.Visible = False
            Min.Visible = True
            Max.Visible = True
            Rbtn.Enabled = True
        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
End Class
