Imports EE

Namespace MPP
    Public Class clsUsuario

        Public Function CrearUsuario(ByVal usuario As Servicios.Usuario) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@NombreUsuario", usuario.NombreUsuario)
            hdatos.Add("@Pass", clsEncriptadora.EncriptarPass(usuario.Password))
            hdatos.Add("@DNI", usuario.DNI)
            hdatos.Add("@Activo", True)
            hdatos.Add("@Perfil", usuario.Perfil.ID)
            hdatos.Add("@Bloqueado", usuario.Bloqueado)
            hdatos.Add("@FechaAlta", usuario.FechaAlta)
            hdatos.Add("@Editable", False)
            hdatos.Add("@Intentos", usuario.Intentos)
            hdatos.Add("@ID_Idioma", usuario.Idioma.ID)
            hdatos.Add("@DVH", MPP.DigitoVerificador.CalcularDVH(usuario.StringDVH))

            resultado = oDatos.Escribir("s_Usuario_Crear", hdatos)

            DigitoVerificador.CalcularDVV("Usuario")

            Return resultado

        End Function

        Public Function EliminarUsuario(ByVal usuario As Servicios.Usuario) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Usuario", usuario.ID)

            resultado = oDatos.Escribir("s_Usuario_Baja", hdatos)
            'DigitoVerificador.CalcularDVV("Usuario")
            Return resultado

        End Function

        Public Function ModificarUsuario(ByVal usuario As Servicios.Usuario) As Boolean
            Dim i As Integer = 0
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean
            Dim oPerf As New Servicios.PermisoCompuesto
            Dim oIdioma As New Servicios.clsIdioma
            'para el usuario cambia
            hdatos.Add("@Id_Usuario", usuario.ID)
            hdatos.Add("@Pass", usuario.Password)
            hdatos.Add("@DNI", usuario.DNI)
            oPerf = usuario.Perfil
            hdatos.Add("@Perfil", oPerf.ID) ' cambiar
            hdatos.Add("@Bloqueado", usuario.Bloqueado)
            hdatos.Add("@Editable", usuario.Editable)
            hdatos.Add("@Intentos", usuario.Intentos)
            oIdioma = usuario.Idioma
            hdatos.Add("@Id_Idioma", oIdioma.ID) 'cambiar
            hdatos.Add("@DVH", MPP.DigitoVerificador.CalcularDVH(usuario.StringDVH))

            resultado = oDatos.Escribir("s_Usuario_Modificar", hdatos)
            'DigitoVerificador.CalcularDVV("Usuario")
            Return resultado
        End Function

        Public Function ListarUsuarios() As List(Of Servicios.Usuario)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaUsuario As New List(Of Servicios.Usuario)
            Dim dt As New DataTable
            Dim oUsu As Servicios.Usuario

            DS = oDatos.Leer("s_Usuario_ListarTodos", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oUsu = New Servicios.Usuario
                    oUsu.ID = Item("Id_Usuario")
                    oUsu.NombreUsuario = Item("NombreUsuario")
                    oUsu.Password = Item("Pass")
                    oUsu.DNI = Item("DNI")
                    oUsu.Activo = Item("Activo")
                    oUsu.Bloqueado = Item("Bloqueado")
                    oUsu.FechaAlta = Item("FechaAlta")
                    oUsu.Editable = Item("Editable")
                    oUsu.Intentos = Item("Intentos")
                    Dim oIdMPP As New MPP.clsIdioma
                    Dim oIdioma As New Servicios.clsIdioma
                    oIdioma.ID = Item("ID_Idioma")
                    oUsu.Idioma = oIdMPP.ConsultarIdioma(oIdioma)
                    listaUsuario.Add(oUsu)
                    Dim oPerfil As New Servicios.PermisoCompuesto
                    Dim oPerMPP As New MPP.Permiso
                    oPerfil.ID = Item("Perfil")
                    oUsu.Perfil = oPerMPP.listarFamilias(oPerfil.ID)
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

            hdatos.Add("@ID_Usuario", usuario.ID)

            DS = oDatos.Leer("s_Usuario_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oUsu.ID = Item("ID_Usuario")
                    oUsu.NombreUsuario = Item("NombreUsuario")
                    oUsu.Password = Item("Pass")
                    oUsu.DNI = Item("DNI")
                    oUsu.Activo = Item("Activo")
                    oUsu.Bloqueado = Item("Bloqueado")
                    oUsu.FechaAlta = Item("FechaAlta")
                    oUsu.Editable = Item("Editable")
                    oUsu.Intentos = Item("Intentos")
                    

                    Dim oIdMPP As New MPP.clsIdioma
                    Dim oIdioma As New Servicios.clsIdioma
                    oIdioma.ID = Item("ID_Idioma")
                    oUsu.Idioma = oIdMPP.ConsultarIdioma(oIdioma)

                    Dim oPerfil As New Servicios.PermisoCompuesto
                    Dim oPerMPP As New MPP.Permiso
                    oPerfil.ID = Item("Perfil")
                    oUsu.Perfil = oPerMPP.listarFamilias(oPerfil.ID)
                Next
                Return oUsu
            Else
                Return Nothing
            End If
        End Function

        Public Function ConsultarUsuarioporNombre(ByVal usuario As Servicios.Usuario) As Servicios.Usuario

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oUsu As New Servicios.Usuario

            hdatos.Add("@NombreUsuario", usuario.NombreUsuario)
            '   If DS.Tables(0).Rows.Count > 0 Then

            DS = oDatos.Leer("s_Usuario_Consultar_PorNombre", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oUsu.ID = Item("ID_Usuario")
                    oUsu.NombreUsuario = Item("NombreUsuario")
                    oUsu.Password = Item("Pass")
                    oUsu.DNI = Item("DNI")
                    oUsu.Activo = CBool(Item("Activo"))
                    oUsu.Bloqueado = CBool(Item("Bloqueado"))
                    oUsu.FechaAlta = CDate(Item("FechaAlta"))
                    oUsu.Editable = CBool(Item("Editable"))
                    oUsu.Intentos = Item("Intentos")

                    Dim oIdMPP As New MPP.clsIdioma
                    Dim oIdioma As New Servicios.clsIdioma
                    oIdioma.ID = Item("ID_Idioma")
                    oUsu.Idioma = oIdMPP.ConsultarIdioma(oIdioma)

                    Dim oPerfil As New Servicios.PermisoCompuesto
                    Dim oPerMPP As New MPP.Permiso
                    oPerfil.ID = Item("Perfil")
                    oUsu.Perfil = oPerMPP.listarFamilias(oPerfil.ID)

                Next
                Return oUsu
            Else
                Return Nothing
            End If
        End Function


#Region "Login"
       


        Public Function chequearUsuario(ByVal oUsuario As Servicios.Usuario) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oUsu As New Servicios.Usuario
            hdatos.Add("@NombreUsuario", oUsuario.NombreUsuario)
            DS = oDatos.Leer("s_Usuario_ChequearUsuario", hdatos)
            If DS.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Function


#End Region


    End Class
End Namespace


