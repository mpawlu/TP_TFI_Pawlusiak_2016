Namespace BLL
    Public Class CursoAsignado
        Public Function Guardar(ByVal QueAsignacion As EE.CursoAsignado) As Boolean
            QueAsignacion.Estado = New EE.Pendiente
            QueAsignacion.FechaAsignacion = Today
            QueAsignacion.FechaVencimiento = Today.AddDays(30)
            QueAsignacion.Intentos = 0
            Dim oMPP As New MPP.CursoAsignado
            Dim resultado As Boolean
            resultado = oMPP.Guardar(QueAsignacion)
            If Resultado = True Then
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Alta, "Se le asigno el curso " & QueAsignacion.Curso.ID & " al empleado " & QueAsignacion.Empleado.NombreUsuario)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            Else
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Ocurrio un error al intentar asignar el curso")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End If
            Return Resultado
        End Function
        Public Function Modificar(ByVal QueAsignacion As EE.CursoAsignado) As Boolean
            Dim oCurAsigMPP As New MPP.CursoAsignado
            Return oCurAsigMPP.Modificar(QueAsignacion)
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
            Dim oMPP As New MPP.CursoAsignado
            Return oMPP.ConsultarCursosPendientes(empleado)
        End Function

        Public Function ActualizarSeccionActual(ByVal QueCursoAsignado As EE.CursoAsignado) As EE.Informativa


        End Function
        Public Function ActualiarSldeActual(ByVal QueSeccion As EE.Informativa) As EE.Slide

        End Function

        Public Function GuardarRespuestas(ByVal _CursoAs As EE.CursoAsignado) As Boolean
            Dim oMPP As New MPP.RespuestaCurso
            Return oMPP.Guardar(_CursoAs)
        End Function
        Public Function ConsultarCursosRealizados(ByVal empleado As EE.Persona) As List(Of EE.CursoAsignado)
            Dim oMPP As New MPP.CursoAsignado
            Return oMPP.ConsultarCursosFinalizados(empleado)
        End Function
        Public Function ObtenerResultado(ByVal QueCursoAsignado As EE.CursoAsignado) As Double
            Return QueCursoAsignado.ResultadoObtenido
        End Function
        Public Function VerificarCorrelatividades(ByVal QueCursoAsignado As EE.CursoAsignado) As Boolean

        End Function
        Public Function Corregir(ByVal QueCursoAsignado As EE.CursoAsignado) As EE.CursoAsignado
            Me.CalcularResultado(QueCursoAsignado)
            Return QueCursoAsignado
        End Function

        Public Function ConsultarFinalizados(ByVal QueCurso As EE.Curso) As List(Of EE.CursoAsignado)
            Dim oMPP As New MPP.CursoAsignado
            Return oMPP.ConsultarRepFinalizadas(QueCurso)
        End Function
        Private Sub CalcularResultado(ByVal _cursoAsgnado As EE.CursoAsignado)
            Dim PuntajeFinal As Double
            Dim puntajeIdeal As Double
            For Each _respuesta As EE.Respuesta_Curso In _cursoAsgnado.Respuestas
                puntajeIdeal += _respuesta.Pregunta.Valor
                If _respuesta.OpcionElegida.Correcta = True Then
                    PuntajeFinal += _respuesta.Pregunta.Valor
                End If
            Next
            _cursoAsgnado.ResultadoObtenido = (PuntajeFinal * 100) / puntajeIdeal
            If _cursoAsgnado.ResultadoObtenido >= 80 Then
                _cursoAsgnado.Aprobado = True
            Else
                _cursoAsgnado.Aprobado = False
            End If
        End Sub
        Public Function FinalizarCurso(ByVal _cursoAsignado As EE.CursoAsignado) As Boolean
            Dim oEncAsigBLL As New BLL.EncuestaAsignada
            Dim resultado As New Boolean
            resultado = oEncAsigBLL.GuradarEncuestaRealizada(_cursoAsignado.EncuestaAsignada)
            If resultado = True Then
                _cursoAsignado.Estado.PasarAFinalizado(_cursoAsignado)
                resultado = Me.Modificar(_cursoAsignado)
                If resultado = True Then
                    Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Modificacion, "El ususario " & _cursoAsignado.Empleado.NombreUsuario & " finalizo el curso " & _cursoAsignado.Curso.Nombre)
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                Else
                    resultado = False
                    Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Ocurrio un error al intentar finalizar el curso")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                End If
            Else
                resultado = False
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Ocurrio un error al intentar finalizar el curso")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End If
            Return resultado
        End Function
        Public Function Consutar(ByVal _CursoAsignado As EE.CursoAsignado) As EE.CursoAsignado
            Dim oMPP As New MPP.CursoAsignado
            Return oMPP.Consultar(_CursoAsignado)
        End Function
        Public Function ComprobarAsignacion(ByVal _persona As EE.Persona, ByVal _curso As EE.curso) As Boolean
            Dim oMPP As New MPP.CursoAsignado
            Return oMPP.ComprobarAsignacion(_persona, _curso)
        End Function
    End Class

End Namespace

