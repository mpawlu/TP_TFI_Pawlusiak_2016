Namespace BLL
    Public Class Persona
        Public Function Guardar(ByVal quePersona As EE.Persona) As Boolean
            Dim oMPP As New MPP.Persona
            Return oMPP.Guardar(quePersona)
        End Function
    End Class
End Namespace

