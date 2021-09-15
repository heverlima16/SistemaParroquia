Public Class EDistrito
    Private _IdDistrito As Integer
    Private _IdProvincia As Integer
    Private _Di_Nombre As String

    Public Property IdDistrito As Integer
        Get
            Return _IdDistrito
        End Get
        Set(value As Integer)
            _IdDistrito = value
        End Set
    End Property

    Public Property IdProvincia As Integer
        Get
            Return _IdProvincia
        End Get
        Set(value As Integer)
            _IdProvincia = value
        End Set
    End Property

    Public Property Di_Nombre As String
        Get
            Return _Di_Nombre
        End Get
        Set(value As String)
            _Di_Nombre = value
        End Set
    End Property
End Class
