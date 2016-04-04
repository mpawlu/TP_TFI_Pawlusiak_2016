Public Class Direccion
    Private _Calle As String
    Public Property Calle() As String
        Get
            Return _Calle
        End Get
        Set(ByVal value As String)
            _Calle = value
        End Set
    End Property

    Private _Numero As Integer
    Public Property Numero() As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
        End Set
    End Property


    Private _Piso As Integer
    Public Property Piso() As Integer
        Get
            Return _Piso
        End Get
        Set(ByVal value As Integer)
            _Piso = value
        End Set
    End Property


    Private _Dpto As String
    Public Property Departamento() As String
        Get
            Return _Dpto
        End Get
        Set(ByVal value As String)
            _Dpto = value
        End Set
    End Property


    Private _Localidad As Localidad
    Public Property Localidad() As Localidad
        Get
            Return _Localidad
        End Get
        Set(ByVal value As Localidad)
            _Localidad = value
        End Set
    End Property

End Class
