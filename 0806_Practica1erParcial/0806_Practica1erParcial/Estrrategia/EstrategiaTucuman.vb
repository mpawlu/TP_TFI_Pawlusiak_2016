Public Class EstrategiaTucuman
    Inherits EstrategiaGenerica

    Public Overrides Function CalcularPrecio(_compra As Compra) As Double

        Return _compra.ImporteCompra + _compra.Envio
    End Function
End Class
