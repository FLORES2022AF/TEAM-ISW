<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionarInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionarInventario))
        Me.iconoBuscarArt = New FontAwesome.Sharp.IconPictureBox()
        Me.buscadorDeProductos = New System.Windows.Forms.TextBox()
        Me.ingreseIDArticulo = New System.Windows.Forms.TextBox()
        Me.ingreseNombreDelArticulo = New System.Windows.Forms.TextBox()
        Me.ingreseCantidadActual = New System.Windows.Forms.TextBox()
        Me.ingreseCantidadDeSeguridad = New System.Windows.Forms.TextBox()
        Me.tablaDeProductosInventario = New System.Windows.Forms.DataGridView()
        Me.id__Articulo_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_Articulo_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_Articulo_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Seguridad_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Actual_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barraDeslizante_GI = New System.Windows.Forms.VScrollBar()
        Me.botonBuscarArticulos = New System.Windows.Forms.Button()
        Me.botonModificarArticulo = New System.Windows.Forms.Button()
        Me.botonDarDeAltaArticulo = New System.Windows.Forms.Button()
        Me.botonBorrarArticulo = New System.Windows.Forms.Button()
        Me.botonRegresarAGestionarUsuario = New System.Windows.Forms.Button()
        Me.ingresePrecioDelArticulo = New System.Windows.Forms.TextBox()
        Me.botonManejoCantidad = New System.Windows.Forms.DomainUpDown()
        CType(Me.iconoBuscarArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaDeProductosInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iconoBuscarArt
        '
        Me.iconoBuscarArt.BackColor = System.Drawing.Color.Transparent
        Me.iconoBuscarArt.ForeColor = System.Drawing.Color.Black
        Me.iconoBuscarArt.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.iconoBuscarArt.IconColor = System.Drawing.Color.Black
        Me.iconoBuscarArt.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoBuscarArt.IconSize = 30
        Me.iconoBuscarArt.Location = New System.Drawing.Point(660, 101)
        Me.iconoBuscarArt.Name = "iconoBuscarArt"
        Me.iconoBuscarArt.Size = New System.Drawing.Size(30, 30)
        Me.iconoBuscarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.iconoBuscarArt.TabIndex = 19
        Me.iconoBuscarArt.TabStop = False
        '
        'buscadorDeProductos
        '
        Me.buscadorDeProductos.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.buscadorDeProductos.Location = New System.Drawing.Point(36, 101)
        Me.buscadorDeProductos.Name = "buscadorDeProductos"
        Me.buscadorDeProductos.Size = New System.Drawing.Size(626, 23)
        Me.buscadorDeProductos.TabIndex = 18
        Me.buscadorDeProductos.Text = "Buscar producto"
        '
        'ingreseIDArticulo
        '
        Me.ingreseIDArticulo.Font = New System.Drawing.Font("Calisto MT", 8.25!)
        Me.ingreseIDArticulo.Location = New System.Drawing.Point(36, 138)
        Me.ingreseIDArticulo.Name = "ingreseIDArticulo"
        Me.ingreseIDArticulo.Size = New System.Drawing.Size(60, 20)
        Me.ingreseIDArticulo.TabIndex = 21
        Me.ingreseIDArticulo.Text = "ID_Articulo"
        '
        'ingreseNombreDelArticulo
        '
        Me.ingreseNombreDelArticulo.Font = New System.Drawing.Font("Calisto MT", 8.25!)
        Me.ingreseNombreDelArticulo.Location = New System.Drawing.Point(165, 136)
        Me.ingreseNombreDelArticulo.Name = "ingreseNombreDelArticulo"
        Me.ingreseNombreDelArticulo.Size = New System.Drawing.Size(167, 20)
        Me.ingreseNombreDelArticulo.TabIndex = 22
        Me.ingreseNombreDelArticulo.Text = "Nombre_Articulo"
        '
        'ingreseCantidadActual
        '
        Me.ingreseCantidadActual.Font = New System.Drawing.Font("Calisto MT", 8.25!)
        Me.ingreseCantidadActual.Location = New System.Drawing.Point(586, 138)
        Me.ingreseCantidadActual.Name = "ingreseCantidadActual"
        Me.ingreseCantidadActual.Size = New System.Drawing.Size(193, 20)
        Me.ingreseCantidadActual.TabIndex = 24
        Me.ingreseCantidadActual.Text = "Cant._Actual_Producto"
        '
        'ingreseCantidadDeSeguridad
        '
        Me.ingreseCantidadDeSeguridad.Font = New System.Drawing.Font("Calisto MT", 8.25!)
        Me.ingreseCantidadDeSeguridad.Location = New System.Drawing.Point(462, 138)
        Me.ingreseCantidadDeSeguridad.Multiline = True
        Me.ingreseCantidadDeSeguridad.Name = "ingreseCantidadDeSeguridad"
        Me.ingreseCantidadDeSeguridad.Size = New System.Drawing.Size(107, 18)
        Me.ingreseCantidadDeSeguridad.TabIndex = 25
        Me.ingreseCantidadDeSeguridad.Text = "Cantidad_Seguridad"
        '
        'tablaDeProductosInventario
        '
        Me.tablaDeProductosInventario.AllowUserToAddRows = False
        Me.tablaDeProductosInventario.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.tablaDeProductosInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaDeProductosInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id__Articulo_Tabla_Gestionar_Inventario, Me.nombre_Articulo_Gestionar_Inventario, Me.precio_Articulo_Tabla_Gestionar_Inventario, Me.cantidad_Seguridad_Tabla_Gestionar_Inventario, Me.cantidad_Actual_Tabla_Gestionar_Inventario})
        Me.tablaDeProductosInventario.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tablaDeProductosInventario.Location = New System.Drawing.Point(36, 162)
        Me.tablaDeProductosInventario.Name = "tablaDeProductosInventario"
        Me.tablaDeProductosInventario.RowTemplate.Height = 25
        Me.tablaDeProductosInventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tablaDeProductosInventario.Size = New System.Drawing.Size(743, 235)
        Me.tablaDeProductosInventario.TabIndex = 27
        '
        'id__Articulo_Tabla_Gestionar_Inventario
        '
        Me.id__Articulo_Tabla_Gestionar_Inventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id__Articulo_Tabla_Gestionar_Inventario.FillWeight = 35.0!
        Me.id__Articulo_Tabla_Gestionar_Inventario.HeaderText = "ID_ARTICULO"
        Me.id__Articulo_Tabla_Gestionar_Inventario.Name = "id__Articulo_Tabla_Gestionar_Inventario"
        Me.id__Articulo_Tabla_Gestionar_Inventario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id__Articulo_Tabla_Gestionar_Inventario.Width = 88
        '
        'nombre_Articulo_Gestionar_Inventario
        '
        Me.nombre_Articulo_Gestionar_Inventario.HeaderText = "NOMBRE_ARTICULO"
        Me.nombre_Articulo_Gestionar_Inventario.Name = "nombre_Articulo_Gestionar_Inventario"
        Me.nombre_Articulo_Gestionar_Inventario.Width = 180
        '
        'precio_Articulo_Tabla_Gestionar_Inventario
        '
        Me.precio_Articulo_Tabla_Gestionar_Inventario.HeaderText = "PRECIO_ARTICULO"
        Me.precio_Articulo_Tabla_Gestionar_Inventario.Name = "precio_Articulo_Tabla_Gestionar_Inventario"
        Me.precio_Articulo_Tabla_Gestionar_Inventario.Width = 110
        '
        'cantidad_Seguridad_Tabla_Gestionar_Inventario
        '
        Me.cantidad_Seguridad_Tabla_Gestionar_Inventario.HeaderText = "CANTIDAD_SEGURIDAD"
        Me.cantidad_Seguridad_Tabla_Gestionar_Inventario.Name = "cantidad_Seguridad_Tabla_Gestionar_Inventario"
        Me.cantidad_Seguridad_Tabla_Gestionar_Inventario.Width = 135
        '
        'cantidad_Actual_Tabla_Gestionar_Inventario
        '
        Me.cantidad_Actual_Tabla_Gestionar_Inventario.HeaderText = "CANTIDAD_ACTUAL_PRODUCTO"
        Me.cantidad_Actual_Tabla_Gestionar_Inventario.Name = "cantidad_Actual_Tabla_Gestionar_Inventario"
        Me.cantidad_Actual_Tabla_Gestionar_Inventario.Width = 185
        '
        'barraDeslizante_GI
        '
        Me.barraDeslizante_GI.Location = New System.Drawing.Point(760, 186)
        Me.barraDeslizante_GI.Name = "barraDeslizante_GI"
        Me.barraDeslizante_GI.Size = New System.Drawing.Size(13, 200)
        Me.barraDeslizante_GI.TabIndex = 28
        '
        'botonBuscarArticulos
        '
        Me.botonBuscarArticulos.AutoSize = True
        Me.botonBuscarArticulos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonBuscarArticulos.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold)
        Me.botonBuscarArticulos.ForeColor = System.Drawing.Color.Transparent
        Me.botonBuscarArticulos.Location = New System.Drawing.Point(685, 101)
        Me.botonBuscarArticulos.Name = "botonBuscarArticulos"
        Me.botonBuscarArticulos.Size = New System.Drawing.Size(84, 28)
        Me.botonBuscarArticulos.TabIndex = 32
        Me.botonBuscarArticulos.Text = "BUSCAR"
        Me.botonBuscarArticulos.UseVisualStyleBackColor = False
        '
        'botonModificarArticulo
        '
        Me.botonModificarArticulo.AutoSize = True
        Me.botonModificarArticulo.BackColor = System.Drawing.Color.LightSlateGray
        Me.botonModificarArticulo.Font = New System.Drawing.Font("Californian FB", 11.25!)
        Me.botonModificarArticulo.ForeColor = System.Drawing.Color.Transparent
        Me.botonModificarArticulo.Location = New System.Drawing.Point(586, 416)
        Me.botonModificarArticulo.Name = "botonModificarArticulo"
        Me.botonModificarArticulo.Size = New System.Drawing.Size(102, 28)
        Me.botonModificarArticulo.TabIndex = 40
        Me.botonModificarArticulo.Text = "MODIFICAR"
        Me.botonModificarArticulo.UseVisualStyleBackColor = False
        '
        'botonDarDeAltaArticulo
        '
        Me.botonDarDeAltaArticulo.AutoSize = True
        Me.botonDarDeAltaArticulo.BackColor = System.Drawing.Color.LightSlateGray
        Me.botonDarDeAltaArticulo.Font = New System.Drawing.Font("Californian FB", 11.25!)
        Me.botonDarDeAltaArticulo.ForeColor = System.Drawing.Color.Transparent
        Me.botonDarDeAltaArticulo.Location = New System.Drawing.Point(462, 416)
        Me.botonDarDeAltaArticulo.Name = "botonDarDeAltaArticulo"
        Me.botonDarDeAltaArticulo.Size = New System.Drawing.Size(107, 28)
        Me.botonDarDeAltaArticulo.TabIndex = 41
        Me.botonDarDeAltaArticulo.Text = "DAR DE ALTA"
        Me.botonDarDeAltaArticulo.UseVisualStyleBackColor = False
        '
        'botonBorrarArticulo
        '
        Me.botonBorrarArticulo.AutoSize = True
        Me.botonBorrarArticulo.BackColor = System.Drawing.Color.LightSlateGray
        Me.botonBorrarArticulo.Font = New System.Drawing.Font("Californian FB", 11.25!)
        Me.botonBorrarArticulo.ForeColor = System.Drawing.Color.Transparent
        Me.botonBorrarArticulo.Location = New System.Drawing.Point(705, 416)
        Me.botonBorrarArticulo.Name = "botonBorrarArticulo"
        Me.botonBorrarArticulo.Size = New System.Drawing.Size(74, 28)
        Me.botonBorrarArticulo.TabIndex = 42
        Me.botonBorrarArticulo.Text = "BORRAR"
        Me.botonBorrarArticulo.UseVisualStyleBackColor = False
        '
        'botonRegresarAGestionarUsuario
        '
        Me.botonRegresarAGestionarUsuario.AutoSize = True
        Me.botonRegresarAGestionarUsuario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonRegresarAGestionarUsuario.Font = New System.Drawing.Font("Californian FB", 15.0!)
        Me.botonRegresarAGestionarUsuario.ForeColor = System.Drawing.Color.White
        Me.botonRegresarAGestionarUsuario.Location = New System.Drawing.Point(12, 485)
        Me.botonRegresarAGestionarUsuario.Name = "botonRegresarAGestionarUsuario"
        Me.botonRegresarAGestionarUsuario.Size = New System.Drawing.Size(120, 34)
        Me.botonRegresarAGestionarUsuario.TabIndex = 43
        Me.botonRegresarAGestionarUsuario.Text = "REGRESAR"
        Me.botonRegresarAGestionarUsuario.UseVisualStyleBackColor = False
        '
        'ingresePrecioDelArticulo
        '
        Me.ingresePrecioDelArticulo.Font = New System.Drawing.Font("Calisto MT", 8.25!)
        Me.ingresePrecioDelArticulo.Location = New System.Drawing.Point(362, 136)
        Me.ingresePrecioDelArticulo.Name = "ingresePrecioDelArticulo"
        Me.ingresePrecioDelArticulo.Size = New System.Drawing.Size(87, 20)
        Me.ingresePrecioDelArticulo.TabIndex = 23
        Me.ingresePrecioDelArticulo.Text = "Precio_Articulo"
        '
        'botonManejoCantidad
        '
        Me.botonManejoCantidad.AutoSize = True
        Me.botonManejoCantidad.Location = New System.Drawing.Point(645, 101)
        Me.botonManejoCantidad.Name = "botonManejoCantidad"
        Me.botonManejoCantidad.Size = New System.Drawing.Size(16, 20)
        Me.botonManejoCantidad.TabIndex = 44
        '
        'gestionarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.botonManejoCantidad)
        Me.Controls.Add(Me.botonRegresarAGestionarUsuario)
        Me.Controls.Add(Me.botonBorrarArticulo)
        Me.Controls.Add(Me.botonDarDeAltaArticulo)
        Me.Controls.Add(Me.botonModificarArticulo)
        Me.Controls.Add(Me.botonBuscarArticulos)
        Me.Controls.Add(Me.barraDeslizante_GI)
        Me.Controls.Add(Me.tablaDeProductosInventario)
        Me.Controls.Add(Me.ingreseCantidadDeSeguridad)
        Me.Controls.Add(Me.ingreseCantidadActual)
        Me.Controls.Add(Me.ingresePrecioDelArticulo)
        Me.Controls.Add(Me.ingreseNombreDelArticulo)
        Me.Controls.Add(Me.ingreseIDArticulo)
        Me.Controls.Add(Me.iconoBuscarArt)
        Me.Controls.Add(Me.buscadorDeProductos)
        Me.DoubleBuffered = True
        Me.Name = "gestionarInventario"
        Me.Text = "GESTIONAR INVENTARIO"
        CType(Me.iconoBuscarArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaDeProductosInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents iconoBuscarArt As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents buscadorDeProductos As TextBox
    Friend WithEvents ingreseIDArticulo As TextBox
    Friend WithEvents ingreseNombreDelArticulo As TextBox
    Friend WithEvents ingreseCantidadActual As TextBox
    Friend WithEvents ingreseCantidadDeSeguridad As TextBox
    Friend WithEvents tablaDeProductosInventario As DataGridView
    Friend WithEvents barraDeslizante_GI As VScrollBar
    Friend WithEvents id__Articulo_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents nombre_Articulo_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents precio_Articulo_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_Seguridad_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_Actual_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents botonBuscarArticulos As Button
    Friend WithEvents botonModificarArticulo As Button
    Friend WithEvents botonDarDeAltaArticulo As Button
    Friend WithEvents botonBorrarArticulo As Button
    Friend WithEvents botonRegresarAGestionarUsuario As Button
    Friend WithEvents ingresePrecioDelArticulo As TextBox
    Friend WithEvents botonManejoCantidad As DomainUpDown
End Class
