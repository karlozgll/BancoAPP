<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.LblNombres = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.LblApMat = New System.Windows.Forms.Label()
        Me.TxtApMat = New System.Windows.Forms.TextBox()
        Me.LblApPat = New System.Windows.Forms.Label()
        Me.TxtApPat = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.LblCelular = New System.Windows.Forms.Label()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.ListaClientes = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellidop = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellidom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Celular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Direccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PanelBus = New System.Windows.Forms.GroupBox()
        Me.PanelReg = New System.Windows.Forms.GroupBox()
        Me.PanelBus.SuspendLayout()
        Me.PanelReg.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(741, 720)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(175, 46)
        Me.BtnSalir.TabIndex = 25
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(17, 204)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(169, 46)
        Me.BtnNuevo.TabIndex = 4
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(241, 204)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(159, 46)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(448, 204)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(163, 46)
        Me.BtnModificar.TabIndex = 6
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(648, 204)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(175, 46)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(145, 54)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(184, 22)
        Me.TxtDNI.TabIndex = 0
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(21, 58)
        Me.LblDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(31, 17)
        Me.LblDNI.TabIndex = 3
        Me.LblDNI.Text = "DNI"
        '
        'LblNombres
        '
        Me.LblNombres.AutoSize = True
        Me.LblNombres.Location = New System.Drawing.Point(21, 107)
        Me.LblNombres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombres.Name = "LblNombres"
        Me.LblNombres.Size = New System.Drawing.Size(65, 17)
        Me.LblNombres.TabIndex = 5
        Me.LblNombres.Text = "Nombres"
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(145, 98)
        Me.TxtNombres.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(239, 22)
        Me.TxtNombres.TabIndex = 1
        '
        'LblApMat
        '
        Me.LblApMat.AutoSize = True
        Me.LblApMat.Location = New System.Drawing.Point(481, 54)
        Me.LblApMat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblApMat.Name = "LblApMat"
        Me.LblApMat.Size = New System.Drawing.Size(85, 17)
        Me.LblApMat.TabIndex = 9
        Me.LblApMat.Text = "Ap. Materno"
        '
        'TxtApMat
        '
        Me.TxtApMat.Location = New System.Drawing.Point(605, 46)
        Me.TxtApMat.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtApMat.Name = "TxtApMat"
        Me.TxtApMat.Size = New System.Drawing.Size(215, 22)
        Me.TxtApMat.TabIndex = 3
        '
        'LblApPat
        '
        Me.LblApPat.AutoSize = True
        Me.LblApPat.Location = New System.Drawing.Point(21, 151)
        Me.LblApPat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblApPat.Name = "LblApPat"
        Me.LblApPat.Size = New System.Drawing.Size(83, 17)
        Me.LblApPat.TabIndex = 7
        Me.LblApPat.Text = "Ap. Paterno"
        '
        'TxtApPat
        '
        Me.TxtApPat.Location = New System.Drawing.Point(145, 148)
        Me.TxtApPat.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtApPat.Name = "TxtApPat"
        Me.TxtApPat.Size = New System.Drawing.Size(239, 22)
        Me.TxtApPat.TabIndex = 2
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(481, 150)
        Me.LblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(67, 17)
        Me.LblDireccion.TabIndex = 13
        Me.LblDireccion.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(605, 142)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(215, 22)
        Me.TxtDireccion.TabIndex = 5
        '
        'LblCelular
        '
        Me.LblCelular.AutoSize = True
        Me.LblCelular.Location = New System.Drawing.Point(481, 103)
        Me.LblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCelular.Name = "LblCelular"
        Me.LblCelular.Size = New System.Drawing.Size(52, 17)
        Me.LblCelular.TabIndex = 11
        Me.LblCelular.Text = "Celular"
        '
        'TxtCelular
        '
        Me.TxtCelular.Location = New System.Drawing.Point(605, 95)
        Me.TxtCelular.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(215, 22)
        Me.TxtCelular.TabIndex = 4
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(379, 11)
        Me.LblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(168, 53)
        Me.LblTitulo.TabIndex = 15
        Me.LblTitulo.Text = "Clientes"
        '
        'ListaClientes
        '
        Me.ListaClientes.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListaClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Nombre, Me.Apellidop, Me.Apellidom, Me.Celular, Me.Direccion})
        Me.ListaClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListaClientes.FullRowSelect = True
        Me.ListaClientes.HideSelection = False
        Me.ListaClientes.Location = New System.Drawing.Point(17, 65)
        Me.ListaClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.ListaClientes.Name = "ListaClientes"
        Me.ListaClientes.Size = New System.Drawing.Size(821, 206)
        Me.ListaClientes.TabIndex = 16
        Me.ListaClientes.UseCompatibleStateImageBehavior = False
        Me.ListaClientes.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 100
        '
        'Apellidop
        '
        Me.Apellidop.Text = "Apedillo P"
        Me.Apellidop.Width = 120
        '
        'Apellidom
        '
        Me.Apellidom.Text = "Apellidom"
        Me.Apellidom.Width = 68
        '
        'Celular
        '
        Me.Celular.Text = "Celular"
        Me.Celular.Width = 100
        '
        'Direccion
        '
        Me.Direccion.Text = "Direcccion"
        Me.Direccion.Width = 120
        '
        'TxtBuscarCliente
        '
        Me.TxtBuscarCliente.Location = New System.Drawing.Point(17, 26)
        Me.TxtBuscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBuscarCliente.Name = "TxtBuscarCliente"
        Me.TxtBuscarCliente.Size = New System.Drawing.Size(263, 22)
        Me.TxtBuscarCliente.TabIndex = 17
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(723, 290)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(117, 41)
        Me.BtnAgregar.TabIndex = 18
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'PanelBus
        '
        Me.PanelBus.Controls.Add(Me.TxtBuscarCliente)
        Me.PanelBus.Controls.Add(Me.BtnAgregar)
        Me.PanelBus.Controls.Add(Me.ListaClientes)
        Me.PanelBus.Location = New System.Drawing.Point(51, 374)
        Me.PanelBus.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelBus.Name = "PanelBus"
        Me.PanelBus.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelBus.Size = New System.Drawing.Size(865, 338)
        Me.PanelBus.TabIndex = 19
        Me.PanelBus.TabStop = False
        Me.PanelBus.Text = "Buscar Cliente"
        '
        'PanelReg
        '
        Me.PanelReg.Controls.Add(Me.TxtNombres)
        Me.PanelReg.Controls.Add(Me.LblDireccion)
        Me.PanelReg.Controls.Add(Me.TxtDireccion)
        Me.PanelReg.Controls.Add(Me.BtnNuevo)
        Me.PanelReg.Controls.Add(Me.LblCelular)
        Me.PanelReg.Controls.Add(Me.BtnGuardar)
        Me.PanelReg.Controls.Add(Me.TxtCelular)
        Me.PanelReg.Controls.Add(Me.BtnModificar)
        Me.PanelReg.Controls.Add(Me.LblApMat)
        Me.PanelReg.Controls.Add(Me.BtnEliminar)
        Me.PanelReg.Controls.Add(Me.TxtApMat)
        Me.PanelReg.Controls.Add(Me.LblApPat)
        Me.PanelReg.Controls.Add(Me.TxtDNI)
        Me.PanelReg.Controls.Add(Me.TxtApPat)
        Me.PanelReg.Controls.Add(Me.LblDNI)
        Me.PanelReg.Controls.Add(Me.LblNombres)
        Me.PanelReg.Location = New System.Drawing.Point(51, 68)
        Me.PanelReg.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelReg.Name = "PanelReg"
        Me.PanelReg.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelReg.Size = New System.Drawing.Size(865, 299)
        Me.PanelReg.TabIndex = 20
        Me.PanelReg.TabStop = False
        Me.PanelReg.Text = "Registrar Cliente"
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(967, 780)
        Me.Controls.Add(Me.PanelReg)
        Me.Controls.Add(Me.PanelBus)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmClientes"
        Me.Text = "Clientes"
        Me.PanelBus.ResumeLayout(False)
        Me.PanelBus.PerformLayout()
        Me.PanelReg.ResumeLayout(False)
        Me.PanelReg.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents LblDNI As Label
    Friend WithEvents LblNombres As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents LblApMat As Label
    Friend WithEvents TxtApMat As TextBox
    Friend WithEvents LblApPat As Label
    Friend WithEvents TxtApPat As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents LblCelular As Label
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtBuscarCliente As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents PanelBus As GroupBox
    Friend WithEvents PanelReg As GroupBox
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents ListaClientes As ListView
    Friend WithEvents Celular As ColumnHeader
    Friend WithEvents Direccion As ColumnHeader
    Friend WithEvents Apellidom As ColumnHeader
    Friend WithEvents Codigo As ColumnHeader
    Public WithEvents Apellidop As ColumnHeader
End Class
