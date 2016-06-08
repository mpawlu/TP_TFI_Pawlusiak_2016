Namespace EE
    Public Class ResultadoIE
        Private _Diseñador As Servicios.Usuario
        Public Property Diseñador() As Servicios.Usuario
            Get
                Return _Diseñador
            End Get
            Set(ByVal value As Servicios.Usuario)
                _Diseñador = value
            End Set
        End Property
        Private _IE As Double
        Public Property IE() As Double
            Get
                Return _IE
            End Get
            Set(ByVal value As Double)
                _IE = value
            End Set
        End Property


    End Class
End Namespace

