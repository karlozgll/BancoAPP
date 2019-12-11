<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnMovimientos = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(216, 73)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(259, 80)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnMovimientos
        '
        Me.BtnMovimientos.Location = New System.Drawing.Point(216, 185)
        Me.BtnMovimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMovimientos.Name = "BtnMovimientos"
        Me.BtnMovimientos.Size = New System.Drawing.Size(259, 86)
        Me.BtnMovimientos.TabIndex = 1
        Me.BtnMovimientos.Text = "Movimientos"
        Me.BtnMovimientos.UseVisualStyleBackColor = True
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(49, 30)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(111, 17)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre Usuario"
        '
        'BtnReportes
        '
        Me.BtnReportes.Location = New System.Drawing.Point(216, 303)
        Me.BtnReportes.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(259, 80)
        Me.BtnReportes.TabIndex = 3
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 409)
        Me.Controls.Add(Me.BtnReportes)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.BtnMovimientos)
        Me.Controls.Add(Me.BtnClientes)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPrincipal"
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnMovimientos As Button
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnReportes As Button
End Class
