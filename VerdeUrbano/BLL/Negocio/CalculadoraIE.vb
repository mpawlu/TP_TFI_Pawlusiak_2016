Imports Servicios
Namespace BLL
    Public Class CalculadoraIE
        Public Function RankearDiseñadores(ByVal _Diseanadores As List(Of Servicios.Usuario), ByVal _Categoria As EE.Categoria) As List(Of EE.CalculadoraIE)
            Dim oReproducciones As New List(Of EE.CursoAsignado)
            Dim oCursos As New List(Of EE.Curso)
            Dim oCursosBLL As New BLL.Curso
            Dim oUsuBLL As New BLL.clsUsuario
            Dim oPermiso As New Servicios.PermisoSimple
            Dim oPerfilBLL As New BLL.clsPermiso
            Dim oResultados As New List(Of EE.CalculadoraIE)
            Dim oUsuariosTodos As New List(Of Servicios.Usuario)
            Dim Ranking As New List(Of Servicios.Usuario)


            For Each Dis In _Diseanadores
                Dim IE As Double
                If Me.CumpleRestriccion(Dis, _Categoria) = True Then
                    oCursos = Me.CursosPorCategoria(Dis, _Categoria)
                    Dim oResultadoID As New EE.ResultadoIE
                    oResultadoID.Diseñador = Dis
                    For Each cur As EE.Curso In oCursos
                        oReproducciones = Me.ReprodPorCurso(cur)
                        For Each rep As EE.CursoAsignado In oReproducciones
                            IE += Me.CalcularIE(rep)
                        Next
                    Next
                    Dim oID As New EE.CalculadoraIE
                    oID.Dieseñador = Dis
                    oID.Cursos = oCursos
                    oID.Reproducciones = oReproducciones
                    oID.IndiceDeSatisfaccion = IE / oReproducciones.Count
                    oResultados.Add(oID)

                End If
            Next
            Return Me.OrdenarLista(oResultados)

        End Function
        Private Function CalcularIE(ByVal _reproduccion As EE.CursoAsignado) As Double
            Dim _enc As New EE.EncuestaAsignada
            _enc = _reproduccion.EncuestaAsignada
            Dim res As Double
            res = (_reproduccion.ResultadoObtenido * 50 + _enc.Dificultad * 20 + _enc.Utilidad * 30) / 100
            Return res
        End Function
        Private Function CumpleRestriccion(ByVal _usu As Servicios.Usuario, ByVal _cat As EE.Categoria) As Boolean
            Dim oCursosFinalizados As New List(Of EE.Curso)
            oCursosFinalizados = CursosPorCategoria(_usu, _cat)
            If Not oCursosFinalizados Is Nothing Then
                If oCursosFinalizados.Count >= 1 Then
                    For Each _curso As EE.Curso In oCursosFinalizados
                        If Me.ReprodPorCurso(_curso).Count >= 5 Then
                            Return True
                        Else
                            Return False
                        End If
                    Next
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Function

        Private Function OrdenarLista(ByVal _lista As List(Of EE.CalculadoraIE)) As List(Of EE.CalculadoraIE)
            Dim listaOrdenada As New List(Of EE.CalculadoraIE)
            _lista.Sort(Function(x, y) y.IndiceDeSatisfaccion.CompareTo(x.IndiceDeSatisfaccion))
            listaOrdenada = _lista
            Return listaOrdenada
        End Function
        Private Function CursosPorCategoria(ByVal _usu As Servicios.Usuario, ByVal _cat As EE.Categoria) As List(Of EE.Curso)
            ''aca tengo que listar los cursos que hizo el diseñador en esa categoria 
            Dim Cursos As New List(Of EE.Curso)
            Dim CursoBLL As New BLL.Curso
            If CursoBLL.ConsultarFinalizados(_cat, _usu) Is Nothing Then
                Return Nothing
            Else
                Return CursoBLL.ConsultarFinalizados(_cat, _usu)
            End If

        End Function

        Private Function ReprodPorCurso(ByVal _curso As EE.Curso) As List(Of EE.CursoAsignado)
            ''aca tengo que listar las reproducciones finalizadas
            Dim _CursoAsBLL As New BLL.CursoAsignado
            Dim _CursosAsignado As New List(Of EE.CursoAsignado)
            _CursosAsignado = _CursoAsBLL.ConsultarFinalizados(_curso)
            Return _CursosAsignado
        End Function
        Sub New()

        End Sub
    End Class
End Namespace

