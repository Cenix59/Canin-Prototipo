Public Class Limpiar
    Sub Limpiarcampos(ByVal control As Form)
        Dim txt As Object
        Dim txttemporal As TextBox
        Dim cmb As ComboBox

        For Each txt In control.Controls
            If TypeOf txt Is TextBox Then
                txttemporal = CType(txt, TextBox)
                txttemporal.Clear()

            ElseIf TypeOf txt Is ComboBox Then
                cmb = CType(txt, ComboBox)
                cmb.SelectedIndex = ""
            End If

        Next
    End Sub
End Class
