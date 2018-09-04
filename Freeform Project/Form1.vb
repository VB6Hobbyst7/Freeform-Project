Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Rbtn.Click
        'Dim creates a variable. This is what the random number generator is equal to.
        Dim number As Integer
        If selectbox.SelectedItem = "Numbers" Then
            Randomize()
            'This randomizes the number based on the parameters put into the 2 text boxes.
            number = Int((NBox1.Text - NBox2.Text * -1) * Rnd())

            MessageBox.Show(number)
            'If the min and max number is the same the randomizer will not work correct and go 2 numbers above and below
        ElseIf selectbox.SelectedItem = "Input" Then
            Dim num As Integer = Math.Ceiling(Rnd() * 4)
            'I assigned a number to each text box to allow the text to be randomly selected based on the inputs put into the text box.
            If num = 1 Then
                MessageBox.Show(Box1.Text)
            ElseIf num = 2 Then
                MessageBox.Show(Box2.Text)
            ElseIf num = 3 Then
                MessageBox.Show(Box3.Text)
            ElseIf num = 4 Then
                MessageBox.Show(Box4.Text)
            End If

        End If




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles resbtn.Click
        'this clears the text that is in the Text boxs
        Box1.Clear()
        Box2.Clear()
        Box3.Clear()
        Box4.Clear()
        NBox1.Clear()
        NBox2.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectbox.SelectedIndexChanged
        'This diables the text boxes that are not needed for certain combo box selections
        If selectbox.SelectedItem = "Input" Then
            Box1.Visible = True
            Box2.Visible = True
            Box3.Visible = True
            Box4.Visible = True
            NBox1.Visible = False
            NBox2.Visible = False
            Min.Visible = False
            Max.Visible = False

        ElseIf selectbox.SelectedItem = "Numbers" Then
            NBox1.Visible = True
            NBox2.Visible = True
            Box1.Visible = False
            Box2.Visible = False
            Box3.Visible = False
            Box4.Visible = False
            Min.Visible = True
            Max.Visible = True

        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub NBox1_TextChanged(sender As Object, e As EventArgs) Handles NBox1.TextChanged
        'this tests whether there is something in the text box which enables you to click randomize. if there is nothing in the text box then it will not let you click randomize.
        If (NBox2.Text = "") Or (NBox1.Text = "") Then
            Rbtn.Enabled = False
        Else
            Rbtn.Enabled = True
        End If
    End Sub

    Private Sub NBox2_TextChanged(sender As Object, e As EventArgs) Handles NBox2.TextChanged
        If (NBox2.Text = "") Or (NBox1.Text = "") Then
            Rbtn.Enabled = False
        Else
            Rbtn.Enabled = True
        End If
    End Sub

    Private Sub Box1_TextChanged(sender As Object, e As EventArgs) Handles Box1.TextChanged
        If (Box1.Text = "") Or (Box2.Text = "") Or (Box3.Text = "") Or (Box4.Text = "") Then
            Rbtn.Enabled = False
        Else
            Rbtn.Enabled = True
        End If
    End Sub

    Private Sub Box2_TextChanged(sender As Object, e As EventArgs) Handles Box2.TextChanged
        If (Box1.Text = "") Or (Box2.Text = "") Or (Box3.Text = "") Or (Box4.Text = "") Then
            Rbtn.Enabled = False
        Else
            Rbtn.Enabled = True
        End If
    End Sub

    Private Sub Box3_TextChanged(sender As Object, e As EventArgs) Handles Box3.TextChanged
        If (Box1.Text = "") Or (Box2.Text = "") Or (Box3.Text = "") Or (Box4.Text = "") Then
            Rbtn.Enabled = False
        Else
            Rbtn.Enabled = True
        End If
    End Sub

    Private Sub Box4_TextChanged(sender As Object, e As EventArgs) Handles Box4.TextChanged
        'This also tests if there is something in the input text boxes. if there is nothing it will not work.
        If (Box1.Text = "") Or (Box2.Text = "") Or (Box3.Text = "") Or (Box4.Text = "") Then
            Rbtn.Enabled = False
        Else
            Rbtn.Enabled = True
        End If
    End Sub
End Class
