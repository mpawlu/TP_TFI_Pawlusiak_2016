Namespace BLL
    Public Class PreguntaEncuesta
        Public Function ConsultarPreguntas() As List(Of EE.PreguntaEncuesta)
            Dim oMPP As New MPP.PreguntaEncuesta
            Return oMPP.ConsultarPreguntas
        End Function
    End Class
End Namespace

