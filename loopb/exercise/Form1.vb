Public Class Form1
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim Number As Integer = txtNumber.Text
        If Number = 0 Then
            MessageBox.Show("zero")
        ElseIf Number > 0 Then
            MessageBox.Show("PositiveNumber")
        ElseIf Number < 0 Then
            MessageBox.Show("NegativeNumber")
        End If
    End Sub
End Class
