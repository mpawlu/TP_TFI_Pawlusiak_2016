﻿Namespace EE
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
        End Sub
    End Class
End Namespace
