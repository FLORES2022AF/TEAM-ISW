<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionarUsuario))
        Me.buscadorDeUsuarios = New System.Windows.Forms.TextBox()
        Me.iconoBuscarUsuario = New FontAwesome.Sharp.IconPictureBox()
        Me.nombreUsuario = New System.Windows.Forms.TextBox()
        Me.etiquetaNombreUsuario = New System.Windows.Forms.Label()
        Me.etiquetaApellidoPaternoUsuario = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.etiquetaApellidoMaternoUsuario = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.etiquetaUsuario_GU = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.botonBuscarUsuario = New System.Windows.Forms.Button()
        Me.botonBorrarUsuario = New System.Windows.Forms.Button()
        Me.botonModificarUsuario = New System.Windows.Forms.Button()
        Me.botonDarDeAltaUsuario = New System.Windows.Forms.Button()
        Me.botonRegresarAGenerarReporte = New System.Windows.Forms.Button()
        CType(Me.iconoBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buscadorDeUsuarios
        '
        Me.buscadorDeUsuarios.Location = New System.Drawing.Point(229, 91)
        Me.buscadorDeUsuarios.Name = "buscadorDeUsuarios"
        Me.buscadorDeUsuarios.Size = New System.Drawing.Size(437, 23)
        Me.buscadorDeUsuarios.TabIndex = 13
        Me.buscadorDeUsuarios.Text = "Buscar usuario"
        '
        'iconoBuscarUsuario
        '
        Me.iconoBuscarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.iconoBuscarUsuario.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.iconoBuscarUsuario.IconColor = System.Drawing.Color.White
        Me.iconoBuscarUsuario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoBuscarUsuario.IconSize = 23
        Me.iconoBuscarUsuario.Location = New System.Drawing.Point(643, 91)
        Me.iconoBuscarUsuario.Name = "iconoBuscarUsuario"
        Me.iconoBuscarUsuario.Size = New System.Drawing.Size(23, 23)
        Me.iconoBuscarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.iconoBuscarUsuario.TabIndex = 16
        Me.iconoBuscarUsuario.TabStop = False
        '
        'nombreUsuario
        '
        Me.nombreUsuario.Location = New System.Drawing.Point(229, 139)
        Me.nombreUsuario.Multiline = True
        Me.nombreUsuario.Name = "nombreUsuario"
        Me.nombreUsuario.Size = New System.Drawing.Size(437, 23)
        Me.nombreUsuario.TabIndex = 18
        '
        'etiquetaNombreUsuario
        '
        Me.etiquetaNombreUsuario.AutoSize = True
        Me.etiquetaNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaNombreUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.etiquetaNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.etiquetaNombreUsuario.Location = New System.Drawing.Point(261, 117)
        Me.etiquetaNombreUsuario.Name = "etiquetaNombreUsuario"
        Me.etiquetaNombreUsuario.Size = New System.Drawing.Size(71, 19)
        Me.etiquetaNombreUsuario.TabIndex = 19
        Me.etiquetaNombreUsuario.Text = "Nombre:"
        '
        'etiquetaApellidoPaternoUsuario
        '
        Me.etiquetaApellidoPaternoUsuario.AutoSize = True
        Me.etiquetaApellidoPaternoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaApellidoPaternoUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.etiquetaApellidoPaternoUsuario.ForeColor = System.Drawing.Color.White
        Me.etiquetaApellidoPaternoUsuario.Location = New System.Drawing.Point(261, 165)
        Me.etiquetaApellidoPaternoUsuario.Name = "etiquetaApellidoPaternoUsuario"
        Me.etiquetaApellidoPaternoUsuario.Size = New System.Drawing.Size(132, 19)
        Me.etiquetaApellidoPaternoUsuario.TabIndex = 30
        Me.etiquetaApellidoPaternoUsuario.Text = "Apellido Paterno:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(229, 187)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(437, 23)
        Me.TextBox3.TabIndex = 31
        '
        'etiquetaApellidoMaternoUsuario
        '
        Me.etiquetaApellidoMaternoUsuario.AutoSize = True
        Me.etiquetaApellidoMaternoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaApellidoMaternoUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.etiquetaApellidoMaternoUsuario.ForeColor = System.Drawing.Color.White
        Me.etiquetaApellidoMaternoUsuario.Location = New System.Drawing.Point(261, 213)
        Me.etiquetaApellidoMaternoUsuario.Name = "etiquetaApellidoMaternoUsuario"
        Me.etiquetaApellidoMaternoUsuario.Size = New System.Drawing.Size(135, 19)
        Me.etiquetaApellidoMaternoUsuario.TabIndex = 32
        Me.etiquetaApellidoMaternoUsuario.Text = "Apellido Materno:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(229, 235)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(437, 23)
        Me.TextBox1.TabIndex = 33
        '
        'etiquetaUsuario_GU
        '
        Me.etiquetaUsuario_GU.AutoSize = True
        Me.etiquetaUsuario_GU.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaUsuario_GU.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.etiquetaUsuario_GU.ForeColor = System.Drawing.Color.White
        Me.etiquetaUsuario_GU.Location = New System.Drawing.Point(261, 261)
        Me.etiquetaUsuario_GU.Name = "etiquetaUsuario_GU"
        Me.etiquetaUsuario_GU.Size = New System.Drawing.Size(69, 19)
        Me.etiquetaUsuario_GU.TabIndex = 34
        Me.etiquetaUsuario_GU.Text = "Usuario:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(229, 283)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(437, 23)
        Me.TextBox4.TabIndex = 35
        '
        'botonBuscarUsuario
        '
        Me.botonBuscarUsuario.AutoSize = True
        Me.botonBuscarUsuario.BackColor = System.Drawing.Color.Green
        Me.botonBuscarUsuario.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonBuscarUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.botonBuscarUsuario.Location = New System.Drawing.Point(672, 88)
        Me.botonBuscarUsuario.Name = "botonBuscarUsuario"
        Me.botonBuscarUsuario.Size = New System.Drawing.Size(77, 26)
        Me.botonBuscarUsuario.TabIndex = 36
        Me.botonBuscarUsuario.Text = "BUSCAR"
        Me.botonBuscarUsuario.UseVisualStyleBackColor = False
        '
        'botonBorrarUsuario
        '
        Me.botonBorrarUsuario.AutoSize = True
        Me.botonBorrarUsuario.BackColor = System.Drawing.Color.Red
        Me.botonBorrarUsuario.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonBorrarUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.botonBorrarUsuario.Location = New System.Drawing.Point(577, 377)
        Me.botonBorrarUsuario.Name = "botonBorrarUsuario"
        Me.botonBorrarUsuario.Size = New System.Drawing.Size(118, 26)
        Me.botonBorrarUsuario.TabIndex = 38
        Me.botonBorrarUsuario.Text = "BORRAR USUARIO"
        Me.botonBorrarUsuario.UseVisualStyleBackColor = False
        '
        'botonModificarUsuario
        '
        Me.botonModificarUsuario.AutoSize = True
        Me.botonModificarUsuario.BackColor = System.Drawing.Color.Orange
        Me.botonModificarUsuario.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonModificarUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.botonModificarUsuario.Location = New System.Drawing.Point(409, 377)
        Me.botonModificarUsuario.Name = "botonModificarUsuario"
        Me.botonModificarUsuario.Size = New System.Drawing.Size(134, 26)
        Me.botonModificarUsuario.TabIndex = 39
        Me.botonModificarUsuario.Text = "MODIFICAR USUARIO"
        Me.botonModificarUsuario.UseVisualStyleBackColor = False
        '
        'botonDarDeAltaUsuario
        '
        Me.botonDarDeAltaUsuario.AutoSize = True
        Me.botonDarDeAltaUsuario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonDarDeAltaUsuario.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonDarDeAltaUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.botonDarDeAltaUsuario.Location = New System.Drawing.Point(229, 377)
        Me.botonDarDeAltaUsuario.Name = "botonDarDeAltaUsuario"
        Me.botonDarDeAltaUsuario.Size = New System.Drawing.Size(142, 26)
        Me.botonDarDeAltaUsuario.TabIndex = 40
        Me.botonDarDeAltaUsuario.Text = "DAR DE ALTA USUARIO"
        Me.botonDarDeAltaUsuario.UseVisualStyleBackColor = False
        '
        'botonRegresarAGenerarReporte
        '
        Me.botonRegresarAGenerarReporte.AutoSize = True
        Me.botonRegresarAGenerarReporte.BackColor = System.Drawing.Color.Black
        Me.botonRegresarAGenerarReporte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonRegresarAGenerarReporte.ForeColor = System.Drawing.Color.White
        Me.botonRegresarAGenerarReporte.Location = New System.Drawing.Point(12, 482)
        Me.botonRegresarAGenerarReporte.Name = "botonRegresarAGenerarReporte"
        Me.botonRegresarAGenerarReporte.Size = New System.Drawing.Size(110, 37)
        Me.botonRegresarAGenerarReporte.TabIndex = 41
        Me.botonRegresarAGenerarReporte.Text = "REGRESAR"
        Me.botonRegresarAGenerarReporte.UseVisualStyleBackColor = False
        '
        'gestionarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.botonRegresarAGenerarReporte)
        Me.Controls.Add(Me.botonDarDeAltaUsuario)
        Me.Controls.Add(Me.botonModificarUsuario)
        Me.Controls.Add(Me.botonBorrarUsuario)
        Me.Controls.Add(Me.botonBuscarUsuario)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.etiquetaUsuario_GU)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.etiquetaApellidoMaternoUsuario)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.etiquetaApellidoPaternoUsuario)
        Me.Controls.Add(Me.etiquetaNombreUsuario)
        Me.Controls.Add(Me.nombreUsuario)
        Me.Controls.Add(Me.iconoBuscarUsuario)
        Me.Controls.Add(Me.buscadorDeUsuarios)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "gestionarUsuario"
        Me.Text = "GESTIONAR USUARIO"
        CType(Me.iconoBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buscadorDeUsuarios As TextBox
    Friend WithEvents iconoBuscarUsuario As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents nombreUsuario As TextBox
    Friend WithEvents etiquetaNombreUsuario As Label
    Friend WithEvents etiquetaApellidoPaternoUsuario As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents etiquetaApellidoMaternoUsuario As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents etiquetaUsuario_GU As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents botonBuscarUsuario As Button
    Friend WithEvents botonBorrarUsuario As Button
    Friend WithEvents botonModificarUsuario As Button
    Friend WithEvents botonDarDeAltaUsuario As Button
    Friend WithEvents botonRegresarAGenerarReporte As Button
End Class
