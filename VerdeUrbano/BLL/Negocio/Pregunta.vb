Public Class Pregunta
    Public Sub AgregarOpcion(ByVal QuePregunta As EE.Pregunta, ByVal QueOpcion As EE.Opcion)
        QuePregunta.Opciones.Add(QueOpcion)
    End Sub
End Class
