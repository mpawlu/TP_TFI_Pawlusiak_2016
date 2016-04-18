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
            Dim _Usuario As New Servicios.Usuario
            _Usuario.NombreUsuario = nombreUsuario
            _Usuario.Password = clsEncriptadora.EncriptarPass(Password)
            Try
                'Existe el usuario?
                If Me.chequearUsuario(_Usuario.NombreUsuario) = False Then
                    '      Throw New UsuarioInexistenteException
                Else

                    'Esta bloquedo?
                    If Me.chequearBloqueado(_Usuario.NombreUsuario) = True Then
                        '         Throw New UsuarioBloqueadoException
                    Else
                        'Esta bien la contraseña?
                        If Me.chequearContraseña(_Usuario.NombreUsuario, _Usuario.Password) = False Then
                            '     Throw New PasswordIncorrectoException
                        Else
                            'Resetear los intentos
                            _Usuario = (New MPP.clsUsuario).ConsultarUsuario(_Usuario)
                            Me.resetearIntentos(_Usuario)
                            Return _Usuario
                        End If
                    End If
                End If
                'Catch ex As UsuarioInexistenteException
                '    Throw New BLL.UsuarioInexistenteException
                'Catch ex As UsuarioBloqueadoException
                '    Throw New BLL.UsuarioBloqueadoException
                'Catch ex As PasswordIncorrectoException
                '    Throw New BLL.PasswordIncorrectoException
            Catch ex As Exception

            End Try
        End Function

        Public Function chequearUsuario(paramNombreUsuario As String) As Boolean
            Try
                Return (New MPP.clsUsuario).chequearUsuario(paramNombreUsuario)
            Catch ex As Exception

            End Try
        End Function

        Public Function chequearContraseña(paramNombreUsuario As String, paramContraseña As String) As Boolean
            Try
                If (New MPP.clsUsuario).chequearContraseña(paramNombreUsuario, paramContraseña) = True Then
                    Return True
                Else
                    ' Me.actualizarIntentos(paramUsuario)
                    Return False
                End If
            Catch ex As Exception

            End Try

        End Function

        Public Function chequearBloqueado(paramNombreUsuario As String) As Boolean
            Try
                Return (New MPP.clsUsuario).chequearBloqueado(paramNombreUsuario)
            Catch ex As Exception

            End Try

        End Function

        Public Sub actualizarIntentos(ByVal paramUsuario As Servicios.Usuario)
            Try
                paramUsuario.Intentos += 1
                Dim _usu As New MPP.clsUsuario
                If paramUsuario.Intentos >= 3 Then
                    Me.BloquearUsuario(paramUsuario)
                End If
                _usu.ActualizarIntentos(paramUsuario)
            Catch ex As Exception

            End Try
        End Sub

        Public Sub resetearIntentos(ByVal paramUsuario As Servicios.Usuario)
            Try
                paramUsuario.Intentos = 0
                Dim _usu As New MPP.clsUsuario
                _usu.ActualizarIntentos(paramUsuario)
            Catch ex As Exception

            End Try
        End Sub

        Public Sub BloquearUsuario(ByVal paramUsuario As Servicios.Usuario)
            Try
                Dim _usu As New MPP.clsUsuario
                _usu.bloquearUsuario(paramUsuario)
            Catch ex As Exception

            End Try
        End Sub

        Public Sub desbloquearUsuario(ByVal paramUsuario As Servicios.Usuario)
            Try
                Dim _usu As New MPP.clsUsuario
                _usu.desbloquearUsuario(paramUsuario)
            Catch ex As Exception

            End Try
        End Sub

    End Class
End Namespace






