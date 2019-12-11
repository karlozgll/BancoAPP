Imports System.Data.SqlClient

Public Class FrmReportes
    Private da As SqlDataAdapter
    Private dt As DataTable
    Private fila As Integer
    Dim source1 As BindingSource
    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxCtaBancaria.Enabled = False
        FechaInicial.Enabled = False
        FechaFin.Enabled = False
        FechaInicial.Format = DateTimePickerFormat.Short
        FechaFin.Format = DateTimePickerFormat.Short
        FechaFin.MaxDate = Today

    End Sub

    Private Sub ComboBoxCtaBancaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCtaBancaria.SelectedIndexChanged
        If CheckBoxCtaBancaria.Checked Then
            source1.Filter = "IdCtaBancaria= '" + ComboBoxCtaBancaria.SelectedItem + "'"
        End If

    End Sub

    Private Sub CheckBoxFecha_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFecha.CheckedChanged
        If (FechaInicial.Enabled And FechaFin.Enabled) Then
            FechaInicial.Enabled = False
            FechaFin.Enabled = False
            source1.RemoveFilter()
        Else
            FechaInicial.Enabled = True
            FechaFin.Enabled = True
            source1.Filter = "IdCtaBancaria= '+"+"'"

        End If
    End Sub

    Private Sub CheckBoxCtaBancaria_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCtaBancaria.CheckedChanged
        If (ComboBoxCtaBancaria.Enabled) Then
            ComboBoxCtaBancaria.Enabled = False
            source1.RemoveFilter()
        Else
            ComboBoxCtaBancaria.Enabled = True
            ComboBoxCtaBancaria.Items.Clear()

            Dim sSel As String = "execute sp_consultaCta " + TxtDNI.Text
            Try
                ComboBoxCtaBancaria.Text = ""
                da = New SqlDataAdapter(sSel, dbConnection)
                dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then

                    Dim fii As Integer = 0
                    While fii < dt.Rows.Count
                        Dim dr As DataRow = dt.Rows(fii)
                        Me.ComboBoxCtaBancaria.Items.Add(dr("numCuenta").ToString.Trim)
                        fii = fii + 1
                    End While
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    Private Sub FechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles FechaInicial.ValueChanged
        If CheckBoxFecha.Checked Then
            source1.Filter = "FechaTransaccion >= '" + FechaInicial.Value.ToString("dd-MM-yyyy") + "'"
        End If
    End Sub

    Private Sub FechaFin_ValueChanged(sender As Object, e As EventArgs) Handles FechaFin.ValueChanged
        If CheckBoxFecha.Checked Then
            source1.Filter = "FechaTransaccion <= '" + FechaFin.Value.ToString("dd-MM-yyyy") + "'"
        End If
    End Sub

    Private Sub TxtDNI_TextChanged(sender As Object, e As EventArgs) Handles TxtDNI.TextChanged
        If (TxtDNI.Text.Length = 8) Then
            Try
                Dim sSel As String
                source1 = New BindingSource()
                sSel = "execute sp_reportes " + TxtDNI.Text
                Dim ds As New DataSet
                dt = New DataTable
                da = New SqlDataAdapter(sSel, dbConnection)
                ds.Tables.Add("Tablareporte")
                da.Fill(ds.Tables("Tablareporte"))
                source1.DataSource = ds.Tables("Tablareporte")
                Me.DataGridVReportes.DataSource = source1

            Catch ex As Exception
                MessageBox.Show("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

End Class