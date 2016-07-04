Namespace BLL
    Public Class SolicitudCurso
        Public Function Guardar(ByVal NuevaSolicitud As EE.SolicitudCurso) As Boolean
            Dim oMPP As New MPP.Solicitud
            Return oMPP.Gauardar(NuevaSolicitud)
        End Function
        Public Function Modificar(ByVal _Solicitud As EE.SolicitudCurso) As Boolean
            Dim oMPP As New MPP.Solicitud
            Return oMPP.Modificar(_Solicitud)
        End Function
        Public Function Consultar(ByVal ID As Integer) As EE.SolicitudCurso

        End Function
        Public Function ListarSolicitudesPendientes(ByVal _dis As Servicios.Usuario) As List(Of EE.SolicitudCurso)
            Dim oMPP As New MPP.Solicitud
            Return oMPP.ConsultarSolicitudesPendientes(_dis)
        End Function
        Public Function ListarSolicitudesFinalizadas() As List(Of EE.SolicitudCurso)
            Dim oMPP As New MPP.Solicitud
            Return oMPP.ConsultarSolicitudesFinalizadas()
        End Function
        Public Function ConsultarUltima() As EE.SolicitudCurso
            Dim oMPP As New MPP.Solicitud
            Return oMPP.ConsultarUltima

        End Function
        Sub New()

        End Sub
    End Class
End Namespace
