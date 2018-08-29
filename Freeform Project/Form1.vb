Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Rbtn.Click
        Dim number As Integer

        Randomize()
        number = Int(Rnd() * 6) + 1

        MessageBox.Show(number)

        ' If (number = 1) Then
        'MessageBox.Show("You rolled 1")
        'End If

        '  If (number > 31 And number < 40) Then
        ' MessageBox.Show("IDK")
        ' End If
        'Call Randomize()



    End Sub
    ' Sub Randomize()

    ' Dim rgn As New Random()
    ' Dim RAND(6) As String
    'RAND(0) = "0"
    '  RAND(1) = "1"
    '  RAND(2) = "2"
    '  RAND(3) = "3"
    '  RAND(4) = "4"
    ' RAND(5) = "5"
    '  RAND(6) = "6"
    '  RAND(7) = "7"
    ' RAND(8) = "8"
    '  RAND(9) = "9"
    '' RAND(10) = "10"
    ' RAND(11) = "11"
    ' RAND(12) = "12"
    ' RAND(13) = "13"
    ' RAND(14) = "14"
    ' RAND(15) = "15"
    ' RAND(16) = "16"
    ' RAND(17) = "17"
    ' RAND(18) = "18"
    '  RAND(19) = "19"
    ' RAND(20) = "20"

    'RDMbox.Text = rgn.Next(RAND.Count())
    'End Sub
End Class
