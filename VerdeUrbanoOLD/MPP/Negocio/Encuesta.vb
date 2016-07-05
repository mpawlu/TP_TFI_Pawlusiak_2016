Namespace MPP
    Public Class Encuesta
        Public Function Consultar(ByVal _Curso As EE.Curso) As EE.Encuesta

            Dim oEnc As EE.Encuesta

            oEnc = New EE.Encuesta
            Dim oCursoMPP As New MPP.Curso
            Dim oCurso As New EE.Curso
            oCurso.ID = _Curso.ID
            oEnc.Curso = oCursoMPP.Consultar(oCurso)

            Dim oPregMPP As New MPP.PreguntaEncuesta
            oEnc.Preguntas = oPregMPP.ConsultarPreguntas
            Return oEnc

        End Function
    End Class
End Namespace

