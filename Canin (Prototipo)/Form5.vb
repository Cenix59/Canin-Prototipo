Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Dim usuario2 As String = Form3.usuario
    Dim Contraseña2 As String = Form3.contraseña
    Dim telefono2 As Integer = Form3.Telefono
    Dim mail2 As String = Form3.Mail

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If TextBox1.Text = String.Empty Or TextBox2.Text = String.Empty Or TextBox3.Text = String.Empty Or TextBox4.Text = String.Empty Or TextBox5.Text = String.Empty Or TextBox6.Text = String.Empty Or TextBox7.Text = String.Empty Then
            MsgBox("ERROR!" + vbCrLf + "Complete todos los campos")

        Else
            If TextBox5.Text.Contains("@gmail.com") Or TextBox5.Text.Contains("@hotmail.com") Or TextBox5.Text.Contains("@Yahoo.com.ar") Then
                MsgBox("Cambios realizados, exitosamente ")
                Form3.usuario = TextBox3.Text
                Form3.contraseña = TextBox4.Text
                Form3.Telefono = TextBox6.Text
                Form3.Mail = TextBox5.Text
                Form4.Show()
                Me.Hide()
            Else
                MsgBox("Ingrese un mail valido")
            End If
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.PasswordChar = "*"
    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If InStr(1, "0123456789" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
            MsgBox("Solo se aceptan números")
        End If
    End Sub
    Private Sub check()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text <> usuario2 Then
            Button4.Enabled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text <> Contraseña2 Then
            Button4.Enabled = True
        End If
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text <> mail2 Then
            Button4.Enabled = True
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text <> telefono2 Then
            Button4.Enabled = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Match.Show()
    End Sub
End Class