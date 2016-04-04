Namespace BLL
    Public Class ClsTraduccion
        Public Function CrearTraduccion(ByVal oTraduccion As EE.clsTraduccion) As Boolean
            Dim oMapper As New MPP.ClsTraduccion
            Dim resultado As Boolean

            resultado = oMapper.CrearTraduccion(oTraduccion)

            Return resultado

        End Function
        Public Function ConsultarTraduccion(ByVal Traduccion As EE.clsTraduccion) As EE.clsTraduccion

            Dim resultado As New EE.clsTraduccion
            Dim Mapper As New MPP.ClsTraduccion

            resultado = Mapper.ConsultarTraduccion(Traduccion)

            Return resultado
        End Function
        Public Function ListarTraducciones(ByVal Idioma As EE.clsIdioma) As List(Of EE.clsTraduccion)
            Dim resultado As New List(Of EE.clsTraduccion)
            Dim Mapper As New MPP.ClsTraduccion

            resultado = Mapper.ListarTraducciones(Idioma)

            Return resultado

        End Function

    End Class
End Namespace
