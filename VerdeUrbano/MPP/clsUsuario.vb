Imports EE

Namespace MPP
    Public Class clsUsuario

        Public Function CrearUsuario(ByVal usuario As EE.clsUsuario) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@Nombre", usuario.Nombre)
            hdatos.Add("@Apellido", usuario.Apellido)
            hdatos.Add("@DNI", usuario.DNI)
            hdatos.Add("@IdLocalidad", usuario.Localidad.Id)
            hdatos.Add("@Activo", "True")
            hdatos.Add("@IdIdioma", usuario.Idioma.ID)

            resultado = oDatos.Escribir("s_Usuario_Crear", hdatos)

            Return resultado

        End Function

        Public Function EliminarUsuario(ByVal usuario As EE.clsUsuario) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@IdUsuario", usuario.Id)

            resultado = oDatos.Escribir("s_Usuario_Baja", hdatos)

            Return resultado

        End Function

        Public Function ModificarUsuario(ByVal usuario As EE.clsUsuario) As Boolean
            Dim i As Integer = 0
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean
            'para el usuario cambia
            hdatos.Add("@IdUsuario", usuario.Id)
            hdatos.Add("@Nombre", usuario.Nombre)
            hdatos.Add("@Apellido", usuario.Apellido)
            hdatos.Add("@DNI", usuario.DNI)
            hdatos.Add("@IdLocalidad", usuario.Localidad.Id)
            hdatos.Add("@IdIdioma", usuario.Idioma.ID)

            
            resultado = oDatos.Escribir("s_Usuario_Modificar", hdatos)
            Return resultado
        End Function


        Public Function ListarUsuarios() As List(Of EE.clsUsuario)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaUsuario As New List(Of EE.clsUsuario)
            Dim dt As New DataTable
            Dim oUsu As EE.clsUsuario

            DS = oDatos.Leer("s_Usuarios_Listar", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oUsu = New EE.clsUsuario
                    oUsu.Id = Item("IdUsuario")
                    oUsu.Nombre = Item("Nombre")
                    oUsu.Apellido = Item("Apellido")
                    oUsu.DNI = Item("DNI")
                    oUsu.Localidad.Id = Item("IdLocalidad")
                    oUsu.Localidad.Descripcion = Item("Localidad")
                    oUsu.Activo = Item("Activo")
                    oUsu.Idioma.ID = Item("ID_Idioma")
                    oUsu.Idioma.Descripcion = Item("Descripcion")

                    listaUsuario.Add(oUsu)
                Next

                Return listaUsuario

            Else
                Return Nothing
            End If
        End Function

        Public Function ListarUsuario(ByVal usuario As EE.clsUsuario) As EE.clsUsuario

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oUsu As New EE.clsUsuario

            hdatos.Add("@IdUsuario", usuario.Id)
            '   If DS.Tables(0).Rows.Count > 0 Then

            DS = oDatos.Leer("s_Usuario_Listar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oUsu = New EE.clsUsuario
                    oUsu.Id = Item("IdUsuario")
                    oUsu.Nombre = Item("Nombre")
                    oUsu.Apellido = Item("Apellido")
                    oUsu.DNI = Item("DNI")
                    oUsu.Localidad.Id = Item("IdLocalidad")
                    oUsu.Localidad.Descripcion = Item("Localidad")
                    oUsu.Activo = Item("Activo")
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


