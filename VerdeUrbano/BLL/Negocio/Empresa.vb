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


        End Function
        Public Function CalcularSatisfaccion(ByVal QueEmpresa As EE.Empresa) As EE.SatisfaccionCliente


        End Function
    End Class
End Namespace

