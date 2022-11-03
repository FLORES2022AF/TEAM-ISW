''Para trabajar con una base de datos en ORACLE
Imports Oracle.DataAccess.Client

Module Globales

    'Para trabajar con una base de datos ORACLE, es requerida
    ' para poder abrir y cerrar la BD

    Public cnx As OracleConnection

    'Estas variables son de MI AUTORIA, la razón para sarlas de manera global
    ' es que las uso en diferentes formularios, y así evito tener que definirlas
    ' o declararlas en cada formulario. la palabra clave para que trabaje como 
    ' global es Public, el tipo de datos, pues ya ustedes lo definen de acuerdo 
    ' a su necesidad


    Public id As Integer
    Public Usuario As String
    Public fecha As String
    Public idContraseña As String
    Public idColor As String
    Public idMarca As String
    Public idTipoMulta As String
    Public idUsuario As String
    Public idNumlic As String
    Public fechaven As String
    Public clave As String
    Public idGenero As String
    Public departamento As String
    Public placa As String
    Public numLic As String
    Public idTipoVehiculo As String
    Public precio As String
    Public idVehiculo As String
    Public idNombre As String
    Public idPaterno As String
    Public idMaterno As String
    Public Materno As String
    Public Paterno As String
    Public idPais As String
    Public miPais As Integer
    Public miPlaca As String
    Public miTipoVehiculo As String
    Public miColor As Integer
    Public miTipoMulta As Integer
    Public miMarca As Integer
    Public miUsuario As Integer
    Public miVehiculo As Integer
    Public idMulta As String
    Public idEstado As String
    Public miEstado As Integer
    Public miMulta As String
    Public idCiudad As String
    Public miCiudad As Integer
    Public idColonia As String
    Public miColonia As Integer
    Public miGenero As Integer
    Public miNumLic As Integer
    Public colNueva As String
    Public UsuarioConectado As String
    Public El_Nombre As String
    Public ElCorreo As String
    Public idClase As String
    Public idEquipo As String
    Public Eldbms As String

End Module