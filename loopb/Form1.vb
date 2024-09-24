Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEnterNumber.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numberEntered As Integer = txtEnterNumber.Text
        While numberEntered
            MessageBox.Show("number" & numberEntered)
            numberEntered = numberEntered - 1
        End While

    End Sub
End Class
