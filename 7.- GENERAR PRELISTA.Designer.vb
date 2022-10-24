<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class generarPrelistaDeArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(generarPrelistaDeArticulos))
        Me.barraDeslizante_GPP = New System.Windows.Forms.VScrollBar()
        Me.tablaDePreListaDeProductos = New System.Windows.Forms.DataGridView()
        Me.id__Articulo_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_Articulo_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_Articulo_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Seguridad_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Actual_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botonRegresarAGestionarInventario = New System.Windows.Forms.Button()
        Me.botonGenerarPreListaPDF = New System.Windows.Forms.Button()
        Me.iconoGenerarPreListaPDF = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.tablaDePreListaDeProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoGenerarPreListaPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barraDeslizante_GPP
        '
        Me.barraDeslizante_GPP.Location = New System.Drawing.Point(763, 177)
        Me.barraDeslizante_GPP.Name = "barraDeslizante_GPP"
        Me.barraDeslizante_GPP.Size = New System.Drawing.Size(10, 200)
        Me.barraDeslizante_GPP.TabIndex = 30
        '
        'tablaDePreListaDeProductos
        '
        Me.tablaDePreListaDeProductos.AllowUserToAddRows = False
        Me.tablaDePreListaDeProductos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.tablaDePreListaDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaDePreListaDeProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id__Articulo_Tabla_Gestionar_Inventario, Me.nombre_Articulo_Gestionar_Inventario, Me.precio_Articulo_Tabla_Gestionar_Inventario, Me.cantidad_Seguridad_Tabla_Gestionar_Inventario, Me.cantidad_Actual_Tabla_Gestionar_Inventario})
        Me.tablaDePreListaDeProductos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tablaDePreListaDeProductos.Location = New System.Drawing.Point(37, 152)
        Me.tablaDePreListaDeProductos.Name = "tablaDePreListaDeProductos"
        Me.tablaDePreListaDeProductos.RowTemplate.Height = 25
        Me.tablaDePreListaDeProductos.Size = New System.Drawing.Size(742, 235)
        Me.tablaDePreListaDeProductos.TabIndex = 29
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
        'botonRegresarAGestionarInventario
        '
        Me.botonRegresarAGestionarInventario.AutoSize = True
        Me.botonRegresarAGestionarInventario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonRegresarAGestionarInventario.Font = New System.Drawing.Font("Californian FB", 15.0!)
        Me.botonRegresarAGestionarInventario.ForeColor = System.Drawing.Color.White
        Me.botonRegresarAGestionarInventario.Location = New System.Drawing.Point(12, 485)
        Me.botonRegresarAGestionarInventario.Name = "botonRegresarAGestionarInventario"
        Me.botonRegresarAGestionarInventario.Size = New System.Drawing.Size(120, 34)
        Me.botonRegresarAGestionarInventario.TabIndex = 44
        Me.botonRegresarAGestionarInventario.Text = "REGRESAR"
        Me.botonRegresarAGestionarInventario.UseVisualStyleBackColor = False
        '
        'botonGenerarPreListaPDF
        '
        Me.botonGenerarPreListaPDF.AutoSize = True
        Me.botonGenerarPreListaPDF.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonGenerarPreListaPDF.Font = New System.Drawing.Font("Californian FB", 11.25!)
        Me.botonGenerarPreListaPDF.ForeColor = System.Drawing.Color.Transparent
        Me.botonGenerarPreListaPDF.Location = New System.Drawing.Point(590, 106)
        Me.botonGenerarPreListaPDF.Name = "botonGenerarPreListaPDF"
        Me.botonGenerarPreListaPDF.Size = New System.Drawing.Size(189, 28)
        Me.botonGenerarPreListaPDF.TabIndex = 45
        Me.botonGenerarPreListaPDF.Text = "GENERAR PRE LISTA PDF"
        Me.botonGenerarPreListaPDF.UseVisualStyleBackColor = False
        '
        'iconoGenerarPreListaPDF
        '
        Me.iconoGenerarPreListaPDF.BackColor = System.Drawing.Color.Transparent
        Me.iconoGenerarPreListaPDF.ForeColor = System.Drawing.Color.Black
        Me.iconoGenerarPreListaPDF.IconChar = FontAwesome.Sharp.IconChar.Download
        Me.iconoGenerarPreListaPDF.IconColor = System.Drawing.Color.Black
        Me.iconoGenerarPreListaPDF.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoGenerarPreListaPDF.IconSize = 26
        Me.iconoGenerarPreListaPDF.Location = New System.Drawing.Point(558, 108)
        Me.iconoGenerarPreListaPDF.Name = "iconoGenerarPreListaPDF"
        Me.iconoGenerarPreListaPDF.Size = New System.Drawing.Size(26, 26)
        Me.iconoGenerarPreListaPDF.TabIndex = 46
        Me.iconoGenerarPreListaPDF.TabStop = False
        '
        'generarPrelistaDeArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.iconoGenerarPreListaPDF)
        Me.Controls.Add(Me.botonGenerarPreListaPDF)
        Me.Controls.Add(Me.botonRegresarAGestionarInventario)
        Me.Controls.Add(Me.barraDeslizante_GPP)
        Me.Controls.Add(Me.tablaDePreListaDeProductos)
        Me.Name = "generarPrelistaDeArticulos"
        Me.Text = "GENERAR PRE LISTA DE PRODUCTOS"
        CType(Me.tablaDePreListaDeProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoGenerarPreListaPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barraDeslizante_GPP As VScrollBar
    Friend WithEvents tablaDePreListaDeProductos As DataGridView
    Friend WithEvents id__Articulo_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents nombre_Articulo_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents precio_Articulo_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_Seguridad_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_Actual_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents botonRegresarAGestionarInventario As Button
    Friend WithEvents botonGenerarPreListaPDF As Button
    Friend WithEvents iconoGenerarPreListaPDF As FontAwesome.Sharp.IconPictureBox
End Class
