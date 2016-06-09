Public Class Mayor3000
    Inherits Handler


    Public Overrides Sub AsignarVendedor(compra As Compra)
        If compra.ImporteFinal > 3000 Then
            compra.Vendedor = "Compra asignada a Adrian. > 3000"

        Else
            compra.Vendedor = "Error"

        End If
    End Sub
End Class
