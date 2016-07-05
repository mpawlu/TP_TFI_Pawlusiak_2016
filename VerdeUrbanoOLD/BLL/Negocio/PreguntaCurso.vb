Public Class PreguntaCurso
    Public Sub AgregarOpcion(ByVal QuePregunta As EE.Pregunta, ByVal QueOpcion As EE.Opcion_PregCurso)
        QuePregunta.Opciones.Add(QueOpcion)
    End Sub
End Class
