Public Class Datos

    Dim counter As Integer = 0
    Dim nom As String
    Dim ed As Integer
    Dim raza As String
    Dim gen As String
    Dim fec As Integer
    Dim data As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        If TextBox1.Text = String.Empty Or TextBox2.Text = String.Empty Or ComboRaza.Text = String.Empty Or ComboGenero.Text = String.Empty Or TextBox5.Text = String.Empty Then
            MsgBox("Complete los campos necesarios, señalados con un *")
        Else

            nom = TextBox1.Text
            ed = TextBox2.Text
            raza = ComboRaza.Text
            gen = ComboGenero.Text
            fec = TextBox5.Text
            data = TextBox6.Text


            Dim x As New Button With {
            .Text = TextBox1.Text,
            .Width = 126,
            .Height = 36,
            .Name = $"for{counter} "
            }
            counter += 1
            AddHandler x.MouseClick, AddressOf showforo
            Form4.NuevoForo.Controls.Add(x)



            Me.Hide()
            Form4.Show()
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboRaza.Text = ""
            ComboGenero.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""

        End If
    End Sub


    Private Sub showforo(sender As Object, e As EventArgs)
        Form4.Hide()
        Diseño.Label3.Text = nom
        Diseño.Label4.Text = ed
        Diseño.Label6.Text = raza
        Diseño.Label8.Text = gen
        Diseño.Label12.Text = fec
        Diseño.Label14.Text = Data
        Diseño.IDForo.Text = CType(sender, Button).Name
        Diseño.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        Form4.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboRaza.Text = ""
        ComboGenero.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If InStr(1, "0123456789añoAÑOMESmes" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ComboRaza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboRaza.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ComboGenero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboGenero.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If InStr(1, "0123456789/-" & Chr(8) & Chr(13), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

End Class