Public Class form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Iniciar.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
