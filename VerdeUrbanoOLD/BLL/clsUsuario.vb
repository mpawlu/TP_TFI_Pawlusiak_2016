﻿Imports EE
Imports MPP

Namespace BLL
    Public Class clsUsuario

        Public Function CrearUsuario(ByVal oUsuario As Servicios.Usuario) As Boolean
            Dim oMapper As New MPP.clsUsuario
            Dim resultado As Boolean

            resultado = oMapper.CrearUsuario(oUsuario)

            If resultado = True Then
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Alta, "Se genero correctamente el usuario " & oUsuario.NombreUsuario)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            Else
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Alta, "Ocurrio un error al intentar dar de alta un usuario")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End If

            Return resultado

        End Function

        Public Function EliminarUsuario(ByVal oUsuario As Servicios.Usuario) As Boolean

            Dim oMapper As New MPP.clsUsuario
            Dim resultado As Boolean

            resultado = oMapper.EliminarUsuario(oUsuario)

            If resultado = True Then
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Baja, "La baja del usuario " & oUsuario.NombreUsuario & "se realizó correctamente")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            Else
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Baja, "Ocurrio un error al intentar dar de baja un usuario")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End If

            Return resultado

        End Function

        Public Function ModificarUsuario(ByVal oUsuario As Servicios.Usuario) As Boolean

            Dim oMapper As New MPP.clsUsuario
            Dim resultado As Boolean

            resultado = oMapper.ModificarUsuario(oUsuario)

            If resultado = True Then
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Modificacion, "Se modifico correctamente el usuario " & oUsuario.NombreUsuario)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            Else
                Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Modificacion, "Ocurrio un error al intentar modificar el usuario " & oUsuario.NombreUsuario)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End If

            Return resultado

        End Function


        Public Function ListarUsuarios() As List(Of Servicios.Usuario)

            Dim listaUsuario As New List(Of Servicios.Usuario)
            Dim oMapper As New MPP.clsUsuario

            listaUsuario = oMapper.ListarUsuarios()

            Return listaUsuario

        End Function

        Public Function ListarUsuario(ByVal oUsuario As Servicios.Usuario) As Servicios.Usuario

            Dim resultado As New Servicios.Usuario
            Dim Mapper As New MPP.clsUsuario

            resultado = Mapper.ConsultarUsuario(oUsuario)

            Return resultado

        End Function

        Public Function RecuperarUsuario(ByVal oUsuario As Servicios.Usuario) As Servicios.Usuario
            Dim resultado As New Servicios.Usuario
            Dim Mapper As New MPP.clsUsuario
            resultado = Mapper.ConsultarUsuario(oUsuario)
            Return resultado
        End Function


        Public Function Login(ByVal nombreUsuario As String, ByVal Password As String) As Servicios.Usuario
            Dim _UsuarioLogin As New Servicios.Usuario
            Dim Mapper As New MPP.clsUsuario
            Dim oBitacora As Servicios.clsBitacora
            _UsuarioLogin.NombreUsuario = nombreUsuario
            _UsuarioLogin.Password = clsEncriptadora.EncriptarPass(Password)
            If Me.chequearUsuario(_UsuarioLogin) = False Then
                Throw New Servicios.clsExcepcionUsuarioInexistente
            Else
                Dim _Usuario As New Servicios.Usuario
                _Usuario = Mapper.ConsultarUsuarioporNombre(_UsuarioLogin)
                If Me.chequearContraseña(_Usuario, _UsuarioLogin) = False Then
                    'Guardo el evento en la bitacora
                    oBitacora = New Servicios.clsBitacora(_Usuario, Servicios.clsBitacora.tipoOperacionBitacora.Login, "El usuario " & _Usuario.NombreUsuario & " ingreso mal la contraseña.")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                    'Lanzo la excepcion
                    Throw New Servicios.clsExcepcionPasswordIncorrecto
                Else
                    If Me.chequearBloqueado(_Usuario) = True Then
                        'Guardo el evento en la bitacora
                        oBitacora = New Servicios.clsBitacora(_Usuario, Servicios.clsBitacora.tipoOperacionBitacora.Login, "El usuario " & _Usuario.NombreUsuario & " intento loguearse pero se encuentra bloqueado.")
                        BLL.clsBitacora.RegistrarEvento(oBitacora)
                        Throw New Servicios.clsExcepcionUsuarioBloqueado
                    Else
                        Me.resetearIntentos(_Usuario)
                        'Guardo el evento en la bitacora
                        oBitacora = New Servicios.clsBitacora(_Usuario, Servicios.clsBitacora.tipoOperacionBitacora.Login, "El usuario " & _Usuario.NombreUsuario & " se logueo correctamente en el sistema.")
                        BLL.clsBitacora.RegistrarEvento(oBitacora)
                        Return _Usuario
                    End If
                End If
            End If


        End Function

        Public Function chequearUsuario(ByVal oUsuario As Servicios.Usuario) As Boolean
            Try
                Dim resultado As Boolean
                Dim Mapper As New MPP.clsUsuario
                resultado = Mapper.chequearUsuario(oUsuario)
                Return resultado
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function

        Public Function chequearContraseña(ByVal oUsuario As Servicios.Usuario, ByVal oUsuarioLogueado As Servicios.Usuario) As Boolean
            Try
                Dim Mapper As New MPP.clsUsuario
                If oUsuario.Password = oUsuarioLogueado.Password Then
                    Return True
                Else
                    Me.actualizarIntentos(oUsuario)
                    Return False
                End If
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try

        End Function

        Public Function chequearBloqueado(ByVal oUsuario As Servicios.Usuario) As Boolean
            Try
                If oUsuario.Bloqueado = True Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try

        End Function

        Public Sub actualizarIntentos(ByVal oUsuario As Servicios.Usuario)
            Try
                Dim Mapper As New MPP.clsUsuario
                oUsuario.Intentos += 1
                If oUsuario.Intentos >= 3 Then
                    Me.BloquearUsuario(oUsuario)
                End If
                Mapper.ModificarUsuario(oUsuario)
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Sub

        Public Sub resetearIntentos(ByVal paramUsuario As Servicios.Usuario)
            Try
                paramUsuario.Intentos = 0
                Dim _usu As New MPP.clsUsuario
                _usu.ModificarUsuario(paramUsuario)
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Sub

        Public Sub BloquearUsuario(ByVal paramUsuario As Servicios.Usuario)
            Try
                paramUsuario.Bloqueado = True
                Dim _usu As New MPP.clsUsuario
                _usu.ModificarUsuario(paramUsuario)

                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(paramUsuario, Servicios.clsBitacora.tipoOperacionBitacora.Bloqueo, "Se ha bloqueado al usuario " & paramUsuario.NombreUsuario)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Sub

        Public Sub desbloquearUsuario(ByVal paramUsuario As Servicios.Usuario)
            Try
                paramUsuario.Bloqueado = False
                Dim _usu As New MPP.clsUsuario
                _usu.ModificarUsuario(paramUsuario)

                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(paramUsuario, Servicios.clsBitacora.tipoOperacionBitacora.Desbloqueo, "Se ha desbloqueado al usuario " & paramUsuario.NombreUsuario)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            Catch ex As Exception

                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Sub

        Public Sub cambiarPassword(ByVal paramUsuario As Servicios.Usuario)
            Try
                Dim _mppUsuario As New MPP.clsUsuario

                If _mppUsuario.cambiarPassword(paramUsuario) = True Then
                    Dim oBitacora As New Servicios.clsBitacora
                    oBitacora = New Servicios.clsBitacora(paramUsuario, Servicios.clsBitacora.tipoOperacionBitacora.Modificacion, "El usuario " & paramUsuario.NombreUsuario & " ha modificado su contraseña.")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                Else
                    Dim oBitacora As New Servicios.clsBitacora
                    oBitacora = New Servicios.clsBitacora(paramUsuario, Servicios.clsBitacora.tipoOperacionBitacora.Modificacion, "Ocurrui un error cuando el usuario " & paramUsuario.NombreUsuario & " intento modificar su contraseña.")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                End If
            Catch ex As Exception
                Dim oBitacora As New Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(paramUsuario, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Sub
        Public Function ListarPorPermiso(ByVal _Permiso As Servicios.PermisoSimple) As List(Of Servicios.Usuario)
            Dim mpp As New MPP.clsUsuario
            Dim todos As New List(Of Servicios.Usuario)
            Dim resultado As New List(Of Servicios.Usuario)
            todos = mpp.ListarUsuarios()
            For Each _usu As Servicios.Usuario In todos
                If Me.TienePermiso(_usu) = True Then
                    resultado.Add(_usu)
                End If
            Next
            Return resultado

        End Function
#Region "Listar usuarios con permisos para crear curso (Diseñandores)"
        Public Function ObtenerDisenadores() As List(Of Servicios.Usuario)
            Dim oUsuariosTodos As New List(Of Servicios.Usuario)
            Dim oDisenadores As New List(Of Servicios.Usuario)
            oUsuariosTodos = Me.ListarUsuarios
            For Each disenador As Servicios.Usuario In oUsuariosTodos
                If Me.TienePermiso(disenador) = True Then
                    oDisenadores.Add(disenador)
                End If
            Next
            Return oDisenadores
        End Function
        Public Function TienePermiso(ByVal _usu As Servicios.Usuario) As Boolean
            Dim resultado As Boolean
            resultado = False
            For Each p As Servicios.PermisoBase In _usu.Perfil.ListaPermisos
                If p.TieneHijos = True Then
                    If p.ID = 10 Then
                        resultado = True
                        Return resultado
                    Else
                        resultado = Me.RecorrerHijos(p)
                    End If
                Else
                    If p.ID = 46 Then
                        resultado = True
                        Return resultado
                    End If
                End If

            Next
            Return resultado
        End Function
        Public Function RecorrerHijos(ByVal _hijo As Servicios.PermisoBase) As Boolean
            If _hijo.TieneHijos = True Then
                If _hijo.ID = 10 Then
                    Return True
                Else
                    _hijo = New Servicios.PermisoCompuesto
                    For Each pHijo As Servicios.PermisoBase In _hijo.ObtenerHijos
                        Me.RecorrerHijos(_hijo)
                    Next
                End If
            Else
                If _hijo.ID = 46 Then
                    Return True
                End If
            End If

        End Function
#End Region

    End Class
End Namespace






