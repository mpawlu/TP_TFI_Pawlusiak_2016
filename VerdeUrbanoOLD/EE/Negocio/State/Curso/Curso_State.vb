Namespace EE
    Public Class Curso_State
        Inherits State
        Public Sub PasarAAprobado(ByVal QueCurso As EE.Curso)

        End Sub
        Public Sub PasarAPendienteDeAprobacion(ByVal QueCurso As EE.Curso)
            Dim oEstado As New PendienteDeAprobacion
            QueCurso.Estado = oEstado
            QueCurso.SolicitudCurso.Estado.PasarASolicitudFinalizada(QueCurso.SolicitudCurso)
        End Sub
        Public Sub PasarARechazado(ByVal QueCurso As EE.Curso)

        End Sub
    End Class
End Namespace
