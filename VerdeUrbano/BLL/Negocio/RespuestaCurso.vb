Namespace BLL
    Public Class RespuestaCurso
        Public Function GuardarRespuestas(ByVal _CursoAsignado As EE.CursoAsignado) As Boolean
            Dim oMPP As New MPP.RespuestaCurso
            Return oMPP.Guardar(_CursoAsignado)
        End Function
    End Class
End Namespace
