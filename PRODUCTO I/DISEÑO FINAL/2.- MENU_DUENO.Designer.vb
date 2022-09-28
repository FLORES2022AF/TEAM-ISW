<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuDueno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuDueno))
        Me.botonPuntoDeVenta_D = New System.Windows.Forms.Button()
        Me.botonCerrarSesion_D = New System.Windows.Forms.Button()
        Me.iconoPuntoVenta_D_1 = New FontAwesome.Sharp.IconPictureBox()
        Me.iconoGestionarUsuario_D_1 = New FontAwesome.Sharp.IconPictureBox()
        Me.iconoGestionarInventario__D_1 = New FontAwesome.Sharp.IconPictureBox()
        Me.iconoGenerarPreLista__D_1 = New FontAwesome.Sharp.IconPictureBox()
        Me.botonGenerarPrelista_D = New System.Windows.Forms.Button()
        Me.botonGestionarInventario_D = New System.Windows.Forms.Button()
        Me.botonGestionarUsuario_D = New System.Windows.Forms.Button()
        CType(Me.iconoPuntoVenta_D_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoGestionarUsuario_D_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoGestionarInventario__D_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoGenerarPreLista__D_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'botonPuntoDeVenta_D
        '
        Me.botonPuntoDeVenta_D.BackColor = System.Drawing.Color.IndianRed
        Me.botonPuntoDeVenta_D.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonPuntoDeVenta_D.ForeColor = System.Drawing.Color.Transparent
        Me.botonPuntoDeVenta_D.Location = New System.Drawing.Point(136, 187)
        Me.botonPuntoDeVenta_D.Name = "botonPuntoDeVenta_D"
        Me.botonPuntoDeVenta_D.Size = New System.Drawing.Size(186, 51)
        Me.botonPuntoDeVenta_D.TabIndex = 0
        Me.botonPuntoDeVenta_D.Text = "PUNTO DE VENTA"
        Me.botonPuntoDeVenta_D.UseVisualStyleBackColor = False
        '
        'botonCerrarSesion_D
        '
        Me.botonCerrarSesion_D.AutoSize = True
        Me.botonCerrarSesion_D.BackColor = System.Drawing.Color.Red
        Me.botonCerrarSesion_D.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonCerrarSesion_D.ForeColor = System.Drawing.Color.White
        Me.botonCerrarSesion_D.Location = New System.Drawing.Point(641, 485)
        Me.botonCerrarSesion_D.Name = "botonCerrarSesion_D"
        Me.botonCerrarSesion_D.Size = New System.Drawing.Size(166, 34)
        Me.botonCerrarSesion_D.TabIndex = 5
        Me.botonCerrarSesion_D.Text = "CERRAR SESIÓN"
        Me.botonCerrarSesion_D.UseVisualStyleBackColor = False
        '
        'iconoPuntoVenta_D_1
        '
        Me.iconoPuntoVenta_D_1.IconChar = FontAwesome.Sharp.IconChar.StoreAlt
        Me.iconoPuntoVenta_D_1.IconColor = System.Drawing.Color.White
        Me.iconoPuntoVenta_D_1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoPuntoVenta_D_1.IconSize = 29
        Me.iconoPuntoVenta_D_1.Location = New System.Drawing.Point(101, 196)
        Me.iconoPuntoVenta_D_1.Name = "iconoPuntoVenta_D_1"
        Me.iconoPuntoVenta_D_1.Size = New System.Drawing.Size(29, 35)
        Me.iconoPuntoVenta_D_1.TabIndex = 9
        Me.iconoPuntoVenta_D_1.TabStop = False
        '
        'iconoGestionarUsuario_D_1
        '
        Me.iconoGestionarUsuario_D_1.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.iconoGestionarUsuario_D_1.IconColor = System.Drawing.Color.White
        Me.iconoGestionarUsuario_D_1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoGestionarUsuario_D_1.IconSize = 29
        Me.iconoGestionarUsuario_D_1.Location = New System.Drawing.Point(328, 369)
        Me.iconoGestionarUsuario_D_1.Name = "iconoGestionarUsuario_D_1"
        Me.iconoGestionarUsuario_D_1.Size = New System.Drawing.Size(29, 35)
        Me.iconoGestionarUsuario_D_1.TabIndex = 13
        Me.iconoGestionarUsuario_D_1.TabStop = False
        '
        'iconoGestionarInventario__D_1
        '
        Me.iconoGestionarInventario__D_1.IconChar = FontAwesome.Sharp.IconChar.FolderTree
        Me.iconoGestionarInventario__D_1.IconColor = System.Drawing.Color.White
        Me.iconoGestionarInventario__D_1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoGestionarInventario__D_1.IconSize = 24
        Me.iconoGestionarInventario__D_1.Location = New System.Drawing.Point(101, 317)
        Me.iconoGestionarInventario__D_1.Name = "iconoGestionarInventario__D_1"
        Me.iconoGestionarInventario__D_1.Size = New System.Drawing.Size(29, 24)
        Me.iconoGestionarInventario__D_1.TabIndex = 14
        Me.iconoGestionarInventario__D_1.TabStop = False
        '
        'iconoGenerarPreLista__D_1
        '
        Me.iconoGenerarPreLista__D_1.IconChar = FontAwesome.Sharp.IconChar.ListCheck
        Me.iconoGenerarPreLista__D_1.IconColor = System.Drawing.Color.White
        Me.iconoGenerarPreLista__D_1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoGenerarPreLista__D_1.IconSize = 29
        Me.iconoGenerarPreLista__D_1.Location = New System.Drawing.Point(328, 253)
        Me.iconoGenerarPreLista__D_1.Name = "iconoGenerarPreLista__D_1"
        Me.iconoGenerarPreLista__D_1.Size = New System.Drawing.Size(29, 35)
        Me.iconoGenerarPreLista__D_1.TabIndex = 17
        Me.iconoGenerarPreLista__D_1.TabStop = False
        '
        'botonGenerarPrelista_D
        '
        Me.botonGenerarPrelista_D.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.botonGenerarPrelista_D.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonGenerarPrelista_D.ForeColor = System.Drawing.Color.Transparent
        Me.botonGenerarPrelista_D.Location = New System.Drawing.Point(136, 244)
        Me.botonGenerarPrelista_D.Name = "botonGenerarPrelista_D"
        Me.botonGenerarPrelista_D.Size = New System.Drawing.Size(186, 51)
        Me.botonGenerarPrelista_D.TabIndex = 18
        Me.botonGenerarPrelista_D.Text = "GENERAR PRE LISTA DE PRODUCTOS"
        Me.botonGenerarPrelista_D.UseVisualStyleBackColor = False
        '
        'botonGestionarInventario_D
        '
        Me.botonGestionarInventario_D.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonGestionarInventario_D.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonGestionarInventario_D.ForeColor = System.Drawing.Color.Transparent
        Me.botonGestionarInventario_D.Location = New System.Drawing.Point(136, 301)
        Me.botonGestionarInventario_D.Name = "botonGestionarInventario_D"
        Me.botonGestionarInventario_D.Size = New System.Drawing.Size(186, 51)
        Me.botonGestionarInventario_D.TabIndex = 19
        Me.botonGestionarInventario_D.Text = "GESTIONAR INVENTARIO"
        Me.botonGestionarInventario_D.UseVisualStyleBackColor = False
        '
        'botonGestionarUsuario_D
        '
        Me.botonGestionarUsuario_D.BackColor = System.Drawing.Color.Olive
        Me.botonGestionarUsuario_D.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonGestionarUsuario_D.ForeColor = System.Drawing.Color.Transparent
        Me.botonGestionarUsuario_D.Location = New System.Drawing.Point(136, 358)
        Me.botonGestionarUsuario_D.Name = "botonGestionarUsuario_D"
        Me.botonGestionarUsuario_D.Size = New System.Drawing.Size(186, 51)
        Me.botonGestionarUsuario_D.TabIndex = 20
        Me.botonGestionarUsuario_D.Text = "GESTIONAR USUARIO"
        Me.botonGestionarUsuario_D.UseVisualStyleBackColor = False
        '
        'menuDueno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.botonGestionarUsuario_D)
        Me.Controls.Add(Me.botonGestionarInventario_D)
        Me.Controls.Add(Me.botonGenerarPrelista_D)
        Me.Controls.Add(Me.iconoGenerarPreLista__D_1)
        Me.Controls.Add(Me.iconoGestionarInventario__D_1)
        Me.Controls.Add(Me.iconoGestionarUsuario_D_1)
        Me.Controls.Add(Me.iconoPuntoVenta_D_1)
        Me.Controls.Add(Me.botonCerrarSesion_D)
        Me.Controls.Add(Me.botonPuntoDeVenta_D)
        Me.DoubleBuffered = True
        Me.Name = "menuDueno"
        Me.Text = "MENU DUEÑO"
        CType(Me.iconoPuntoVenta_D_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoGestionarUsuario_D_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoGestionarInventario__D_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoGenerarPreLista__D_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonPuntoDeVenta_D As Button
    Friend WithEvents botonCerrarSesion_D As Button
    Friend WithEvents iconoPuntoVenta_D_1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconoGestionarUsuario_D_1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconoGestionarInventario__D_1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconoGenerarPreLista__D_1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents botonGenerarPrelista_D As Button
    Friend WithEvents botonGestionarInventario_D As Button
    Friend WithEvents botonGestionarUsuario_D As Button
End Class
