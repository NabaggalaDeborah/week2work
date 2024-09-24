Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Dim result As String = String.Empty
        For I As Integer = 1 To 10
            For M As Integer = 1 To 10
                result &= $"{I * M,4}"
            Next
            result &= Environment.NewLine
        Next
        TextBox1.Text = result
    End Sub
End Class
