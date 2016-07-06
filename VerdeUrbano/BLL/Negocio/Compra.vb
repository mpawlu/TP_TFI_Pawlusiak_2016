Namespace BLL
    Public Class Compra

        Public Function ConfirmarCompra(ByVal QueCompra As EE.Compra) As EE.CuponPago
            If Me.GuardarCompra(QueCompra) = True Then
                'Dim CuponEE As New EE.CuponPago
                'Dim estCupon As New EE.Emitido
                'QueCompra.Total = CalcularTotal(QueCompra)
                'CuponEE.Compra = QueCompra
                'CuponEE.FechaEmision = Today
                'CuponEE.Estado = estCupon
                'Dim CuponBLL As New CuponPago

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
        Public Function GuardarCompra(ByVal QueCompra As EE.Compra) As Boolean
            Try
                Dim oMPP As New MPP.Compra
                Dim Resultado As Boolean
                Resultado = oMPP.GuardarCompra(QueCompra)
                If Resultado = True Then
                    Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Alta, "La empresa " & QueCompra.Empresa.Nombre & " compro el curso " & QueCompra.Curso.Nombre)
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                Else
                    Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Ocurrio un error al intentar dar de alta una compra")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                End If
                Return Resultado
            Catch ex As Exception
            End Try
        End Function
        Sub New()

        End Sub
        Public Function ConsultarCompras(ByVal queEmpresa As EE.Empresa) As List(Of EE.Compra)
            Dim oMPP As New MPP.Compra
            Return oMPP.ConsultarCompras(queEmpresa)
        End Function
    End Class
End Namespace

