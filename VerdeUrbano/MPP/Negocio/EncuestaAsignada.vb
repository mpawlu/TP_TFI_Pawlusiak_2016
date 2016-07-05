Namespace MPP
    Public Class EncuestaAsignada
        Public Function Consultar(ByVal _CursoAsignado As EE.CursoAsignado) As EE.EncuestaAsignada
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oEncAsig As EE.EncuestaAsignada
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Curso", _CursoAsignado.Curso.ID)
            hdatos.Add("@ID_Empleado", _CursoAsignado.Empleado.ID)

            DS = oDatos.Leer("s_RespuestaEncuesta_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oEncAsig = New EE.EncuestaAsignada
                    Dim oUsu As New Servicios.Usuario
                    oUsu.ID = _CursoAsignado.Empleado.ID
                    Dim oUsuMPP As New MPP.clsUsuario
                    oEncAsig.Empleado = oUsuMPP.ConsultarUsuario(oUsu)

                    Dim oCur As New EE.Curso
                    oCur.ID = _CursoAsignado.Curso.ID
                    Dim oEncMPP As New MPP.Encuesta
                    oEncAsig.Encuesta = oEncMPP.Consultar(oCur)

                    Dim oRespMPP As New MPP.RespuestasEncuesta
                    oEncAsig.Respuestas = oRespMPP.Consutlar(oUsu, oCur)

                    For Each r As EE.Respuesta In oEncAsig.Respuestas
                        If r.PreguntaEncuesta.ID_Pregunta = 1 Then
                            oEncAsig.Dificultad = r.Valor
                        ElseIf r.PreguntaEncuesta.ID_Pregunta = 2 Then
                            oEncAsig.Utilidad = r.Valor
                        End If
                    Next
                    Return oEncAsig
                Next
            Else
                Return Nothing
            End If

        End Function
        Public Function Guardar(ByVal _EncuestaAs As EE.EncuestaAsignada) As Boolean
            Dim oDatos As New DAL.Datos
            Dim Resultado As Boolean
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Pregunta", 1)
            hdatos.Add("@ID_Curso", _EncuestaAs.Encuesta.Curso.ID)
            hdatos.Add("@ID_Usuario", _EncuestaAs.Empleado.ID)
            hdatos.Add("@Respuesta", _EncuestaAs.Utilidad)
            If oDatos.Escribir("s_Respuestas_Encuesta_Crear", hdatos) = False Then
                Return False
            End If
            hdatos = New Hashtable
            hdatos.Add("@ID_Pregunta", 2)
            hdatos.Add("@ID_Curso", _EncuestaAs.Encuesta.Curso.ID)
            hdatos.Add("@ID_Usuario", _EncuestaAs.Empleado.ID)
            hdatos.Add("@Respuesta", _EncuestaAs.Dificultad)
            If oDatos.Escribir("s_Respuestas_Encuesta_Crear", hdatos) = False Then
                Return False
            End If
            For Each _respuesta As EE.Respuesta In _EncuestaAs.Respuestas
                Dim hdatos2 As New Hashtable

                hdatos2.Add("@ID_Pregunta", _respuesta.PreguntaEncuesta.ID_Pregunta)
                hdatos2.Add("@ID_Curso", _EncuestaAs.Encuesta.Curso.ID)
                hdatos2.Add("@ID_Usuario", _EncuestaAs.Empleado.ID)
                hdatos2.Add("@Respuesta", _respuesta.OpcionElegida)

                If oDatos.Escribir("s_Respuestas_Encuesta_Crear", hdatos2) = False Then
                    Return False
                End If
            Next
            Return True
        End Function
    End Class
End Namespace

