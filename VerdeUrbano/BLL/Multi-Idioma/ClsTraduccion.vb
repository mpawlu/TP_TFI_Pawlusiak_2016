﻿Namespace BLL
    Public Class ClsTraduccion
        Public Function CrearTraduccion(ByVal oTraduccion As Servicios.ClsTraduccion) As Boolean
            Dim oMapper As New MPP.ClsTraduccion
            Dim resultado As Boolean

            resultado = oMapper.CrearTraduccion(oTraduccion)

            Return resultado

        End Function
        Public Function ConsultarTraduccion(ByVal Traduccion As Servicios.ClsTraduccion) As Servicios.ClsTraduccion

            Dim resultado As New Servicios.ClsTraduccion
            Dim Mapper As New MPP.ClsTraduccion

            resultado = Mapper.ConsultarTraduccion(Traduccion)

            Return resultado
        End Function
        Public Function ListarTraducciones(ByVal Idioma As Servicios.clsIdioma) As List(Of Servicios.ClsTraduccion)
            Dim resultado As New List(Of Servicios.ClsTraduccion)
            Dim Mapper As New MPP.ClsTraduccion

            resultado = Mapper.ListarTraducciones(Idioma)

            Return resultado

        End Function

    End Class
End Namespace
