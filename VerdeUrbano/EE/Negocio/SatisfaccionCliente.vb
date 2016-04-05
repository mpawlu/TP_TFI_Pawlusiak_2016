Namespace EE
    Public Class SatisfaccionCliente
        Private _Valor1 As Double
        Public Property Valor1() As Double
            Get
                Return _Valor1
            End Get
            Set(ByVal value As Double)
                _Valor1 = value
            End Set
        End Property

        Private _Valor2 As Double
        Public Property Valor2() As Double
            Get
                Return _Valor2
            End Get
            Set(ByVal value As Double)
                _Valor2 = value
            End Set
        End Property

        Private _Valor3 As Double
        Public Property Valor3() As Double
            Get
                Return _Valor3
            End Get
            Set(ByVal value As Double)
                _Valor3 = value
            End Set
        End Property

        Private _Valor4 As Double
        Public Property Valor4() As Double
            Get
                Return _Valor4
            End Get
            Set(ByVal value As Double)
                _Valor4 = value
            End Set
        End Property

        Private _Valor5 As Double
        Public Property Valor5() As Double
            Get
                Return _Valor5
            End Get
            Set(ByVal value As Double)
                _Valor5 = value
            End Set
        End Property

        Private _satisfaccion As Double
        Public Property Satisfaccion() As Double
            Get
                Return _satisfaccion
            End Get
            Set(ByVal value As Double)
                _satisfaccion = value
            End Set
        End Property
        Private _SatisfaccionCalculada As Double
        Public Property SatisfaccionCalculada() As Double
            Get
                Return _SatisfaccionCalculada
            End Get
            Set(ByVal value As Double)
                _SatisfaccionCalculada = value
            End Set
        End Property

        Sub New(ByVal Val1 As Double, ByVal Val2 As Double, ByVal Val3 As Double, ByVal Val4 As Double, ByVal Val5 As Double)

        End Sub

    End Class
End Namespace

