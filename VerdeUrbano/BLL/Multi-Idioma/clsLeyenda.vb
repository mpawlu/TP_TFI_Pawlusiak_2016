Namespace BLL
    Public Class clsLeyenda
        Public Function ListarLeyendas() As List(Of Servicios.clsLeyenda)
            Dim resultado As New List(Of Servicios.clsLeyenda)
            Dim Mapper As New MPP.clsLeyenda

            resultado = Mapper.ListarLeyendas()

            Return resultado
        End Function

    End Class
End Namespace

