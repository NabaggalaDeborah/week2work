Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String = txtName.Text
        Dim Age As Integer = txtAge.Text
        Dim FavoriteColor As String = txtFavoritecolor.Text

        MessageBox.Show(Name & Age & FavoriteColor)
    End Sub
End Class
