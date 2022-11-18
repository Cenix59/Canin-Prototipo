Public Class Form3
    Public usuario As String = "Nico"
    Public contraseña As String = 1234
    Public Telefono As Integer = 1161480881
    Public documento As Integer = "46.584.988"
    Public Nombre As String = "Nicolas"
    Public apellido As String = "González Márquez"
    Public Mail As String = "Marqueznicolas.et24@gmail.com"
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim limpiar As Limpiar = New Limpiar()


        If TextBox1.Text = String.Empty Or TextBox2.Text = String.Empty Or TextBox3.Text = String.Empty Or TextBox4.Text = String.Empty Or TextBox5.Text = String.Empty Or TextBox6.Text = String.Empty Or TextBox7.Text = String.Empty Then
            MsgBox("ERROR!" + vbCrLf + "Complete todos los campos")

        Else
            If TextBox7.Text.Contains("@gmail.com") Or TextBox7.Text.Contains("@hotmail.com") Or TextBox7.Text.Contains("@Yahoo.com.ar") Then
                MsgBox($"Registro exitoso ")
                usuario = TextBox1.Text
                contraseña = TextBox2.Text
                Telefono = TextBox3.Text
                documento = TextBox4.Text
                Nombre = TextBox5.Text
                apellido = TextBox6.Text
                Mail = TextBox7.Text

                limpiar.Limpiarcampos(Me)
                Iniciar.Show()
                Me.Hide()
            Else
                MsgBox("Ingrese un mail valido")
            End If
        End If

    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Dim limpiar As Limpiar = New Limpiar()
        limpiar.Limpiarcampos(Me)
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
        REM Button1.Image = Application.StartupPath+"imagen.png"
    End Sub


    Private Sub TextBox4_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If InStr(1, "0123456789." & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
            MsgBox("Solo se aceptan números y el punto")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If InStr(1, "0123456789" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
            MsgBox("Solo se aceptan números")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Iniciar.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
            MsgBox("Solo se aceptan letras")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
            MsgBox("Solo se aceptan letras")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class
