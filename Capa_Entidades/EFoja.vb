Public Class EFoja
    Private _IdFoja As Integer
    Private _Fo_Numero As Integer
    Private _Fo_Anotaciones As String

    Public Property IdFoja As Integer
        Get
            Return _IdFoja
        End Get
        Set(value As Integer)
            _IdFoja = value
        End Set
    End Property

    Public Property Fo_Numero As Integer
        Get
            Return _Fo_Numero
        End Get
        Set(value As Integer)
            _Fo_Numero = value
        End Set
    End Property

    Public Property Fo_Anotaciones As String
        Get
            Return _Fo_Anotaciones
        End Get
        Set(value As String)
            _Fo_Anotaciones = value
        End Set
    End Property
End Class
