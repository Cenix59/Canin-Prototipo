Public Class Diseño
    Dim counter As Integer = 0
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

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Form4.NuevoForo.Controls.Remove(Form4.NuevoForo.Controls(Me.IDForo.Text))
        ListMensaje.Items.Clear()

        Me.Hide()
        Form4.Show()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("$ Le diste me gusta al foro")
    End Sub


End Class