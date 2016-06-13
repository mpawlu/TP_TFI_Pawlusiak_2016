Namespace MPP
    Public Class RespuestasEncuesta
        Public Function Consutlar(ByVal _usuario As Servicios.Usuario, ByVal _curso As EE.Curso) As List(Of EE.Respuesta)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oResp As EE.Respuesta
            Dim oListaRespuesta As New List(Of EE.Respuesta)
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Curso", _curso.ID)
            hdatos.Add("@ID_Empleado", _usuario.ID)

            DS = oDatos.Leer("s_RespuestaEncuesta_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oResp = New EE.Respuesta
                    Dim oPregMPP As New MPP.PreguntaEncuesta
                    Dim oPreg As New EE.PreguntaEncuesta
                    oPreg.ID_Pregunta = Item("ID_Pregunta_Encuesta")
                    oResp.PreguntaEncuesta = oPregMPP.Consultar(oPreg)
                    oResp.OpcionElegida = Item("Respuesta")
                    oListaRespuesta.Add(oResp)

                Next
                Return oListaRespuesta
            End If
            Return Nothing

        End Function
    End Class
End Namespace

