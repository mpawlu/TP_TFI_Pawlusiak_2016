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

        Public Function ActualizarSeccionActual(ByVal QueCursoAsignado As EE.CursoAsignado) As EE.Seccion


        End Function
        Public Function ActualiarSldeActual(ByVal QueSeccion As EE.Seccion) As EE.Slide

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
    End Class
End Namespace

