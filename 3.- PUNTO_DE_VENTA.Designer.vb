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
        Me.tituloPuntoDeVenta = New System.Windows.Forms.Label()
        Me.buscadorDeArticulos = New System.Windows.Forms.TextBox()
        Me.botonManejoCantidad = New System.Windows.Forms.DomainUpDown()
        Me.botonAgregarArticulos = New System.Windows.Forms.Button()
        Me.iconoBuscarArt = New FontAwesome.Sharp.IconPictureBox()
        Me.botonEliminaArticulos = New System.Windows.Forms.Button()
        Me.botonRegresar_E_D1 = New System.Windows.Forms.Button()
        Me.botonGenerarReporte = New System.Windows.Forms.Button()
        Me.botonGenerarVenta = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.iconoBuscarArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tituloPuntoDeVenta
        '
        Me.tituloPuntoDeVenta.AutoSize = True
        Me.tituloPuntoDeVenta.BackColor = System.Drawing.Color.Transparent
        Me.tituloPuntoDeVenta.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tituloPuntoDeVenta.ForeColor = System.Drawing.Color.GhostWhite
        Me.tituloPuntoDeVenta.Location = New System.Drawing.Point(262, 9)
        Me.tituloPuntoDeVenta.Name = "tituloPuntoDeVenta"
        Me.tituloPuntoDeVenta.Size = New System.Drawing.Size(254, 50)
        Me.tituloPuntoDeVenta.TabIndex = 11
        Me.tituloPuntoDeVenta.Text = "PUNTO DE VENTA"
        Me.tituloPuntoDeVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buscadorDeArticulos
        '
        Me.buscadorDeArticulos.Location = New System.Drawing.Point(25, 62)
        Me.buscadorDeArticulos.Name = "buscadorDeArticulos"
        Me.buscadorDeArticulos.Size = New System.Drawing.Size(638, 23)
        Me.buscadorDeArticulos.TabIndex = 12
        Me.buscadorDeArticulos.Text = "Buscar artículo"
        '
        'botonManejoCantidad
        '
        Me.botonManejoCantidad.AutoSize = True
        Me.botonManejoCantidad.Location = New System.Drawing.Point(669, 62)
        Me.botonManejoCantidad.Name = "botonManejoCantidad"
        Me.botonManejoCantidad.Size = New System.Drawing.Size(18, 23)
        Me.botonManejoCantidad.TabIndex = 13
        '
        'botonAgregarArticulos
        '
        Me.botonAgregarArticulos.AutoSize = True
        Me.botonAgregarArticulos.BackColor = System.Drawing.Color.Black
        Me.botonAgregarArticulos.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonAgregarArticulos.ForeColor = System.Drawing.Color.White
        Me.botonAgregarArticulos.Location = New System.Drawing.Point(710, 51)
        Me.botonAgregarArticulos.Name = "botonAgregarArticulos"
        Me.botonAgregarArticulos.Size = New System.Drawing.Size(81, 34)
        Me.botonAgregarArticulos.TabIndex = 14
        Me.botonAgregarArticulos.Text = "AGREGAR"
        Me.botonAgregarArticulos.UseVisualStyleBackColor = False
        '
        'iconoBuscarArt
        '
        Me.iconoBuscarArt.BackColor = System.Drawing.Color.Transparent
        Me.iconoBuscarArt.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.iconoBuscarArt.IconColor = System.Drawing.Color.White
        Me.iconoBuscarArt.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoBuscarArt.IconSize = 23
        Me.iconoBuscarArt.Location = New System.Drawing.Point(640, 62)
        Me.iconoBuscarArt.Name = "iconoBuscarArt"
        Me.iconoBuscarArt.Size = New System.Drawing.Size(23, 23)
        Me.iconoBuscarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.iconoBuscarArt.TabIndex = 15
        Me.iconoBuscarArt.TabStop = False
        '
        'botonEliminaArticulos
        '
        Me.botonEliminaArticulos.AutoSize = True
        Me.botonEliminaArticulos.BackColor = System.Drawing.Color.Black
        Me.botonEliminaArticulos.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonEliminaArticulos.ForeColor = System.Drawing.Color.White
        Me.botonEliminaArticulos.Location = New System.Drawing.Point(665, 342)
        Me.botonEliminaArticulos.Name = "botonEliminaArticulos"
        Me.botonEliminaArticulos.Size = New System.Drawing.Size(126, 34)
        Me.botonEliminaArticulos.TabIndex = 17
        Me.botonEliminaArticulos.Text = "ELIMINAR ARTICULO"
        Me.botonEliminaArticulos.UseVisualStyleBackColor = False
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
        Me.botonRegresar_E_D1.TabIndex = 18
        Me.botonRegresar_E_D1.Text = "REGRESAR"
        Me.botonRegresar_E_D1.UseVisualStyleBackColor = False
        '
        'botonGenerarReporte
        '
        Me.botonGenerarReporte.AutoSize = True
        Me.botonGenerarReporte.BackColor = System.Drawing.Color.Black
        Me.botonGenerarReporte.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonGenerarReporte.ForeColor = System.Drawing.Color.White
        Me.botonGenerarReporte.Location = New System.Drawing.Point(25, 382)
        Me.botonGenerarReporte.Name = "botonGenerarReporte"
        Me.botonGenerarReporte.Size = New System.Drawing.Size(370, 67)
        Me.botonGenerarReporte.TabIndex = 19
        Me.botonGenerarReporte.Text = "GENERAR REPORTE"
        Me.botonGenerarReporte.UseVisualStyleBackColor = False
        '
        'botonGenerarVenta
        '
        Me.botonGenerarVenta.AutoSize = True
        Me.botonGenerarVenta.BackColor = System.Drawing.Color.Black
        Me.botonGenerarVenta.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonGenerarVenta.ForeColor = System.Drawing.Color.White
        Me.botonGenerarVenta.Location = New System.Drawing.Point(421, 382)
        Me.botonGenerarVenta.Name = "botonGenerarVenta"
        Me.botonGenerarVenta.Size = New System.Drawing.Size(370, 67)
        Me.botonGenerarVenta.TabIndex = 20
        Me.botonGenerarVenta.Text = "GENERAR VENTA"
        Me.botonGenerarVenta.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.a})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 91)
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
        'puntoDeVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(814, 541)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.botonGenerarVenta)
        Me.Controls.Add(Me.botonGenerarReporte)
        Me.Controls.Add(Me.botonRegresar_E_D1)
        Me.Controls.Add(Me.botonEliminaArticulos)
        Me.Controls.Add(Me.iconoBuscarArt)
        Me.Controls.Add(Me.botonAgregarArticulos)
        Me.Controls.Add(Me.botonManejoCantidad)
        Me.Controls.Add(Me.buscadorDeArticulos)
        Me.Controls.Add(Me.tituloPuntoDeVenta)
        Me.Name = "puntoDeVenta"
        Me.Text = "PUNTO DE VENTA"
        CType(Me.iconoBuscarArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tituloPuntoDeVenta As Label
    Friend WithEvents buscadorDeArticulos As TextBox
    Friend WithEvents botonManejoCantidad As DomainUpDown
    Friend WithEvents botonAgregarArticulos As Button
    Friend WithEvents iconoBuscarArt As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents botonEliminaArticulos As Button
    Friend WithEvents botonRegresar_E_D1 As Button
    Friend WithEvents botonGenerarReporte As Button
    Friend WithEvents botonGenerarVenta As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents a As DataGridViewTextBoxColumn
End Class
