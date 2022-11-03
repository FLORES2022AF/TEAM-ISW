Public Class menuDueno

    Private Sub menuDueno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub iconoPuntoVenta_D_1_Click(sender As Object, e As EventArgs) Handles iconoPuntoVenta_D_1.Click

    End Sub

    Private Sub botonPuntoDeVenta_D_Click(sender As Object, e As EventArgs) Handles botonPuntoDeVenta_D.Click

    End Sub

    Private Sub iconoGenerarPreLista__D_1_Click(sender As Object, e As EventArgs) Handles iconoGenerarPreLista__D_1.Click

    End Sub

    Private Sub botonGenerarPrelista_D_Click(sender As Object, e As EventArgs) Handles botonGenerarPrelista_D.Click
        generarPrelistaDeArticulos.Show()
        Me.Close()
    End Sub

    Private Sub iconoGestionarInventario__D_1_Click(sender As Object, e As EventArgs) Handles iconoGestionarInventario__D_1.Click

    End Sub

    Private Sub botonGestionarInventario_D_Click(sender As Object, e As EventArgs) Handles botonGestionarInventario_D.Click

    End Sub

    Private Sub iconoGestionarUsuario_D_1_Click(sender As Object, e As EventArgs) Handles iconoGestionarUsuario_D_1.Click

    End Sub

    Private Sub botonGestionarUsuario_D_Click(sender As Object, e As EventArgs) Handles botonGestionarUsuario_D.Click
        gestionarUsuario.Show()
        Me.Close()
    End Sub

    Private Sub botonCerrarSesion_D_Click(sender As Object, e As EventArgs) Handles botonCerrarSesion_D.Click
        If MsgBox("¿Deseas cerrar la sesion?", vbQuestion + vbYesNo, "Cerrando sesion") = vbYes Then
            Login.Show()
            Me.Close()

        End If
    End Sub

End Class