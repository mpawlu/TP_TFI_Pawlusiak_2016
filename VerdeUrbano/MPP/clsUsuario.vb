Imports EE

Namespace MPP
    Public Class clsUsuario

        Public Function CrearUsuario(ByVal usuario As Servicios.Usuario) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@NombreUsuario", usuario.NombreUsuario)
            hdatos.Add("@Password", usuario.Password)
            hdatos.Add("@DNI", usuario.DNI)
            hdatos.Add("@Activo", usuario.Activo)
            hdatos.Add("@Perfil", usuario.Perfil)
            hdatos.Add("@Bloqueado", usuario.Bloqueado)
            hdatos.Add("@FechaAlta", usuario.FechaAlta)
            hdatos.Add("@Editable", usuario.Editable)
            hdatos.Add("@Intentos", usuario.Intentos)
            hdatos.Add("@IdIdioma", usuario.Idioma.ID)

            resultado = oDatos.Escribir("s_Usuario_Crear", hdatos)

            Return resultado

        End Function

        Public Function EliminarUsuario(ByVal usuario As Servicios.Usuario) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@IdUsuario", usuario.Id)

            resultado = oDatos.Escribir("s_Usuario_Baja", hdatos)

            Return resultado

        End Function

        Public Function ModificarUsuario(ByVal usuario As Servicios.Usuario) As Boolean
            Dim i As Integer = 0
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean
            'para el usuario cambia
            hdatos.Add("@IdUsuario", usuario.ID)
            hdatos.Add("@NombreUsuario", usuario.NombreUsuario)
            hdatos.Add("@Password", usuario.Password)
            hdatos.Add("@DNI", usuario.DNI)
            hdatos.Add("@Activo", usuario.Activo)
            hdatos.Add("@Perfil", usuario.Perfil)
            hdatos.Add("@Bloqueado", usuario.Bloqueado)
            hdatos.Add("@FechaAlta", usuario.FechaAlta)
            hdatos.Add("@Editable", usuario.Editable)
            hdatos.Add("@Intentos", usuario.Intentos)
            hdatos.Add("@IdIdioma", usuario.Idioma.ID)

            resultado = oDatos.Escribir("s_Usuario_Modificar", hdatos)
            Return resultado
        End Function


        Public Function ListarUsuarios() As List(Of Servicios.Usuario)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaUsuario As New List(Of Servicios.Usuario)
            Dim dt As New DataTable
            Dim oUsu As Servicios.Usuario

            DS = oDatos.Leer("s_Usuarios_Listar", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oUsu = New Servicios.Usuario
                    oUsu.Id = Item("IdUsuario")
                    oUsu.NombreUsuario = Item("NombreUsuario")
                    oUsu.Password = Item("Password")
                    oUsu.DNI = Item("DNI")
                    oUsu.Activo = Item("Activo")
                    oUsu.Perfil = Item("Perfil")
                    oUsu.Bloqueado = Item("Bloqueado")
                    oUsu.FechaAlta = Item("FechaAlta")
                    oUsu.Editable = Item("Editables")
                    oUsu.Intentos = Item("Intentos")
                    oUsu.Idioma.ID = Item("ID_Idioma")
                    oUsu.Idioma.Descripcion = Item("Descripcion")

                    listaUsuario.Add(oUsu)
                Next

                Return listaUsuario

            Else
                Return Nothing
            End If
        End Function

        Public Function ConsultarUsuario(ByVal usuario As Servicios.Usuario) As Servicios.Usuario

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oUsu As New Servicios.Usuario

            hdatos.Add("@IdUsuario", usuario.ID)
            '   If DS.Tables(0).Rows.Count > 0 Then

            DS = oDatos.Leer("s_Usuario_Listar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oUsu.ID = Item("IdUsuario")
                    oUsu.NombreUsuario = Item("NombreUsuario")
                    oUsu.Password = Item("Password")
                    oUsu.DNI = Item("DNI")
                    oUsu.Activo = Item("Activo")
                    oUsu.Perfil = Item("Perfil")
                    oUsu.Bloqueado = Item("Bloqueado")
                    oUsu.FechaAlta = Item("FechaAlta")
                    oUsu.Editable = Item("Editables")
                    oUsu.Intentos = Item("Intentos")
                    oUsu.Idioma.ID = Item("ID_Idioma")
                    oUsu.Idioma.Descripcion = Item("Descripcion")
                Next
                Return oUsu
            Else
                Return Nothing
            End If
        End Function

    End Class
End Namespace


