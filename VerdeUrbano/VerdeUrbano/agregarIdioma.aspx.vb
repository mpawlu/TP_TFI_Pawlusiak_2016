Public Class agregarIdioma
    Inherits System.Web.UI.Page
    Dim oLeyenda As New List(Of Servicios.clsLeyenda)
    Dim oLeyBLL As New BLL.clsLeyenda
    Dim oTrad As New Servicios.ClsTraduccion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim oTrad As New List(Of Servicios.ClsTraduccion)
            Dim oIdioma As New Servicios.clsIdioma
            Dim oTradBLL As New BLL.ClsTraduccion
            oIdioma.ID = 1
            oTrad = oTradBLL.ListarTraducciones(oIdioma)
            CargarGrilla()
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
            Dim NuevoIdioma As New Servicios.clsIdioma
            NuevoIdioma.Descripcion = txtNombre.Text
            Dim oIdiomaBLL As New BLL.clsIdioma
            If oIdiomaBLL.CrearIdioma(NuevoIdioma) = True Then
                Dim oLeyenda As New Servicios.clsLeyenda
                Dim oTrad As New Servicios.ClsTraduccion
                Dim oTradBLL As New BLL.ClsTraduccion
                For Each r As GridViewRow In gv_Palabras.Rows
                    'Try
                    oLeyenda.ID = CStr(r.Cells(0).Text)
                    oLeyenda.Leyenda = CStr(r.Cells(1).Text)
                    oTrad.Leyenda = oLeyenda
                    oTrad.Idioma = oIdiomaBLL.ConsultarPorNombre(Me.txtNombre.Text)
                    If CStr(r.Cells(2).Text) = "" Then
                        oTrad.Traduccion = CStr(r.Cells(1).Text)
                    Else
                        oTrad.Traduccion = CStr(r.Cells(2).Text)
                    End If

                    If oTradBLL.CrearTraduccion(oTrad) = False Then
                        'Excepcion Validacion traduccion
                        Exit For
                    End If
                    'Catch ex As Exception

                    'End Try
                Next
            Else
                'Excepcion validacion nombre Idioma
            End If
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Mensaje
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub
    Private Sub CargarGrilla()
        oLeyenda = oLeyBLL.ListarLeyendas
        Me.gv_Palabras.DataSource = oLeyenda
        Me.gv_Palabras.DataBind()

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
End Class