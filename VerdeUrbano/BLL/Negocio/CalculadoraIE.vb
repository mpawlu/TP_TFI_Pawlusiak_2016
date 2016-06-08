Imports Servicios
Namespace BLL
    Public Class CalculadoraIE
        Public Function RankearDiseñadores(ByVal _Categoria As EE.Categoria) As List(Of EE.CalculadoraIE)
            Dim oReproducciones As New List(Of EE.CursoAsignado)
            Dim oCursos As New List(Of EE.Curso)
            Dim oCursosBLL As New BLL.Curso
            Dim oDisenadores As New List(Of Servicios.Usuario)
            Dim oUsuBLL As New BLL.clsUsuario
            Dim oPerfil As New Servicios.PermisoCompuesto
            Dim oPerfilBLL As New BLL.clsPermiso
            Dim oResultados As New List(Of EE.CalculadoraIE)

            Dim Ranking As New List(Of Servicios.Usuario)

            oPerfil = oPerfilBLL.ObtenerPerfilDisenador
            oDisenadores = oUsuBLL.ListarPorPerfil(oPerfil)

            For Each Dis In oDisenadores
                If Me.CumpleRestriccion(Dis) = True Then
                    oCursos = Me.CursosPorCategoria(Dis, _Categoria)
                    Dim oResultadoID As New EE.ResultadoIE
                    oResultadoID.Diseñador = Dis
                    For Each cur As EE.Curso In oCursos
                        oReproducciones = Me.ReprodPorCurso(cur)
                        For Each rep As EE.CursoAsignado In oReproducciones
                            oResultadoID.IE += Me.CalcularIE(rep)
                        Next
                    Next
                    Dim oID As New EE.CalculadoraIE
                    oID.Dieseñador = Dis
                    oID.Cursos = oCursos
                    oID.Reproducciones = oReproducciones
                    oResultadoID.IE = oResultadoID.IE / oReproducciones.Count
                    oResultados.Add(oID)
                End If
            Next
            'oResultados.Sort(
            'Ordenar la lista por IE desc
            Return oResultados
        End Function
        Private Function CalcularIE(ByVal _reproduccion As EE.CursoAsignado) As Double


        End Function
        Private Function CumpleRestriccion(ByVal _usu As Servicios.Usuario) As Boolean

        End Function

        Public Function ObtenerMayorIE() As Servicios.Usuario

        End Function
        Public Function CursosPorCategoria(ByVal _usu As Servicios.Usuario, ByVal _cat As EE.Categoria) As List(Of EE.Curso)
            ''aca tengo que listar los cursos que hizo el diseñador en esa categoria 

        End Function

        Public Function ReprodPorCurso(ByVal _curso As EE.Curso) As List(Of EE.CursoAsignado)
            ''aca tengo que listar las reproducciones finalizadas
        End Function
        Sub New()

        End Sub
    End Class
End Namespace

