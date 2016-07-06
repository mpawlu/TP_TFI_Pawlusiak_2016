Namespace BLL
    Public Class SolicitudCurso
        Public Function Guardar(ByVal NuevaSolicitud As EE.SolicitudCurso) As Boolean
            Dim oMPP As New MPP.Solicitud
            Dim resultado As Boolean
            resultado = oMPP.Gauardar(NuevaSolicitud)
            If Resultado = True Then
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Alta, "El usuario " & NuevaSolicitud.Solicitante.NombreUsuario & " genero correctamente una nueva solicitud")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            Else
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Ocurrio un error al intentar crear una solicitud")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End If
            Return resultado
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
        Public Function ListarSolicitudesFinalizadas(ByVal _solicitante As Servicios.Usuario) As List(Of EE.SolicitudCurso)
            Dim oMPP As New MPP.Solicitud
            Return oMPP.ConsultarSolicitudesFinalizadas(_solicitante)
        End Function
        Public Function ConsultarUltima() As EE.SolicitudCurso
            Dim oMPP As New MPP.Solicitud
            Return oMPP.ConsultarUltima

        End Function
        Public Function AprobarCurso(ByVal _solicitud As EE.SolicitudCurso) As Boolean
            Dim oMPP As New MPP.Solicitud
            Dim resultado As Boolean
            resultado = oMPP.AprobarCurso(_solicitud)
            If Resultado = True Then
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Modificacion, "Se aprobo el curso correspondiente a la solicitud " & _solicitud.ID)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            Else
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Ocurrio un error al intentar aprobar el curso")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End If
            Return Resultado
        End Function
        Sub New()

        End Sub
    End Class
End Namespace
