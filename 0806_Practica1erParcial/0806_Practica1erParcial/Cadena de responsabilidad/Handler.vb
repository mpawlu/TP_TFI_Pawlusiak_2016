Public MustInherit Class Handler
    Private _ProximoHandler As Handler
    Public Property ProximoHandler() As Handler
        Get
            Return _ProximoHandler
        End Get
        Set(ByVal value As Handler)
            _ProximoHandler = value
        End Set
    End Property
    Public MustOverride Sub AsignarVendedor(ByVal compra As Compra)




End Class
