Imports Oracle.DataAccess.Client
Module Conexion
    Public Cone As OracleConnection

    Public Sub Con()
        Cone = New OracleConnection
        Cone.ConnectionString = "Data Source=desktop-emsni6m;User ID=LaTipica;Password=tipica;"
        Cone.Open()

    End Sub

End Module
