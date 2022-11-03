Imports Oracle.DataAccess.Client
Public Class gestionarUsuario



    Public Sub InsertarUsuario()
        'Dim sqlcmd As New OracleCommand("INSERT INTO usuarios (id,correo,password) VALUES  (2,'sd','asd@s.com')", Cone)

        Dim command As New OracleCommand
        command.Connection = Cone
        'Cone.BeginTransaction()


        Try
            command.CommandText = "INSERT  INTO Usuarios VALUES (" & ingreseId.Text & ",'" & ingreseNombreUsuario.Text & "','" & ingreseApellidoPaternoUsuario.Text & "','" & ingreseApellidoMaternoUsuario.Text & "','" & ingreseUsuario.Text & "','" & ingreseClave.Text & "','" & ingreseTipodeUsuario.Text & "')"
            command.ExecuteNonQuery()
            MsgBox("Usuario creado con exito")

        Catch ex As Exception
            MsgBox(ex.ToString)
            'Throw New Exception("Error: " & ex.Message)
            If (ex.ToString.Contains("unique")) Then
                MsgBox("Llave Primaria Duplicada")
            End If
            If (ex.ToString.Contains("missing" Or "NULL")) Then
                MsgBox("No se puede insertar, existen campos vacios")
            End If
            if(Len(ingreseId.Text) < 4 or  Len(ingreseId.Text) > 8) Then
                MsgBox("El id debe contener al menos 4 caracteres y no debe de excederse de 8 caracteres")
            End If
            Dim bool as boolean = false
            For x As Integer = 1 to Len(ingreseNombreUsuario.Text)
                if isNumeric(mid(ingreseNombreUsuario.Text),x,1) Then
                    bool = true;
            if(bool){
                Throw New Exception("Error: " & "El nombre de usuario no debe contener numeros")                
            }
            End If
            Dim bool as boolean = false
            For x As Integer = 1 to Len(ingreseApellidoPaternoUsuario.Text)
                if isNumeric(mid(ingreseApellidoPaternoUsuario.Text),x,1) Then
                    bool = true;
            if(bool){
                Throw New Exception("Error: " & "El apellido paterno de usuario no debe contener numeros") 
            }
            End If
            Dim bool as boolean = false
            For x As Integer = 1 to Len(ingreseApellidoMaternoUsuario.Text)
                if isNumeric(mid(ingreseApellidoMaternoUsuario.Text),x,1) Then
                    bool = true;
            if(bool){
                Throw New Exception("Error: " & "El apellido materno de usuario no debe contener numeros") 
            }
            End If
                if isNumeric(mid(ingreseUsuario.Text),0,1) Then
                   Throw New Exception("Error: " & "El usuario no debe iniciar por un numero") 
                End If
            End If
            

            

        End Try

    End Sub
    Private Sub gestionarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub




    Private Sub buscadorDeUsuarios_TextChanged(sender As Object, e As EventArgs) Handles buscadorDeUsuarios.TextChanged

    End Sub

    Private Sub iconoBuscarUsuario_Click(sender As Object, e As EventArgs) Handles iconoBuscarUsuario.Click

    End Sub

    Private Sub botonBuscarUsuario_Click(sender As Object, e As EventArgs) Handles botonBuscarUsuario.Click

        Try

            Dim dap As New OracleDataAdapter("SELECT * FROM Usuarios WHERE ID_USUARIOS = " & Me.buscadorDeUsuarios.Text & "", Cone)
            Dim ds As New DataSet

            dap.Fill(ds, "Usuarios")

            Me.ingreseId.Text = ds.Tables("Usuarios").Rows(0).Item(0)
            Me.ingreseNombreUsuario.Text = ds.Tables("Usuarios").Rows(0).Item(1)
            Me.ingreseApellidoPaternoUsuario.Text = ds.Tables("Usuarios").Rows(0).Item(2)
            Me.ingreseApellidoMaternoUsuario.Text = ds.Tables("Usuarios").Rows(0).Item(3)
            Me.ingreseUsuario.Text = ds.Tables("Usuarios").Rows(0).Item(4)
            Me.ingreseClave.Text = ds.Tables("Usuarios").Rows(0).Item(5)
            Me.ingreseTipodeUsuario.Text = ds.Tables("Usuarios").Rows(0).Item(6)
            MsgBox("Usuario Encontrado")
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub etiquetaNombreUsuario_Click(sender As Object, e As EventArgs) Handles etiquetaNombreUsuario.Click

    End Sub

    Private Sub ingreseNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles ingreseNombreUsuario.TextChanged

    End Sub

    Private Sub etiquetaApellidoPaternoUsuario_Click(sender As Object, e As EventArgs) Handles etiquetaApellidoPaternoUsuario.Click

    End Sub

    Private Sub ingreseApellidoPaternoUsuario_TextChanged(sender As Object, e As EventArgs) Handles ingreseApellidoPaternoUsuario.TextChanged

    End Sub

    Private Sub etiquetaApellidoMaternoUsuario_Click(sender As Object, e As EventArgs) Handles etiquetaApellidoMaternoUsuario.Click

    End Sub

    Private Sub ingreseApellidoMaternoUsuario_TextChanged(sender As Object, e As EventArgs) Handles ingreseApellidoMaternoUsuario.TextChanged

    End Sub

    Private Sub etiquetaUsuario_GU_Click(sender As Object, e As EventArgs) Handles etiquetaUsuario_GU.Click

    End Sub

    Private Sub ingreseUsuario_TextChanged(sender As Object, e As EventArgs) Handles ingreseUsuario.TextChanged

    End Sub

    Private Sub botonDarDeAltaUsuario_Click(sender As Object, e As EventArgs) Handles botonDarDeAltaUsuario.Click
        InsertarUsuario()
        ingreseId.Clear()
        ingreseNombreUsuario.Clear()
        ingreseApellidoPaternoUsuario.Clear()
        ingreseApellidoMaternoUsuario.Clear()
        ingreseUsuario.Clear()
        ingreseClave.Clear()
        ingreseTipodeUsuario.Clear()
    End Sub

    Private Sub botonModificarUsuario_Click(sender As Object, e As EventArgs) Handles botonModificarUsuario.Click
        If Cone.State = ConnectionState.Closed Then
            Cone.Open()
        End If
        Try

            Dim command As New OracleCommand("UPDATE Usuarios SET NOMBRE='" & Me.ingreseNombreUsuario.Text & "', A_PATERNO='" & Me.ingreseApellidoPaternoUsuario.Text & "',A_MATERNO='" & Me.ingreseApellidoMaternoUsuario.Text & "',USUARIO='" & Me.ingreseUsuario.Text & "',CLAVE='" & Me.ingreseClave.Text & "',T_USUARIO='" & Me.ingreseTipodeUsuario.Text & "' WHERE ID_USUARIOS=" & Me.ingreseId.Text & "", Cone)
        command.ExecuteNonQuery()

        If MsgBox("¿Seguro que quiere guardar cambios?", vbQuestion + vbYesNo, "Usuario modificado con exito") = vbYes Then
            MsgBox("Usuario modificado con exito")
            Me.Show()
        End If
        Catch ex As Exception
        MsgBox(ex.ToString)
        'Throw New Exception("Error: " & ex.Message)
        If (ex.ToString.Contains("unique")) Then
            MsgBox("Llave Primaria Duplicada")
        End If
        If (ex.ToString.Contains("missing" Or "NULL")) Then
            MsgBox("No se puede insertar, existen campos vacios")
        End If
        If Cone.State = ConnectionState.Open Then
            Cone.Close()
        End If
        End Try
    End Sub

    Private Sub botonBorrarUsuario_Click(sender As Object, e As EventArgs) Handles botonBorrarUsuario.Click
        ' If Cone.State = ConnectionState.Closed Then
        'Cone.Open()
        'End If
        Dim command As New OracleCommand("DELETE FROM Usuarios WHERE ID_USUARIOS=" & Me.ingreseId.Text & "", Cone)
        command.ExecuteNonQuery()

        If MsgBox("¿Seguro que quiere eliminar este usuario?", vbQuestion + vbYesNo, "Usuario eliminado con exito") = vbYes Then
            MsgBox("Usuario eliminado con exito")
            Me.Show()
        End If

        ingreseId.Clear()
        ingreseNombreUsuario.Clear()
        ingreseApellidoPaternoUsuario.Clear()
        ingreseApellidoMaternoUsuario.Clear()
        ingreseUsuario.Clear()
        ingreseClave.Clear()
        ingreseTipodeUsuario.Clear()
    End Sub

    Private Sub botonRegresarAGenerarReporte_Click(sender As Object, e As EventArgs) Handles botonRegresarAGenerarReporte.Click
        menuDueno.Show()
        Me.Close()

    End Sub

    Private Sub clave_Click(sender As Object, e As EventArgs) Handles clave.Click

    End Sub

    Private Sub ingreseClave_TextChanged(sender As Object, e As EventArgs) Handles ingreseClave.TextChanged

    End Sub

    Private Sub ingreseId_TextChanged(sender As Object, e As EventArgs) Handles ingreseId.TextChanged

    End Sub

    Private Sub TUsuario_Click(sender As Object, e As EventArgs) Handles tipoUsuario.Click

    End Sub
Private Sub ingreseTipodeUsuario_TextChanged(sender As Object, e As EventArgs) Handles ingreseTipodeUsuario.TextChanged

    End Sub
End Class