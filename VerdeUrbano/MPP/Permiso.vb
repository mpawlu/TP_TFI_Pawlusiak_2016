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
        Public Function ConsultarPermiso(ByVal _perm As Servicios.PermisoBase) As Servicios.PermisoBase

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

    End Class

    Public Function listarFamilias(paramFiltro As Boolean) As List(Of Entidades.PermisoBase)
        Dim _listaFamilias As New List(Of Entidades.PermisoBase)
        Dim MiComando As SqlCommand
        MiComando = Conexion.retornaComando("Select * from Patente where url is null and esAccion= @accion or @accion is null order by esAccion asc, id_patente asc")
        If paramFiltro = True Then
            MiComando.Parameters.Add(New SqlParameter("@accion", 0))
        Else
            MiComando.Parameters.Add(New SqlParameter("@accion", DBNull.Value))
        End If
        Dim _dt As DataTable = Conexion.ExecuteDataTable(MiComando)
        For Each _dr As DataRow In _dt.Rows
            Dim _per As Entidades.PermisoBase = ConvertirDataRowEnPermiso(_dr)
            _listaFamilias.Add(_per)
        Next
        Return _listaFamilias
    End Function

    Public Function listarFamilias(paramID As Integer) As Entidades.PermisoCompuesto
        Dim MiComando As SqlCommand = Conexion.retornaComando("Select * from Patente where id_Patente=@IdPatente")
        MiComando.Parameters.Add(New SqlParameter("@IdPatente", paramID))
        Dim _dt As DataTable = Conexion.ExecuteDataTable(MiComando)
        If _dt.Rows.Count = 1 Then
            Return ConvertirDataRowEnPermiso(_dt.Rows(0))
        Else
            Return Nothing
        End If
    End Function

    Public Function obtenerIDPermiso(paramNombrePermiso As String) As Integer
        'Esto es descripcion
        Dim MiComando As SqlCommand = Conexion.retornaComando("Select * from Patente where Nombre=@Nombre")
        MiComando.Parameters.Add(New SqlParameter("@Nombre", paramNombrePermiso))
        Dim _dt As DataTable = Conexion.ExecuteDataTable(MiComando)
        If _dt.Rows.Count = 1 Then
            Return CInt(_dt.Rows(0).Item(0))
        Else
            Return Nothing
        End If
    End Function

    Public Function chequearNombrePermiso(paramNombrePermiso As String) As Boolean
        Dim MiComando As SqlCommand = Conexion.retornaComando("Select * from Patente where Nombre=@Nombre")
        MiComando.Parameters.Add(New SqlParameter("@Nombre", paramNombrePermiso))
        Dim _dt As DataTable = Conexion.ExecuteDataTable(MiComando)
        If _dt.Rows.Count = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function ConvertirDataRowEnPermiso(_dr As DataRow) As Entidades.PermisoBase
        Dim _permiso As Entidades.PermisoBase
        If Not _dr.Item("esAccion") Is DBNull.Value AndAlso Convert.ToBoolean(_dr.Item("esAccion")) Then
            _permiso = New Entidades.PermisoSimple
        Else
            _permiso = New Entidades.PermisoCompuesto
        End If
        _permiso.ID = CInt(_dr.Item("Id_Patente"))
        _permiso.Nombre = Convert.ToString(_dr.Item("Nombre"))
        _permiso.URL = _dr.Item("URL").ToString
        If _permiso.tieneHijos Then
            Dim ListaHijos As List(Of Entidades.PermisoBase) = Me.ListarHijos(_permiso.ID)
            For Each hijo As Entidades.PermisoBase In ListaHijos
                _permiso.agregarHijo(hijo)
            Next
        End If
        Return _permiso
    End Function

    Private Function ListarHijos(ByVal _id As Integer) As List(Of Entidades.PermisoBase)
        Dim lista As List(Of Entidades.PermisoBase) = New List(Of Entidades.PermisoBase)
        Dim MiComando As SqlClient.SqlCommand = Conexion.retornaComando("SELECT Patente.Id_Patente,Nombre,Url,esAccion FROM Patente LEFT JOIN Familia_Patente as b ON (b.Id_Patente=patente.Id_Patente) WHERE b.ID_Familia = @IDFamilia  ORDER BY Patente.Id_Patente ASC")
        MiComando.Parameters.Add(New SqlParameter("@IDFamilia", _id))
        Dim dt As DataTable = Conexion.ExecuteDataTable(MiComando)
        For Each mirow As DataRow In dt.Rows
            Dim MiPermiso As Entidades.PermisoBase = Me.ConvertirDataRowEnPermiso(mirow)
            lista.Add(MiPermiso)
        Next
        Return lista
    End Function

    Public Sub AltaPermiso(paramPermiso As Entidades.PermisoBase)
        Try
            Dim MiID As Integer = Conexion.ObtenerID("Patente", "ID_Patente")
            'Es un Perfil
            Dim MiComando As SqlCommand = Conexion.retornaComando("insert into patente values(@ID_Patente, @Nombre, @URL, @esAccion)")
            With MiComando.Parameters
                .Add(New SqlParameter("@ID_Patente", MiID))
                .Add(New SqlParameter("@Nombre", paramPermiso.Nombre))
                .Add(New SqlParameter("@URL", DBNull.Value))
                .Add(New SqlParameter("@esAccion", 0))
            End With
            Conexion.ExecuteNonQuery(MiComando)

            For Each MiPermiso As Entidades.PermisoBase In paramPermiso.ObtenerHijos
                MiComando = Conexion.retornaComando("insert into familia_patente values (@ID_Familia, @ID_Patente)")
                With MiComando.Parameters
                    .Add(New SqlParameter("@ID_Familia", MiID))
                    .Add(New SqlParameter("@ID_Patente", MiPermiso.ID))
                End With
                Conexion.ExecuteNonQuery(MiComando)
            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub BajaPermiso(paramID As Integer)
        Try
            Dim MiComando As SqlCommand = Conexion.retornaComando("delete from familia_patente where ID_Familia=@IDFamilia")
            With MiComando.Parameters
                .Add(New SqlParameter("@IDFamilia", paramID))
            End With
            Conexion.ExecuteNonQuery(MiComando)
            MiComando.Dispose()
            MiComando = Conexion.retornaComando("delete from familia_patente where ID_patente=@IDFamilia")
            With MiComando.Parameters
                .Add(New SqlParameter("@IDFamilia", paramID))
            End With
            Conexion.ExecuteNonQuery(MiComando)
            MiComando.Dispose()
            MiComando = Conexion.retornaComando("delete from Patente where ID_Patente=@IDPatente")
            With MiComando.Parameters
                .Add(New SqlParameter("@IDPatente", paramID))
            End With
            Conexion.ExecuteNonQuery(MiComando)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ModificarPermiso(paramPermiso As Entidades.PermisoBase)
        Try
            Dim MiComando As SqlCommand = Conexion.retornaComando("delete from familia_patente where ID_Familia=@IDFamilia")
            With MiComando.Parameters
                .Add(New SqlParameter("@IDFamilia", paramPermiso.ID))
            End With
            Conexion.ExecuteNonQuery(MiComando)
            MiComando.Dispose()
            For Each MiPermiso As Entidades.PermisoBase In paramPermiso.ObtenerHijos
                MiComando = Conexion.retornaComando("insert into familia_patente values (@ID_Familia, @ID_Patente)")
                With MiComando.Parameters
                    .Add(New SqlParameter("@ID_Familia", paramPermiso.ID))
                    .Add(New SqlParameter("@ID_Patente", MiPermiso.ID))
                End With
                If Not paramPermiso.ID = MiPermiso.ID Then
                    Conexion.ExecuteNonQuery(MiComando)
                End If
            Next
        Catch ex As Exception


        End Try
    End Sub
End Namespace

