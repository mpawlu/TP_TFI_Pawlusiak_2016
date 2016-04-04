Namespace EE
    Public Class Pago

        Private _NumeroComprobante As Integer
        Public Property NumeroComprobante() As Integer
            Get
                Return _NumeroComprobante
            End Get
            Set(ByVal value As Integer)
                _NumeroComprobante = value
            End Set
        End Property
        Public Sub InicializarDatos(ByVal CuponPago As CuponPago, ByVal int As Integer)

        End Sub

        Private _CuponPago As CuponPago
        Public Property CuponPago() As CuponPago
            Get
                Return _CuponPago
            End Get
            Set(ByVal value As CuponPago)
                _CuponPago = value
            End Set
        End Property

        Private _FechaPago As Date
        Public Property FechaPago() As Date
            Get
                Return _FechaPago
            End Get
            Set(ByVal value As Date)
                _FechaPago = value
            End Set
        End Property
        Sub New(ByVal QueCupon As EE.CuponPago, ByVal FechaPago As Date, ByVal NumeroComporbante As Integer)

        End Sub
    End Class
End Namespace

