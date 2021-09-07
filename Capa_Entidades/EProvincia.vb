Public Class EProvincia
    Private _IdProvincia As Integer
    Private _IdDepartamento As Integer
    Private _Pro_Nombre As String

    Public Property IdProvincia As Integer
        Get
            Return _IdProvincia
        End Get
        Set(value As Integer)
            _IdProvincia = value
        End Set
    End Property

    Public Property IdDepartamento As Integer
        Get
            Return _IdDepartamento
        End Get
        Set(value As Integer)
            _IdDepartamento = value
        End Set
    End Property

    Public Property Pro_Nombre As String
        Get
            Return _Pro_Nombre
        End Get
        Set(value As String)
            _Pro_Nombre = value
        End Set
    End Property
End Class
