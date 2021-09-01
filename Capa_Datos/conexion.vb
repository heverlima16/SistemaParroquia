Imports System.Data.SqlClient
Public Class conexion

    Private _BD As String
    Private _Servidor As String
    Private _Usuario As String
    Private _Clave As String
    Private _Seguridad As Boolean = True
    Public conn As SqlConnection

    ''Encapsulacion de codigo.
    Public Property BD As String
        Get
            Return _BD
        End Get
        Set(value As String)
            _BD = value
        End Set
    End Property

    Public Property Servidor As String
        Get
            Return _Servidor
        End Get
        Set(value As String)
            _Servidor = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _Clave
        End Get
        Set(value As String)
            _Clave = value
        End Set
    End Property

    Public Property Seguridad As String
        Get
            Return _Seguridad
        End Get
        Set(value As String)
            _Seguridad = value
        End Set
    End Property

    ''Fin de Encapsulacion de codigo.


    Public Sub New()
        Me.BD = "DB_Parroquia"
        Me.Servidor = "PC-HEVER"
        Me.Usuario = "sa"
        Me.Clave = "root"
        Me.conn = New SqlConnection(CrearCadena)
    End Sub

    Public Function CrearCadena() As String
        Dim cadena As String
        cadena = "Server=" & Me.Servidor & "; Database=" & Me.BD & ";"
        If Me.Seguridad Then
            '' Auth de Windows
            cadena = cadena & "Integrated Security=SSPI"
        Else
            '' auth de sql server
            cadena = cadena & "User Id=" & Me.Usuario & "; Password=" & Me.Clave
        End If
        Return cadena

    End Function
End Class
