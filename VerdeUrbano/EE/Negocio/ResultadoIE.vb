Namespace EE
    Public Class ResultadoIE
        Private _Diseñador As EE.clsUsuario
        Public Property Diseñador() As EE.clsUsuario
            Get
                Return _Diseñador
            End Get
            Set(ByVal value As EE.clsUsuario)
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

        Sub New(ByVal Diseñador As EE.clsUsuario, ByVal IE As Double)

        End Sub
    End Class
End Namespace

