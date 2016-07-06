Public Class comprarCurso
    Inherits System.Web.UI.Page
    Protected mensajeConfirmacion2 As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarDDL()
            CargarGrilla()
            mensajeConfirmacion2 = "¿Desea Adquirir el Producto?"
        End If
    End Sub
    Public Sub CargarDDL()

        For i As Integer = 1 To 20
            Me.ddl_lic.Items.Add(i.ToString)
        Next
    End Sub
    Private Function ListarCursos() As List(Of EE.Curso)
        Dim ListaCursos As New List(Of EE.Curso)
        Dim oBLL As New BLL.Curso
        Dim oPer As New EE.Persona
        Dim oPerBLL As New BLL.Persona
        oPer = oPerBLL.Consultar(Me.RecuperarUsuario.DNI)
        ListaCursos = oBLL.ListarDisponibles(oPer.Empresa)
        Return ListaCursos
    End Function
    Public Sub CargarGrilla()
        Me.gv_cursos.DataSource = ListarCursos()
        Me.gv_cursos.DataBind()
    End Sub

    Private Function validarCheckBox() As Boolean
        Dim _flag As Boolean = False
        Dim _cant As Integer = 0
        For Each row As GridViewRow In Me.gv_cursos.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)
            If checkbox.Checked = True Then
                _flag = True
                _cant += 1
            End If
            If _cant > 1 Then
                Return False
            End If
        Next
        Return _flag
    End Function

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Try


            If Me.validarCheckBox = False Then
                Throw New Servicios.clsExcepcionCamposIncompletos
            Else
                Dim _Curso As New EE.Curso
                Dim _Empresa As New EE.Empresa
                Dim _Presona As New EE.Persona
                Dim oPersBLL As New BLL.Persona
                _Presona = oPersBLL.Consultar(Me.RecuperarUsuario.DNI)
                _Empresa = _Presona.Empresa
                _Curso = Me.Seleccionado
                Dim oCompra As New EE.Compra
                oCompra.Curso = _Curso
                oCompra.Empresa = _Empresa
                oCompra.Licencias = CInt(Me.ddl_lic.SelectedItem.Text)
                Dim oCompraBLL As New BLL.Compra
                If oCompraBLL.GuardarCompra(oCompra) = True Then
                    Me.correcto.Visible = True
                    Me.formulario.Visible = False
                Else
                    Throw New Servicios.clsExcepcionErrorBBDD
                End If
            End If

        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionErrorBBDD
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception

        End Try
    End Sub
    Public Function Seleccionado() As EE.Curso
        Dim indice As Integer
        Dim cont As Integer
        indice = 0
        cont = 0
        For Each row As GridViewRow In gv_cursos.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)
            cont += 1
            If checkbox.Checked = True Then
                indice = cont
            End If
        Next
        Return Me.ListarCursos()(indice - 1)
    End Function
    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function
End Class