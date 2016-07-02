Public Class crearCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If validaciones.validarPagina(Me) = False Then
        '    Response.Redirect("error.aspx")
        'End If

        If Not IsPostBack Then
            '  CargarGrilla()
        End If
    End Sub
    Private Sub CargarGrilla()
        Dim oSol As New List(Of EE.SolicitudCurso)
        oSol.Add(DirectCast(Session("Solicitud"), EE.SolicitudCurso))
        Me.gv_solicitudes.DataSource = oSol
        Me.gv_solicitudes.DataBind()
    End Sub


    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnAgregarSeccion.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
            Dim oCurso As New EE.Curso
            Dim oCursoBLL As New BLL.Curso
            Dim oSol As New EE.SolicitudCurso
            Dim oSolBLL As New BLL.SolicitudCurso
            oSol = DirectCast(Session("Solicitud"), EE.SolicitudCurso)
            oCurso = oCursoBLL.Consultar(oSol)
            oCurso.Nombre = txtNombre.Text
            oCurso.Descripcion = txtDescripcion.Text
            oCurso.Duracion = CInt(txtDuracion.Text)
            If oCursoBLL.Modificar(oCurso) = True Then
                oSol.Estado.PasarAEnConstruccion(oSol)
                If oSolBLL.Modificar(oSol) = True Then
                    correcto.Visible = True
                    Session("Curso") = oCursoBLL.Consultar(oSol)
                    Response.Redirect("agregarSeccion.aspx")
                Else
                    ''Fallo operacion
                End If
            Else
                ''Fallo operacion
            End If
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