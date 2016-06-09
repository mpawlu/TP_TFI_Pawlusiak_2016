Public Class EstrategiaCordoba

    Inherits EstrategiaGenerica
    Public Overrides Function CalcularPrecio(_compra As Compra) As Double
        Return _compra.ImporteCompra + _compra.Envio + _compra.Impuesto
    End Function
End Class
