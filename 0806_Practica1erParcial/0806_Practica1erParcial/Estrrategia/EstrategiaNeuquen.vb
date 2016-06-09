Public Class EstrategiaNeuquen
    Inherits EstrategiaGenerica

    Public Overrides Function CalcularPrecio(_compra As Compra) As Double
        Return _compra.ImporteCompra
    End Function
End Class
