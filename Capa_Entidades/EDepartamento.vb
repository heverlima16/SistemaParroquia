Public Class EDepartamento
    Private _IdDepartamento As Integer
    Private _IdPais As Integer
    Private _De_Nombre As String

    Public Property IdDepartamento As Integer
        Get
            Return _IdDepartamento
        End Get
        Set(value As Integer)
            _IdDepartamento = value
        End Set
    End Property

    Public Property IdPais As Integer
        Get
            Return _IdPais
        End Get
        Set(value As Integer)
            _IdPais = value
        End Set
    End Property

    Public Property De_Nombre As String
        Get
            Return _De_Nombre
        End Get
        Set(value As String)
            _De_Nombre = value
        End Set
    End Property
End Class
