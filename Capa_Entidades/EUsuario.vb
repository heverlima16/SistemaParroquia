Public Class EUsuario
#Region "campos"
    Private _IdUsuario As Integer
    Private _IdRol As Integer
    Private _Usuario_Nombre As String
    Private _Usuario_NickName As String
    Private _Usuario_Clave As String
    Private _Usuario_Rol As String

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Public Property IdRol As Integer
        Get
            Return _IdRol
        End Get
        Set(value As Integer)
            _IdRol = value
        End Set
    End Property

    Public Property Usuario_Nombre As String
        Get
            Return _Usuario_Nombre
        End Get
        Set(value As String)
            _Usuario_Nombre = value
        End Set
    End Property

    Public Property Usuario_NickName As String
        Get
            Return _Usuario_NickName
        End Get
        Set(value As String)
            _Usuario_NickName = value
        End Set
    End Property

    Public Property Usuario_Clave As String
        Get
            Return _Usuario_Clave
        End Get
        Set(value As String)
            _Usuario_Clave = value
        End Set
    End Property

    Public Property Usuario_Rol As String
        Get
            Return _Usuario_Rol
        End Get
        Set(value As String)
            _Usuario_Rol = value
        End Set
    End Property
#End Region
End Class
