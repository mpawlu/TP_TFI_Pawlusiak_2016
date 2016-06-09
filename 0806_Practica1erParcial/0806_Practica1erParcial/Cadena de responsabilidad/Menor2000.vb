Public Class Menor2000
    Inherits Handler


    Public Overrides Sub AsignarVendedor(compra As Compra)
        If compra.ImporteFinal < 2000 Then
            compra.Vendedor = "Compra vigilada por Agustin < 2000"

        Else
            Me.ProximoHandler.AsignarVendedor(compra)
        End If
    End Sub
End Class
