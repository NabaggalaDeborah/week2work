Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        For I As Integer = 1 To 10
            MessageBox.Show("Number" & I)
        Next
    End Sub
End Class
