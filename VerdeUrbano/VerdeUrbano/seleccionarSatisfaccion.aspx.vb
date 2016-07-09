Public Class seleccionarSatisfaccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ocultarDivs()
        If validaciones.validarPagina(Me) = False Then
            'Response.Redirect("error.aspx")
        End If
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
            Dim oEmpresa As New EE.Empresa
            oEmpresa.ID = Seleccionado.ID
            Dim oEmpBLL As New BLL.Empresa
            oEmpresa = oEmpBLL.ConsultarEmpresa(oEmpresa)
            Dim oSatClie As New EE.SatisfaccionCliente
            oSatClie.Empresa = oEmpresa
            oSatClie.SatisfaccionCalculada = oEmpBLL.CalcularSatisfaccion(oEmpresa)
            Session("Satisfaccion") = oSatClie
            If validarCheckBox() = True Then
                Response.Redirect("detalleSatisfaccion.aspx")
            Else
                Throw New Servicios.clsExcepcionCamposIncompletos
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
    Public Function Seleccionado() As EE.Empresa
        Dim oBLL As New BLL.Empresa
        Dim indice As Integer
        Dim cont As Integer
        indice = 0
        cont = 0
        For Each row As GridViewRow In gv_Clientes.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)

            If checkbox.Checked = True Then
                indice = cont
            End If
            cont += 1
        Next
        Dim oca As New EE.Empresa
        oca = oBLL.ListarClientes()(indice)
        Return oca
    End Function
    Public Sub ocultarDivs()
        Me.correcto.Visible = False
        Me.error.Visible = False
    End Sub
End Class