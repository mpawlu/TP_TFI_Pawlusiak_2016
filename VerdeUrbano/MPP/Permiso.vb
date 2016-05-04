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
End Namespace

