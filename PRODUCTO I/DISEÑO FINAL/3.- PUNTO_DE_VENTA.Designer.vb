<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class puntoDeVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(puntoDeVenta))
        Me.buscadorDeArticulos = New System.Windows.Forms.TextBox()
        Me.botonManejoCantidad = New System.Windows.Forms.DomainUpDown()
        Me.botonAgregarArticulos = New System.Windows.Forms.Button()
        Me.iconoBuscarArticulo = New FontAwesome.Sharp.IconPictureBox()
        Me.botonEliminaArticulos = New System.Windows.Forms.Button()
        Me.botonRegresarAMenuEncargado = New System.Windows.Forms.Button()
        Me.botonGenerarReporte = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botonGenerarVenta = New System.Windows.Forms.Button()
        CType(Me.iconoBuscarArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buscadorDeArticulos
        '
        Me.buscadorDeArticulos.Location = New System.Drawing.Point(25, 91)
        Me.buscadorDeArticulos.Name = "buscadorDeArticulos"
        Me.buscadorDeArticulos.Size = New System.Drawing.Size(638, 23)
        Me.buscadorDeArticulos.TabIndex = 12
        Me.buscadorDeArticulos.Text = "Buscar artículo"
        '
        'botonManejoCantidad
        '
        Me.botonManejoCantidad.AutoSize = True
        Me.botonManejoCantidad.Location = New System.Drawing.Point(669, 91)
        Me.botonManejoCantidad.Name = "botonManejoCantidad"
        Me.botonManejoCantidad.Size = New System.Drawing.Size(18, 23)
        Me.botonManejoCantidad.TabIndex = 13
        '
        'botonAgregarArticulos
        '
        Me.botonAgregarArticulos.AutoSize = True
        Me.botonAgregarArticulos.BackColor = System.Drawing.Color.Green
        Me.botonAgregarArticulos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonAgregarArticulos.ForeColor = System.Drawing.Color.Transparent
        Me.botonAgregarArticulos.Location = New System.Drawing.Point(714, 89)
        Me.botonAgregarArticulos.Name = "botonAgregarArticulos"
        Me.botonAgregarArticulos.Size = New System.Drawing.Size(77, 26)
        Me.botonAgregarArticulos.TabIndex = 14
        Me.botonAgregarArticulos.Text = "AGREGAR"
        Me.botonAgregarArticulos.UseVisualStyleBackColor = False
        '
        'iconoBuscarArticulo
        '
        Me.iconoBuscarArticulo.BackColor = System.Drawing.Color.Transparent
        Me.iconoBuscarArticulo.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.iconoBuscarArticulo.IconColor = System.Drawing.Color.White
        Me.iconoBuscarArticulo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoBuscarArticulo.IconSize = 23
        Me.iconoBuscarArticulo.Location = New System.Drawing.Point(691, 91)
        Me.iconoBuscarArticulo.Name = "iconoBuscarArticulo"
        Me.iconoBuscarArticulo.Size = New System.Drawing.Size(23, 23)
        Me.iconoBuscarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.iconoBuscarArticulo.TabIndex = 15
        Me.iconoBuscarArticulo.TabStop = False
        '
        'botonEliminaArticulos
        '
        Me.botonEliminaArticulos.AutoSize = True
        Me.botonEliminaArticulos.BackColor = System.Drawing.Color.Red
        Me.botonEliminaArticulos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonEliminaArticulos.ForeColor = System.Drawing.Color.White
        Me.botonEliminaArticulos.Location = New System.Drawing.Point(639, 382)
        Me.botonEliminaArticulos.Name = "botonEliminaArticulos"
        Me.botonEliminaArticulos.Size = New System.Drawing.Size(152, 34)
        Me.botonEliminaArticulos.TabIndex = 17
        Me.botonEliminaArticulos.Text = "ELIMINAR ARTÍCULO"
        Me.botonEliminaArticulos.UseVisualStyleBackColor = False
        '
        'botonRegresarAMenuEncargado
        '
        Me.botonRegresarAMenuEncargado.AutoSize = True
        Me.botonRegresarAMenuEncargado.BackColor = System.Drawing.Color.Black
        Me.botonRegresarAMenuEncargado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonRegresarAMenuEncargado.ForeColor = System.Drawing.Color.White
        Me.botonRegresarAMenuEncargado.Location = New System.Drawing.Point(12, 482)
        Me.botonRegresarAMenuEncargado.Name = "botonRegresarAMenuEncargado"
        Me.botonRegresarAMenuEncargado.Size = New System.Drawing.Size(110, 37)
        Me.botonRegresarAMenuEncargado.TabIndex = 18
        Me.botonRegresarAMenuEncargado.Text = "REGRESAR"
        Me.botonRegresarAMenuEncargado.UseVisualStyleBackColor = False
        '
        'botonGenerarReporte
        '
        Me.botonGenerarReporte.AutoSize = True
        Me.botonGenerarReporte.BackColor = System.Drawing.Color.OrangeRed
        Me.botonGenerarReporte.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonGenerarReporte.ForeColor = System.Drawing.Color.White
        Me.botonGenerarReporte.Location = New System.Drawing.Point(177, 446)
        Me.botonGenerarReporte.Name = "botonGenerarReporte"
        Me.botonGenerarReporte.Size = New System.Drawing.Size(176, 39)
        Me.botonGenerarReporte.TabIndex = 19
        Me.botonGenerarReporte.Text = "GENERAR REPORTE"
        Me.botonGenerarReporte.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.a})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(766, 228)
        Me.DataGridView1.TabIndex = 21
        '
        'a
        '
        Me.a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.a.FillWeight = 35.0!
        Me.a.HeaderText = ""
        Me.a.Name = "a"
        Me.a.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'botonGenerarVenta
        '
        Me.botonGenerarVenta.AutoSize = True
        Me.botonGenerarVenta.BackColor = System.Drawing.Color.LightSalmon
        Me.botonGenerarVenta.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonGenerarVenta.ForeColor = System.Drawing.Color.Black
        Me.botonGenerarVenta.Location = New System.Drawing.Point(442, 446)
        Me.botonGenerarVenta.Name = "botonGenerarVenta"
        Me.botonGenerarVenta.Size = New System.Drawing.Size(141, 39)
        Me.botonGenerarVenta.TabIndex = 23
        Me.botonGenerarVenta.Text = "GENERAR VENTA"
        Me.botonGenerarVenta.UseVisualStyleBackColor = False
        '
        'puntoDeVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.botonGenerarVenta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.botonGenerarReporte)
        Me.Controls.Add(Me.botonRegresarAMenuEncargado)
        Me.Controls.Add(Me.botonEliminaArticulos)
        Me.Controls.Add(Me.iconoBuscarArticulo)
        Me.Controls.Add(Me.botonAgregarArticulos)
        Me.Controls.Add(Me.botonManejoCantidad)
        Me.Controls.Add(Me.buscadorDeArticulos)
        Me.DoubleBuffered = True
        Me.Name = "puntoDeVenta"
        Me.Text = "PUNTO DE VENTA"
        CType(Me.iconoBuscarArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buscadorDeArticulos As TextBox
    Friend WithEvents botonManejoCantidad As DomainUpDown
    Friend WithEvents botonAgregarArticulos As Button
    Friend WithEvents iconoBuscarArticulo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents botonEliminaArticulos As Button
    Friend WithEvents botonRegresarAMenuEncargado As Button
    Friend WithEvents botonGenerarReporte As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents a As DataGridViewTextBoxColumn
    Friend WithEvents botonGenerarVenta As Button
End Class
