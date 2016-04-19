Public Class agregarIdioma
    Inherits System.Web.UI.Page
    Dim oLeyenda As New List(Of Servicios.clsLeyenda)
    Dim oLeyBLL As New BLL.clsLeyenda
    Dim oTrad As New Servicios.ClsTraduccion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oTrad As New List(Of Servicios.ClsTraduccion)
        Dim oIdioma As New Servicios.clsIdioma
        Dim oTradBLL As New BLL.ClsTraduccion
        oIdioma.ID = 1
        oTrad = oTradBLL.ListarTraducciones(oIdioma)
        CargarGrilla()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim NuevoIdioma As New Servicios.clsIdioma
        NuevoIdioma.Descripcion = txt_NombreIdioma.Text
        Dim oIdiomaBLL As New BLL.clsIdioma
        If oIdiomaBLL.CrearIdioma(NuevoIdioma) = True Then

            Dim oLeyenda As New Servicios.clsLeyenda
            Dim oTrad As New Servicios.ClsTraduccion
            Dim oTradBLL As New BLL.ClsTraduccion

            For Each r As DataRow In gv_Palabras.Rows
                Try
                    oLeyenda.ID = CInt(r(0))
                    oLeyenda.Leyenda = CStr(r(1))
                    oTrad.Leyenda = oLeyenda
                    oTrad.Idioma = NuevoIdioma
                    oTrad.Traduccion = CStr(r(2))
                    If oTradBLL.CrearTraduccion(oTrad) = False Then
                        'Excepcion Validacion traduccion
                        Exit For
                    End If
                Catch ex As Exception

                End Try
            Next
        Else
            'Excepcion validacion nombre Idioma
        End If

    End Sub
    Private Sub CargarGrilla()
        oLeyenda = oLeyBLL.ListarLeyendas
        Me.gv_Palabras.DataSource = oLeyenda
        Me.gv_Palabras.DataBind()

    End Sub
End Class