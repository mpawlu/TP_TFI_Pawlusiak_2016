Namespace MPP
    Public Class Permiso
        Public Function ListarPerfiles() As List(Of Servicios.PermisoBase)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaPermisos As New List(Of Servicios.PermisoBase)
            Dim dt As New DataTable
            Dim oPermiso As Servicios.PermisoBase

            DS = oDatos.Leer("s_Permiso_ListarHuerfanos", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPermiso.ID = Item("ID_Permiso")
                    oPermiso.Descripcion = Item("Descripcion")
                    oPermiso.Url = Item("URL")
                    oPermiso.Accion = Item("Accion")

                    listaPermisos.Add(oPermiso)

                Next

                Return listaPermisos

            Else
                Return Nothing
            End If
        End Function

        Public Function ConsultarHijos(ByVal _perm As Servicios.PermisoBase) As List(Of Servicios.PermisoBase)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaPermisos As New List(Of Servicios.PermisoBase)
            Dim dt As New DataTable
            Dim oPermiso As Servicios.PermisoBase

            DS = oDatos.Leer("s_Permiso_ListarHijos", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPermiso.ID = Item("ID_Permiso")
                    oPermiso.Descripcion = Item("Descripcion")
                    oPermiso.Url = Item("URL")
                    oPermiso.Accion = Item("Accion")

                    listaPermisos.Add(oPermiso)

                Next

                Return listaPermisos

            Else
                Return Nothing
            End If
        End Function



        Public Function listarFamilias() As List(Of Servicios.PermisoBase)
            Dim _listaFamilias As New List(Of Servicios.PermisoBase)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaPermisos As New List(Of Servicios.PermisoBase)
            Dim dt As New DataTable
            Dim oPermiso As Servicios.PermisoBase

            DS = oDatos.Leer("s_Permiso_ListarCompuestos", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPermiso.ID = Item("ID_Permiso")
                    oPermiso.Descripcion = Item("Descripcion")
                    oPermiso.Url = Item("URL")
                    oPermiso.Accion = Item("Accion")
                    listaPermisos.Add(oPermiso)
                Next

                Return listaPermisos

            Else
                Return Nothing
            End If
            'Dim MiComando As SqlCommand
            'MiComando = Conexion.retornaComando("Select * from Patente where url is null and esAccion= @accion or @accion is null order by esAccion asc, id_patente asc")
            'If paramFiltro = True Then
            '    MiComando.Parameters.Add(New SqlParameter("@accion", 0))
            'Else
            '    MiComando.Parameters.Add(New SqlParameter("@accion", DBNull.Value))
            'End If
            'Dim _dt As DataTable = Conexion.ExecuteDataTable(MiComando)
            'For Each _dr As DataRow In _dt.Rows
            '    Dim _per As Entidades.PermisoBase = ConvertirDataRowEnPermiso(_dr)
            '    _listaFamilias.Add(_per)
            'Next
            'Return _listaFamilias
        End Function

        'A este hay que modificarlo con el ConvertirDR
        Public Function listarFamilias(paramID As Integer) As Servicios.PermisoCompuesto
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oPermiso As Servicios.PermisoBase

            hdatos.Add("@ID_Permiso", paramID)

            DS = oDatos.Leer("s_Permiso_ConsultarPorID", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPermiso.ID = Item("ID_Permiso")
                    oPermiso.Descripcion = Item("Descripcion")
                    oPermiso.Url = Item("URL")
                    oPermiso.Accion = Item("Accion")
                Next

                Return oPermiso

            Else
                Return Nothing
            End If
            'Dim MiComando As SqlCommand = Conexion.retornaComando("Select * from Patente where id_Patente=@IdPatente")
            'MiComando.Parameters.Add(New SqlParameter("@IdPatente", paramID))
            'Dim _dt As DataTable = Conexion.ExecuteDataTable(MiComando)
            'If _dt.Rows.Count = 1 Then
            '    Return ConvertirDataRowEnPermiso(_dt.Rows(0))
            'Else
            '    Return Nothing
            'End If
        End Function

        Public Function obtenerIDPermiso(pDescripcionPermiso As String) As Integer
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim hdatos As New Hashtable
            Dim oPermiso As Servicios.PermisoBase

            hdatos.Add("@Descripcion", pDescripcionPermiso)

            DS = oDatos.Leer("s_Permiso_ConsultarPorDescripcion", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPermiso.ID = Item("ID_Permiso")
                Next
                Return oPermiso.ID
            Else
                Return Nothing
            End If
            ''Esto es descripcion
            'Dim MiComando As SqlCommand = Conexion.retornaComando("Select * from Patente where Nombre=@Nombre")
            'MiComando.Parameters.Add(New SqlParameter("@Nombre", paramNombrePermiso))
            'Dim _dt As DataTable = Conexion.ExecuteDataTable(MiComando)
            'If _dt.Rows.Count = 1 Then
            '    Return CInt(_dt.Rows(0).Item(0))
            'Else
            '    Return Nothing
            'End If
        End Function

        Public Function chequearNombrePermiso(pDescripcionPermiso As String) As Boolean
            Dim _listaFamilias As New List(Of Servicios.PermisoBase)
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet

            hdatos.Add("@Descripcion", pDescripcionPermiso)
            DS = oDatos.Leer("s_Permiso_ConsultarPorDescripcion", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Function ConvertirDataRowEnPermiso(_dr As DataRow) As Servicios.PermisoBase
            Dim _permiso As Servicios.PermisoBase
            If Not _dr.Item("Accion") Is DBNull.Value AndAlso Convert.ToBoolean(_dr.Item("esAccion")) Then
                _permiso = New Servicios.PermisoSimple
            Else
                _permiso = New Servicios.PermisoCompuesto
            End If
            _permiso.ID = CInt(_dr.Item("Id_Patente"))
            _permiso.Descripcion = Convert.ToString(_dr.Item("Descripcion"))
            _permiso.URL = _dr.Item("URL").ToString
            If _permiso.tieneHijos Then
                Dim ListaHijos As List(Of Servicios.PermisoBase) = Me.ListarHijos(_permiso.ID)
                For Each hijo As Servicios.PermisoBase In ListaHijos
                    '_permiso.agregarHijo(hijo)
                Next
            End If
            Return _permiso
        End Function

        Private Function ListarHijos(ByVal _id As Integer) As List(Of Servicios.PermisoBase)
            Dim listaPermisos As New List(Of Servicios.PermisoBase)
            Dim _listaFamilias As New List(Of Servicios.PermisoBase)
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oPermiso As Servicios.PermisoBase

            hdatos.Add("@ID_Permiso", _id)

            DS = oDatos.Leer("s_Permiso_ListarHijos", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPermiso.ID = Item("ID_Permiso")
                    oPermiso.Descripcion = Item("Descripcion")
                    oPermiso.Url = Item("URL")
                    oPermiso.Accion = Item("Accion")
                    listaPermisos.Add(oPermiso)
                Next

                Return listaPermisos

            Else
                Return Nothing
            End If
            'Dim MiComando As SqlClient.SqlCommand = Conexion.retornaComando("SELECT Patente.Id_Patente,Nombre,Url,esAccion FROM Patente LEFT JOIN Familia_Patente as b ON (b.Id_Patente=patente.Id_Patente) WHERE b.ID_Familia = @IDFamilia  ORDER BY Patente.Id_Patente ASC")
            'MiComando.Parameters.Add(New SqlParameter("@IDFamilia", _id))
            'Dim dt As DataTable = Conexion.ExecuteDataTable(MiComando)
            'For Each mirow As DataRow In dt.Rows
            '    Dim MiPermiso As Entidades.PermisoBase = Me.ConvertirDataRowEnPermiso(mirow)
            '    lista.Add(MiPermiso)
            'Next
            Return listaPermisos
        End Function

        Public Sub AltaPermiso(paramPermiso As Servicios.PermisoBase)
            Try
                Dim oDatos As New DAL.Datos
                Dim hdatos As New Hashtable
                Dim resultado As Boolean

                hdatos.Add("@Descripcion", paramPermiso.Descripcion)
                hdatos.Add("@URL", paramPermiso.Url)
                hdatos.Add("@Accion", paramPermiso.Accion)

                resultado = oDatos.Escribir("s_Permiso_Crear", hdatos)
                If resultado = True Then
                    Dim IDpadre As Integer
                    IDpadre = Me.obtenerIDPermiso(paramPermiso.Descripcion)
                    oDatos = Nothing
                    hdatos = Nothing
                    For Each MiPermiso As Servicios.PermisoBase In paramPermiso.ObtenerHijos
                        hdatos.Add("@ID_PermisoPadre", IDpadre)
                        hdatos.Add("@ID_Permiso", MiPermiso.ID)
                        oDatos.Escribir("s_Permiso_Padre_Crear", hdatos)
                    Next
                End If

                'Dim MiID As Integer = Conexion.ObtenerID("Patente", "ID_Patente")
                ''Es un Perfil
                'Dim MiComando As SqlCommand = Conexion.retornaComando("insert into patente values(@ID_Patente, @Nombre, @URL, @esAccion)")
                'With MiComando.Parameters
                '    .Add(New SqlParameter("@ID_Patente", MiID))
                '    .Add(New SqlParameter("@Nombre", paramPermiso.Nombre))
                '    .Add(New SqlParameter("@URL", DBNull.Value))
                '    .Add(New SqlParameter("@esAccion", 0))
                'End With
                'Conexion.ExecuteNonQuery(MiComando)

                'For Each MiPermiso As Entidades.PermisoBase In paramPermiso.ObtenerHijos
                '    MiComando = Conexion.retornaComando("insert into familia_patente values (@ID_Familia, @ID_Patente)")
                '    With MiComando.Parameters
                '        .Add(New SqlParameter("@ID_Familia", MiID))
                '        .Add(New SqlParameter("@ID_Patente", MiPermiso.ID))
                '    End With
                '    Conexion.ExecuteNonQuery(MiComando)
                'Next
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Public Sub BajaPermiso(paramID As Integer)
            Try
                Dim oDatos As New DAL.Datos
                Dim hdatos As New Hashtable

                hdatos.Add("@ID_Permiso", paramID)

                oDatos.Escribir("s_Permiso_Baja", hdatos)
                'Dim MiComando As SqlCommand = Conexion.retornaComando("delete from familia_patente where ID_Familia=@IDFamilia")
                'With MiComando.Parameters
                '    .Add(New SqlParameter("@IDFamilia", paramID))
                'End With
                'Conexion.ExecuteNonQuery(MiComando)
                'MiComando.Dispose()
                'MiComando = Conexion.retornaComando("delete from familia_patente where ID_patente=@IDFamilia")
                'With MiComando.Parameters
                '    .Add(New SqlParameter("@IDFamilia", paramID))
                'End With
                'Conexion.ExecuteNonQuery(MiComando)
                'MiComando.Dispose()
                'MiComando = Conexion.retornaComando("delete from Patente where ID_Patente=@IDPatente")
                'With MiComando.Parameters
                '    .Add(New SqlParameter("@IDPatente", paramID))
                'End With
                'Conexion.ExecuteNonQuery(MiComando)
            Catch ex As Exception
            End Try
        End Sub

        Public Sub ModificarPermiso(paramPermiso As Servicios.PermisoBase)
            Try
                Dim oDatos As New DAL.Datos
                Dim hdatos As New Hashtable
                Dim resultado As Boolean

                hdatos.Add("@ID_PermisoPadre", paramPermiso.ID)
                resultado = oDatos.Escribir("s_Permiso_Padre_Baja", hdatos)
                If resultado = True Then
                    oDatos = Nothing
                    hdatos = Nothing
                    For Each MiPermiso As Servicios.PermisoBase In paramPermiso.ObtenerHijos
                        hdatos.Add("@ID_PermisoPadre", paramPermiso.ID)
                        hdatos.Add("@ID_Permiso", MiPermiso.ID)
                        oDatos.Escribir("s_Permiso_Padre_Crear", hdatos)
                    Next
                End If
                'Try
                '    Dim MiComando As SqlCommand = Conexion.retornaComando("delete from familia_patente where ID_Familia=@IDFamilia")
                '    With MiComando.Parameters
                '        .Add(New SqlParameter("@IDFamilia", paramPermiso.ID))
                '    End With
                '    Conexion.ExecuteNonQuery(MiComando)
                '    MiComando.Dispose()
                '    For Each MiPermiso As Entidades.PermisoBase In paramPermiso.ObtenerHijos
                '        MiComando = Conexion.retornaComando("insert into familia_patente values (@ID_Familia, @ID_Patente)")
                '        With MiComando.Parameters
                '            .Add(New SqlParameter("@ID_Familia", paramPermiso.ID))
                '            .Add(New SqlParameter("@ID_Patente", MiPermiso.ID))
                '        End With
                '        If Not paramPermiso.ID = MiPermiso.ID Then
                '            Conexion.ExecuteNonQuery(MiComando)
                '        End If
                '    Next
            Catch ex As Exception


            End Try
        End Sub
    End Class
End Namespace

