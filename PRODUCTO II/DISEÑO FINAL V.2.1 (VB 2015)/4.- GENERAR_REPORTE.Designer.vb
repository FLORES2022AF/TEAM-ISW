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
        Me.tablReportes = New System.Windows.Forms.DataGridView()
        Me.fecha_Tabla_Generar_Reporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productos_Tabla_Generar_Reporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_Tabla_Generar_Reporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venta_Tabla_Generar_Reporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botonGenerarReportePDF = New System.Windows.Forms.Button()
        Me.botonRegresarAPuntoDeVenta = New System.Windows.Forms.Button()
        Me.iconoGenerarReportePDF = New FontAwesome.Sharp.IconPictureBox()
        Me.barraDeslizante_GR = New System.Windows.Forms.VScrollBar()
        CType(Me.tablReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoGenerarReportePDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(17, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(785, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Tipo de reporte"
        '
        'tablReportes
        '
        Me.tablReportes.AllowUserToAddRows = False
        Me.tablReportes.AllowUserToOrderColumns = True
        Me.tablReportes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.tablReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablReportes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_Tabla_Generar_Reporte, Me.productos_Tabla_Generar_Reporte, Me.cantidad_Tabla_Generar_Reporte, Me.venta_Tabla_Generar_Reporte})
        Me.tablReportes.Location = New System.Drawing.Point(17, 163)
        Me.tablReportes.Name = "tablReportes"
        Me.tablReportes.RowTemplate.Height = 25
        Me.tablReportes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tablReportes.Size = New System.Drawing.Size(785, 198)
        Me.tablReportes.TabIndex = 16
        '
        'fecha_Tabla_Generar_Reporte
        '
        Me.fecha_Tabla_Generar_Reporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.fecha_Tabla_Generar_Reporte.FillWeight = 35.0!
        Me.fecha_Tabla_Generar_Reporte.HeaderText = "FECHA"
        Me.fecha_Tabla_Generar_Reporte.Name = "fecha_Tabla_Generar_Reporte"
        Me.fecha_Tabla_Generar_Reporte.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fecha_Tabla_Generar_Reporte.Width = 150
        '
        'productos_Tabla_Generar_Reporte
        '
        Me.productos_Tabla_Generar_Reporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.productos_Tabla_Generar_Reporte.HeaderText = "PRODUCTOS"
        Me.productos_Tabla_Generar_Reporte.Name = "productos_Tabla_Generar_Reporte"
        Me.productos_Tabla_Generar_Reporte.Width = 350
        '
        'cantidad_Tabla_Generar_Reporte
        '
        Me.cantidad_Tabla_Generar_Reporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.cantidad_Tabla_Generar_Reporte.HeaderText = "CANTIDAD"
        Me.cantidad_Tabla_Generar_Reporte.Name = "cantidad_Tabla_Generar_Reporte"
        Me.cantidad_Tabla_Generar_Reporte.Width = 90
        '
        'venta_Tabla_Generar_Reporte
        '
        Me.venta_Tabla_Generar_Reporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.venta_Tabla_Generar_Reporte.HeaderText = "VENTA"
        Me.venta_Tabla_Generar_Reporte.Name = "venta_Tabla_Generar_Reporte"
        Me.venta_Tabla_Generar_Reporte.Width = 150
        '
        'botonGenerarReportePDF
        '
        Me.botonGenerarReportePDF.AutoSize = True
        Me.botonGenerarReportePDF.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonGenerarReportePDF.Font = New System.Drawing.Font("Californian FB", 11.25!)
        Me.botonGenerarReportePDF.ForeColor = System.Drawing.Color.Transparent
        Me.botonGenerarReportePDF.Location = New System.Drawing.Point(685, 367)
        Me.botonGenerarReportePDF.Name = "botonGenerarReportePDF"
        Me.botonGenerarReportePDF.Size = New System.Drawing.Size(117, 28)
        Me.botonGenerarReportePDF.TabIndex = 20
        Me.botonGenerarReportePDF.Text = "GENERAR PDF"
        Me.botonGenerarReportePDF.UseVisualStyleBackColor = False
        '
        'botonRegresarAPuntoDeVenta
        '
        Me.botonRegresarAPuntoDeVenta.AutoSize = True
        Me.botonRegresarAPuntoDeVenta.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botonRegresarAPuntoDeVenta.Font = New System.Drawing.Font("Californian FB", 15.0!)
        Me.botonRegresarAPuntoDeVenta.ForeColor = System.Drawing.Color.White
        Me.botonRegresarAPuntoDeVenta.Location = New System.Drawing.Point(12, 485)
        Me.botonRegresarAPuntoDeVenta.Name = "botonRegresarAPuntoDeVenta"
        Me.botonRegresarAPuntoDeVenta.Size = New System.Drawing.Size(120, 34)
        Me.botonRegresarAPuntoDeVenta.TabIndex = 21
        Me.botonRegresarAPuntoDeVenta.Text = "REGRESAR"
        Me.botonRegresarAPuntoDeVenta.UseVisualStyleBackColor = False
        '
        'iconoGenerarReportePDF
        '
        Me.iconoGenerarReportePDF.BackColor = System.Drawing.Color.Transparent
        Me.iconoGenerarReportePDF.ForeColor = System.Drawing.Color.Black
        Me.iconoGenerarReportePDF.IconChar = FontAwesome.Sharp.IconChar.Download
        Me.iconoGenerarReportePDF.IconColor = System.Drawing.Color.Black
        Me.iconoGenerarReportePDF.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoGenerarReportePDF.IconSize = 26
        Me.iconoGenerarReportePDF.Location = New System.Drawing.Point(653, 367)
        Me.iconoGenerarReportePDF.Name = "iconoGenerarReportePDF"
        Me.iconoGenerarReportePDF.Size = New System.Drawing.Size(26, 26)
        Me.iconoGenerarReportePDF.TabIndex = 31
        Me.iconoGenerarReportePDF.TabStop = False
        '
        'barraDeslizante_GR
        '
        Me.barraDeslizante_GR.Location = New System.Drawing.Point(777, 186)
        Me.barraDeslizante_GR.Name = "barraDeslizante_GR"
        Me.barraDeslizante_GR.Size = New System.Drawing.Size(10, 159)
        Me.barraDeslizante_GR.TabIndex = 32
        '
        'generarReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.barraDeslizante_GR)
        Me.Controls.Add(Me.iconoGenerarReportePDF)
        Me.Controls.Add(Me.botonRegresarAPuntoDeVenta)
        Me.Controls.Add(Me.botonGenerarReportePDF)
        Me.Controls.Add(Me.tablReportes)
        Me.Controls.Add(Me.ComboBox1)
        Me.DoubleBuffered = True
        Me.Name = "generarReporte"
        Me.Text = "GENERAR REPORTE"
        CType(Me.tablReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconoGenerarReportePDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents tablReportes As DataGridView
    Friend WithEvents botonGenerarReportePDF As Button
    Friend WithEvents botonRegresarAPuntoDeVenta As Button
    Friend WithEvents iconoGenerarReportePDF As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents fecha_Tabla_Generar_Reporte As DataGridViewTextBoxColumn
    Friend WithEvents productos_Tabla_Generar_Reporte As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_Tabla_Generar_Reporte As DataGridViewTextBoxColumn
    Friend WithEvents venta_Tabla_Generar_Reporte As DataGridViewTextBoxColumn
    Friend WithEvents barraDeslizante_GR As VScrollBar
End Class
