Namespace MPP
    Public Class Permiso
        Public Function ListarPerfiles() As List(Of Servicios.PermisoCompuesto)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaPermisos As New List(Of Servicios.PermisoCompuesto)
            Dim dt As New DataTable


            DS = oDatos.Leer("s_Permiso_ListarHuerfanos", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    Dim oPermiso As New Servicios.PermisoCompuesto
                    oPermiso.ID = Item("ID_Permiso")
                    oPermiso.Descripcion = Item("Descripcion")
                    If IsDBNull(Item("URL")) = True Then
                        oPermiso.Url = Nothing
                    Else
                        oPermiso.Url = Item("URL")
                    End If
                    oPermiso.Accion = Item("Accion")

                    listaPermisos.Add(ConvertirDataRowEnPermiso(Item))
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
                    If IsDBNull(Item("URL")) = True Then
                        oPermiso.Url = Nothing
                    Else
                        oPermiso.Url = Item("URL")
                    End If
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
                    If IsDBNull(Item("URL")) = True Then
                        oPermiso.Url = Nothing
                    Else
                        oPermiso.Url = Item("URL")
                    End If
                    oPermiso.Accion = Item("Accion")
                    listaPermisos.Add(oPermiso)
                Next

                Return listaPermisos

            Else
                Return Nothing
            End If

        End Function

        Public Function listarFamilias(paramID As Integer) As Servicios.PermisoCompuesto
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oPermiso As Servicios.PermisoBase

            hdatos.Add("@ID_Permiso", paramID)

            DS = oDatos.Leer("s_Permiso_ConsultarPorID", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                Return ConvertirDataRowEnPermiso(DS.Tables(0).Rows(0))

            Else
                Return Nothing
            End If

        End Function

        Public Function obtenerIDPermiso(pDescripcionPermiso As String) As Integer
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim hdatos As New Hashtable
            Dim oPermiso As New Servicios.PermisoSimple

            hdatos.Add("@Descripcion", pDescripcionPermiso)

            DS = oDatos.Leer("s_Permiso_ConsultarPorNombre", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPermiso.ID = Item("ID_Permiso")
                Next
                Return oPermiso.ID
            Else
                Return Nothing
            End If

        End Function

        Public Function chequearNombrePermiso(pDescripcionPermiso As String) As Boolean
            Dim _listaFamilias As New List(Of Servicios.PermisoBase)
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet

            hdatos.Add("@Descripcion", pDescripcionPermiso)
            DS = oDatos.Leer("s_Permiso_ConsultarPorNombre", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Function ConvertirDataRowEnPermiso(_dr As DataRow) As Servicios.PermisoBase
            Dim _permiso As Servicios.PermisoBase
            If Not _dr.Item("Accion") Is DBNull.Value AndAlso Convert.ToBoolean(_dr.Item("Accion")) Then
                _permiso = New Servicios.PermisoSimple
            Else
                _permiso = New Servicios.PermisoCompuesto
            End If
            _permiso.ID = CInt(_dr.Item("id_permiso"))
            _permiso.Descripcion = Convert.ToString(_dr.Item("Descripcion"))

            If IsDBNull(_dr.Item("URL")) = True Then
                _permiso.Url = Nothing
            Else
                _permiso.Url = _dr.Item("URL").ToString
            End If
            If _permiso.tieneHijos Then
                Dim ListaHijos As New List(Of Servicios.PermisoBase)
                ListaHijos = Me.ListarHijos(_permiso.ID)
                For Each hijo As Servicios.PermisoBase In ListaHijos
                    _permiso.agregarHijo(hijo)
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
                oPermiso = New Servicios.PermisoCompuesto
                For Each Item As DataRow In DS.Tables(0).Rows

                    oPermiso.ID = Item("ID_Permiso")
                    oPermiso.Descripcion = Item("Descripcion")
                    If IsDBNull(Item("URL")) = True Then
                        oPermiso.Url = Nothing
                    Else
                        oPermiso.Url = Item("URL")
                    End If
                    oPermiso.Accion = Item("Accion")

                    listaPermisos.Add(ConvertirDataRowEnPermiso(Item))

                Next

                Return listaPermisos

            Else
                Return Nothing
            End If

        End Function

        Public Sub AltaPermiso(ByVal paramPermiso As Servicios.PermisoBase)
            Try
                Dim oDatos As New DAL.Datos
                Dim hdatos As New Hashtable
                Dim resultado As Boolean

                hdatos.Add("@Descripcion", paramPermiso.Descripcion)
                hdatos.Add("@URL", DBNull.Value)
                hdatos.Add("@Accion", False)
                hdatos.Add("@EsPerfil", True)

                resultado = oDatos.Escribir("s_Permiso_CrearPerfil", hdatos)
                If resultado = True Then

                    Dim IDpadre As Integer
                    IDpadre = Me.obtenerIDPermiso(paramPermiso.Descripcion)
                    oDatos = Nothing
                    hdatos = Nothing
                    For Each MiPermiso As Servicios.PermisoBase In paramPermiso.ObtenerHijos
                        Dim hdatos2 As New Hashtable
                        Dim oDatos2 As New DAL.Datos
                        If Me.ExisteRelacion(IDpadre, MiPermiso.ID) = False Then
                            hdatos2.Add("@ID_PermisoPadre", IDpadre)
                            hdatos2.Add("@ID_Permiso", MiPermiso.ID)
                            oDatos2.Escribir("s_Permiso_Padre_Crear", hdatos2)
                        End If
                    Next
                End If


            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Public Function BajaPermiso(paramID As Integer) As Boolean
            Try
                Dim oDatos As New DAL.Datos
                Dim hdatos As New Hashtable

                hdatos.Add("@ID_Permiso", paramID)

                Return oDatos.Escribir("s_Permiso_Baja", hdatos)

            Catch ex As Exception
            End Try
        End Function

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

            Catch ex As Exception

            End Try
        End Sub

        Public Function ListarPermisos() As List(Of Servicios.PermisoSimple)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaPermisos As New List(Of Servicios.PermisoSimple)
            Dim dt As New DataTable


            DS = oDatos.Leer("obtenerPrueba", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    Dim oPermiso As New Servicios.PermisoCompuesto
                    oPermiso.ID = Item("ID_Permiso")
                    oPermiso.Descripcion = Item("Descripcion")
                    If IsDBNull(Item("URL")) = True Then
                        oPermiso.Url = Nothing
                    Else
                        oPermiso.Url = Item("URL")
                    End If
                    oPermiso.Accion = Item("Accion")

                    listaPermisos.Add(ConvertirDataRowEnPermiso(Item))
                Next

                Return listaPermisos

            Else
                Return Nothing
            End If
        End Function

        Public Function ConsultarPermiso(ByVal ID As Integer) As Servicios.PermisoBase
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim oPermiso As Servicios.PermisoBase
            Dim dt As New DataTable
            Dim hdatos As New Hashtable


            hdatos.Add("@ID_Permiso", ID)

            DS = oDatos.Leer("s_Permiso_ConsultarPermiso", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    If Not IsDBNull(Item("URL")) = True Then
                        oPermiso = New Servicios.PermisoSimple
                        oPermiso.ID = Item("ID_Permiso")
                        oPermiso.Descripcion = Item("Descripcion")
                        oPermiso.Url = Item("URL")
                        Return oPermiso
                    Else
                        oPermiso = New Servicios.PermisoCompuesto
                        oPermiso.ID = Item("ID_Permiso")
                        oPermiso.Descripcion = Item("Descripcion")
                        oPermiso.Url = Nothing
                        Return oPermiso
                    End If

                Next

            Else
                Return Nothing
            End If

        End Function
        Public Function ExisteRelacion(ByVal paramID_Padre As Integer, ByVal paramID As Integer) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oPermiso As Servicios.PermisoBase

            hdatos.Add("@ID_Permiso_Padre", paramID_Padre)
            hdatos.Add("@ID_Permiso", paramID)

            DS = oDatos.Leer("s_Permiso_Padre_Existe", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                Return True
            Else
                Return False
            End If

        End Function
        Public Function ObtenerPermisoCrearCurso() As Servicios.PermisoSimple
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim oPermiso As Servicios.PermisoSimple
            Dim dt As New DataTable
            Dim listaPermisos As New List(Of Servicios.PermisoBase)

            DS = oDatos.Leer("s_Permiso_SolicitudesPendientes", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then
                oPermiso = New Servicios.PermisoSimple
                For Each Item As DataRow In DS.Tables(0).Rows
                    oPermiso.ID = Item("ID_Permiso")
                    oPermiso.Descripcion = Item("Descripcion")
                    If IsDBNull(Item("URL")) = True Then
                        oPermiso.Url = Nothing
                    Else
                        oPermiso.Url = Item("URL")
                    End If
                    oPermiso.Accion = Item("Accion")
                Next

                Return oPermiso

            Else
                Return Nothing
            End If
        End Function

    End Class
End Namespace

