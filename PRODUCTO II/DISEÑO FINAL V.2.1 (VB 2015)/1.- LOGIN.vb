Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cajaImagenLaTipica_Click(sender As Object, e As EventArgs) Handles cajaImagenLaTipica.Click

    End Sub

    Private Sub etiquetaUsuario_Click(sender As Object, e As EventArgs) Handles etiquetaUsuario.Click

    End Sub

    Private Sub iconoUsuario_Click(sender As Object, e As EventArgs) Handles iconoUsuario.Click

    End Sub

    Private Sub cajaDeTextoIngreseUsuario_TextChanged(sender As Object, e As EventArgs) Handles cajaDeTextoIngreseUsuario.TextChanged

    End Sub

    Private Sub etiquetaContrasena_Click(sender As Object, e As EventArgs) Handles etiquetaContrasena.Click

    End Sub

    Private Sub iconoContraseña_Click(sender As Object, e As EventArgs) Handles iconoContraseña.Click

    End Sub

    Private Sub cajaDeTextoIngreseContrasena_TextChanged(sender As Object, e As EventArgs) Handles cajaDeTextoIngreseContrasena.TextChanged

    End Sub

    Private Sub botonIniciarSesion_Click(sender As Object, e As EventArgs) Handles botonIniciarSesion.Click
        Dim usuario As String
        Dim clave As String
        usuario = cajaDeTextoIngreseUsuario.Text
        clave = cajaDeTextoIngreseContrasena.Text
        If (usuario = "laTipica") And (clave = "tipica") Then
            menuDueno.Show()
        Else
            MsgBox("ERROR: EL USUARIO Y/O LA CONTRASEÑA SON INCORRECTOS, INGRESE DATOS NUEVAMENTE")

        End If
    End Sub

End Class