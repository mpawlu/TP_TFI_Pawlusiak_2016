Namespace BLL
    Public Class clsIdioma
        Public Function CrearIdioma(ByVal oIdioma As Servicios.clsIdioma) As Boolean
            Dim oMapper As New MPP.clsIdioma
            Dim resultado As Boolean
            Dim oBitacora As Servicios.clsBitacora

            resultado = oMapper.CrearIdioma(oIdioma)
            Return resultado

            If resultado = True Then
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Alta, "Se ha creado un nuevo idioma.")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            Else
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Alta, "Ocurrio un error al intentar dar de alta un nuevo idioma.")
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End If
        End Function
        Public Function ListarIdiomas() As List(Of Servicios.clsIdioma)
            Dim oMapper As New MPP.clsIdioma
            Dim listaIdiomas As New List(Of Servicios.clsIdioma)

            listaIdiomas = oMapper.ListarIdiomas()

            Return listaIdiomas
        End Function
        Public Function ConsultarPorNombre(ByVal oNombre As String) As Servicios.clsIdioma

            Dim oMapper As New MPP.clsIdioma
            Return oMapper.ConsultarIdioma(oNombre)
        End Function
        Public Function ChequearNombre(ByVal oNombre As String) As Boolean

            Dim oMapper As New MPP.clsIdioma
            Return oMapper.chequearNombre(oNombre)
        End Function
    End Class
End Namespace

