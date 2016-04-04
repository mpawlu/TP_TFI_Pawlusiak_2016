Imports EE
Imports MPP

Namespace BLL
    Public Class clsUsuario

        Public Function CrearUsuario(ByVal oUsuario As EE.clsUsuario) As Boolean
            Dim oMapper As New MPP.clsUsuario
            Dim resultado As Boolean

            resultado = oMapper.CrearUsuario(oUsuario)

            Return resultado

        End Function

        Public Function EliminarUsuario(ByVal oUsuario As EE.clsUsuario) As Boolean

            Dim oMapper As New MPP.clsUsuario
            Dim resultado As Boolean

            resultado = oMapper.EliminarUsuario(oUsuario)

            Return resultado

        End Function

        Public Function ModificarUsuario(ByVal oUsuario As EE.clsUsuario) As Boolean

            Dim oMapper As New MPP.clsUsuario
            Dim resultado As Boolean

            resultado = oMapper.ModificarUsuario(oUsuario)

            Return resultado

        End Function


        Public Function ListarUsuarios() As List(Of EE.clsUsuario)

            Dim listaUsuario As New List(Of EE.clsUsuario)
            Dim oMapper As New MPP.clsUsuario

            listaUsuario = oMapper.ListarUsuarios()

            Return listaUsuario

        End Function

        Public Function ListarUsuario(ByVal oUsuario As EE.clsUsuario) As EE.clsUsuario

            Dim resultado As New EE.clsUsuario
            Dim Mapper As New MPP.clsUsuario

            resultado = Mapper.ListarUsuario(oUsuario)

            Return resultado

        End Function
        Public Function ListarDiseñadores() As List(Of EE.clsUsuario)

            Dim resultado As New List(Of EE.clsUsuario)


            Return resultado

        End Function
        Public Function RecuperarUsuario(ByVal oUsuario As EE.clsUsuario) As EE.clsUsuario

            Dim resultado As New EE.clsUsuario
            Dim Mapper As New MPP.clsUsuario

            resultado = Mapper.ListarUsuario(oUsuario)

            Return resultado

        End Function
    End Class
End Namespace






