Public Class seleccionarSatisfaccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarGrid()
        End If
    End Sub
    Public Sub cargarGrid()
        Dim oEmpBLL As New BLL.Empresa
        Dim oClientes As New List(Of EE.Empresa)
        oClientes = oEmpBLL.ListarClientes
        Me.gv_Clientes.DataSource = oClientes
        Me.gv_Clientes.DataBind()
    End Sub

    Protected Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            If validarCheckBox() = True Then
                Response.Redirect("detalleSatisfaccion.aspx")
            Else
                Throw New Servicios.clsExcepcionCamposIncompletos
            End If
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Titulo
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub

    Private Function validarCheckBox() As Boolean
        Dim _flag As Boolean = False
        For Each row As GridViewRow In Me.gv_Clientes.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)
            If checkbox.Checked = True Then
                Return True
            End If
        Next
        Return _flag
    End Function

End Class