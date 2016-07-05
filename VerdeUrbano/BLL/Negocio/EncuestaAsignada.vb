Namespace BLL
    Public Class EncuestaAsignada
        Public Sub AgregarRespuesta(ByVal QueEncuestaAsignada As EE.EncuestaAsignada, ByVal respuesta As EE.Respuesta)
            QueEncuestaAsignada.Respuestas.Add(respuesta)

        End Sub
        Public Function GuradarEncuestaRealizada(ByVal QueEncuestaAsignada As EE.EncuestaAsignada) As Boolean
            Dim oMPP As New MPP.EncuestaAsignada
            Return oMPP.Guardar(QueEncuestaAsignada)
        End Function

        Public Function Consultar(ByVal QueCursoAsignado As EE.CursoAsignado) As EE.EncuestaAsignada

        End Function
        Public Function ConsultarFinalizadas(ByVal Empresa As EE.Empresa) As List(Of EE.EncuestaAsignada)

        End Function

    End Class
End Namespace
