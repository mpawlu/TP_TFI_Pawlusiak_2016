Namespace BLL
    Public Class CursoAsignado
        Public Function Guardar(ByVal QueAsignacion As EE.CursoAsignado) As Boolean

        End Function
        Public Function Modificar(ByVal QueAsignacion As EE.CursoAsignado) As Boolean

        End Function
        Public Sub InicializarDatos(ByVal Asignacion As EE.CursoAsignado, ByVal curso As EE.Curso, ByVal empleado As Servicios.Usuario)
            Asignacion.Curso = curso
            Asignacion.Empleado = empleado
            Asignacion.FechaVencimiento = CalcularFechaVencimiento(Asignacion)
        End Sub
        Private Function CalcularFechaVencimiento(ByVal curso As EE.CursoAsignado) As Date
            Return curso.FechaAsignacion.AddDays(30)
        End Function
        Public Sub ActualizarUltimoIngreso()

        End Sub
        Public Function ConsultarCursosPendientes(ByVal empleado As Servicios.Usuario) As List(Of EE.CursoAsignado)

        End Function

        Public Function ActualizarSeccionActual(ByVal QueCursoAsignado As EE.CursoAsignado) As EE.Informativa


        End Function
        Public Function ActualiarSldeActual(ByVal QueSeccion As EE.Informativa) As EE.Slide

        End Function

        Public Sub GuardarRespuesta(ByRef Respuesta As Opcion)
            'Me.Respuestas.Add(Respuesta)
        End Sub
        Public Function ConsultarCursoRealizado(ByVal curso As EE.Curso, ByVal empleado As Servicios.Usuario) As EE.CursoAsignado


        End Function
        Public Function ObtenerResultado(ByVal QueCursoAsignado As EE.CursoAsignado) As Double
            Return QueCursoAsignado.ResultadoObtenido
        End Function
        Public Function VerificarCorrelatividades(ByVal QueCursoAsignado As EE.CursoAsignado) As Boolean

        End Function
        Public Function PasarAIniciado(ByVal QueCursoAsignado As EE.CursoAsignado) As EE.CursoAsignado


        End Function
        Public Function PasarAFinalizado(ByVal QueCursoAsignado As EE.CursoAsignado) As EE.CursoAsignado


        End Function
        Public Function ConsultarFinalizados(ByVal QueCurso As EE.Curso) As List(Of EE.CursoAsignado)
            Dim oMPP As New MPP.CursoAsignado
            Return oMPP.ConsultarRepFinalizadas(QueCurso)
        End Function
        Private Function CalcularResultado(ByVal _cursoAsgnado As EE.CursoAsignado) As Double
            Dim PuntajeFinal As Double
            For Each _respuesta As EE.Respuesta_Curso In _cursoAsgnado.Respuestas
                If _respuesta.OpcionElegida.Correcta = True Then
                    PuntajeFinal += _respuesta.Pregunta.Valor
                End If
            Next
            Return PuntajeFinal
        End Function
        Public Sub FinalizarCurso(ByVal _cursoAsignado As EE.CursoAsignado)
            _cursoAsignado.ResultadoObtenido = CalcularResultado(_cursoAsignado)
            _cursoAsignado.Estado.PasarAFinalizado(_cursoAsignado)
            Me.Guardar(_cursoAsignado)
        End Sub
    End Class

End Namespace

