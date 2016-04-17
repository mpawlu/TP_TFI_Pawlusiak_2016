Namespace BLL
    Public Class clsIdioma
        Public Function CrearIdioma(ByVal oIdioma As Servicios.clsIdioma) As Boolean
            Dim oMapper As New MPP.clsIdioma
            Dim resultado As Boolean

            resultado = oMapper.CrearIdioma(oIdioma)

            Return resultado

        End Function
        Public Function ListarIdiomas() As List(Of Servicios.clsIdioma)
            Dim oMapper As New MPP.clsIdioma
            Dim listaIdiomas As New List(Of Servicios.clsIdioma)

            listaIdiomas = oMapper.ListarIdiomas()

            Return listaIdiomas
        End Function
    End Class
End Namespace

