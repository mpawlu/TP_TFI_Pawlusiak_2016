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
    End Class
End Namespace






