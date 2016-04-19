﻿Imports EE

Namespace MPP
    Public Class clsUsuario

        Public Function CrearUsuario(ByVal usuario As Servicios.Usuario) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@NombreUsuario", usuario.NombreUsuario)
            hdatos.Add("@Pass", usuario.Password)
            hdatos.Add("@DNI", usuario.DNI)
            hdatos.Add("@Activo", usuario.Activo)
            hdatos.Add("@Perfil", usuario.Perfil.ID)
            hdatos.Add("@Bloqueado", usuario.Bloqueado)
            hdatos.Add("@FechaAlta", usuario.FechaAlta)
            hdatos.Add("@Editable", usuario.Editable)
            hdatos.Add("@Intentos", usuario.Intentos)
            hdatos.Add("@ID_Idioma", usuario.Idioma.ID)
            hdatos.Add("@DVH", "ASFDDFD")

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
            hdatos.Add("@Pass", usuario.Password)
            hdatos.Add("@DNI", usuario.DNI)
            hdatos.Add("@Activo", usuario.Activo)
            hdatos.Add("@Perfil", usuario.Perfil)
            hdatos.Add("@Bloqueado", usuario.Bloqueado)
            hdatos.Add("@FechaAlta", usuario.FechaAlta)
            hdatos.Add("@Editable", usuario.Editable)
            hdatos.Add("@Intentos", usuario.Intentos)
            hdatos.Add("@IdIdioma", usuario.Idioma.ID)
            hdatos.Add("@DVH", "ASFDDFD")

            resultado = oDatos.Escribir("s_Usuario_Modificar", hdatos)
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
                    oUsu.Id = Item("IdUsuario")
                    oUsu.NombreUsuario = Item("NombreUsuario")
                    oUsu.Password = Item("Pass")
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

            hdatos.Add("@ID_Usuario", usuario.ID)
            '   If DS.Tables(0).Rows.Count > 0 Then

            DS = oDatos.Leer("s_Usuario_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oUsu.ID = Item("IdUsuario")
                    oUsu.NombreUsuario = Item("NombreUsuario")
                    oUsu.Password = Item("Pass")
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

        Public Function ConsultarUsuarioporNombre(ByVal usuario As Servicios.Usuario) As Servicios.Usuario

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oUsu As New Servicios.Usuario

            hdatos.Add("@NombreUsuario", usuario.NombreUsuario)
            '   If DS.Tables(0).Rows.Count > 0 Then

            DS = oDatos.Leer("s_Usuario_Consultar_porNombre", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oUsu.ID = Item("IdUsuario")
                    oUsu.NombreUsuario = Item("NombreUsuario")
                    oUsu.Password = Item("Pass")
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


#Region "Login"
        Public Function chequearContraseña(ByVal oUsuario As Servicios.Usuario) As Boolean
            Try
                Dim oDatos As New DAL.Datos
                Dim resultado As Boolean
                Dim hdatos As New Hashtable
                Dim DS As New DataSet
                hdatos.Add("@NombreUsuario", oUsuario.NombreUsuario)
                hdatos.Add("@Pass", oUsuario.Password)
                DS = oDatos.Leer("s_Usuario_chequearContraseña", hdatos)
                If DS.Tables(0).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ActualizarIntentos(paramUsuario As Servicios.Usuario) As Boolean
            Try
                Dim oDatos As New DAL.Datos
                Dim resultado As Boolean
                Dim hdatos As New Hashtable
                hdatos.Add("@ID_Usuario", paramUsuario.ID)
                hdatos.Add("@Intentos", paramUsuario.Intentos)
                resultado = oDatos.Escribir("s_Usuario_ActualizarIntentos", hdatos)
                Return resultado
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function bloquearUsuario(paramUsuario As Servicios.Usuario) As Boolean
            Try
                Dim oDatos As New DAL.Datos
                Dim resultado As Boolean
                Dim hdatos As New Hashtable
                hdatos.Add("@ID_Usuario", paramUsuario.ID)
                hdatos.Add("@Bloqueado", True)
                resultado = oDatos.Escribir("s_Usuario_ManejoBloqueo", hdatos)
                Return resultado
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function desbloquearUsuario(paramUsuario As Servicios.Usuario) As Boolean
            Try
                Dim oDatos As New DAL.Datos
                Dim resultado As Boolean
                Dim hdatos As New Hashtable
                hdatos.Add("@ID_Usuario", paramUsuario.ID)
                hdatos.Add("@Bloqueado", True)
                resultado = oDatos.Escribir("s_Usuario_ManejoBloqueo", hdatos)
                Return resultado
            Catch ex As Exception
                Throw ex
            End Try
        End Function

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


