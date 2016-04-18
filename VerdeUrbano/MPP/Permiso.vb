Namespace MPP
    Public Class Permiso
        Public Function ListarTodosLosPermisos() As List(Of Servicios.PermisoBase)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaPermisos As New List(Of Servicios.PermisoBase)
            Dim dt As New DataTable
            Dim oPermiso As Servicios.PermisoBase

            DS = oDatos.Leer("s_Permiso_ListarTodos", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    'oUsu = New Servicios.Usuario
                    'oUsu.ID = Item("IdUsuario")
                    'oUsu.NombreUsuario = Item("NombreUsuario")
                    'oUsu.Password = Item("Pass")
                    'oUsu.DNI = Item("DNI")
                    'oUsu.Activo = Item("Activo")
                    'oUsu.Perfil = Item("Perfil")
                    'oUsu.Bloqueado = Item("Bloqueado")
                    'oUsu.FechaAlta = Item("FechaAlta")
                    'oUsu.Editable = Item("Editables")
                    'oUsu.Intentos = Item("Intentos")
                    'oUsu.Idioma.ID = Item("ID_Idioma")
                    'oUsu.Idioma.Descripcion = Item("Descripcion")

                    'listaUsuario.Add(oUsu)
                Next

                Return listaPermisos

            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

