Public Class ERol
    Private _idrol As Integer
    Private _nombre As String

    Public Property Idrol As Integer
        Get
            Return _idrol
        End Get
        Set(value As Integer)
            _idrol = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
