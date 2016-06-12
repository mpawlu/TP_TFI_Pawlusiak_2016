Namespace MPP
    Public Class Curso
        Public Function ConsultarFinalizados() As List(Of EE.Curso)

        End Function
        Public Function ConsultarFinalizados(ByVal QueCategoria As EE.Categoria) As List(Of EE.Curso)

        End Function
        Public Function ConsultarFinalizados(ByVal QueCategoria As EE.Categoria, ByVal QueUsuario As Servicios.Usuario) As List(Of EE.Curso)

        End Function
        Public Function Guardar(ByVal _Curso As EE.Curso) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Categoria", _Curso.Categoria.ID)
            hdatos.Add("@ID_Solicitud", _Curso.SolicitudCurso.ID)
            hdatos.Add("@ID_Estado", _Curso.Estado.ID)

            resultado = oDatos.Escribir("s_Curso_Crear", hdatos)

            Return resultado
        End Function
    End Class
End Namespace

