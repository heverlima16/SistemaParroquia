Public Class ECMatrimonio

    Private _IdPMatrimonio As Integer
    Private _IdLibro As Integer
    Private _IdFoja As Integer
    Private _Ma_Numero As Integer
    Private _Ma_NEsposo As String
    Private _Ma_LEsposo As String
    Private _Ma_FNEsposo As Date
    Private _Ma_NEsposa As String
    Private _Ma_LEsposa As String
    Private _Ma_FNEsposa As Date
    Private _idsacerdote As Integer
    Private _IdParroquiaBautizado As Integer
    Private _Ma_NPadreEsposo As String
    Private _Ma_NPadreEsposa As String
    Private _Ma_NMadreEsposo As String
    Private _Ma_NMadreEsposa As String
    Private _Ma_NPadrino As String
    Private _Ma_LMatrimonio As String
    Private _Ma_FMatrimonio As Date
    Private _Ma_AnotacionesTextuales As String

    Public Property IdPMatrimonio As Integer
        Get
            Return _IdPMatrimonio
        End Get
        Set(value As Integer)
            _IdPMatrimonio = value
        End Set
    End Property

    Public Property IdLibro As Integer
        Get
            Return _IdLibro
        End Get
        Set(value As Integer)
            _IdLibro = value
        End Set
    End Property

    Public Property IdFoja As Integer
        Get
            Return _IdFoja
        End Get
        Set(value As Integer)
            _IdFoja = value
        End Set
    End Property

    Public Property Ma_Numero As Integer
        Get
            Return _Ma_Numero
        End Get
        Set(value As Integer)
            _Ma_Numero = value
        End Set
    End Property

    Public Property Ma_NEsposo As String
        Get
            Return _Ma_NEsposo
        End Get
        Set(value As String)
            _Ma_NEsposo = value
        End Set
    End Property

    Public Property Ma_LEsposo As String
        Get
            Return _Ma_LEsposo
        End Get
        Set(value As String)
            _Ma_LEsposo = value
        End Set
    End Property

    Public Property Ma_FNEsposo As Date
        Get
            Return _Ma_FNEsposo
        End Get
        Set(value As Date)
            _Ma_FNEsposo = value
        End Set
    End Property

    Public Property Ma_NEsposa As String
        Get
            Return _Ma_NEsposa
        End Get
        Set(value As String)
            _Ma_NEsposa = value
        End Set
    End Property

    Public Property Ma_LEsposa As String
        Get
            Return _Ma_LEsposa
        End Get
        Set(value As String)
            _Ma_LEsposa = value
        End Set
    End Property

    Public Property Ma_FNEsposa As Date
        Get
            Return _Ma_FNEsposa
        End Get
        Set(value As Date)
            _Ma_FNEsposa = value
        End Set
    End Property

    Public Property Idsacerdote As Integer
        Get
            Return _idsacerdote
        End Get
        Set(value As Integer)
            _idsacerdote = value
        End Set
    End Property

    Public Property IdParroquiaBautizado As Integer
        Get
            Return _IdParroquiaBautizado
        End Get
        Set(value As Integer)
            _IdParroquiaBautizado = value
        End Set
    End Property

    Public Property Ma_NPadreEsposo As String
        Get
            Return _Ma_NPadreEsposo
        End Get
        Set(value As String)
            _Ma_NPadreEsposo = value
        End Set
    End Property

    Public Property Ma_NPadreEsposa As String
        Get
            Return _Ma_NPadreEsposa
        End Get
        Set(value As String)
            _Ma_NPadreEsposa = value
        End Set
    End Property

    Public Property Ma_NMadreEsposo As String
        Get
            Return _Ma_NMadreEsposo
        End Get
        Set(value As String)
            _Ma_NMadreEsposo = value
        End Set
    End Property

    Public Property Ma_NMadreEsposa As String
        Get
            Return _Ma_NMadreEsposa
        End Get
        Set(value As String)
            _Ma_NMadreEsposa = value
        End Set
    End Property

    Public Property Ma_NPadrino As String
        Get
            Return _Ma_NPadrino
        End Get
        Set(value As String)
            _Ma_NPadrino = value
        End Set
    End Property

    Public Property Ma_LMatrimonio As String
        Get
            Return _Ma_LMatrimonio
        End Get
        Set(value As String)
            _Ma_LMatrimonio = value
        End Set
    End Property

    Public Property Ma_FMatrimonio As Date
        Get
            Return _Ma_FMatrimonio
        End Get
        Set(value As Date)
            _Ma_FMatrimonio = value
        End Set
    End Property

    Public Property Ma_AnotacionesTextuales As String
        Get
            Return _Ma_AnotacionesTextuales
        End Get
        Set(value As String)
            _Ma_AnotacionesTextuales = value
        End Set
    End Property
End Class


