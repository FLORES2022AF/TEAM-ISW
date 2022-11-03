<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.botonIniciarSesion = New System.Windows.Forms.Button()
        Me.cajaDeTextoIngreseContrasena = New System.Windows.Forms.TextBox()
        Me.etiquetaContrasena = New System.Windows.Forms.Label()
        Me.etiquetaUsuario = New System.Windows.Forms.Label()
        Me.cajaDeTextoIngreseUsuario = New System.Windows.Forms.TextBox()
        Me.cajaImagenLaTipica = New System.Windows.Forms.PictureBox()
        Me.iconoUsuario = New FontAwesome.Sharp.IconPictureBox()
        Me.iconoContraseña = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.cajaImagenLaTipica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'botonIniciarSesion
        '
        Me.botonIniciarSesion.AutoSize = True
        Me.botonIniciarSesion.BackColor = System.Drawing.Color.LightSlateGray
        Me.botonIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.botonIniciarSesion.Font = New System.Drawing.Font("Californian FB", 20.25!)
        Me.botonIniciarSesion.ForeColor = System.Drawing.Color.White
        Me.botonIniciarSesion.Location = New System.Drawing.Point(430, 578)
        Me.botonIniciarSesion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.botonIniciarSesion.Name = "botonIniciarSesion"
        Me.botonIniciarSesion.Size = New System.Drawing.Size(416, 98)
        Me.botonIniciarSesion.TabIndex = 5
        Me.botonIniciarSesion.Text = "INICIAR SESIÓN"
        Me.botonIniciarSesion.UseVisualStyleBackColor = False
        '
        'cajaDeTextoIngreseContrasena
        '
        Me.cajaDeTextoIngreseContrasena.Location = New System.Drawing.Point(430, 497)
        Me.cajaDeTextoIngreseContrasena.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cajaDeTextoIngreseContrasena.MaxLength = 20
        Me.cajaDeTextoIngreseContrasena.Multiline = True
        Me.cajaDeTextoIngreseContrasena.Name = "cajaDeTextoIngreseContrasena"
        Me.cajaDeTextoIngreseContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cajaDeTextoIngreseContrasena.Size = New System.Drawing.Size(414, 33)
        Me.cajaDeTextoIngreseContrasena.TabIndex = 7
        '
        'etiquetaContrasena
        '
        Me.etiquetaContrasena.AutoSize = True
        Me.etiquetaContrasena.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaContrasena.Font = New System.Drawing.Font("Californian FB", 12.0!)
        Me.etiquetaContrasena.ForeColor = System.Drawing.Color.Black
        Me.etiquetaContrasena.Location = New System.Drawing.Point(554, 466)
        Me.etiquetaContrasena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.etiquetaContrasena.Name = "etiquetaContrasena"
        Me.etiquetaContrasena.Size = New System.Drawing.Size(174, 28)
        Me.etiquetaContrasena.TabIndex = 8
        Me.etiquetaContrasena.Text = "CONTRASENA:"
        '
        'etiquetaUsuario
        '
        Me.etiquetaUsuario.AutoSize = True
        Me.etiquetaUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaUsuario.Font = New System.Drawing.Font("Californian FB", 12.0!)
        Me.etiquetaUsuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaUsuario.Location = New System.Drawing.Point(576, 383)
        Me.etiquetaUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.etiquetaUsuario.Name = "etiquetaUsuario"
        Me.etiquetaUsuario.Size = New System.Drawing.Size(122, 28)
        Me.etiquetaUsuario.TabIndex = 1
        Me.etiquetaUsuario.Text = "USUARIO:"
        '
        'cajaDeTextoIngreseUsuario
        '
        Me.cajaDeTextoIngreseUsuario.Location = New System.Drawing.Point(430, 414)
        Me.cajaDeTextoIngreseUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cajaDeTextoIngreseUsuario.MaxLength = 25
        Me.cajaDeTextoIngreseUsuario.Multiline = True
        Me.cajaDeTextoIngreseUsuario.Name = "cajaDeTextoIngreseUsuario"
        Me.cajaDeTextoIngreseUsuario.Size = New System.Drawing.Size(414, 33)
        Me.cajaDeTextoIngreseUsuario.TabIndex = 3
        '
        'cajaImagenLaTipica
        '
        Me.cajaImagenLaTipica.Image = CType(resources.GetObject("cajaImagenLaTipica.Image"), System.Drawing.Image)
        Me.cajaImagenLaTipica.Location = New System.Drawing.Point(412, 129)
        Me.cajaImagenLaTipica.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cajaImagenLaTipica.Name = "cajaImagenLaTipica"
        Me.cajaImagenLaTipica.Size = New System.Drawing.Size(434, 215)
        Me.cajaImagenLaTipica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cajaImagenLaTipica.TabIndex = 9
        Me.cajaImagenLaTipica.TabStop = False
        '
        'iconoUsuario
        '
        Me.iconoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.iconoUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.iconoUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.iconoUsuario.IconColor = System.Drawing.SystemColors.ControlText
        Me.iconoUsuario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoUsuario.IconSize = 39
        Me.iconoUsuario.Location = New System.Drawing.Point(381, 414)
        Me.iconoUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.iconoUsuario.Name = "iconoUsuario"
        Me.iconoUsuario.Size = New System.Drawing.Size(39, 40)
        Me.iconoUsuario.TabIndex = 10
        Me.iconoUsuario.TabStop = False
        '
        'iconoContraseña
        '
        Me.iconoContraseña.BackColor = System.Drawing.Color.Transparent
        Me.iconoContraseña.ForeColor = System.Drawing.SystemColors.ControlText
        Me.iconoContraseña.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.iconoContraseña.IconColor = System.Drawing.SystemColors.ControlText
        Me.iconoContraseña.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoContraseña.IconSize = 35
        Me.iconoContraseña.Location = New System.Drawing.Point(381, 497)
        Me.iconoContraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.iconoContraseña.Name = "iconoContraseña"
        Me.iconoContraseña.Size = New System.Drawing.Size(40, 35)
        Me.iconoContraseña.TabIndex = 11
        Me.iconoContraseña.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1228, 817)
        Me.Controls.Add(Me.iconoContraseña)
        Me.Controls.Add(Me.iconoUsuario)
        Me.Controls.Add(Me.cajaImagenLaTipica)
        Me.Controls.Add(Me.etiquetaContrasena)
        Me.Controls.Add(Me.cajaDeTextoIngreseContrasena)
        Me.Controls.Add(Me.botonIniciarSesion)
        Me.Controls.Add(Me.cajaDeTextoIngreseUsuario)
        Me.Controls.Add(Me.etiquetaUsuario)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Login"
        Me.Text = "LOGIN"
        CType(Me.cajaImagenLaTipica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents botonIniciarSesion As Button
    Friend WithEvents cajaDeTextoIngreseContrasena As TextBox
    Friend WithEvents etiquetaContrasena As Label
    Friend WithEvents etiquetaUsuario As Label
    Friend WithEvents cajaDeTextoIngreseUsuario As TextBox
    Friend WithEvents cajaImagenLaTipica As PictureBox
    Friend WithEvents iconoUsuario As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconoContraseña As FontAwesome.Sharp.IconPictureBox
End Class
