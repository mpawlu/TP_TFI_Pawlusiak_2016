Namespace EE
    Public Class CuponPago
        Private _IdCupon As Integer
        Public Property ID_Cupon() As Integer
            Get
                Return _IdCupon
            End Get
            Set(ByVal value As Integer)
                _IdCupon = value
            End Set
        End Property

        Private _Compra As Compra
        Public Property Compra() As Compra
            Get
                Return _Compra
            End Get
            Set(ByVal value As Compra)
                _Compra = value
            End Set
        End Property


        Private _Monto As Double
        Public Property Monto() As Double
            Get
                Return _Monto
            End Get
            Set(ByVal value As Double)
                _Monto = value
            End Set
        End Property


        Private _FechaEmision As Date
        Public Property FechaEmision() As Date
            Get
                Return _FechaEmision
            End Get
            Set(ByVal value As Date)
                _FechaEmision = value
            End Set
        End Property


        Private _FechaVencimiento As Date
        Public Property FechaVencimiento() As Date
            Get
                Return _FechaVencimiento
            End Get
            Set(ByVal value As Date)
                _FechaVencimiento = value
            End Set
        End Property

    End Class
End Namespace

