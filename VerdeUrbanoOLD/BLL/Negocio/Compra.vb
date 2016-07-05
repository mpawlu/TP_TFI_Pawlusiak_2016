Namespace BLL
    Public Class Compra

        Public Function ConfirmarCompra(ByVal QueCompra As EE.Compra) As EE.CuponPago
            If Me.GuardarCompra(QueCompra) = True Then
                Dim CuponEE As New EE.CuponPago
                Dim estCupon As New EE.Emitido
                QueCompra.Total = CalcularTotal(QueCompra)
                CuponEE.Compra = QueCompra
                CuponEE.FechaEmision = Today
                CuponEE.Estado = estCupon
                Dim CuponBLL As New CuponPago

            End If
        End Function
        Public Function CalcularTotal(ByVal QueCompra As EE.Compra) As Double
            If QueCompra.Licencias > 1 Then
                Return QueCompra.Curso.Valor + (QueCompra.Curso.Valor * 0.1 * QueCompra.Licencias)
            Else
                Return QueCompra.Curso.Valor
            End If
        End Function
        Public Function ConsultarCupon(ByVal Compra As EE.Compra) As EE.CuponPago

        End Function
        Private Function GuardarCompra(ByVal QueCompra As EE.Compra) As Boolean

        End Function
        Sub New()

        End Sub
        Public Function ConsultarCompras(ByVal queEmpresa As EE.Empresa) As List(Of EE.Compra)
            Dim oMPP As New MPP.Compra

        End Function
    End Class
End Namespace

