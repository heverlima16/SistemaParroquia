
Public Class EParroquia

    Private _Idparroquia As Integer
    Private _Pa_Nombre As String

    Public Property Idparroquia As Integer
        Get
            Return _Idparroquia
        End Get
        Set(value As Integer)
            _Idparroquia = value
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
