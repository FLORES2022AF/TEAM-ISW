Imports Oracle.DataAccess.Client

Public Class log
    'Variables de instancia de la Clase
    Private id As Integer
    Private usuario As String
    Private clave As String

    'Método constructor inicializa variables
    Public Sub New()
        usuario = ""
        clave = ""

    End Sub


    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal us As String, ByVal cla As String)
        'Aquí recibimos los datos
        usuario = us
        clave = cla
    End Sub

    'Metodos get y set
    Public Function getUsuario()
        Return Me.usuario
    End Function
    Public Property getSetUsuario() As String
        Get
            Return usuario
        End Get
        Set(ByVal Value As String)
            usuario = Value
        End Set
    End Property

    Public Property getSetClave() As String
        Get
            Return clave
        End Get
        Set(ByVal Value As String)
            clave = Value
        End Set
    End Property

    Public Function getId()
        Return Me.id
    End Function

    Public Function existeUsuario() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        strSQL = "SELECT * FROM usuario " &
                 "WHERE nombre='" & usuario & "' and clave ='" & clave & "' "
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
