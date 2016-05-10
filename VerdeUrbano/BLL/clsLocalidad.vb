Imports EE
Imports MPP
Namespace BLL

    Public Class clsLocalidad

        Public Function ListarLocalidades() As List(Of EE.clsLocalidad)
            Try
                Dim oMapper As New MPP.clsLocalidad
                Dim listaLocaliades As New List(Of EE.clsLocalidad)

                listaLocaliades = oMapper.ListarLocalidades()

                Return listaLocaliades
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function
    End Class
End Namespace

