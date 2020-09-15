Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Backgroundcolor As New ColorDialog

        If Backgroundcolor.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.BackColor = Backgroundcolor.Color

        Else




        End If

    End Sub
End Class