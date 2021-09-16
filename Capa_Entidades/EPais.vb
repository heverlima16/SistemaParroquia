Public Class EPais
    Private _IdPais As Integer
    Private _Pa_Nombre As String

    Public Property IdPais As Integer
        Get
            Return _IdPais
        End Get
        Set(value As Integer)
            _IdPais = value
        End Set
    End Property

    Public Property Pa_Nombre As String
        Get
            Return _Pa_Nombre
        End Get
        Set(value As String)
            _Pa_Nombre = value
        End Set
    End Property
End Class
