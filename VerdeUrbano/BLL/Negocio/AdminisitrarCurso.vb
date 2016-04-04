Imports EE
Namespace BLL
    Public Class AdminisitrarCurso
        Public Sub Inicializar(ByVal empleado As EE.AdministrarCurso, ByVal curso As EE.Curso)

        End Sub

        Public Sub DecrementarLicenciasDisponibles(ByVal QueCurso As EE.AdministrarCurso)
            QueCurso.LicenciasDisponibles -= 1
        End Sub
        Public Sub GuardarAsignaciones()

        End Sub
        Public Sub AgregarEmpleado(ByVal AdministrarCurso As EE.AdministrarCurso, ByVal QueEmpleado As EE.Empleado)
            AdministrarCurso.AsignadoA.Add(QueEmpleado)
        End Sub
        Public Function ConsultarCursosDisponibles(ByVal QueEmpresa As EE.Empresa) As List(Of EE.Curso)


        End Function
        Public Function Consultar(ByVal QueCurso As EE.Curso, ByVal QueEmpresa As EE.Empresa) As EE.AdministrarCurso

        End Function
        Public Function ConsultarLicenciasDisponibles(ByVal AdministrarCurso As EE.AdministrarCurso) As Integer

        End Function
        Public Function Guardar(ByRef QueAdministrarCurso As EE.AdministrarCurso) As Boolean

        End Function
        Public Function Modificar(ByRef QueAdministrarCurso As EE.AdministrarCurso) As Boolean

        End Function
        Sub New()

        End Sub
    End Class
End Namespace
