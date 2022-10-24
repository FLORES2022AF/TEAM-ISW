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
        Me.ingreseNombreUsuario = New System.Windows.Forms.TextBox()
        Me.etiquetaNombreUsuario = New System.Windows.Forms.Label()
        Me.etiquetaApellidoPaternoUsuario = New System.Windows.Forms.Label()
        Me.ingreseApellidoPaternoUsuario = New System.Windows.Forms.TextBox()
        Me.etiquetaApellidoMaternoUsuario = New System.Windows.Forms.Label()
        Me.ingreseApellidoMaternoUsuario = New System.Windows.Forms.TextBox()
        Me.etiquetaUsuario_GU = New System.Windows.Forms.Label()
        Me.ingreseUsuario = New System.Windows.Forms.TextBox()
        Me.botonBorrarUsuario = New System.Windows.Forms.Button()
        Me.botonModificarUsuario = New System.Windows.Forms.Button()
        Me.botonDarDeAltaUsuario = New System.Windows.Forms.Button()
        Me.botonRegresarAGenerarReporte = New System.Windows.Forms.Button()
        Me.botonBuscarUsuario = New System.Windows.Forms.Button()
        Me.botonManejoCantidad = New System.Windows.Forms.DomainUpDown()
        Me.ingreseClave = New System.Windows.Forms.TextBox()
        Me.ingreseTipodeUsuario = New System.Windows.Forms.TextBox()
        Me.ingreseId = New System.Windows.Forms.TextBox()
        Me.Id = New System.Windows.Forms.Label()
        Me.clave = New System.Windows.Forms.Label()
        Me.tipoUsuario = New System.Windows.Forms.Label()
        CType(Me.iconoBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buscadorDeUsuarios
        '
        Me.buscadorDeUsuarios.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.buscadorDeUsuarios.ForeColor = System.Drawing.Color.Black
        Me.buscadorDeUsuarios.Location = New System.Drawing.Point(163, 141)
        Me.buscadorDeUsuarios.Name = "buscadorDeUsuarios"
        Me.buscadorDeUsuarios.Size = New System.Drawing.Size(395, 23)
        Me.buscadorDeUsuarios.TabIndex = 13
        Me.buscadorDeUsuarios.Text = "Buscar usuario"
        '
        'iconoBuscarUsuario
        '
        Me.iconoBuscarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.iconoBuscarUsuario.ForeColor = System.Drawing.Color.Black
        Me.iconoBuscarUsuario.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.iconoBuscarUsuario.IconColor = System.Drawing.Color.Black
        Me.iconoBuscarUsuario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoBuscarUsuario.IconSize = 30
        Me.iconoBuscarUsuario.Location = New System.Drawing.Point(562, 141)
        Me.iconoBuscarUsuario.Name = "iconoBuscarUsuario"
        Me.iconoBuscarUsuario.Size = New System.Drawing.Size(30, 30)
        Me.iconoBuscarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.iconoBuscarUsuario.TabIndex = 16
        Me.iconoBuscarUsuario.TabStop = False
        '
        'ingreseNombreUsuario
        '
        Me.ingreseNombreUsuario.ForeColor = System.Drawing.Color.Black
        Me.ingreseNombreUsuario.Location = New System.Drawing.Point(270, 226)
        Me.ingreseNombreUsuario.Multiline = True
        Me.ingreseNombreUsuario.Name = "ingreseNombreUsuario"
        Me.ingreseNombreUsuario.Size = New System.Drawing.Size(304, 20)
        Me.ingreseNombreUsuario.TabIndex = 18
        '
        'etiquetaNombreUsuario
        '
        Me.etiquetaNombreUsuario.AutoSize = True
        Me.etiquetaNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaNombreUsuario.Font = New System.Drawing.Font("Californian FB", 9.75!)
        Me.etiquetaNombreUsuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaNombreUsuario.Location = New System.Drawing.Point(210, 226)
        Me.etiquetaNombreUsuario.Name = "etiquetaNombreUsuario"
        Me.etiquetaNombreUsuario.Size = New System.Drawing.Size(54, 16)
        Me.etiquetaNombreUsuario.TabIndex = 19
        Me.etiquetaNombreUsuario.Text = "Nombre:"
        '
        'etiquetaApellidoPaternoUsuario
        '
        Me.etiquetaApellidoPaternoUsuario.AutoSize = True
        Me.etiquetaApellidoPaternoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaApellidoPaternoUsuario.Font = New System.Drawing.Font("Californian FB", 9.75!)
        Me.etiquetaApellidoPaternoUsuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaApellidoPaternoUsuario.Location = New System.Drawing.Point(160, 265)
        Me.etiquetaApellidoPaternoUsuario.Name = "etiquetaApellidoPaternoUsuario"
        Me.etiquetaApellidoPaternoUsuario.Size = New System.Drawing.Size(101, 16)
        Me.etiquetaApellidoPaternoUsuario.TabIndex = 30
        Me.etiquetaApellidoPaternoUsuario.Text = "Apellido Paterno:"
        '
        'ingreseApellidoPaternoUsuario
        '
        Me.ingreseApellidoPaternoUsuario.ForeColor = System.Drawing.Color.Black
        Me.ingreseApellidoPaternoUsuario.Location = New System.Drawing.Point(270, 265)
        Me.ingreseApellidoPaternoUsuario.Multiline = True
        Me.ingreseApellidoPaternoUsuario.Name = "ingreseApellidoPaternoUsuario"
        Me.ingreseApellidoPaternoUsuario.Size = New System.Drawing.Size(304, 20)
        Me.ingreseApellidoPaternoUsuario.TabIndex = 31
        '
        'etiquetaApellidoMaternoUsuario
        '
        Me.etiquetaApellidoMaternoUsuario.AutoSize = True
        Me.etiquetaApellidoMaternoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaApellidoMaternoUsuario.Font = New System.Drawing.Font("Californian FB", 9.75!)
        Me.etiquetaApellidoMaternoUsuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaApellidoMaternoUsuario.Location = New System.Drawing.Point(160, 307)
        Me.etiquetaApellidoMaternoUsuario.Name = "etiquetaApellidoMaternoUsuario"
        Me.etiquetaApellidoMaternoUsuario.Size = New System.Drawing.Size(106, 16)
        Me.etiquetaApellidoMaternoUsuario.TabIndex = 32
        Me.etiquetaApellidoMaternoUsuario.Text = "Apellido Materno:"
        '
        'ingreseApellidoMaternoUsuario
        '
        Me.ingreseApellidoMaternoUsuario.ForeColor = System.Drawing.Color.Black
        Me.ingreseApellidoMaternoUsuario.Location = New System.Drawing.Point(270, 307)
        Me.ingreseApellidoMaternoUsuario.Multiline = True
        Me.ingreseApellidoMaternoUsuario.Name = "ingreseApellidoMaternoUsuario"
        Me.ingreseApellidoMaternoUsuario.Size = New System.Drawing.Size(304, 20)
        Me.ingreseApellidoMaternoUsuario.TabIndex = 33
        '
        'etiquetaUsuario_GU
        '
        Me.etiquetaUsuario_GU.AutoSize = True
        Me.etiquetaUsuario_GU.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaUsuario_GU.Font = New System.Drawing.Font("Californian FB", 9.75!)
        Me.etiquetaUsuario_GU.ForeColor = System.Drawing.Color.Black
        Me.etiquetaUsuario_GU.Location = New System.Drawing.Point(211, 358)
        Me.etiquetaUsuario_GU.Name = "etiquetaUsuario_GU"
        Me.etiquetaUsuario_GU.Size = New System.Drawing.Size(53, 16)
        Me.etiquetaUsuario_GU.TabIndex = 34
        Me.etiquetaUsuario_GU.Text = "Usuario:"
        '
        'ingreseUsuario
        '
        Me.ingreseUsuario.ForeColor = System.Drawing.Color.Black
        Me.ingreseUsuario.Location = New System.Drawing.Point(270, 358)
        Me.ingreseUsuario.Multiline = True
        Me.ingreseUsuario.Name = "ingreseUsuario"
        Me.ingreseUsuario.Size = New System.Drawing.Size(304, 20)
        Me.ingreseUsuario.TabIndex = 35
        '
        'botonBorrarUsuario
        '
        Me.botonBorrarUsuario.AutoSize = True
        Me.botonBorrarUsuario.BackColor = System.Drawing.Color.LightSlateGray
        Me.botonBorrarUsuario.Font = New System.Drawing.Font("Californian FB", 11.25!)
        Me.botonBorrarUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.botonBorrarUsuario.Location = New System.Drawing.Point(542, 485)
        Me.botonBorrarUsuario.Name = "botonBorrarUsuario"
        Me.botonBorrarUsuario.Size = New System.Drawing.Size(144, 28)
        Me.botonBorrarUsuario.TabIndex = 38
        Me.botonBorrarUsuario.Text = "BORRAR USUARIO"
        Me.botonBorrarUsuario.UseVisualStyleBackColor = False
        '
        'botonModificarUsuario
        '
        Me.botonModificarUsuario.AutoSize = True
        Me.botonModificarUsuario.BackColor = System.Drawing.Color.LightSlateGray
        Me.botonModificarUsuario.Font = New System.Drawing.Font("Californian FB", 11.25!)
        Me.botonModificarUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.botonModificarUsuario.Location = New System.Drawing.Point(358, 485)
        Me.botonModificarUsuario.Name = "botonModificarUsuario"
        Me.botonModificarUsuario.Size = New System.Drawing.Size(172, 28)
        Me.botonModificarUsuario.TabIndex = 39
        Me.botonModificarUsuario.Text = "MODIFICAR USUARIO"
        Me.botonModificarUsuario.UseVisualStyleBackColor = False
        '
        'botonDarDeAltaUsuario
        '
        Me.botonDarDeAltaUsuario.AutoSize = True
        Me.botonDarDeAltaUsuario.BackColor = System.Drawing.Color.LightSlateGray
        Me.botonDarDeAltaUsuario.Font = New System.Drawing.Font("Californian FB", 11.25!)
        Me.botonDarDeAltaUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.botonDarDeAltaUsuario.Location = New System.Drawing.Point(166, 485)
        Me.botonDarDeAltaUsuario.Name = "botonDarDeAltaUsuario"
        Me.botonDarDeAltaUsuario.Size = New System.Drawing.Size(177, 28)
        Me.botonDarDeAltaUsuario.TabIndex = 40
        Me.botonDarDeAltaUsuario.Text = "DAR DE ALTA USUARIO"
        Me.botonDarDeAltaUsuario.UseVisualStyleBackColor = False
        '
        'botonRegresarAGenerarReporte
        '
        Me.botonRegresarAGenerarReporte.AutoSize = True
        Me.botonRegresarAGenerarReporte.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonRegresarAGenerarReporte.Font = New System.Drawing.Font("Californian FB", 15.0!)
        Me.botonRegresarAGenerarReporte.ForeColor = System.Drawing.Color.White
        Me.botonRegresarAGenerarReporte.Location = New System.Drawing.Point(12, 485)
        Me.botonRegresarAGenerarReporte.Name = "botonRegresarAGenerarReporte"
        Me.botonRegresarAGenerarReporte.Size = New System.Drawing.Size(120, 34)
        Me.botonRegresarAGenerarReporte.TabIndex = 41
        Me.botonRegresarAGenerarReporte.Text = "REGRESAR"
        Me.botonRegresarAGenerarReporte.UseVisualStyleBackColor = False
        '
        'botonBuscarUsuario
        '
        Me.botonBuscarUsuario.AutoSize = True
        Me.botonBuscarUsuario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonBuscarUsuario.Font = New System.Drawing.Font("Californian FB", 11.25!)
        Me.botonBuscarUsuario.ForeColor = System.Drawing.Color.White
        Me.botonBuscarUsuario.Location = New System.Drawing.Point(593, 141)
        Me.botonBuscarUsuario.Name = "botonBuscarUsuario"
        Me.botonBuscarUsuario.Size = New System.Drawing.Size(83, 28)
        Me.botonBuscarUsuario.TabIndex = 42
        Me.botonBuscarUsuario.Text = "BUSCAR"
        Me.botonBuscarUsuario.UseVisualStyleBackColor = False
        '
        'botonManejoCantidad
        '
        Me.botonManejoCantidad.AutoSize = True
        Me.botonManejoCantidad.ForeColor = System.Drawing.Color.Black
        Me.botonManejoCantidad.Location = New System.Drawing.Point(542, 141)
        Me.botonManejoCantidad.Name = "botonManejoCantidad"
        Me.botonManejoCantidad.Size = New System.Drawing.Size(16, 20)
        Me.botonManejoCantidad.TabIndex = 43
        '
        'ingreseClave
        '
        Me.ingreseClave.ForeColor = System.Drawing.Color.Black
        Me.ingreseClave.Location = New System.Drawing.Point(270, 398)
        Me.ingreseClave.Multiline = True
        Me.ingreseClave.Name = "ingreseClave"
        Me.ingreseClave.Size = New System.Drawing.Size(304, 20)
        Me.ingreseClave.TabIndex = 44
        '
        'ingreseTipodeUsuario
        '
        Me.ingreseTipodeUsuario.ForeColor = System.Drawing.Color.Black
        Me.ingreseTipodeUsuario.Location = New System.Drawing.Point(270, 440)
        Me.ingreseTipodeUsuario.Multiline = True
        Me.ingreseTipodeUsuario.Name = "ingreseTipodeUsuario"
        Me.ingreseTipodeUsuario.Size = New System.Drawing.Size(304, 20)
        Me.ingreseTipodeUsuario.TabIndex = 45
        '
        'ingreseId
        '
        Me.ingreseId.ForeColor = System.Drawing.Color.Black
        Me.ingreseId.Location = New System.Drawing.Point(270, 189)
        Me.ingreseId.Multiline = True
        Me.ingreseId.Name = "ingreseId"
        Me.ingreseId.Size = New System.Drawing.Size(304, 20)
        Me.ingreseId.TabIndex = 46
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.BackColor = System.Drawing.Color.Transparent
        Me.Id.Font = New System.Drawing.Font("Californian FB", 9.75!)
        Me.Id.ForeColor = System.Drawing.Color.Black
        Me.Id.Location = New System.Drawing.Point(207, 189)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(22, 16)
        Me.Id.TabIndex = 47
        Me.Id.Text = "Id:"
        '
        'clave
        '
        Me.clave.AutoSize = True
        Me.clave.BackColor = System.Drawing.Color.Transparent
        Me.clave.Font = New System.Drawing.Font("Californian FB", 9.75!)
        Me.clave.ForeColor = System.Drawing.Color.Black
        Me.clave.Location = New System.Drawing.Point(194, 400)
        Me.clave.Name = "clave"
        Me.clave.Size = New System.Drawing.Size(70, 16)
        Me.clave.TabIndex = 48
        Me.clave.Text = "Contraseña:"
        '
        'tipoUsuario
        '
        Me.tipoUsuario.AutoSize = True
        Me.tipoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.tipoUsuario.Font = New System.Drawing.Font("Californian FB", 9.75!)
        Me.tipoUsuario.ForeColor = System.Drawing.Color.Black
        Me.tipoUsuario.Location = New System.Drawing.Point(170, 440)
        Me.tipoUsuario.Name = "tipoUsuario"
        Me.tipoUsuario.Size = New System.Drawing.Size(96, 16)
        Me.tipoUsuario.TabIndex = 49
        Me.tipoUsuario.Text = "Tipo de Usuario:"
        '
        'gestionarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.tipoUsuario)
        Me.Controls.Add(Me.clave)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.ingreseId)
        Me.Controls.Add(Me.ingreseTipodeUsuario)
        Me.Controls.Add(Me.ingreseClave)
        Me.Controls.Add(Me.botonManejoCantidad)
        Me.Controls.Add(Me.botonBuscarUsuario)
        Me.Controls.Add(Me.botonRegresarAGenerarReporte)
        Me.Controls.Add(Me.botonDarDeAltaUsuario)
        Me.Controls.Add(Me.botonModificarUsuario)
        Me.Controls.Add(Me.botonBorrarUsuario)
        Me.Controls.Add(Me.ingreseUsuario)
        Me.Controls.Add(Me.etiquetaUsuario_GU)
        Me.Controls.Add(Me.ingreseApellidoMaternoUsuario)
        Me.Controls.Add(Me.etiquetaApellidoMaternoUsuario)
        Me.Controls.Add(Me.ingreseApellidoPaternoUsuario)
        Me.Controls.Add(Me.etiquetaApellidoPaternoUsuario)
        Me.Controls.Add(Me.etiquetaNombreUsuario)
        Me.Controls.Add(Me.ingreseNombreUsuario)
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
    Friend WithEvents ingreseNombreUsuario As TextBox
    Friend WithEvents etiquetaNombreUsuario As Label
    Friend WithEvents etiquetaApellidoPaternoUsuario As Label
    Friend WithEvents ingreseApellidoPaternoUsuario As TextBox
    Friend WithEvents etiquetaApellidoMaternoUsuario As Label
    Friend WithEvents ingreseApellidoMaternoUsuario As TextBox
    Friend WithEvents etiquetaUsuario_GU As Label
    Friend WithEvents ingreseUsuario As TextBox
    Friend WithEvents botonBorrarUsuario As Button
    Friend WithEvents botonModificarUsuario As Button
    Friend WithEvents botonDarDeAltaUsuario As Button
    Friend WithEvents botonRegresarAGenerarReporte As Button
    Friend WithEvents botonBuscarUsuario As Button
    Friend WithEvents botonManejoCantidad As DomainUpDown
    Friend WithEvents ingreseClave As TextBox
    Friend WithEvents ingreseTipodeUsuario As TextBox
    Friend WithEvents ingreseId As TextBox
    Friend WithEvents Id As Label
    Friend WithEvents clave As Label
    Friend WithEvents tipoUsuario As Label
End Class
