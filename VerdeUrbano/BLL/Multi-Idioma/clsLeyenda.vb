Namespace BLL
    Public Class clsLeyenda

        Public Function ListarLeyendas() As List(Of Servicios.clsLeyenda)
            Try
                Dim resultado As New List(Of Servicios.clsLeyenda)
                Dim Mapper As New MPP.clsLeyenda

                resultado = Mapper.ListarLeyendas()

                Return resultado
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function
    End Class
End Namespace

