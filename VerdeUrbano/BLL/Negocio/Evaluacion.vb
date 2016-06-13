Namespace BLL
    Public Class Evaluacion
        Public Function Consultar(ByVal _curso As EE.Curso) As EE.Evaluacion
            Dim oMPP As New MPP.Evaluacion
            Return oMPP.Consultar(_curso)
        End Function
    End Class
End Namespace

