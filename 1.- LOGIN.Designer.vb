<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.usuario = New System.Windows.Forms.Label()
        Me.contraseña = New System.Windows.Forms.Label()
        Me.ingreseContraseña = New System.Windows.Forms.TextBox()
        Me.botonIniciarSesion = New System.Windows.Forms.Button()
        Me.ingreseUsuario = New System.Windows.Forms.TextBox()
        Me.iconoLoginUsuario = New System.Windows.Forms.PictureBox()
        Me.iconoUsuario = New FontAwesome.Sharp.IconPictureBox()
        Me.iconoContraseña = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.iconoLoginUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.BackColor = System.Drawing.Color.Transparent
        Me.usuario.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.usuario.ForeColor = System.Drawing.Color.White
        Me.usuario.Location = New System.Drawing.Point(180, 226)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(135, 50)
        Me.usuario.TabIndex = 1
        Me.usuario.Text = "Usuario:"
        '
        'contraseña
        '
        Me.contraseña.AutoSize = True
        Me.contraseña.BackColor = System.Drawing.Color.Transparent
        Me.contraseña.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.contraseña.ForeColor = System.Drawing.Color.White
        Me.contraseña.Location = New System.Drawing.Point(118, 298)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.Size = New System.Drawing.Size(185, 50)
        Me.contraseña.TabIndex = 2
        Me.contraseña.Text = "Contraseña:"
        '
        'ingreseContraseña
        '
        Me.ingreseContraseña.Location = New System.Drawing.Point(340, 298)
        Me.ingreseContraseña.Multiline = True
        Me.ingreseContraseña.Name = "ingreseContraseña"
        Me.ingreseContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ingreseContraseña.Size = New System.Drawing.Size(374, 45)
        Me.ingreseContraseña.TabIndex = 4
        '
        'botonIniciarSesion
        '
        Me.botonIniciarSesion.AutoSize = True
        Me.botonIniciarSesion.BackColor = System.Drawing.Color.Black
        Me.botonIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.botonIniciarSesion.Font = New System.Drawing.Font("Agency FB", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonIniciarSesion.ForeColor = System.Drawing.Color.White
        Me.botonIniciarSesion.Location = New System.Drawing.Point(254, 450)
        Me.botonIniciarSesion.Name = "botonIniciarSesion"
        Me.botonIniciarSesion.Size = New System.Drawing.Size(293, 84)
        Me.botonIniciarSesion.TabIndex = 5
        Me.botonIniciarSesion.Text = "INICIAR SESION"
        Me.botonIniciarSesion.UseVisualStyleBackColor = False
        '
        'ingreseUsuario
        '
        Me.ingreseUsuario.Location = New System.Drawing.Point(340, 226)
        Me.ingreseUsuario.Multiline = True
        Me.ingreseUsuario.Name = "ingreseUsuario"
        Me.ingreseUsuario.Size = New System.Drawing.Size(374, 50)
        Me.ingreseUsuario.TabIndex = 3
        '
        'iconoLoginUsuario
        '
        Me.iconoLoginUsuario.BackColor = System.Drawing.Color.Transparent
        Me.iconoLoginUsuario.Image = CType(resources.GetObject("iconoLoginUsuario.Image"), System.Drawing.Image)
        Me.iconoLoginUsuario.Location = New System.Drawing.Point(340, 12)
        Me.iconoLoginUsuario.Name = "iconoLoginUsuario"
        Me.iconoLoginUsuario.Size = New System.Drawing.Size(125, 125)
        Me.iconoLoginUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconoLoginUsuario.TabIndex = 6
        Me.iconoLoginUsuario.TabStop = False
        '
        'iconoUsuario
        '
        Me.iconoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.iconoUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.iconoUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.iconoUsuario.IconColor = System.Drawing.SystemColors.ControlText
        Me.iconoUsuario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoUsuario.Location = New System.Drawing.Point(154, 239)
        Me.iconoUsuario.Name = "iconoUsuario"
        Me.iconoUsuario.Size = New System.Drawing.Size(32, 32)
        Me.iconoUsuario.TabIndex = 7
        Me.iconoUsuario.TabStop = False
        '
        'iconoContraseña
        '
        Me.iconoContraseña.BackColor = System.Drawing.Color.Transparent
        Me.iconoContraseña.ForeColor = System.Drawing.SystemColors.ControlText
        Me.iconoContraseña.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.iconoContraseña.IconColor = System.Drawing.SystemColors.ControlText
        Me.iconoContraseña.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoContraseña.Location = New System.Drawing.Point(80, 311)
        Me.iconoContraseña.Name = "iconoContraseña"
        Me.iconoContraseña.Size = New System.Drawing.Size(32, 32)
        Me.iconoContraseña.TabIndex = 8
        Me.iconoContraseña.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 541)
        Me.Controls.Add(Me.iconoContraseña)
        Me.Controls.Add(Me.iconoUsuario)
        Me.Controls.Add(Me.iconoLoginUsuario)
        Me.Controls.Add(Me.botonIniciarSesion)
        Me.Controls.Add(Me.ingreseContraseña)
        Me.Controls.Add(Me.ingreseUsuario)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.usuario)
        Me.Name = "login"
        Me.Text = "LOGIN"
        CType(Me.iconoLoginUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usuario As Label
    Friend WithEvents contraseña As Label
    Friend WithEvents ingreseContraseña As TextBox
    Friend WithEvents botonIniciarSesion As Button
    Friend WithEvents ingreseUsuario As TextBox
    Friend WithEvents iconoLoginUsuario As PictureBox
    Friend WithEvents iconoUsuario As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconoContraseña As FontAwesome.Sharp.IconPictureBox
End Class
