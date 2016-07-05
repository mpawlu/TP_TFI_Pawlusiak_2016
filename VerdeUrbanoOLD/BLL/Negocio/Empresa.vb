Namespace BLL
    Public Class Empresa
        Public Sub AgregarEmpleado(ByVal QueEmpresa As EE.Empresa, ByVal QueEmpleado As Servicios.Usuario)
            QueEmpresa.Empleados.Add(QueEmpleado)
        End Sub
        Public Function ListarEmpleados(ByVal QueEmpresa As EE.Empresa) As List(Of Servicios.Usuario)

        End Function
        Sub New()

        End Sub
        Public Function ListarClientes() As List(Of EE.Empresa)
            Dim oMPP As New MPP.Empresa
            Return oMPP.Listar

        End Function
        Public Function CalcularSatisfaccion(ByVal QueEmpresa As EE.Empresa) As Double
            Dim oBLL As New BLL.SatisfaccionCliente
            Return oBLL.CalcularSatisfaccion(QueEmpresa)
        End Function
        Public Function ConsultarEmpresa(ByVal QueEmpresa As EE.Empresa) As EE.Empresa
            Try
                Dim oMPP As New MPP.Empresa
                Return oMPP.Consultar(QueEmpresa)
            Catch ex As Exception
            End Try

        End Function
    End Class
End Namespace

