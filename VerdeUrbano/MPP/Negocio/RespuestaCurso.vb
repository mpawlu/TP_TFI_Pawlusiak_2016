Namespace MPP
    Public Class RespuestaCurso
        Public Function Guardar(ByVal _CursoAsignado As EE.CursoAsignado) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean
            For Each _resp As EE.Respuesta_Curso In _CursoAsignado.Respuestas
                hdatos.Add("@ID_Curso", _CursoAsignado.Curso.ID)
                hdatos.Add("@ID_Empleado", _CursoAsignado.Empleado.ID)
                hdatos.Add("@ID_Pregunta", _resp.Pregunta.ID)
                hdatos.Add("@ID_OpcionElegida", _resp.OpcionElegida.ID)

                resultado = oDatos.Escribir("s_Respuesta_Curso_Guradar", hdatos)

            Next

        End Function
    End Class
End Namespace

