﻿Namespace EE
    Public Class SolicitudCurso_State
        Inherits State
        Public Sub PasarAEnConstruccion(ByVal Solicitud As EE.SolicitudCurso)
            Dim EnCons As New EE.EnConstruccion
            Solicitud.Estado = EnCons
        End Sub
        Public Sub PasarASolicitudFinalizada(ByVal Solicitud As EE.SolicitudCurso)

        End Sub
    End Class
End Namespace

