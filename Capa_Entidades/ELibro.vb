Public Class ELibro
    Private _IdLibro As Integer
    Private _li_Numero As Integer
    Private _li_Anotaciones As String

    Public Property IdLibro As Integer
        Get
            Return _IdLibro
        End Get
        Set(value As Integer)
            _IdLibro = value
        End Set
    End Property

    Public Property Li_Numero As Integer
        Get
            Return _li_Numero
        End Get
        Set(value As Integer)
            _li_Numero = value
        End Set
    End Property

    Public Property Li_Anotaciones As String
        Get
            Return _li_Anotaciones
        End Get
        Set(value As String)
            _li_Anotaciones = value
        End Set
    End Property
End Class
