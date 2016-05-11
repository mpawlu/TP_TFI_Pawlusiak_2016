Public Class editarIdioma
    Inherits System.Web.UI.Page
    Dim oLeyenda As New List(Of Servicios.clsLeyenda)
    Dim oLeyBLL As New BLL.clsLeyenda
    Dim oTrad As New Servicios.ClsTraduccion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
        If Not IsPostBack Then
            CargarDDLIdioma()
            CargarGrilla()
        End If

    End Sub

    Public Sub CargarDDLIdioma()
        Dim oIdioma As New List(Of Servicios.clsIdioma)
        Dim oIdiomaBLL As New BLL.clsIdioma
        oIdioma = oIdiomaBLL.ListarIdiomas()
        Me.ddl_idioma.DataSource = oIdioma
        Me.ddl_idioma.DataTextField = "Descripcion"
        Me.ddl_idioma.DataValueField = "ID"
        Me.ddl_idioma.DataBind()
    End Sub
    Private Sub CargarGrilla()

        Dim oIdioma As New Servicios.clsIdioma
        Dim oIdiomaBLL As New BLL.clsIdioma

        oLeyenda = oLeyBLL.ListarLeyendas
        Me.gv_Palabras.DataSource = oLeyenda
        Me.gv_Palabras.DataBind()


        Dim oLey As New Servicios.clsLeyenda
        Dim oTrad As New Servicios.ClsTraduccion
        Dim oTradBLL As New BLL.ClsTraduccion
        For Each r As GridViewRow In gv_Palabras.Rows
            Try
                oLey.ID = CStr(r.Cells(0).Text)
                oLey.Leyenda = CStr(r.Cells(1).Text)
                oTrad.Leyenda = oLey
                oTrad.Idioma = oIdiomaBLL.ConsultarPorNombre(Me.ddl_idioma.SelectedItem.Text)
                oTrad = oTradBLL.ConsultarTraduccion(oTrad)
                If r.Cells(2).HasControls() = True Then
                    For Each micontrol As Control In r.Cells(2).Controls
                        If TypeOf (micontrol) Is TextBox Then
                            DirectCast(micontrol, TextBox).Text = CStr(r.Cells(1).Text)
                        End If
                    Next
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub ddl_idioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_idioma.SelectedIndexChanged
        CargarGrilla()
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
            Dim oIdiomaBLL As New BLL.clsIdioma
            Dim oLeyenda As New Servicios.clsLeyenda
            Dim oTrad As New Servicios.ClsTraduccion
            Dim oTradBLL As New BLL.ClsTraduccion
            For Each r As GridViewRow In gv_Palabras.Rows
                Try
                    oLeyenda.ID = CStr(r.Cells(0).Text)
                    oLeyenda.Leyenda = CStr(r.Cells(1).Text)
                    oTrad.Leyenda = oLeyenda
                    oTrad.Idioma = oIdiomaBLL.ConsultarPorNombre(Me.ddl_idioma.SelectedItem.Text)
                    If r.Cells(2).HasControls() = True Then
                        For Each micontrol As Control In r.Cells(2).Controls
                            If TypeOf (micontrol) Is TextBox Then
                                If Not DirectCast(micontrol, TextBox).Text = "" Then
                                    oTrad.Traduccion = DirectCast(micontrol, TextBox).Text
                                Else
                                    oTrad.Traduccion = CStr(r.Cells(1).Text)
                                End If
                            End If
                        Next
                    End If
                    If oTradBLL.ModificarTraduccion(oTrad) = False Then
                        'Excepcion Validacion traduccion
                        Exit For
                    End If
                Catch ex As Exception
                    'Ocurrio un error al querer guardar una traduccion
                End Try
            Next
            Me.correcto.Visible = True
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub

    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function
End Class