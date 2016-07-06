Namespace MPP
    Public Class Solicitud
        Public Function Gauardar(ByVal _Solicitud As EE.SolicitudCurso) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@Titulo", _Solicitud.Titulo)
            hdatos.Add("@Detalle", _Solicitud.Detalle)
            hdatos.Add("@Fecha_Solicitud", _Solicitud.FechaSolicitud)
            hdatos.Add("@Fecha_Limite_Creacion", _Solicitud.FechaLimiteDeCreacion)
            hdatos.Add("@ID_Solicitante", _Solicitud.Solicitante.ID)
            hdatos.Add("@ID_Disenador", _Solicitud.Disenador.ID)
            hdatos.Add("@ID_Estado", _Solicitud.Estado.ID)

            resultado = oDatos.Escribir("s_Solicitud_Crear", hdatos)

            Return resultado
        End Function
        Public Function Modificar(ByVal _Solicitud As EE.SolicitudCurso) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Solicitud", _Solicitud.ID)
            hdatos.Add("@Titulo", _Solicitud.Titulo)
            hdatos.Add("@Detalle", _Solicitud.Detalle)
            hdatos.Add("@Fecha_Solicitud", _Solicitud.FechaSolicitud)
            hdatos.Add("@Fecha_Limite_Creacion", _Solicitud.FechaLimiteDeCreacion)
            hdatos.Add("@ID_Solicitante", _Solicitud.Solicitante.ID)
            hdatos.Add("@ID_Disenador", _Solicitud.Disenador.ID)
            hdatos.Add("@ID_Estado", _Solicitud.Estado.ID)

            resultado = oDatos.Escribir("s_Solicitud_Modificar", hdatos)

            Return resultado
        End Function
        Public Function ConsultarUltima() As EE.SolicitudCurso
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oSolicitud As EE.SolicitudCurso

            DS = oDatos.Leer("s_Solicitud_ConsultarUltima", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oSolicitud = New EE.SolicitudCurso
                    oSolicitud.ID = Item("Id_Solicitud")
                    oSolicitud.Titulo = Item("Titulo")
                    oSolicitud.Detalle = Item("Detalle")
                    oSolicitud.FechaSolicitud = Item("Fecha_Solicitud")
                    oSolicitud.FechaLimiteDeCreacion = Item("Fecha_Limite_Creacion")
                    Select Case Item("ID_Estado")
                        Case 1
                            oSolicitud.Estado = New EE.EnConstruccion
                        Case 2
                            oSolicitud.Estado = New EE.SolicitudFinalizada
                        Case 3
                            oSolicitud.Estado = New EE.Solicitado
                    End Select
                Next

                Return oSolicitud

            Else
                Return Nothing
            End If
        End Function
        Public Function ConsultarSolicitud(ByVal _solicitud As EE.SolicitudCurso) As EE.SolicitudCurso
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oSol As EE.SolicitudCurso
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Solicitud", _solicitud.ID)
            DS = oDatos.Leer("s_Solicitud_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oSol = New EE.SolicitudCurso
                    oSol.ID = Item("Id_Solicitud")
                    oSol.Titulo = Item("Titulo")
                    oSol.Detalle = Item("Detalle")
                    oSol.FechaSolicitud = Item("Fecha_Solicitud")
                    oSol.FechaLimiteDeCreacion = Item("Fecha_Limite_Creacion")

                    Dim oUsuMPP As New MPP.clsUsuario
                    Dim oDisenador As New Servicios.Usuario
                    oDisenador.ID = Item("ID_Disenador")
                    oSol.Disenador = oUsuMPP.ConsultarUsuario(oDisenador)

                    Dim oSolicitante As New Servicios.Usuario
                    oSolicitante.ID = Item("ID_Solicitante")
                    oSol.Solicitante = oUsuMPP.ConsultarUsuario(oSolicitante)

                    Select Case Item("ID_Estado")
                        Case 1
                            oSol.Estado = New EE.EnConstruccion
                        Case 2
                            oSol.Estado = New EE.SolicitudFinalizada
                        Case 3
                            oSol.Estado = New EE.Solicitado
                    End Select
                Next

                Return oSol

            Else
                Return Nothing
            End If
        End Function
        Public Function ConsultarSolicitudesFinalizadas(ByVal _solicitante As Servicios.Usuario) As List(Of EE.SolicitudCurso)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oSol As EE.SolicitudCurso
            Dim hdatos As New Hashtable
            Dim oResultado As New List(Of EE.SolicitudCurso)
            hdatos.Add("@ID_Solicitante", _solicitante.ID)

            DS = oDatos.Leer("s_Solicitud_Listar_FinalizadasXSolicitante", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oSol = New EE.SolicitudCurso
                    oSol.ID = Item("Id_Solicitud")
                    oSol.Titulo = Item("Titulo")
                    oSol.Detalle = Item("Detalle")
                    oSol.FechaSolicitud = Item("Fecha_Solicitud")
                    oSol.FechaLimiteDeCreacion = Item("Fecha_Limite_Creacion")

                    Dim oUsuMPP As New MPP.clsUsuario
                    Dim oDisenador As New Servicios.Usuario
                    oDisenador.ID = Item("ID_Disenador")
                    oSol.Disenador = oUsuMPP.ConsultarUsuario(oDisenador)

                    Dim oSolicitante As New Servicios.Usuario
                    oSolicitante.ID = Item("ID_Solicitante")
                    oSol.Solicitante = oUsuMPP.ConsultarUsuario(oSolicitante)

                    Select Case Item("ID_Estado")
                        Case 1
                            oSol.Estado = New EE.EnConstruccion
                        Case 2
                            oSol.Estado = New EE.SolicitudFinalizada
                        Case 3
                            oSol.Estado = New EE.Solicitado
                    End Select
                    oResultado.Add(oSol)
                Next
                Return oResultado
            Else
                Return Nothing
            End If
        End Function
        Public Function ConsultarSolicitudesPendientes(ByVal _disenador As Servicios.Usuario) As List(Of EE.SolicitudCurso)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oSol As EE.SolicitudCurso
            Dim hdatos As New Hashtable
            Dim oResultado As New List(Of EE.SolicitudCurso)

            hdatos.Add("@ID_Usuario", _disenador.ID)
            DS = oDatos.Leer("s_Solicitud_Listar_PendXDis", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oSol = New EE.SolicitudCurso
                    oSol.ID = Item("Id_Solicitud")
                    oSol.Titulo = Item("Titulo")
                    oSol.Detalle = Item("Detalle")
                    oSol.FechaSolicitud = Item("Fecha_Solicitud")
                    oSol.FechaLimiteDeCreacion = Item("Fecha_Limite_Creacion")

                    Dim oUsuMPP As New MPP.clsUsuario
                    Dim oDisenador As New Servicios.Usuario
                    oDisenador.ID = Item("ID_Disenador")
                    oSol.Disenador = oUsuMPP.ConsultarUsuario(oDisenador)

                    Dim oSolicitante As New Servicios.Usuario
                    oSolicitante.ID = Item("ID_Solicitante")
                    oSol.Solicitante = oUsuMPP.ConsultarUsuario(oSolicitante)

                    Select Case Item("ID_Estado")
                        Case 1
                            oSol.Estado = New EE.EnConstruccion
                        Case 2
                            oSol.Estado = New EE.SolicitudFinalizada
                        Case 3
                            oSol.Estado = New EE.Solicitado
                    End Select
                    oResultado.Add(oSol)
                Next
                Return oResultado
            Else
                Return Nothing
            End If

        End Function
        Public Function AprobarCurso(ByVal _solicitud As EE.SolicitudCurso) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Solicitud", _solicitud.ID)

            resultado = oDatos.Escribir("s_Curso_Aprobar", hdatos)

            Return resultado
        End Function
    End Class
End Namespace

