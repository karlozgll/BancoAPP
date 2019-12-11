<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.ComboBoxCtaBancaria = New System.Windows.Forms.ComboBox()
        Me.FechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxCtaBancaria = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFecha = New System.Windows.Forms.CheckBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.DataGridVReportes = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridVReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(281, 63)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(312, 22)
        Me.TxtDNI.TabIndex = 0
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(65, 71)
        Me.LblDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(31, 17)
        Me.LblDNI.TabIndex = 1
        Me.LblDNI.Text = "DNI"
        '
        'ComboBoxCtaBancaria
        '
        Me.ComboBoxCtaBancaria.FormattingEnabled = True
        Me.ComboBoxCtaBancaria.Location = New System.Drawing.Point(281, 127)
        Me.ComboBoxCtaBancaria.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCtaBancaria.Name = "ComboBoxCtaBancaria"
        Me.ComboBoxCtaBancaria.Size = New System.Drawing.Size(312, 24)
        Me.ComboBoxCtaBancaria.TabIndex = 3
        '
        'FechaInicial
        '
        Me.FechaInicial.Location = New System.Drawing.Point(281, 191)
        Me.FechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaInicial.MaxDate = New Date(2019, 12, 10, 0, 0, 0, 0)
        Me.FechaInicial.Name = "FechaInicial"
        Me.FechaInicial.Size = New System.Drawing.Size(200, 22)
        Me.FechaInicial.TabIndex = 6
        Me.FechaInicial.Value = New Date(2019, 12, 10, 0, 0, 0, 0)
        '
        'FechaFin
        '
        Me.FechaFin.Location = New System.Drawing.Point(568, 191)
        Me.FechaFin.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.Size = New System.Drawing.Size(197, 22)
        Me.FechaFin.TabIndex = 7
        '
        'CheckBoxCtaBancaria
        '
        Me.CheckBoxCtaBancaria.AutoSize = True
        Me.CheckBoxCtaBancaria.Location = New System.Drawing.Point(69, 130)
        Me.CheckBoxCtaBancaria.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxCtaBancaria.Name = "CheckBoxCtaBancaria"
        Me.CheckBoxCtaBancaria.Size = New System.Drawing.Size(135, 21)
        Me.CheckBoxCtaBancaria.TabIndex = 8
        Me.CheckBoxCtaBancaria.Text = "Cuenta Bancaria"
        Me.CheckBoxCtaBancaria.UseVisualStyleBackColor = True
        '
        'CheckBoxFecha
        '
        Me.CheckBoxFecha.AutoSize = True
        Me.CheckBoxFecha.Location = New System.Drawing.Point(69, 191)
        Me.CheckBoxFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxFecha.Name = "CheckBoxFecha"
        Me.CheckBoxFecha.Size = New System.Drawing.Size(135, 21)
        Me.CheckBoxFecha.TabIndex = 9
        Me.CheckBoxFecha.Text = "Rango de Fecha"
        Me.CheckBoxFecha.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Location = New System.Drawing.Point(421, 257)
        Me.BtnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(105, 39)
        Me.BtnGenerar.TabIndex = 11
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'DataGridVReportes
        '
        Me.DataGridVReportes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridVReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVReportes.Location = New System.Drawing.Point(81, 347)
        Me.DataGridVReportes.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridVReportes.Name = "DataGridVReportes"
        Me.DataGridVReportes.Size = New System.Drawing.Size(799, 183)
        Me.DataGridVReportes.TabIndex = 12
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(948, 620)
        Me.Controls.Add(Me.DataGridVReportes)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.CheckBoxFecha)
        Me.Controls.Add(Me.CheckBoxCtaBancaria)
        Me.Controls.Add(Me.FechaFin)
        Me.Controls.Add(Me.FechaInicial)
        Me.Controls.Add(Me.ComboBoxCtaBancaria)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.TxtDNI)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmReportes"
        Me.Text = "Reportes"
        CType(Me.DataGridVReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents LblDNI As Label
    Friend WithEvents ComboBoxCtaBancaria As ComboBox
    Friend WithEvents FechaInicial As DateTimePicker
    Friend WithEvents FechaFin As DateTimePicker
    Friend WithEvents CheckBoxCtaBancaria As CheckBox
    Friend WithEvents CheckBoxFecha As CheckBox
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents DataGridVReportes As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
End Class
