<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class generarReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(generarReporte))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tituloGenerarReporte = New System.Windows.Forms.Label()
        Me.botonAgregarArticulos = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.fecha_Tabla_Generar_Reporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productos_Tabla_Generar_Reporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Tabla_Generar_Reporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venta_Tabla_Generar_Reporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botonRegresar_E_D1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(23, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(677, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Tipo de reporte"
        '
        'tituloGenerarReporte
        '
        Me.tituloGenerarReporte.BackColor = System.Drawing.Color.Transparent
        Me.tituloGenerarReporte.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tituloGenerarReporte.ForeColor = System.Drawing.Color.White
        Me.tituloGenerarReporte.Location = New System.Drawing.Point(232, 9)
        Me.tituloGenerarReporte.Name = "tituloGenerarReporte"
        Me.tituloGenerarReporte.Size = New System.Drawing.Size(364, 63)
        Me.tituloGenerarReporte.TabIndex = 5
        Me.tituloGenerarReporte.Text = "GENERAR REPORTE"
        Me.tituloGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botonAgregarArticulos
        '
        Me.botonAgregarArticulos.AutoSize = True
        Me.botonAgregarArticulos.BackColor = System.Drawing.Color.Black
        Me.botonAgregarArticulos.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonAgregarArticulos.ForeColor = System.Drawing.Color.White
        Me.botonAgregarArticulos.Location = New System.Drawing.Point(706, 65)
        Me.botonAgregarArticulos.Name = "botonAgregarArticulos"
        Me.botonAgregarArticulos.Size = New System.Drawing.Size(81, 34)
        Me.botonAgregarArticulos.TabIndex = 15
        Me.botonAgregarArticulos.Text = "GENERAR"
        Me.botonAgregarArticulos.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_Tabla_Generar_Reporte, Me.productos_Tabla_Generar_Reporte, Me.cantidad_Tabla_Generar_Reporte, Me.venta_Tabla_Generar_Reporte})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(764, 267)
        Me.DataGridView1.TabIndex = 16
        '
        'fecha_Tabla_Generar_Reporte
        '
        Me.fecha_Tabla_Generar_Reporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fecha_Tabla_Generar_Reporte.FillWeight = 35.0!
        Me.fecha_Tabla_Generar_Reporte.HeaderText = "FECHA"
        Me.fecha_Tabla_Generar_Reporte.Name = "fecha_Tabla_Generar_Reporte"
        Me.fecha_Tabla_Generar_Reporte.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'productos_Tabla_Generar_Reporte
        '
        Me.productos_Tabla_Generar_Reporte.HeaderText = "PRODUCTOS"
        Me.productos_Tabla_Generar_Reporte.Name = "productos_Tabla_Generar_Reporte"
        '
        'cantidad_Tabla_Generar_Reporte
        '
        Me.cantidad_Tabla_Generar_Reporte.HeaderText = "CANTIDAD"
        Me.cantidad_Tabla_Generar_Reporte.Name = "cantidad_Tabla_Generar_Reporte"
        '
        'venta_Tabla_Generar_Reporte
        '
        Me.venta_Tabla_Generar_Reporte.HeaderText = "VENTA"
        Me.venta_Tabla_Generar_Reporte.Name = "venta_Tabla_Generar_Reporte"
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
        Me.botonRegresar_E_D1.TabIndex = 19
        Me.botonRegresar_E_D1.Text = "REGRESAR"
        Me.botonRegresar_E_D1.UseVisualStyleBackColor = False
        '
        'generarReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 541)
        Me.Controls.Add(Me.botonRegresar_E_D1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.botonAgregarArticulos)
        Me.Controls.Add(Me.tituloGenerarReporte)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "generarReporte"
        Me.Text = "GENERAR REPORTE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents tituloGenerarReporte As Label
    Friend WithEvents botonAgregarArticulos As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents fecha_Tabla_Generar_Reporte As DataGridViewTextBoxColumn
    Friend WithEvents productos_Tabla_Generar_Reporte As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_Tabla_Generar_Reporte As DataGridViewTextBoxColumn
    Friend WithEvents venta_Tabla_Generar_Reporte As DataGridViewTextBoxColumn
    Friend WithEvents botonRegresar_E_D1 As Button
End Class
