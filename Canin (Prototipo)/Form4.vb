Public Class Form4
    Private Sub Perfil_Click(sender As Object, e As EventArgs) Handles Perfil.Click

        Form5.TextBox7.Text = Form3.documento
        Form5.TextBox1.Text = Form3.Nombre
        Form5.TextBox2.Text = Form3.apellido
        Form5.TextBox3.Text = Form3.usuario
        Form5.TextBox4.Text = Form3.contraseña
        Form5.TextBox5.Text = Form3.Mail
        Form5.TextBox6.Text = Form3.Telefono
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        Foro1.Show()
    End Sub

    Private Sub Foro_Click(sender As Object, e As EventArgs) Handles Foro.Click
        If NuevoForo.Controls.Count = 3 Then
            Return
        End If
        Me.Hide()
        Datos.Show()

    End Sub
End Class