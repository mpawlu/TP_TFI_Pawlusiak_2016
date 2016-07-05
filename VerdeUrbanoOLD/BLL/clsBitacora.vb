Namespace BLL
    Public Class clsBitacora
        Public Shared Sub RegistrarEvento(ByVal Evento As Servicios.clsBitacora)
            Dim mpp As New MPP.Bitacora
            Dim resultado As Boolean

            resultado = mpp.CrearEvento(Evento)

        End Sub

        Public Function ConsultarUltimoID() As Integer
            Try
                Dim oMapper As New MPP.Bitacora
                Return oMapper.UltimoID
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function
        Public Function ListarBitacora(ByVal paramDesde As Integer) As List(Of Servicios.clsBitacora)
            Try
                Dim listaBitacora As New List(Of Servicios.clsBitacora)
                Dim oMapper As New MPP.Bitacora

                listaBitacora = oMapper.ListarBitacora(paramDesde)

                Return listaBitacora
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function

        Public Function ListarBitacora(ByVal paramUsuario As Servicios.Usuario, ByVal paramFecha As Date, ByVal paramOperacion As Integer, ByVal paramDesde As Integer) As List(Of Servicios.clsBitacora)

            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim oMapper As New MPP.Bitacora

            Try
                If paramUsuario Is Nothing And paramFecha = "#12:00:00 AM#" And paramOperacion = 0 Then
                    'NO TIENE NADA
                    listaBitacora = oMapper.ListarBitacora(paramDesde)
                ElseIf paramUsuario Is Nothing And paramFecha = "#12:00:00 AM#" And paramOperacion <> 0 Then
                    'TIENE SOLO OPERACION
                    listaBitacora = oMapper.ListarBitacora(paramOperacion, paramDesde)
                ElseIf paramUsuario Is Nothing And paramFecha <> "#12:00:00 AM#" And paramOperacion = 0 Then
                    'TIENE LA FECHA
                    listaBitacora = oMapper.ListarBitacora(paramFecha, paramDesde)
                ElseIf paramUsuario Is Nothing And paramFecha <> "#12:00:00 AM#" And paramOperacion <> 0 Then
                    'TIENE LA FECHA Y EL OPERACION
                    listaBitacora = oMapper.ListarBitacora(paramFecha, paramOperacion, paramDesde)
                ElseIf Not paramUsuario Is Nothing And paramFecha = "#12:00:00 AM#" And paramOperacion = 0 Then
                    'TIENE EL USUARIO
                    listaBitacora = oMapper.ListarBitacora(paramUsuario, paramDesde)
                ElseIf Not paramUsuario Is Nothing And paramFecha = "#12:00:00 AM#" And paramOperacion <> 0 Then
                    'TIENE EL USUARIO y EL OPERACION
                    listaBitacora = oMapper.ListarBitacora(paramUsuario, paramOperacion, paramDesde)
                ElseIf Not paramUsuario Is Nothing And paramFecha <> "#12:00:00 AM#" And paramOperacion = 0 Then
                    'TIENE EL USUARIO Y LA FECHA
                    listaBitacora = oMapper.ListarBitacora(paramUsuario, paramFecha, paramDesde)
                ElseIf Not paramUsuario Is Nothing And paramFecha <> "#12:00:00 AM#" And paramOperacion <> 0 Then
                    'TIENE EL USUARIO, LA PERSONA y EL ESTADO
                    listaBitacora = oMapper.ListarBitacora(paramUsuario, paramFecha, paramOperacion, paramDesde)
                End If
                Return listaBitacora
            Catch ex As Exception

                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function
    End Class
End Namespace

