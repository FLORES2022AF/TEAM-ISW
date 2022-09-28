<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuEncargado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuEncargado))
        Me.iconoGenerarPreLista__E_2 = New FontAwesome.Sharp.IconPictureBox()
        Me.botonPuntoDeVenta_E = New System.Windows.Forms.Button()
        Me.iconoPuntoVenta_E_2 = New FontAwesome.Sharp.IconPictureBox()
        Me.botonGenerarPrelistaDePoductos_E = New System.Windows.Forms.Button()
        Me.botonGestionarInventario_E = New System.Windows.Forms.Button()
        Me.iconoGestionarInventario__E_2 = New FontAwesome.Sharp.IconPictureBox()
        Me.botonCerrarSesion_E = New System.Windows.Forms.Button()
        CType(Me.iconoGenerarPreLista__E_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoPuntoVenta_E_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoGestionarInventario__E_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iconoGenerarPreLista__E_2
        '
        Me.iconoGenerarPreLista__E_2.BackColor = System.Drawing.Color.White
        Me.iconoGenerarPreLista__E_2.ForeColor = System.Drawing.Color.Black
        Me.iconoGenerarPreLista__E_2.IconChar = FontAwesome.Sharp.IconChar.ListCheck
        Me.iconoGenerarPreLista__E_2.IconColor = System.Drawing.Color.Black
        Me.iconoGenerarPreLista__E_2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoGenerarPreLista__E_2.IconSize = 29
        Me.iconoGenerarPreLista__E_2.Location = New System.Drawing.Point(326, 277)
        Me.iconoGenerarPreLista__E_2.Name = "iconoGenerarPreLista__E_2"
        Me.iconoGenerarPreLista__E_2.Size = New System.Drawing.Size(29, 35)
        Me.iconoGenerarPreLista__E_2.TabIndex = 29
        Me.iconoGenerarPreLista__E_2.TabStop = False
        '
        'botonPuntoDeVenta_E
        '
        Me.botonPuntoDeVenta_E.BackColor = System.Drawing.Color.IndianRed
        Me.botonPuntoDeVenta_E.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonPuntoDeVenta_E.ForeColor = System.Drawing.Color.Transparent
        Me.botonPuntoDeVenta_E.Location = New System.Drawing.Point(134, 204)
        Me.botonPuntoDeVenta_E.Name = "botonPuntoDeVenta_E"
        Me.botonPuntoDeVenta_E.Size = New System.Drawing.Size(186, 51)
        Me.botonPuntoDeVenta_E.TabIndex = 30
        Me.botonPuntoDeVenta_E.Text = "PUNTO DE VENTA"
        Me.botonPuntoDeVenta_E.UseVisualStyleBackColor = False
        '
        'iconoPuntoVenta_E_2
        '
        Me.iconoPuntoVenta_E_2.BackColor = System.Drawing.Color.White
        Me.iconoPuntoVenta_E_2.ForeColor = System.Drawing.Color.Black
        Me.iconoPuntoVenta_E_2.IconChar = FontAwesome.Sharp.IconChar.StoreAlt
        Me.iconoPuntoVenta_E_2.IconColor = System.Drawing.Color.Black
        Me.iconoPuntoVenta_E_2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoPuntoVenta_E_2.IconSize = 29
        Me.iconoPuntoVenta_E_2.Location = New System.Drawing.Point(100, 212)
        Me.iconoPuntoVenta_E_2.Name = "iconoPuntoVenta_E_2"
        Me.iconoPuntoVenta_E_2.Size = New System.Drawing.Size(29, 35)
        Me.iconoPuntoVenta_E_2.TabIndex = 22
        Me.iconoPuntoVenta_E_2.TabStop = False
        '
        'botonGenerarPrelistaDePoductos_E
        '
        Me.botonGenerarPrelistaDePoductos_E.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.botonGenerarPrelistaDePoductos_E.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonGenerarPrelistaDePoductos_E.ForeColor = System.Drawing.Color.Transparent
        Me.botonGenerarPrelistaDePoductos_E.Location = New System.Drawing.Point(134, 261)
        Me.botonGenerarPrelistaDePoductos_E.Name = "botonGenerarPrelistaDePoductos_E"
        Me.botonGenerarPrelistaDePoductos_E.Size = New System.Drawing.Size(186, 51)
        Me.botonGenerarPrelistaDePoductos_E.TabIndex = 32
        Me.botonGenerarPrelistaDePoductos_E.Text = "GENERAR PRE LISTA DE PRODUCTOS"
        Me.botonGenerarPrelistaDePoductos_E.UseVisualStyleBackColor = False
        '
        'botonGestionarInventario_E
        '
        Me.botonGestionarInventario_E.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonGestionarInventario_E.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonGestionarInventario_E.ForeColor = System.Drawing.Color.Transparent
        Me.botonGestionarInventario_E.Location = New System.Drawing.Point(134, 318)
        Me.botonGestionarInventario_E.Name = "botonGestionarInventario_E"
        Me.botonGestionarInventario_E.Size = New System.Drawing.Size(186, 51)
        Me.botonGestionarInventario_E.TabIndex = 34
        Me.botonGestionarInventario_E.Text = "GESTIONAR INVENTARIO"
        Me.botonGestionarInventario_E.UseVisualStyleBackColor = False
        '
        'iconoGestionarInventario__E_2
        '
        Me.iconoGestionarInventario__E_2.BackColor = System.Drawing.Color.White
        Me.iconoGestionarInventario__E_2.ForeColor = System.Drawing.Color.Black
        Me.iconoGestionarInventario__E_2.IconChar = FontAwesome.Sharp.IconChar.FolderTree
        Me.iconoGestionarInventario__E_2.IconColor = System.Drawing.Color.Black
        Me.iconoGestionarInventario__E_2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoGestionarInventario__E_2.IconSize = 24
        Me.iconoGestionarInventario__E_2.Location = New System.Drawing.Point(99, 334)
        Me.iconoGestionarInventario__E_2.Name = "iconoGestionarInventario__E_2"
        Me.iconoGestionarInventario__E_2.Size = New System.Drawing.Size(29, 24)
        Me.iconoGestionarInventario__E_2.TabIndex = 33
        Me.iconoGestionarInventario__E_2.TabStop = False
        '
        'botonCerrarSesion_E
        '
        Me.botonCerrarSesion_E.AutoSize = True
        Me.botonCerrarSesion_E.BackColor = System.Drawing.Color.Red
        Me.botonCerrarSesion_E.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonCerrarSesion_E.ForeColor = System.Drawing.Color.White
        Me.botonCerrarSesion_E.Location = New System.Drawing.Point(650, 485)
        Me.botonCerrarSesion_E.Name = "botonCerrarSesion_E"
        Me.botonCerrarSesion_E.Size = New System.Drawing.Size(157, 34)
        Me.botonCerrarSesion_E.TabIndex = 35
        Me.botonCerrarSesion_E.Text = "CERRAR SESIÓN"
        Me.botonCerrarSesion_E.UseVisualStyleBackColor = False
        '
        'menuEncargado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.botonCerrarSesion_E)
        Me.Controls.Add(Me.botonGestionarInventario_E)
        Me.Controls.Add(Me.iconoGestionarInventario__E_2)
        Me.Controls.Add(Me.botonGenerarPrelistaDePoductos_E)
        Me.Controls.Add(Me.botonPuntoDeVenta_E)
        Me.Controls.Add(Me.iconoGenerarPreLista__E_2)
        Me.Controls.Add(Me.iconoPuntoVenta_E_2)
        Me.DoubleBuffered = True
        Me.Name = "menuEncargado"
        Me.Text = "MENU ENCARGADOS"
        CType(Me.iconoGenerarPreLista__E_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoPuntoVenta_E_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoGestionarInventario__E_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents iconoGenerarPreLista__E_2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents botonPuntoDeVenta_E As Button
    Friend WithEvents iconoPuntoVenta_E_2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents botonGenerarPrelistaDePoductos_E As Button
    Friend WithEvents botonGestionarInventario_E As Button
    Friend WithEvents iconoGestionarInventario__E_2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents botonCerrarSesion_E As Button
End Class
