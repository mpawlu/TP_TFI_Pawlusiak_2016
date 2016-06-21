Imports Servicios
Namespace BLL
    Public Class Curso
        Public Sub AgregarCorrelatividad(ByVal QueCurso As EE.Curso, ByVal QueCorrelatividad As EE.Curso)
            QueCurso.Correlatividades.Add(QueCorrelatividad)
        End Sub
        Public Function Guardar(ByVal _Curso As EE.Curso) As Boolean
            Try
                Dim oMPP As New MPP.Curso
                Return oMPP.Guardar(_Curso)

            Catch ex As Exception
            End Try

        End Function

        Public Function MostrarSiguienteSeccion(ByVal QueCurso As EE.Curso) As EE.Informativa

        End Function
        Public Sub AgregarSeccion(ByVal QueCurso As EE.Curso, ByVal QueSeccion As EE.Informativa)
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
        Public Function Consultar(ByVal QueSolicitud As EE.SolicitudCurso) As EE.Curso
            Dim oMPP As New MPP.Curso
            Try
                Return oMPP.Consultar(QueSolicitud)
            Catch ex As Exception
            End Try

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
            Try
                Dim resultado As New List(Of EE.Curso)
                Dim Mapper As New MPP.Curso

                resultado = Mapper.ConsultarFinalizados()

                Return resultado
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function

        Public Function ConsultarFinalizados(ByVal QueCategoria As EE.Categoria) As List(Of EE.Curso)
            Try
                Dim resultado As New List(Of EE.Curso)
                Dim Mapper As New MPP.Curso

                resultado = Mapper.ConsultarFinalizados(QueCategoria)

                Return resultado
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function

        Public Function ConsultarFinalizados(ByVal QueCategoria As EE.Categoria, ByVal QueUsuario As Servicios.Usuario) As List(Of EE.Curso)
            Try
                Dim resultado As New List(Of EE.Curso)
                Dim Mapper As New MPP.Curso

                resultado = Mapper.ConsultarFinalizados(QueCategoria, QueUsuario)

                Return resultado
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function
        Public Function Modificar(ByVal _curso As EE.Curso) As Boolean
            Dim oMPP As New MPP.Curso
            Try
                Return oMPP.Modificar(_curso)
            Catch ex As Exception

            End Try
        End Function
    End Class
End Namespace
