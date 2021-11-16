Public Class frmGuess
    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim answer As Integer = 15
        Dim attempts As Integer = 0
        Dim userentry As String = ""
        'a loop that repeats while the users guess iz not the same as the answer
        While answer.ToString <> userentry
            userentry = InputBox("Enter a number between 1 and 20")
            'each time through the loop 1 is added to the number of attempts
            attempts = attempts + 1

        End While
        'after the loop it will say how many attempts it took
        MessageBox.Show("Well done you correctly guessed the number, it took you " & attempts.ToString & " attempts")
    End Sub
End Class
