<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTIONAR_USUARIO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GESTIONAR_USUARIO))
        Me.buscadorDeUsuarios = New System.Windows.Forms.TextBox()
        Me.tituloGestionarUsuario = New System.Windows.Forms.Label()
        Me.iconoBuscarArt = New FontAwesome.Sharp.IconPictureBox()
        Me.botonAceptar = New System.Windows.Forms.Button()
        Me.nombreUsuario = New System.Windows.Forms.TextBox()
        Me.etiquetaNombreUsuario = New System.Windows.Forms.Label()
        Me.etiquetaApellidoPaternoUsuario = New System.Windows.Forms.Label()
        Me.apellidoPaternoUsuario = New System.Windows.Forms.TextBox()
        Me.etiquetaUsuario = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.botonRegresar_E_D1 = New System.Windows.Forms.Button()
        Me.botonDarDeAltaUsuario = New System.Windows.Forms.Button()
        Me.botonModificarUsuario = New System.Windows.Forms.Button()
        Me.botonBorrarUsuario = New System.Windows.Forms.Button()
        CType(Me.iconoBuscarArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buscadorDeUsuarios
        '
        Me.buscadorDeUsuarios.Location = New System.Drawing.Point(28, 91)
        Me.buscadorDeUsuarios.Name = "buscadorDeUsuarios"
        Me.buscadorDeUsuarios.Size = New System.Drawing.Size(638, 23)
        Me.buscadorDeUsuarios.TabIndex = 13
        Me.buscadorDeUsuarios.Text = "Buscar usuario"
        '
        'tituloGestionarUsuario
        '
        Me.tituloGestionarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.tituloGestionarUsuario.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tituloGestionarUsuario.ForeColor = System.Drawing.Color.White
        Me.tituloGestionarUsuario.Location = New System.Drawing.Point(241, 9)
        Me.tituloGestionarUsuario.Name = "tituloGestionarUsuario"
        Me.tituloGestionarUsuario.Size = New System.Drawing.Size(364, 63)
        Me.tituloGestionarUsuario.TabIndex = 14
        Me.tituloGestionarUsuario.Text = "GESTIONAR USUARIO"
        Me.tituloGestionarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iconoBuscarArt
        '
        Me.iconoBuscarArt.BackColor = System.Drawing.Color.Transparent
        Me.iconoBuscarArt.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.iconoBuscarArt.IconColor = System.Drawing.Color.White
        Me.iconoBuscarArt.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoBuscarArt.IconSize = 23
        Me.iconoBuscarArt.Location = New System.Drawing.Point(643, 91)
        Me.iconoBuscarArt.Name = "iconoBuscarArt"
        Me.iconoBuscarArt.Size = New System.Drawing.Size(23, 23)
        Me.iconoBuscarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.iconoBuscarArt.TabIndex = 16
        Me.iconoBuscarArt.TabStop = False
        '
        'botonAceptar
        '
        Me.botonAceptar.AutoSize = True
        Me.botonAceptar.BackColor = System.Drawing.Color.Black
        Me.botonAceptar.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonAceptar.ForeColor = System.Drawing.Color.White
        Me.botonAceptar.Location = New System.Drawing.Point(684, 81)
        Me.botonAceptar.Name = "botonAceptar"
        Me.botonAceptar.Size = New System.Drawing.Size(81, 34)
        Me.botonAceptar.TabIndex = 17
        Me.botonAceptar.Text = "ACEPTAR"
        Me.botonAceptar.UseVisualStyleBackColor = False
        '
        'nombreUsuario
        '
        Me.nombreUsuario.Location = New System.Drawing.Point(210, 134)
        Me.nombreUsuario.Multiline = True
        Me.nombreUsuario.Name = "nombreUsuario"
        Me.nombreUsuario.Size = New System.Drawing.Size(456, 34)
        Me.nombreUsuario.TabIndex = 18
        '
        'etiquetaNombreUsuario
        '
        Me.etiquetaNombreUsuario.AutoSize = True
        Me.etiquetaNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaNombreUsuario.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.etiquetaNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.etiquetaNombreUsuario.Location = New System.Drawing.Point(122, 134)
        Me.etiquetaNombreUsuario.Name = "etiquetaNombreUsuario"
        Me.etiquetaNombreUsuario.Size = New System.Drawing.Size(86, 34)
        Me.etiquetaNombreUsuario.TabIndex = 19
        Me.etiquetaNombreUsuario.Text = "Nombre:"
        '
        'etiquetaApellidoPaternoUsuario
        '
        Me.etiquetaApellidoPaternoUsuario.AutoSize = True
        Me.etiquetaApellidoPaternoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaApellidoPaternoUsuario.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.etiquetaApellidoPaternoUsuario.Location = New System.Drawing.Point(51, 187)
        Me.etiquetaApellidoPaternoUsuario.Name = "etiquetaApellidoPaternoUsuario"
        Me.etiquetaApellidoPaternoUsuario.Size = New System.Drawing.Size(157, 34)
        Me.etiquetaApellidoPaternoUsuario.TabIndex = 21
        Me.etiquetaApellidoPaternoUsuario.Text = "Apellido paterno:"
        '
        'apellidoPaternoUsuario
        '
        Me.apellidoPaternoUsuario.Location = New System.Drawing.Point(210, 187)
        Me.apellidoPaternoUsuario.Multiline = True
        Me.apellidoPaternoUsuario.Name = "apellidoPaternoUsuario"
        Me.apellidoPaternoUsuario.Size = New System.Drawing.Size(456, 34)
        Me.apellidoPaternoUsuario.TabIndex = 20
        '
        'etiquetaUsuario
        '
        Me.etiquetaUsuario.AutoSize = True
        Me.etiquetaUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaUsuario.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.etiquetaUsuario.Location = New System.Drawing.Point(122, 253)
        Me.etiquetaUsuario.Name = "etiquetaUsuario"
        Me.etiquetaUsuario.Size = New System.Drawing.Size(86, 34)
        Me.etiquetaUsuario.TabIndex = 23
        Me.etiquetaUsuario.Text = "Usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(210, 253)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(456, 34)
        Me.TextBox1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(28, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 34)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "APELLIDO PATERNO:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(210, 315)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(456, 34)
        Me.TextBox2.TabIndex = 24
        '
        'botonRegresar_E_D1
        '
        Me.botonRegresar_E_D1.AutoSize = True
        Me.botonRegresar_E_D1.BackColor = System.Drawing.Color.Black
        Me.botonRegresar_E_D1.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonRegresar_E_D1.ForeColor = System.Drawing.Color.White
        Me.botonRegresar_E_D1.Location = New System.Drawing.Point(12, 495)
        Me.botonRegresar_E_D1.Name = "botonRegresar_E_D1"
        Me.botonRegresar_E_D1.Size = New System.Drawing.Size(81, 34)
        Me.botonRegresar_E_D1.TabIndex = 26
        Me.botonRegresar_E_D1.Text = "REGRESAR"
        Me.botonRegresar_E_D1.UseVisualStyleBackColor = False
        '
        'botonDarDeAltaUsuario
        '
        Me.botonDarDeAltaUsuario.AutoSize = True
        Me.botonDarDeAltaUsuario.BackColor = System.Drawing.Color.Black
        Me.botonDarDeAltaUsuario.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonDarDeAltaUsuario.ForeColor = System.Drawing.Color.White
        Me.botonDarDeAltaUsuario.Location = New System.Drawing.Point(87, 397)
        Me.botonDarDeAltaUsuario.Name = "botonDarDeAltaUsuario"
        Me.botonDarDeAltaUsuario.Size = New System.Drawing.Size(194, 47)
        Me.botonDarDeAltaUsuario.TabIndex = 27
        Me.botonDarDeAltaUsuario.Text = "DAR DE ALTA USUARIO"
        Me.botonDarDeAltaUsuario.UseVisualStyleBackColor = False
        '
        'botonModificarUsuario
        '
        Me.botonModificarUsuario.AutoSize = True
        Me.botonModificarUsuario.BackColor = System.Drawing.Color.Black
        Me.botonModificarUsuario.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonModificarUsuario.ForeColor = System.Drawing.Color.White
        Me.botonModificarUsuario.Location = New System.Drawing.Point(313, 397)
        Me.botonModificarUsuario.Name = "botonModificarUsuario"
        Me.botonModificarUsuario.Size = New System.Drawing.Size(194, 47)
        Me.botonModificarUsuario.TabIndex = 28
        Me.botonModificarUsuario.Text = "MODIFICAR USUARIO"
        Me.botonModificarUsuario.UseVisualStyleBackColor = False
        '
        'botonBorrarUsuario
        '
        Me.botonBorrarUsuario.AutoSize = True
        Me.botonBorrarUsuario.BackColor = System.Drawing.Color.Black
        Me.botonBorrarUsuario.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonBorrarUsuario.ForeColor = System.Drawing.Color.White
        Me.botonBorrarUsuario.Location = New System.Drawing.Point(538, 397)
        Me.botonBorrarUsuario.Name = "botonBorrarUsuario"
        Me.botonBorrarUsuario.Size = New System.Drawing.Size(194, 47)
        Me.botonBorrarUsuario.TabIndex = 29
        Me.botonBorrarUsuario.Text = "BORRAR USUARIO"
        Me.botonBorrarUsuario.UseVisualStyleBackColor = False
        '
        'GESTIONAR_USUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 541)
        Me.Controls.Add(Me.botonBorrarUsuario)
        Me.Controls.Add(Me.botonModificarUsuario)
        Me.Controls.Add(Me.botonDarDeAltaUsuario)
        Me.Controls.Add(Me.botonRegresar_E_D1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.etiquetaUsuario)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.etiquetaApellidoPaternoUsuario)
        Me.Controls.Add(Me.apellidoPaternoUsuario)
        Me.Controls.Add(Me.etiquetaNombreUsuario)
        Me.Controls.Add(Me.nombreUsuario)
        Me.Controls.Add(Me.botonAceptar)
        Me.Controls.Add(Me.iconoBuscarArt)
        Me.Controls.Add(Me.tituloGestionarUsuario)
        Me.Controls.Add(Me.buscadorDeUsuarios)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "GESTIONAR_USUARIO"
        Me.Text = "GESTIONAR_USUARIO"
        CType(Me.iconoBuscarArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buscadorDeUsuarios As TextBox
    Friend WithEvents tituloGestionarUsuario As Label
    Friend WithEvents iconoBuscarArt As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents botonAceptar As Button
    Friend WithEvents nombreUsuario As TextBox
    Friend WithEvents etiquetaNombreUsuario As Label
    Friend WithEvents etiquetaApellidoPaternoUsuario As Label
    Friend WithEvents apellidoPaternoUsuario As TextBox
    Friend WithEvents etiquetaUsuario As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents botonRegresar_E_D1 As Button
    Friend WithEvents botonDarDeAltaUsuario As Button
    Friend WithEvents botonModificarUsuario As Button
    Friend WithEvents botonBorrarUsuario As Button
End Class
