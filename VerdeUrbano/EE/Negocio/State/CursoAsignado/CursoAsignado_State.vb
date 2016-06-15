Namespace EE
    Public Class CursoAsignado_State
        Inherits State
        Public Sub PasarAEnCurso(ByVal QueCursoAsig As EE.CursoAsignado)

        End Sub
        Public Sub PasarAPendienteVencido(ByVal QueCursoAsig As EE.CursoAsignado)

        End Sub
        Public Sub PasarAEnCursoVencido(ByVal QueCursoAsig As EE.CursoAsignado)

        End Sub
        Public Sub PasarAFinalizado(ByVal QueCursoAsig As EE.CursoAsignado)
            QueCursoAsig.Estado = New EE.Finalizado
            QueCursoAsig.Intentos += 1
            'Dim puntajeIdeal As Double
            'For Each preg As EE.Pregunta In QueCursoAsig.Curso.Evaluacion.Preguntas
            '    puntajeIdeal += preg.Valor
            'Next
            'If QueCursoAsig.ResultadoObtenido >= puntajeIdeal * 0.8 Then
            '    QueCursoAsig.Aprobado = True
            'Else
            '    QueCursoAsig.Aprobado = False
            'End If
            'QueCursoAsig.Intentos += 1
        End Sub
    End Class
End Namespace
