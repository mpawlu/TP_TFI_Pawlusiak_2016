Public Class Telefono
    Private _Codigo As String
    Public Property CodigoArea() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Private _Numero As String
    Public Property Numero() As String
        Get
            Return _Numero
        End Get
        Set(ByVal value As String)
            _Numero = value
        End Set
    End Property


    Private _Tipo As [Enum]
    Public Property Tipo() As [Enum]
        Get
            Return _Tipo
        End Get
        Set(ByVal value As [Enum])
            _Tipo = value
        End Set
    End Property
End Class
