Public Class agregarIdioma
    Inherits System.Web.UI.Page
    Dim oLeyenda As New List(Of Servicios.clsLeyenda)
    Dim oLeyBLL As New BLL.clsLeyenda
    Dim oTrad As New Servicios.ClsTraduccion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '   If validaciones.validarPagina(Me) = False Then
        ' Response.Redirect("error.aspx")
        ' End If
        If Not IsPostBack Then
            Dim oTrad As New List(Of Servicios.ClsTraduccion)
            Dim oIdioma As New Servicios.clsIdioma
            Dim oTradBLL As New BLL.ClsTraduccion
            oIdioma.ID = 1
            oTrad = oTradBLL.ListarTraducciones(oIdioma)
            CargarGrilla()
        End If
        Me.correcto.Visible = False
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
            Dim oIdiomaBLL As New BLL.clsIdioma
            If oIdiomaBLL.ChequearNombre(txtNombre.Text) = False Then
                Dim NuevoIdioma As New servicios.clsIdioma
                NuevoIdioma.Descripcion = txtNombre.Text

                If oIdiomaBLL.CrearIdioma(NuevoIdioma) = True Then
                    Dim oLeyenda As New servicios.clsLeyenda
                    Dim oTrad As New servicios.ClsTraduccion
                    Dim oTradBLL As New BLL.ClsTraduccion
                    For Each r As GridViewRow In gv_Palabras.Rows
                        Try
                            oLeyenda.ID = CStr(r.Cells(0).Text)
                            oLeyenda.Leyenda = CStr(r.Cells(1).Text)
                            oTrad.Leyenda = oLeyenda
                            oTrad.Idioma = oIdiomaBLL.ConsultarPorNombre(Me.txtNombre.Text)
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
                            If oTradBLL.CrearTraduccion(oTrad) = False Then
                                'Excepcion Validacion traduccion
                                Exit For
                            End If
                        Catch ex As Exception
                            'Ocurrio un error al querer guardar una traduccion
                        End Try
                    Next
                        Else
                            'Ocurrio un error al querer dar de alta el nuevo idioma por favor contacte al administrador.
                        End If
            Else
                        'El nombre de idioma elegido ya se encuentra registrado en la base de datos.
            End If
            Me.correcto.Visible = True
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            'Me.lbl_TituloError.Text = ex.Mensaje
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