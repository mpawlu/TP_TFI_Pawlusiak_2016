Imports EE
Imports MPP

Namespace BLL
    Public Class clsUsuario

        Public Function CrearUsuario(ByVal oUsuario As Servicios.Usuario) As Boolean
            Dim oMapper As New MPP.clsUsuario
            Dim resultado As Boolean

            resultado = oMapper.CrearUsuario(oUsuario)

            Return resultado

        End Function

        Public Function EliminarUsuario(ByVal oUsuario As Servicios.Usuario) As Boolean

            Dim oMapper As New MPP.clsUsuario
            Dim resultado As Boolean

            resultado = oMapper.EliminarUsuario(oUsuario)

            Return resultado

        End Function

        Public Function ModificarUsuario(ByVal oUsuario As Servicios.Usuario) As Boolean

            Dim oMapper As New MPP.clsUsuario
            Dim resultado As Boolean

            resultado = oMapper.ModificarUsuario(oUsuario)

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
        Public Function ListarDiseñadores() As List(Of Servicios.Usuario)

            Dim resultado As New List(Of Servicios.Usuario)


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
            _UsuarioLogin.NombreUsuario = nombreUsuario
            _UsuarioLogin.Password = clsEncriptadora.EncriptarPass(Password)
            'Try
            If Me.chequearUsuario(_UsuarioLogin) = False Then
                Throw New clsExcepcionUsuarioInexistente
            Else
                Dim _Usuario As New Servicios.Usuario
                _Usuario = Mapper.ConsultarUsuarioporNombre(_UsuarioLogin)
                If Me.chequearContraseña(_Usuario, _UsuarioLogin) = False Then
                    Throw New clsExcepcionPasswordIncorrecto
                Else
                    If Me.chequearBloqueado(_Usuario) = True Then
                        Throw New clsExcepcionUsuarioBloqueado
                    Else
                        Me.resetearIntentos(_Usuario)
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

            End Try
        End Sub

        Public Sub resetearIntentos(ByVal paramUsuario As Servicios.Usuario)
            Try
                paramUsuario.Intentos = 0
                Dim _usu As New MPP.clsUsuario
                _usu.ModificarUsuario(paramUsuario)
            Catch ex As Exception

            End Try
        End Sub

        Public Sub BloquearUsuario(ByVal paramUsuario As Servicios.Usuario)
            Try
                paramUsuario.Bloqueado = True
                Dim _usu As New MPP.clsUsuario
                _usu.ModificarUsuario(paramUsuario)
            Catch ex As Exception

            End Try
        End Sub

        Public Sub desbloquearUsuario(ByVal paramUsuario As Servicios.Usuario)
            Try
                paramUsuario.Bloqueado = False
                Dim _usu As New MPP.clsUsuario
                _usu.ModificarUsuario(paramUsuario)
            Catch ex As Exception

            End Try
        End Sub

    End Class
End Namespace






