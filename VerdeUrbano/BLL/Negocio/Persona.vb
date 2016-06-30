Namespace BLL
    Public Class Persona
        Public Function Guardar(ByVal quePersona As EE.Persona) As Boolean
            Dim oMPP As New MPP.Persona
            If oMPP.Guardar(quePersona) = True Then
                Dim oUsuMPP As New MPP.clsUsuario
                Dim oNuevoUsu As New Servicios.Usuario
                oNuevoUsu = quePersona.Usuario
                Return oUsuMPP.CrearUsuario(oNuevoUsu)
            End If
        End Function
        Public Function Consultar(ByVal _DNI As Integer) As EE.Persona
            Dim oMPP As New MPP.Persona
            Return oMPP.Consultar(_DNI)
        End Function
    End Class
End Namespace

