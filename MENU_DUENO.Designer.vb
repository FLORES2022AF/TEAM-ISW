<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuDueno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuDueno))
        Me.botonPuntoDeVenta = New System.Windows.Forms.Button()
        Me.botonGestionarUsuario = New System.Windows.Forms.Button()
        Me.botonGestionarInventario = New System.Windows.Forms.Button()
        Me.botonGenerarPrelistaDeProductos = New System.Windows.Forms.Button()
        Me.tituloMenuDueno = New System.Windows.Forms.Label()
        Me.botonRegresar1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'botonPuntoDeVenta
        '
        Me.botonPuntoDeVenta.BackColor = System.Drawing.Color.Black
        Me.botonPuntoDeVenta.Font = New System.Drawing.Font("Agency FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonPuntoDeVenta.ForeColor = System.Drawing.Color.White
        Me.botonPuntoDeVenta.Location = New System.Drawing.Point(115, 166)
        Me.botonPuntoDeVenta.Name = "botonPuntoDeVenta"
        Me.botonPuntoDeVenta.Size = New System.Drawing.Size(181, 139)
        Me.botonPuntoDeVenta.TabIndex = 0
        Me.botonPuntoDeVenta.Text = "PUNTO DE VENTA"
        Me.botonPuntoDeVenta.UseVisualStyleBackColor = False
        '
        'botonGestionarUsuario
        '
        Me.botonGestionarUsuario.BackColor = System.Drawing.Color.Black
        Me.botonGestionarUsuario.Font = New System.Drawing.Font("Agency FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonGestionarUsuario.ForeColor = System.Drawing.Color.White
        Me.botonGestionarUsuario.Location = New System.Drawing.Point(302, 166)
        Me.botonGestionarUsuario.Name = "botonGestionarUsuario"
        Me.botonGestionarUsuario.Size = New System.Drawing.Size(181, 139)
        Me.botonGestionarUsuario.TabIndex = 1
        Me.botonGestionarUsuario.Text = "GESTIONAR USUARIO"
        Me.botonGestionarUsuario.UseVisualStyleBackColor = False
        '
        'botonGestionarInventario
        '
        Me.botonGestionarInventario.BackColor = System.Drawing.Color.Black
        Me.botonGestionarInventario.Font = New System.Drawing.Font("Agency FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonGestionarInventario.ForeColor = System.Drawing.Color.White
        Me.botonGestionarInventario.Location = New System.Drawing.Point(115, 311)
        Me.botonGestionarInventario.Name = "botonGestionarInventario"
        Me.botonGestionarInventario.Size = New System.Drawing.Size(181, 139)
        Me.botonGestionarInventario.TabIndex = 2
        Me.botonGestionarInventario.Text = "GESTIONAR INVENTARIO"
        Me.botonGestionarInventario.UseVisualStyleBackColor = False
        '
        'botonGenerarPrelistaDeProductos
        '
        Me.botonGenerarPrelistaDeProductos.BackColor = System.Drawing.Color.Black
        Me.botonGenerarPrelistaDeProductos.Font = New System.Drawing.Font("Agency FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonGenerarPrelistaDeProductos.ForeColor = System.Drawing.Color.White
        Me.botonGenerarPrelistaDeProductos.Location = New System.Drawing.Point(302, 311)
        Me.botonGenerarPrelistaDeProductos.Name = "botonGenerarPrelistaDeProductos"
        Me.botonGenerarPrelistaDeProductos.Size = New System.Drawing.Size(181, 139)
        Me.botonGenerarPrelistaDeProductos.TabIndex = 3
        Me.botonGenerarPrelistaDeProductos.Text = "GENERAR PRELISTA DE PRODUCTOS"
        Me.botonGenerarPrelistaDeProductos.UseVisualStyleBackColor = False
        '
        'tituloMenuDueno
        '
        Me.tituloMenuDueno.BackColor = System.Drawing.Color.Transparent
        Me.tituloMenuDueno.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tituloMenuDueno.Location = New System.Drawing.Point(115, 9)
        Me.tituloMenuDueno.Name = "tituloMenuDueno"
        Me.tituloMenuDueno.Size = New System.Drawing.Size(368, 121)
        Me.tituloMenuDueno.TabIndex = 4
        Me.tituloMenuDueno.Text = "MENÚ PRINCIPAL (DUEÑO)"
        Me.tituloMenuDueno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botonRegresar1
        '
        Me.botonRegresar1.AutoSize = True
        Me.botonRegresar1.BackColor = System.Drawing.Color.Black
        Me.botonRegresar1.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonRegresar1.ForeColor = System.Drawing.Color.White
        Me.botonRegresar1.Location = New System.Drawing.Point(25, 507)
        Me.botonRegresar1.Name = "botonRegresar1"
        Me.botonRegresar1.Size = New System.Drawing.Size(81, 34)
        Me.botonRegresar1.TabIndex = 5
        Me.botonRegresar1.Text = "REGRESAR"
        Me.botonRegresar1.UseVisualStyleBackColor = False
        '
        'menuDueno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(574, 571)
        Me.Controls.Add(Me.botonRegresar1)
        Me.Controls.Add(Me.tituloMenuDueno)
        Me.Controls.Add(Me.botonGenerarPrelistaDeProductos)
        Me.Controls.Add(Me.botonGestionarInventario)
        Me.Controls.Add(Me.botonGestionarUsuario)
        Me.Controls.Add(Me.botonPuntoDeVenta)
        Me.Name = "menuDueno"
        Me.Text = "MENU DUEÑO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonPuntoDeVenta As Button
    Friend WithEvents botonGestionarUsuario As Button
    Friend WithEvents botonGestionarInventario As Button
    Friend WithEvents botonGenerarPrelistaDeProductos As Button
    Friend WithEvents tituloMenuDueno As Label
    Friend WithEvents botonRegresar1 As Button
End Class
