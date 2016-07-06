Namespace MPP
    Public Class Curso
        Public Function ConsultarFinalizados() As List(Of EE.Curso)

        End Function
        Public Function ConsultarFinalizados(ByVal QueCategoria As EE.Categoria) As List(Of EE.Curso)

        End Function
        Public Function Listar() As List(Of EE.Curso)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaCursos As New List(Of EE.Curso)
            Dim dt As New DataTable
            Dim oCur As EE.Curso


            DS = oDatos.Leer("s_Curso_listar", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oCur = New EE.Curso
                    oCur.ID = Item("Id_Curso")

                    If IsDBNull(Item("Nombre")) = True Then
                        oCur.Nombre = Nothing
                    Else
                        oCur.Nombre = Item("Nombre")
                    End If

                    If IsDBNull(Item("Descripcion")) = True Then
                        oCur.Descripcion = Nothing
                    Else
                        oCur.Descripcion = Item("Descripcion")
                    End If


                    Dim oCatMPP As New MPP.Categoria
                    Dim oCategoria As New EE.Categoria
                    oCategoria.ID = Item("ID_Categoria")
                    oCur.Categoria = oCatMPP.ConsultarCategoria(oCategoria)

                    If IsDBNull(Item("Duracion")) = True Then
                        oCur.Duracion = Nothing
                    Else
                        oCur.Duracion = Item("Duracion")
                    End If

                    If IsDBNull(Item("Valor")) = True Then
                        oCur.Valor = Nothing
                    Else
                        oCur.Valor = Item("Valor")
                    End If

                    Dim oSolMPP As New MPP.Solicitud
                    Dim oSolicitud As New EE.SolicitudCurso
                    oSolicitud.ID = Item("ID_Solicitud")
                    oCur.SolicitudCurso = oSolMPP.ConsultarSolicitud(oSolicitud)

                    Select Case Item("ID_Estado")
                        Case 1
                            oCur.Estado = New EE.Aprobado
                        Case 2
                            oCur.Estado = New EE.EnCreacion
                        Case 3
                            oCur.Estado = New EE.PendienteDeAprobacion
                        Case 4
                            oCur.Estado = New EE.Rechazado
                    End Select

                    If IsDBNull(Item("Fecha_Creacion")) = True Then
                        oCur.FechaCreacion = Nothing
                    Else
                        oCur.FechaCreacion = Item("Fecha_Creacion")
                    End If

                    listaCursos.Add(oCur)

                Next

                Return listaCursos

            Else
                Return Nothing
            End If
        End Function
        Public Function ListarDisponibles(ByVal QueEmpresa As EE.Empresa) As List(Of EE.Curso)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaCursos As New List(Of EE.Curso)
            Dim dt As New DataTable
            Dim oCur As EE.Curso
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Empresa", QueEmpresa.ID)


            DS = oDatos.Leer("s_Curso_ListarDispXEmpresa", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oCur = New EE.Curso
                    oCur.ID = Item("Id_Curso")

                    If IsDBNull(Item("Nombre")) = True Then
                        oCur.Nombre = Nothing
                    Else
                        oCur.Nombre = Item("Nombre")
                    End If

                    If IsDBNull(Item("Descripcion")) = True Then
                        oCur.Descripcion = Nothing
                    Else
                        oCur.Descripcion = Item("Descripcion")
                    End If


                    Dim oCatMPP As New MPP.Categoria
                    Dim oCategoria As New EE.Categoria
                    oCategoria.ID = Item("ID_Categoria")
                    oCur.Categoria = oCatMPP.ConsultarCategoria(oCategoria)

                    If IsDBNull(Item("Duracion")) = True Then
                        oCur.Duracion = Nothing
                    Else
                        oCur.Duracion = Item("Duracion")
                    End If

                    If IsDBNull(Item("Valor")) = True Then
                        oCur.Valor = Nothing
                    Else
                        oCur.Valor = Item("Valor")
                    End If

                    Dim oSolMPP As New MPP.Solicitud
                    Dim oSolicitud As New EE.SolicitudCurso
                    oSolicitud.ID = Item("ID_Solicitud")
                    oCur.SolicitudCurso = oSolMPP.ConsultarSolicitud(oSolicitud)

                    Select Case Item("ID_Estado")
                        Case 1
                            oCur.Estado = New EE.Aprobado
                        Case 2
                            oCur.Estado = New EE.EnCreacion
                        Case 3
                            oCur.Estado = New EE.PendienteDeAprobacion
                        Case 4
                            oCur.Estado = New EE.Rechazado
                    End Select

                    If IsDBNull(Item("Fecha_Creacion")) = True Then
                        oCur.FechaCreacion = Nothing
                    Else
                        oCur.FechaCreacion = Item("Fecha_Creacion")
                    End If

                    listaCursos.Add(oCur)

                Next

                Return listaCursos

            Else
                Return Nothing
            End If
        End Function
        Public Function ConsultarFinalizados(ByVal QueCategoria As EE.Categoria, ByVal QueUsuario As Servicios.Usuario) As List(Of EE.Curso)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaCursos As New List(Of EE.Curso)
            Dim dt As New DataTable
            Dim oCur As EE.Curso
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Disenador", QueUsuario.ID)
            hdatos.Add("@ID_Categoria", QueCategoria.ID)

            DS = oDatos.Leer("s_Curso_Finalizados_Categoria_Disenador", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oCur = New EE.Curso
                    oCur.ID = Item("Id_Curso")

                    If IsDBNull(Item("Nombre")) = True Then
                        oCur.Nombre = Nothing
                    Else
                        oCur.Nombre = Item("Nombre")
                    End If

                    If IsDBNull(Item("Descripcion")) = True Then
                        oCur.Descripcion = Nothing
                    Else
                        oCur.Descripcion = Item("Descripcion")
                    End If


                    Dim oCatMPP As New MPP.Categoria
                    Dim oCategoria As New EE.Categoria
                    oCategoria.ID = Item("ID_Categoria")
                    oCur.Categoria = oCatMPP.ConsultarCategoria(oCategoria)

                    If IsDBNull(Item("Duracion")) = True Then
                        oCur.Duracion = Nothing
                    Else
                        oCur.Duracion = Item("Duracion")
                    End If

                    If IsDBNull(Item("Valor")) = True Then
                        oCur.Valor = Nothing
                    Else
                        oCur.Valor = Item("Valor")
                    End If

                    Dim oSolMPP As New MPP.Solicitud
                    Dim oSolicitud As New EE.SolicitudCurso
                    oSolicitud.ID = Item("ID_Solicitud")
                    oCur.SolicitudCurso = oSolMPP.ConsultarSolicitud(oSolicitud)

                    Select Case Item("ID_Estado")
                        Case 1
                            oCur.Estado = New EE.Aprobado
                        Case 2
                            oCur.Estado = New EE.EnCreacion
                        Case 3
                            oCur.Estado = New EE.PendienteDeAprobacion
                        Case 4
                            oCur.Estado = New EE.Rechazado
                    End Select

                    If IsDBNull(Item("Fecha_Creacion")) = True Then
                        oCur.FechaCreacion = Nothing
                    Else
                        oCur.FechaCreacion = Item("Fecha_Creacion")
                    End If

                    listaCursos.Add(oCur)

                Next

                Return listaCursos

            Else
                Return Nothing
            End If
        End Function
        Public Function Consultar(ByVal _curso As EE.Curso) As EE.Curso
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oCur As EE.Curso
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Curso", _curso.ID)

            DS = oDatos.Leer("s_Curso_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oCur = New EE.Curso
                    oCur.ID = Item("Id_Curso")

                    If IsDBNull(Item("Nombre")) = True Then
                        oCur.Nombre = Nothing
                    Else
                        oCur.Nombre = Item("Nombre")
                    End If

                    If IsDBNull(Item("Descripcion")) = True Then
                        oCur.Descripcion = Nothing
                    Else
                        oCur.Descripcion = Item("Descripcion")
                    End If


                    Dim oCatMPP As New MPP.Categoria
                    Dim oCategoria As New EE.Categoria
                    oCategoria.ID = Item("ID_Categoria")
                    oCur.Categoria = oCatMPP.ConsultarCategoria(oCategoria)

                    If IsDBNull(Item("Duracion")) = True Then
                        oCur.Duracion = Nothing
                    Else
                        oCur.Duracion = Item("Duracion")
                    End If

                    If IsDBNull(Item("Valor")) = True Then
                        oCur.Valor = Nothing
                    Else
                        oCur.Valor = Item("Valor")
                    End If

                    Dim oSolMPP As New MPP.Solicitud
                    Dim oSolicitud As New EE.SolicitudCurso
                    oSolicitud.ID = Item("ID_Solicitud")
                    oCur.SolicitudCurso = oSolMPP.ConsultarSolicitud(oSolicitud)

                    Select Case Item("ID_Estado")
                        Case 1
                            oCur.Estado = New EE.Aprobado
                        Case 2
                            oCur.Estado = New EE.EnCreacion
                        Case 3
                            oCur.Estado = New EE.PendienteDeAprobacion
                        Case 4
                            oCur.Estado = New EE.Rechazado
                    End Select

                    If IsDBNull(Item("Fecha_Creacion")) = True Then
                        oCur.FechaCreacion = Nothing
                    Else
                        oCur.FechaCreacion = Item("Fecha_Creacion")
                    End If
                    Dim oSecMPP As New MPP.Seccion
                    oCur.Secciones = oSecMPP.Consultar(oCur)
                    Dim oEvalMPP As New MPP.Evaluacion
                    oCur.Evaluacion = oEvalMPP.Consultar(oCur)

                    Return oCur

                Next

            Else
                Return Nothing
            End If
        End Function
        Public Function Guardar(ByVal _Curso As EE.Curso) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Categoria", _Curso.Categoria.ID)
            hdatos.Add("@ID_Solicitud", _Curso.SolicitudCurso.ID)
            hdatos.Add("@ID_Estado", _Curso.Estado.ID)

            resultado = oDatos.Escribir("s_Curso_Crear", hdatos)

            Return resultado
        End Function
        Public Function Modificar(ByVal _Curso As EE.Curso) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Curso", _Curso.ID)
            hdatos.Add("@Nombre", _Curso.Nombre)
            hdatos.Add("@Descripcion", _Curso.Descripcion)
            hdatos.Add("@ID_Estado", _Curso.Estado.ID)
            hdatos.Add("@Duracion", _Curso.Duracion)
            If Not _Curso.FechaCreacion = Nothing Then
                hdatos.Add("@Fecha_Creacion", _Curso.FechaCreacion)
            Else
                hdatos.Add("@Fecha_Creacion", DBNull.Value)
            End If
            If Not _Curso.Evaluacion Is Nothing Then
                hdatos.Add("@ID_Evaluacion", _Curso.Evaluacion.ID)
            Else
                hdatos.Add("@ID_Evaluacion", DBNull.Value)
            End If
            If Not _Curso.Valor = Nothing Then
                hdatos.Add("@Valor", _Curso.Valor)
            Else
                hdatos.Add("@Valor", DBNull.Value)
            End If

            resultado = oDatos.Escribir("s_Curso_Modificar", hdatos)

            Return resultado
        End Function
        Public Function Consultar(ByVal _sol As EE.SolicitudCurso) As EE.Curso
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oCur As EE.Curso
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Solicitud", _sol.ID)

            DS = oDatos.Leer("s_Curso_ConsultarXSolicitud", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oCur = New EE.Curso
                    oCur.ID = Item("Id_Curso")

                    If IsDBNull(Item("Nombre")) = True Then
                        oCur.Nombre = Nothing
                    Else
                        oCur.Nombre = Item("Nombre")
                    End If

                    If IsDBNull(Item("Descripcion")) = True Then
                        oCur.Descripcion = Nothing
                    Else
                        oCur.Descripcion = Item("Descripcion")
                    End If


                    Dim oCatMPP As New MPP.Categoria
                    Dim oCategoria As New EE.Categoria
                    oCategoria.ID = Item("ID_Categoria")
                    oCur.Categoria = oCatMPP.ConsultarCategoria(oCategoria)

                    If IsDBNull(Item("Duracion")) = True Then
                        oCur.Duracion = Nothing
                    Else
                        oCur.Duracion = Item("Duracion")
                    End If

                    If IsDBNull(Item("Valor")) = True Then
                        oCur.Valor = Nothing
                    Else
                        oCur.Valor = Item("Valor")
                    End If

                    Dim oSolMPP As New MPP.Solicitud
                    Dim oSolicitud As New EE.SolicitudCurso
                    oSolicitud.ID = Item("ID_Solicitud")
                    oCur.SolicitudCurso = oSolMPP.ConsultarSolicitud(oSolicitud)

                    Select Case Item("ID_Estado")
                        Case 1
                            oCur.Estado = New EE.Aprobado
                        Case 2
                            oCur.Estado = New EE.EnCreacion
                        Case 3
                            oCur.Estado = New EE.PendienteDeAprobacion
                        Case 4
                            oCur.Estado = New EE.Rechazado
                    End Select

                    If IsDBNull(Item("Fecha_Creacion")) = True Then
                        oCur.FechaCreacion = Nothing
                    Else
                        oCur.FechaCreacion = Item("Fecha_Creacion")
                    End If

                    Dim oEvalMPP As New MPP.Evaluacion
                    oCur.Evaluacion = oEvalMPP.Consultar(oCur)
                    Dim oSecMPP As New MPP.Seccion
                    oCur.Secciones = oSecMPP.Consultar(oCur)
                    Return oCur

                Next

            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

