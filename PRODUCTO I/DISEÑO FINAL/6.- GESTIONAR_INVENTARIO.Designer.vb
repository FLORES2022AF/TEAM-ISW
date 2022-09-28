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
        Me.ingresePrecioDelArticulo = New System.Windows.Forms.TextBox()
        Me.ingreseCantidadActual = New System.Windows.Forms.TextBox()
        Me.ingreseCantidadDeSeguridad = New System.Windows.Forms.TextBox()
        Me.tablaDeProductosInventario = New System.Windows.Forms.DataGridView()
        Me.id__Articulo_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_Articulo_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_Articulo_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Seguridad_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Actual_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barraDeslizante3 = New System.Windows.Forms.VScrollBar()
        Me.botonBuscarArticulos = New System.Windows.Forms.Button()
        Me.botonModificarArticulo = New System.Windows.Forms.Button()
        Me.botonDarDeAltaArticulo = New System.Windows.Forms.Button()
        Me.botonBorrarArticulo = New System.Windows.Forms.Button()
        Me.botonRegresarAGestionarUsuario = New System.Windows.Forms.Button()
        CType(Me.iconoBuscarArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaDeProductosInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iconoBuscarArt
        '
        Me.iconoBuscarArt.BackColor = System.Drawing.Color.Transparent
        Me.iconoBuscarArt.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.iconoBuscarArt.IconColor = System.Drawing.Color.White
        Me.iconoBuscarArt.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoBuscarArt.IconSize = 23
        Me.iconoBuscarArt.Location = New System.Drawing.Point(651, 85)
        Me.iconoBuscarArt.Name = "iconoBuscarArt"
        Me.iconoBuscarArt.Size = New System.Drawing.Size(23, 23)
        Me.iconoBuscarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.iconoBuscarArt.TabIndex = 19
        Me.iconoBuscarArt.TabStop = False
        '
        'buscadorDeProductos
        '
        Me.buscadorDeProductos.Location = New System.Drawing.Point(36, 85)
        Me.buscadorDeProductos.Name = "buscadorDeProductos"
        Me.buscadorDeProductos.Size = New System.Drawing.Size(616, 23)
        Me.buscadorDeProductos.TabIndex = 18
        Me.buscadorDeProductos.Text = "Buscar producto"
        '
        'ingreseIDArticulo
        '
        Me.ingreseIDArticulo.Location = New System.Drawing.Point(36, 138)
        Me.ingreseIDArticulo.Name = "ingreseIDArticulo"
        Me.ingreseIDArticulo.Size = New System.Drawing.Size(69, 23)
        Me.ingreseIDArticulo.TabIndex = 21
        Me.ingreseIDArticulo.Text = "ID_Articulo"
        '
        'ingreseNombreDelArticulo
        '
        Me.ingreseNombreDelArticulo.Location = New System.Drawing.Point(111, 138)
        Me.ingreseNombreDelArticulo.Name = "ingreseNombreDelArticulo"
        Me.ingreseNombreDelArticulo.Size = New System.Drawing.Size(201, 23)
        Me.ingreseNombreDelArticulo.TabIndex = 22
        Me.ingreseNombreDelArticulo.Text = "Nombre_Articulo"
        '
        'ingresePrecioDelArticulo
        '
        Me.ingresePrecioDelArticulo.Location = New System.Drawing.Point(318, 138)
        Me.ingresePrecioDelArticulo.Name = "ingresePrecioDelArticulo"
        Me.ingresePrecioDelArticulo.Size = New System.Drawing.Size(87, 23)
        Me.ingresePrecioDelArticulo.TabIndex = 23
        Me.ingresePrecioDelArticulo.Text = "Precio_Articulo"
        '
        'ingreseCantidadActual
        '
        Me.ingreseCantidadActual.Location = New System.Drawing.Point(540, 138)
        Me.ingreseCantidadActual.Name = "ingreseCantidadActual"
        Me.ingreseCantidadActual.Size = New System.Drawing.Size(134, 23)
        Me.ingreseCantidadActual.TabIndex = 24
        Me.ingreseCantidadActual.Text = "Cant._Actual_Producto"
        '
        'ingreseCantidadDeSeguridad
        '
        Me.ingreseCantidadDeSeguridad.Location = New System.Drawing.Point(411, 138)
        Me.ingreseCantidadDeSeguridad.Multiline = True
        Me.ingreseCantidadDeSeguridad.Name = "ingreseCantidadDeSeguridad"
        Me.ingreseCantidadDeSeguridad.Size = New System.Drawing.Size(123, 23)
        Me.ingreseCantidadDeSeguridad.TabIndex = 25
        Me.ingreseCantidadDeSeguridad.Text = "Cantidad_Seguridad"
        '
        'tablaDeProductosInventario
        '
        Me.tablaDeProductosInventario.BackgroundColor = System.Drawing.Color.MistyRose
        Me.tablaDeProductosInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaDeProductosInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id__Articulo_Tabla_Gestionar_Inventario, Me.nombre_Articulo_Gestionar_Inventario, Me.precio_Articulo_Tabla_Gestionar_Inventario, Me.cantidad_Seguridad_Tabla_Gestionar_Inventario, Me.cantidad_Actual_Tabla_Gestionar_Inventario})
        Me.tablaDeProductosInventario.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tablaDeProductosInventario.Location = New System.Drawing.Point(36, 178)
        Me.tablaDeProductosInventario.Name = "tablaDeProductosInventario"
        Me.tablaDeProductosInventario.RowTemplate.Height = 25
        Me.tablaDeProductosInventario.Size = New System.Drawing.Size(742, 271)
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
        'barraDeslizante3
        '
        Me.barraDeslizante3.Location = New System.Drawing.Point(758, 232)
        Me.barraDeslizante3.Name = "barraDeslizante3"
        Me.barraDeslizante3.Size = New System.Drawing.Size(13, 207)
        Me.barraDeslizante3.TabIndex = 28
        '
        'botonBuscarArticulos
        '
        Me.botonBuscarArticulos.AutoSize = True
        Me.botonBuscarArticulos.BackColor = System.Drawing.Color.Green
        Me.botonBuscarArticulos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonBuscarArticulos.ForeColor = System.Drawing.Color.Transparent
        Me.botonBuscarArticulos.Location = New System.Drawing.Point(701, 85)
        Me.botonBuscarArticulos.Name = "botonBuscarArticulos"
        Me.botonBuscarArticulos.Size = New System.Drawing.Size(77, 26)
        Me.botonBuscarArticulos.TabIndex = 32
        Me.botonBuscarArticulos.Text = "BUSCAR"
        Me.botonBuscarArticulos.UseVisualStyleBackColor = False
        '
        'botonModificarArticulo
        '
        Me.botonModificarArticulo.AutoSize = True
        Me.botonModificarArticulo.BackColor = System.Drawing.Color.Orange
        Me.botonModificarArticulo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonModificarArticulo.ForeColor = System.Drawing.Color.Transparent
        Me.botonModificarArticulo.Location = New System.Drawing.Point(618, 455)
        Me.botonModificarArticulo.Name = "botonModificarArticulo"
        Me.botonModificarArticulo.Size = New System.Drawing.Size(80, 26)
        Me.botonModificarArticulo.TabIndex = 40
        Me.botonModificarArticulo.Text = "MODIFICAR"
        Me.botonModificarArticulo.UseVisualStyleBackColor = False
        '
        'botonDarDeAltaArticulo
        '
        Me.botonDarDeAltaArticulo.AutoSize = True
        Me.botonDarDeAltaArticulo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonDarDeAltaArticulo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonDarDeAltaArticulo.ForeColor = System.Drawing.Color.Transparent
        Me.botonDarDeAltaArticulo.Location = New System.Drawing.Point(690, 135)
        Me.botonDarDeAltaArticulo.Name = "botonDarDeAltaArticulo"
        Me.botonDarDeAltaArticulo.Size = New System.Drawing.Size(88, 26)
        Me.botonDarDeAltaArticulo.TabIndex = 41
        Me.botonDarDeAltaArticulo.Text = "DAR DE ALTA"
        Me.botonDarDeAltaArticulo.UseVisualStyleBackColor = False
        '
        'botonBorrarArticulo
        '
        Me.botonBorrarArticulo.AutoSize = True
        Me.botonBorrarArticulo.BackColor = System.Drawing.Color.Red
        Me.botonBorrarArticulo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonBorrarArticulo.ForeColor = System.Drawing.Color.Transparent
        Me.botonBorrarArticulo.Location = New System.Drawing.Point(701, 455)
        Me.botonBorrarArticulo.Name = "botonBorrarArticulo"
        Me.botonBorrarArticulo.Size = New System.Drawing.Size(77, 26)
        Me.botonBorrarArticulo.TabIndex = 42
        Me.botonBorrarArticulo.Text = "BORRAR"
        Me.botonBorrarArticulo.UseVisualStyleBackColor = False
        '
        'botonRegresarAGestionarUsuario
        '
        Me.botonRegresarAGestionarUsuario.AutoSize = True
        Me.botonRegresarAGestionarUsuario.BackColor = System.Drawing.Color.Black
        Me.botonRegresarAGestionarUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonRegresarAGestionarUsuario.ForeColor = System.Drawing.Color.White
        Me.botonRegresarAGestionarUsuario.Location = New System.Drawing.Point(12, 462)
        Me.botonRegresarAGestionarUsuario.Name = "botonRegresarAGestionarUsuario"
        Me.botonRegresarAGestionarUsuario.Size = New System.Drawing.Size(110, 37)
        Me.botonRegresarAGestionarUsuario.TabIndex = 43
        Me.botonRegresarAGestionarUsuario.Text = "REGRESAR"
        Me.botonRegresarAGestionarUsuario.UseVisualStyleBackColor = False
        '
        'gestionarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 511)
        Me.Controls.Add(Me.botonRegresarAGestionarUsuario)
        Me.Controls.Add(Me.botonBorrarArticulo)
        Me.Controls.Add(Me.botonDarDeAltaArticulo)
        Me.Controls.Add(Me.botonModificarArticulo)
        Me.Controls.Add(Me.botonBuscarArticulos)
        Me.Controls.Add(Me.barraDeslizante3)
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
    Friend WithEvents ingresePrecioDelArticulo As TextBox
    Friend WithEvents ingreseCantidadActual As TextBox
    Friend WithEvents ingreseCantidadDeSeguridad As TextBox
    Friend WithEvents tablaDeProductosInventario As DataGridView
    Friend WithEvents barraDeslizante3 As VScrollBar
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
End Class
