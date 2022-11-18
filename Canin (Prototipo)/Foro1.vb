Public Class Foro1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mensaje As String = Form3.usuario + ":  " + TextBox1.Text
        Dim lista As ListViewItem = New ListViewItem(mensaje)
        ListMensaje.Items.Add(lista)
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
        Form4.Button1.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Le diste me gusta al foro")
    End Sub
End Class