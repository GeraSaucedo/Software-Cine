<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Lblpass = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(24, 286)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(93, 35)
        Me.btnEntrar.TabIndex = 0
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(123, 286)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(93, 35)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(24, 196)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(189, 20)
        Me.txtUser.TabIndex = 2
        '
        'TxtPass
        '
        Me.TxtPass.AcceptsTab = True
        Me.TxtPass.Location = New System.Drawing.Point(24, 238)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(189, 20)
        Me.TxtPass.TabIndex = 3
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Blue
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(24, 176)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(43, 17)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "Usuario"
        Me.lblUser.UseCompatibleTextRendering = True
        '
        'Lblpass
        '
        Me.Lblpass.AutoSize = True
        Me.Lblpass.ForeColor = System.Drawing.Color.White
        Me.Lblpass.Location = New System.Drawing.Point(21, 222)
        Me.Lblpass.Name = "Lblpass"
        Me.Lblpass.Size = New System.Drawing.Size(61, 13)
        Me.Lblpass.TabIndex = 5
        Me.Lblpass.Text = "Contraseña"
        Me.Lblpass.UseMnemonic = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(245, 345)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lblpass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEntrar)
        Me.Name = "Login"
        Me.Text = "Cinepelis"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Lblpass As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
