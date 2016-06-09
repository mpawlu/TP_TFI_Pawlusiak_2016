Public Class Entre2000y3000
    Inherits Handler

    Public Overrides Sub AsignarVendedor(compra As Compra)
        If compra.ImporteFinal >= 2000 And compra.ImporteFinal <= 3000 Then
            compra.Vendedor = "Compra asiganada a Jose entre 2000 y 3000"
        Else
            Me.ProximoHandler.AsignarVendedor(compra)
        End If
    End Sub
End Class
