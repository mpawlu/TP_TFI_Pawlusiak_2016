﻿Namespace BLL
    Public Class SolicitudCurso
        Public Function Guardar(ByVal NuevaSolicitud As EE.SolicitudCurso) As Boolean
            Dim oMPP As New MPP.Solicitud
            Return oMPP.Gauardar(NuevaSolicitud)
        End Function
        Public Function Consultar(ByVal ID As Integer) As EE.SolicitudCurso

        End Function
        Public Function ListarSolicituddes() As List(Of EE.SolicitudCurso)

        End Function
        Public Function ConsultarUltima() As EE.SolicitudCurso
            Dim oMPP As New MPP.Solicitud
            Return oMPP.ConsultarUltima

        End Function
        Sub New()

        End Sub
    End Class
End Namespace
