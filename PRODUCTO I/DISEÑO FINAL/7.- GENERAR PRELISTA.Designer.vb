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
        Me.barraDeslizante3 = New System.Windows.Forms.VScrollBar()
        Me.tablaDeProductosInventario = New System.Windows.Forms.DataGridView()
        Me.id__Articulo_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_Articulo_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_Articulo_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Seguridad_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Actual_Tabla_Gestionar_Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botonRegresarAGestionarInventario = New System.Windows.Forms.Button()
        Me.botonGenerarReportePDF = New System.Windows.Forms.Button()
        Me.iconoGenerarReportePDF = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.tablaDeProductosInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoGenerarReportePDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barraDeslizante3
        '
        Me.barraDeslizante3.Location = New System.Drawing.Point(751, 144)
        Me.barraDeslizante3.Name = "barraDeslizante3"
        Me.barraDeslizante3.Size = New System.Drawing.Size(13, 207)
        Me.barraDeslizante3.TabIndex = 30
        '
        'tablaDeProductosInventario
        '
        Me.tablaDeProductosInventario.BackgroundColor = System.Drawing.Color.LightCyan
        Me.tablaDeProductosInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaDeProductosInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id__Articulo_Tabla_Gestionar_Inventario, Me.nombre_Articulo_Gestionar_Inventario, Me.precio_Articulo_Tabla_Gestionar_Inventario, Me.cantidad_Seguridad_Tabla_Gestionar_Inventario, Me.cantidad_Actual_Tabla_Gestionar_Inventario})
        Me.tablaDeProductosInventario.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tablaDeProductosInventario.Location = New System.Drawing.Point(29, 90)
        Me.tablaDeProductosInventario.Name = "tablaDeProductosInventario"
        Me.tablaDeProductosInventario.RowTemplate.Height = 25
        Me.tablaDeProductosInventario.Size = New System.Drawing.Size(742, 271)
        Me.tablaDeProductosInventario.TabIndex = 29
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
        Me.botonRegresarAGestionarInventario.BackColor = System.Drawing.Color.Black
        Me.botonRegresarAGestionarInventario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonRegresarAGestionarInventario.ForeColor = System.Drawing.Color.White
        Me.botonRegresarAGestionarInventario.Location = New System.Drawing.Point(12, 482)
        Me.botonRegresarAGestionarInventario.Name = "botonRegresarAGestionarInventario"
        Me.botonRegresarAGestionarInventario.Size = New System.Drawing.Size(110, 37)
        Me.botonRegresarAGestionarInventario.TabIndex = 44
        Me.botonRegresarAGestionarInventario.Text = "REGRESAR"
        Me.botonRegresarAGestionarInventario.UseVisualStyleBackColor = False
        '
        'botonGenerarReportePDF
        '
        Me.botonGenerarReportePDF.AutoSize = True
        Me.botonGenerarReportePDF.BackColor = System.Drawing.Color.Green
        Me.botonGenerarReportePDF.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonGenerarReportePDF.ForeColor = System.Drawing.Color.Transparent
        Me.botonGenerarReportePDF.Location = New System.Drawing.Point(635, 441)
        Me.botonGenerarReportePDF.Name = "botonGenerarReportePDF"
        Me.botonGenerarReportePDF.Size = New System.Drawing.Size(155, 26)
        Me.botonGenerarReportePDF.TabIndex = 45
        Me.botonGenerarReportePDF.Text = "GENERAR PRE LISTA PDF"
        Me.botonGenerarReportePDF.UseVisualStyleBackColor = False
        '
        'iconoGenerarReportePDF
        '
        Me.iconoGenerarReportePDF.BackColor = System.Drawing.Color.Orange
        Me.iconoGenerarReportePDF.ForeColor = System.Drawing.Color.Black
        Me.iconoGenerarReportePDF.IconChar = FontAwesome.Sharp.IconChar.Download
        Me.iconoGenerarReportePDF.IconColor = System.Drawing.Color.Black
        Me.iconoGenerarReportePDF.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoGenerarReportePDF.IconSize = 21
        Me.iconoGenerarReportePDF.Location = New System.Drawing.Point(600, 441)
        Me.iconoGenerarReportePDF.Name = "iconoGenerarReportePDF"
        Me.iconoGenerarReportePDF.Size = New System.Drawing.Size(29, 21)
        Me.iconoGenerarReportePDF.TabIndex = 46
        Me.iconoGenerarReportePDF.TabStop = False
        '
        'generarPrelistaDeArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.iconoGenerarReportePDF)
        Me.Controls.Add(Me.botonGenerarReportePDF)
        Me.Controls.Add(Me.botonRegresarAGestionarInventario)
        Me.Controls.Add(Me.barraDeslizante3)
        Me.Controls.Add(Me.tablaDeProductosInventario)
        Me.Name = "generarPrelistaDeArticulos"
        Me.Text = "GENERAR PRE LISTA DE PRODUCTOS"
        CType(Me.tablaDeProductosInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoGenerarReportePDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barraDeslizante3 As VScrollBar
    Friend WithEvents tablaDeProductosInventario As DataGridView
    Friend WithEvents id__Articulo_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents nombre_Articulo_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents precio_Articulo_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_Seguridad_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_Actual_Tabla_Gestionar_Inventario As DataGridViewTextBoxColumn
    Friend WithEvents botonRegresarAGestionarInventario As Button
    Friend WithEvents botonGenerarReportePDF As Button
    Friend WithEvents iconoGenerarReportePDF As FontAwesome.Sharp.IconPictureBox
End Class
