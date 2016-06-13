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
            End If

        End Function
    End Class
End Namespace

