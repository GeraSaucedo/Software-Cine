<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnDevoluciones = New System.Windows.Forms.Button()
        Me.btnFunciones = New System.Windows.Forms.Button()
        Me.btnBoletos = New System.Windows.Forms.Button()
        Me.btnPeliculas = New System.Windows.Forms.Button()
        Me.btnEstadisticas = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(338, 30)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(142, 44)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(508, 30)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(142, 44)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Location = New System.Drawing.Point(338, 90)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(142, 44)
        Me.btnProveedores.TabIndex = 2
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Location = New System.Drawing.Point(508, 90)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(142, 44)
        Me.btnVentas.TabIndex = 3
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Location = New System.Drawing.Point(338, 151)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(142, 44)
        Me.btnEmpleados.TabIndex = 4
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnDevoluciones
        '
        Me.btnDevoluciones.Location = New System.Drawing.Point(508, 151)
        Me.btnDevoluciones.Name = "btnDevoluciones"
        Me.btnDevoluciones.Size = New System.Drawing.Size(142, 44)
        Me.btnDevoluciones.TabIndex = 5
        Me.btnDevoluciones.Text = "Devoluciones"
        Me.btnDevoluciones.UseVisualStyleBackColor = True
        '
        'btnFunciones
        '
        Me.btnFunciones.Location = New System.Drawing.Point(338, 210)
        Me.btnFunciones.Name = "btnFunciones"
        Me.btnFunciones.Size = New System.Drawing.Size(142, 44)
        Me.btnFunciones.TabIndex = 6
        Me.btnFunciones.Text = "Funciones"
        Me.btnFunciones.UseVisualStyleBackColor = True
        '
        'btnBoletos
        '
        Me.btnBoletos.Location = New System.Drawing.Point(508, 210)
        Me.btnBoletos.Name = "btnBoletos"
        Me.btnBoletos.Size = New System.Drawing.Size(142, 44)
        Me.btnBoletos.TabIndex = 7
        Me.btnBoletos.Text = "Boletos"
        Me.btnBoletos.UseVisualStyleBackColor = True
        '
        'btnPeliculas
        '
        Me.btnPeliculas.Location = New System.Drawing.Point(338, 269)
        Me.btnPeliculas.Name = "btnPeliculas"
        Me.btnPeliculas.Size = New System.Drawing.Size(142, 44)
        Me.btnPeliculas.TabIndex = 8
        Me.btnPeliculas.Text = "Peliculas"
        Me.btnPeliculas.UseVisualStyleBackColor = True
        '
        'btnEstadisticas
        '
        Me.btnEstadisticas.Location = New System.Drawing.Point(508, 269)
        Me.btnEstadisticas.Name = "btnEstadisticas"
        Me.btnEstadisticas.Size = New System.Drawing.Size(142, 44)
        Me.btnEstadisticas.TabIndex = 9
        Me.btnEstadisticas.Text = "Estadisticas"
        Me.btnEstadisticas.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 283)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(420, 322)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(139, 23)
        Me.btnCerrarSesion.TabIndex = 11
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 357)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEstadisticas)
        Me.Controls.Add(Me.btnPeliculas)
        Me.Controls.Add(Me.btnBoletos)
        Me.Controls.Add(Me.btnFunciones)
        Me.Controls.Add(Me.btnDevoluciones)
        Me.Controls.Add(Me.btnEmpleados)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnProveedores)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnClientes)
        Me.Name = "MenuPrincipal"
        Me.Text = "Cinepelis"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnDevoluciones As Button
    Friend WithEvents btnFunciones As Button
    Friend WithEvents btnBoletos As Button
    Friend WithEvents btnPeliculas As Button
    Friend WithEvents btnEstadisticas As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCerrarSesion As Button
End Class
