Public Class Iniciar
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End

    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click

        Dim limpiar As Limpiar = New Limpiar()
        limpiar.Limpiarcampos(Me)
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim limpiar As Limpiar = New Limpiar()
        If TextBox1.Text = String.Empty Or TextBox2.Text = String.Empty Then
            MsgBox("Complete todos los campos para poder ingresar")
        Else
            If TextBox1.Text <> Form3.usuario Or TextBox2.Text <> Form3.contraseña Then
                MsgBox("Usuario incorrecto")
            Else
                limpiar.Limpiarcampos(Me)
                Me.Hide()
                Form4.Show()

            End If
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

    Private Sub Iniciar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim limpiar As Limpiar = New Limpiar()
        limpiar.Limpiarcampos(Me)
        Form3.Show()
        Me.Hide()
    End Sub
End Class