Imports Oracle.DataAccess.Client
Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con()

    End Sub


    Public Function objetoDataAdapter() As DataSet

        Try
            Dim ds As New DataSet
            Dim check As Boolean = False
            Dim contraseña As String = ""
            Dim dap As New OracleDataAdapter("SELECT * FROM [Usuarios]", Cone)
            dap.Fill(ds)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If (ds.Tables(0).Rows(i).Item("USUARIO").Equals(cajaDeTextoIngreseUsuario.Text)) Then
                    ' MsgBox(ds.Tables(0).Rows(i).Item("USUARIO"))
                    'MsgBox(ds.Tables(0).Rows(i).Item("CLAVE"))
                    contraseña = ds.Tables(0).Rows(i).Item("CLAVE")
                    check = True
                    Exit For
                End If
            Next
            If Not check Then
                MsgBox("Usuario no existente")
                Return ds
            End If
            If Not contraseña.Equals(cajaDeTextoIngreseContrasena.Text) Then
                MsgBox("Contraseña Incorrecta")
                Return ds
            End If
            MsgBox("Login exitoso")
            menuDueno.Show()
            Me.Close()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try

    End Function




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

        objetoDataAdapter()

    End Sub

End Class