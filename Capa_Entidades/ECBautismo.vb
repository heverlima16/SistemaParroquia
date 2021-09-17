Public Class ECBautismo

    Private _IdPBautismo As Integer
    Private _IdLibro As Integer
    Private _IdFoja As Integer
    Private _Ba_Numero As Integer
    Private _Ba_Nombre As String
    Private _Ba_Apellido As String
    Private _Ba_LNacimiento As String
    Private _Ba_FNacimiento As Date
    Private _idsacerdote As Integer
    Private _IdParroquiaBautizado As Integer
    Private _Ba_NPadre As String
    Private _Ba_NMadre As String
    Private _Ba_NPadrino As String
    Private _Ba_LBautismo As String
    Private _Ba_FBautismo As Date
    Private _Ba_AnotacionesTextuales As String

    Public Property IdPBautismo As Integer
        Get
            Return _IdPBautismo
        End Get
        Set(value As Integer)
            _IdPBautismo = value
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

    Public Property Ba_Numero As Integer
        Get
            Return _Ba_Numero
        End Get
        Set(value As Integer)
            _Ba_Numero = value
        End Set
    End Property

    Public Property Ba_Nombre As String
        Get
            Return _Ba_Nombre
        End Get
        Set(value As String)
            _Ba_Nombre = value
        End Set
    End Property

    Public Property Ba_Apellido As String
        Get
            Return _Ba_Apellido
        End Get
        Set(value As String)
            _Ba_Apellido = value
        End Set
    End Property

    Public Property Ba_LNacimiento As String
        Get
            Return _Ba_LNacimiento
        End Get
        Set(value As String)
            _Ba_LNacimiento = value
        End Set
    End Property

    Public Property Ba_FNacimiento As Date
        Get
            Return _Ba_FNacimiento
        End Get
        Set(value As Date)
            _Ba_FNacimiento = value
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

    Public Property Ba_NPadre As String
        Get
            Return _Ba_NPadre
        End Get
        Set(value As String)
            _Ba_NPadre = value
        End Set
    End Property

    Public Property Ba_NMadre As String
        Get
            Return _Ba_NMadre
        End Get
        Set(value As String)
            _Ba_NMadre = value
        End Set
    End Property

    Public Property Ba_NPadrino As String
        Get
            Return _Ba_NPadrino
        End Get
        Set(value As String)
            _Ba_NPadrino = value
        End Set
    End Property

    Public Property Ba_LBautismo As String
        Get
            Return _Ba_LBautismo
        End Get
        Set(value As String)
            _Ba_LBautismo = value
        End Set
    End Property

    Public Property Ba_FBautismo As Date
        Get
            Return _Ba_FBautismo
        End Get
        Set(value As Date)
            _Ba_FBautismo = value
        End Set
    End Property

    Public Property Ba_AnotacionesTextuales As String
        Get
            Return _Ba_AnotacionesTextuales
        End Get
        Set(value As String)
            _Ba_AnotacionesTextuales = value
        End Set
    End Property
End Class
