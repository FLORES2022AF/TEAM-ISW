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
        CType(Me.tablReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconoGenerarReportePDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(23, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(677, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Tipo de reporte"
        '
        'tablReportes
        '
        Me.tablReportes.AllowUserToOrderColumns = True
        Me.tablReportes.BackgroundColor = System.Drawing.Color.Khaki
        Me.tablReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablReportes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_Tabla_Generar_Reporte, Me.productos_Tabla_Generar_Reporte, Me.cantidad_Tabla_Generar_Reporte, Me.venta_Tabla_Generar_Reporte})
        Me.tablReportes.Location = New System.Drawing.Point(23, 110)
        Me.tablReportes.Name = "tablReportes"
        Me.tablReportes.RowTemplate.Height = 25
        Me.tablReportes.Size = New System.Drawing.Size(782, 361)
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
        Me.botonGenerarReportePDF.BackColor = System.Drawing.Color.Green
        Me.botonGenerarReportePDF.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonGenerarReportePDF.ForeColor = System.Drawing.Color.Transparent
        Me.botonGenerarReportePDF.Location = New System.Drawing.Point(710, 79)
        Me.botonGenerarReportePDF.Name = "botonGenerarReportePDF"
        Me.botonGenerarReportePDF.Size = New System.Drawing.Size(95, 26)
        Me.botonGenerarReportePDF.TabIndex = 20
        Me.botonGenerarReportePDF.Text = "GENERAR PDF"
        Me.botonGenerarReportePDF.UseVisualStyleBackColor = False
        '
        'botonRegresarAPuntoDeVenta
        '
        Me.botonRegresarAPuntoDeVenta.AutoSize = True
        Me.botonRegresarAPuntoDeVenta.BackColor = System.Drawing.Color.Black
        Me.botonRegresarAPuntoDeVenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonRegresarAPuntoDeVenta.ForeColor = System.Drawing.Color.White
        Me.botonRegresarAPuntoDeVenta.Location = New System.Drawing.Point(12, 482)
        Me.botonRegresarAPuntoDeVenta.Name = "botonRegresarAPuntoDeVenta"
        Me.botonRegresarAPuntoDeVenta.Size = New System.Drawing.Size(110, 37)
        Me.botonRegresarAPuntoDeVenta.TabIndex = 21
        Me.botonRegresarAPuntoDeVenta.Text = "REGRESAR"
        Me.botonRegresarAPuntoDeVenta.UseVisualStyleBackColor = False
        '
        'iconoGenerarReportePDF
        '
        Me.iconoGenerarReportePDF.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.iconoGenerarReportePDF.IconChar = FontAwesome.Sharp.IconChar.Download
        Me.iconoGenerarReportePDF.IconColor = System.Drawing.Color.White
        Me.iconoGenerarReportePDF.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconoGenerarReportePDF.IconSize = 21
        Me.iconoGenerarReportePDF.Location = New System.Drawing.Point(776, 52)
        Me.iconoGenerarReportePDF.Name = "iconoGenerarReportePDF"
        Me.iconoGenerarReportePDF.Size = New System.Drawing.Size(29, 21)
        Me.iconoGenerarReportePDF.TabIndex = 31
        Me.iconoGenerarReportePDF.TabStop = False
        '
        'generarReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
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
End Class
