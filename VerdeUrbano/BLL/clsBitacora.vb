Namespace BLL
    Public Class clsBitacora
        Public Sub RegistrarEvento(ByVal Evento As Servicios.clsBitacora)
            'Dim Bmpp As New MPP.Bitacora

        End Sub
        Public Function ListarBitacora() As List(Of Servicios.clsBitacora)

            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim oMapper As New MPP.Bitacora

            listaBitacora = oMapper.ListarBitacora()

            Return listaBitacora

        End Function
    End Class
End Namespace

