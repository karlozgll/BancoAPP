Public Class FrmPrincipal
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        FrmClientes.Show()
    End Sub

    Private Sub BtnMovimientos_Click(sender As Object, e As EventArgs) Handles BtnMovimientos.Click
        FrmMovimientos.Show()
    End Sub

    Private Sub FrmPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmLogin.Close()
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        FrmReportes.Show()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class