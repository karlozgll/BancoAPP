Public Class FrmMovimientos

    Private Sub BtnBuscarClientes_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        Variables.vista = 2
        FrmClientes.Show()
    End Sub

    Private Sub FrmMovimientos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Variables.vista = 0
    End Sub
End Class