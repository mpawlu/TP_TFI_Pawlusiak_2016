Namespace BLL
    Public Class Evaluacion
        Public Function Consultar(ByVal _curso As EE.Curso) As EE.Evaluacion
            Dim oMPP As New MPP.Evaluacion
            Return oMPP.Consultar(_curso)
        End Function
        Public Function ConsultarUltima() As EE.Evaluacion
            Dim oMPP As New MPP.Evaluacion
            Return oMPP.ConsultarUltima
        End Function
        Public Function Guardar(ByVal _curso As EE.Curso) As Boolean
            Dim oMPP As New MPP.Evaluacion
            Return oMPP.Guardar(_curso)
        End Function
    End Class
End Namespace

