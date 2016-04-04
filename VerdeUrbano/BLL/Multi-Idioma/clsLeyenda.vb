Namespace BLL
    Public Class clsLeyenda
        Public Function ListarLeyendas() As List(Of EE.clsLeyenda)
            Dim resultado As New List(Of EE.clsLeyenda)
            Dim Mapper As New MPP.clsLeyenda

            resultado = Mapper.ListarLeyendas()

            Return resultado
        End Function

    End Class
End Namespace

