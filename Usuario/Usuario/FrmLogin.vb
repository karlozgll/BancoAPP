Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opciones = 2
        Conectar()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If opciones > 0 And opciones < 3 Then
            Try
                Dim cmd As New SqlCommand("sp_BuscaUsuario '" & Me.TxtUsuario.Text & "', '" & Me.TxtContraseña.Text & "'", dbConnection)
                dbDataReader = cmd.ExecuteReader
                If dbDataReader.Read Then
                    Me.Hide()
                    Dim user As String
                    user = dbDataReader.Item(1) + " " + dbDataReader.Item(2)
                    dbDataReader.Close()
                    FrmPrincipal.LblNombre.Text = user
                    FrmPrincipal.Show()
                Else
                    MsgBox("No existe Usuario, le quedan " & opciones & "opciones")
                    opciones = opciones - 1
                    dbDataReader.Close()
                    Me.TxtContraseña.Text = ""
                    Me.TxtUsuario.Text = ""
                    Me.TxtUsuario.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                'cn.Close()
            End Try
        Else
            MsgBox("No puede Ingresar ")
            Me.Close()
        End If
    End Sub

    Private Sub TxtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContraseña.KeyPress
        If (e.KeyChar = vbCr) Then 'PARA DAR ENTER Y FUNCIONAR'
            BtnIngresar_Click(sender, e)
        End If
    End Sub
End Class
