Public Class DetalleDeCompra
    Inherits System.Web.UI.Page
    Dim oCompra As Compra
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        oCompra = Session("Compra")
        Me.Vendedor.Text = oCompra.Vendedor
        Me.PrecioFinal.Text = oCompra.ImporteFinal
        Pcia.Text = oCompra.Provincia

    End Sub

End Class