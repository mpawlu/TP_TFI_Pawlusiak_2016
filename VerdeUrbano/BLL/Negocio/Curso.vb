Imports Servicios
Namespace BLL
    Public Class Curso
        Public Sub AgregarCorrelatividad(ByVal QueCurso As EE.Curso, ByVal QueCorrelatividad As EE.Curso)
            QueCurso.Correlatividades.Add(QueCorrelatividad)
        End Sub

        Public Function MostrarSiguienteSeccion(ByVal QueCurso As EE.Curso) As EE.Seccion

        End Function
        Public Sub AgregarSeccion(ByVal QueCurso As EE.Curso, ByVal QueSeccion As EE.Seccion)
            QueCurso.Secciones.Add(QueSeccion)
        End Sub

        Public Sub CambiarEstadoAAprobado(ByVal QueCurso As EE.Curso)

        End Sub
        Public Sub CambiarEstadoARechazado(ByVal QueCurso As EE.Curso)

        End Sub
        Public Sub AsignarPrecio(ByVal QueCurso As EE.Curso, ByVal QuePrecio As Double)

        End Sub
        Public Function ConsultarSeccion(ByVal QueCurso As EE.Curso, ByVal QueSeccion As Integer) As EE.Slide

        End Function
        Public Function MostrarDetalle(ByVal QueCurso As EE.Curso) As EE.Curso

        End Function
        Public Function ListarCursos() As List(Of EE.Curso)

        End Function
        Public Function ListarAprobados() As List(Of EE.Curso)

        End Function
        Public Function Listar(ByVal QueCategoria As EE.Categoria, ByVal QueDiseñador As Servicios.Usuario) As List(Of EE.Curso)

        End Function
        Public Sub FinalizarCreacion(ByVal QueCurso As EE.Curso)

        End Sub

        Public Function ListarPendientesDeAprobacion() As List(Of EE.Curso)

        End Function
        Public Function Modificar(ByVal QueCurso As EE.Curso) As Boolean

        End Function
        Public Function ConsultarFinalizados() As List(Of EE.Curso)

        End Function
        Public Function ConsultarFinalizados(ByVal QueCategoria As EE.Categoria) As List(Of EE.Curso)

        End Function
        Public Function ConsultarFinalizados(ByVal QueCategoria As EE.Categoria, ByVal QueUsuario As Servicios.Usuario) As List(Of EE.Curso)

        End Function
    End Class
End Namespace
