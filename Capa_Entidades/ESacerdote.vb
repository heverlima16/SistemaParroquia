Public Class ESacerdote



    Private _IdSacerdote As Integer
    Private _IdParroquia As Integer
    Private _Sacerdote_Nombre As String

    Public Property IdSacerdote As Integer
        Get
            Return _IdSacerdote
        End Get
        Set(value As Integer)
            _IdSacerdote = value
        End Set
    End Property

    Public Property IdParroquia As Integer
        Get
            Return _IdParroquia
        End Get
        Set(value As Integer)
            _IdParroquia = value
        End Set
    End Property

    Public Property Sacerdote_Nombre As String
        Get
            Return _Sacerdote_Nombre
        End Get
        Set(value As String)
            _Sacerdote_Nombre = value
        End Set
    End Property
End Class
