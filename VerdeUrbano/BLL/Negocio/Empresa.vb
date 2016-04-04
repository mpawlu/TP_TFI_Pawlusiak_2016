Namespace BLL
    Public Class Empresa
        Public Sub AgregarEmpleado(ByVal QueEmpresa As EE.Empresa, ByVal QueEmpleado As EE.clsUsuario)
            QueEmpresa.Empleados.Add(QueEmpleado)
        End Sub
        Public Function ListarEmpleados(ByVal QueEmpresa As EE.Empresa) As List(Of EE.clsUsuario)

        End Function
        Sub New()

        End Sub
    End Class
End Namespace

