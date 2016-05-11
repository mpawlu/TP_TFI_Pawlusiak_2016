Namespace BLL
    Public Class ClsTraduccion
        Public Function CrearTraduccion(ByVal oTraduccion As Servicios.ClsTraduccion) As Boolean
            Try
                Dim oMapper As New MPP.ClsTraduccion
                Dim resultado As Boolean
                Dim oBitacora As Servicios.clsBitacora

                resultado = oMapper.CrearTraduccion(oTraduccion)

                Return resultado

                If resultado = False Then
                    oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Alta, "Ocurrio un error al intentar dar de alta una traduccion.")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                End If
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function
        Public Function ConsultarTraduccion(ByVal Traduccion As Servicios.ClsTraduccion) As Servicios.ClsTraduccion
            Try
                Dim resultado As New Servicios.ClsTraduccion
                Dim Mapper As New MPP.ClsTraduccion

                resultado = Mapper.ConsultarTraduccion(Traduccion)

                Return resultado
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function
        Public Function ListarTraducciones(ByVal Idioma As Servicios.clsIdioma) As List(Of Servicios.ClsTraduccion)
            Try
                Dim resultado As New List(Of Servicios.ClsTraduccion)
                Dim Mapper As New MPP.ClsTraduccion

                resultado = Mapper.ListarTraducciones(Idioma)

                Return resultado
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function

        Public Shared Function Traducir(ByVal oUsuarioSesion As Servicios.Usuario, ByVal ID_Leyenda As String) As String
            'Try
            Dim oIdioma As New Servicios.clsIdioma
            Dim oLeyenda As New Servicios.clsLeyenda
            If oUsuarioSesion Is Nothing Then
                oIdioma.ID = 1
            Else
                oIdioma = oUsuarioSesion.Idioma
            End If
            oLeyenda.ID = ID_Leyenda
            Dim oATraducir As New Servicios.ClsTraduccion
            oATraducir.Idioma = oIdioma
            oATraducir.Leyenda = oLeyenda
            Dim oTradMPP As New MPP.ClsTraduccion
            oATraducir = oTradMPP.ConsultarTraduccion(oATraducir)
            Return oATraducir.Traduccion
            'Catch ex As Exception
            'End Try
        End Function

        Public Function ModificarTraduccion(ByVal _Traduccion As Servicios.ClsTraduccion) As Boolean
            Try
                Dim oMapper As New MPP.ClsTraduccion
                Dim resultado As Boolean
                Dim oBitacora As Servicios.clsBitacora

                resultado = oMapper.ModificarTraduccion(_Traduccion)

                Return resultado

                If resultado = False Then
                    oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Alta, "Ocurrio un error al intentar Modificar una traduccion.")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                End If
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function
    End Class
End Namespace
