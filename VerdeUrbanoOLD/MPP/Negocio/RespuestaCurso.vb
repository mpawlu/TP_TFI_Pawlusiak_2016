Namespace MPP
    Public Class RespuestaCurso
        Public Function Guardar(ByVal _CursoAsignado As EE.CursoAsignado) As Boolean
            Dim oDatos As New DAL.Datos

            Dim resultado As Boolean
            For Each _resp As EE.Respuesta_Curso In _CursoAsignado.Respuestas
                Dim hdatos As New Hashtable
                hdatos.Add("@ID_Curso", _CursoAsignado.Curso.ID)
                hdatos.Add("@ID_Empleado", _CursoAsignado.Empleado.ID)
                hdatos.Add("@ID_Pregunta", _resp.Pregunta.ID)
                hdatos.Add("@ID_OpcionElegida", _resp.OpcionElegida.ID)

                resultado = oDatos.Escribir("s_Respuesta_Curso_Guradar", hdatos)
            Next
            Return resultado
        End Function
        Public Function Consultar(ByVal _CursoAsignado As EE.CursoAsignado) As List(Of EE.Respuesta_Curso)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oResp As EE.Respuesta_Curso
            Dim oCurMPP As New MPP.Curso
            Dim hdatos As New Hashtable
            Dim oListaResp As New List(Of EE.Respuesta_Curso)

            hdatos.Add("@ID_Curso", _CursoAsignado.Curso.ID)
            hdatos.Add("@ID_Empleado", _CursoAsignado.Empleado.ID)

            DS = oDatos.Leer("s_Respuesta_Curso_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oResp = New EE.Respuesta_Curso
                    Dim oPreg As New EE.Pregunta
                    Dim oOpcion As New EE.Opcion_PregCurso
                    oPreg.ID = Item("ID_Pregunta")
                    oOpcion.ID = Item("ID_OpcionElegida")
                    Dim oOpMPP As New MPP.OpcionPregEval
                    Dim oPregMPP As New MPP.PreguntaEvaluacion
                    oPreg = oPregMPP.Consultar(oPreg)
                    oOpcion = oOpMPP.Consultar(oOpcion)
                    oResp.OpcionElegida = oOpcion
                    oResp.Pregunta = oPreg
                    oListaResp.Add(oResp)
                Next
                Return oListaResp
            Else
                Return Nothing
            End If

        End Function
    End Class
End Namespace

