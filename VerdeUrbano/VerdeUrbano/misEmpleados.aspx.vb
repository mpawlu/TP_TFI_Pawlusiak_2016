Public Class misEmpleados
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ocultarDivs()
        CargarEmpleados()
    End Sub
    Public Sub ocultarDivs()
        Me.correcto.Visible = False
        Me.error.Visible = False
    End Sub

    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function
    Public Sub CargarEmpleados()
        Dim Empleados As New List(Of EE.Persona)
        Dim EmpleadosDisp As New List(Of EE.Persona)
        Dim oPerBLL As New BLL.Persona
        Dim oUsSes As New Servicios.Usuario
        oUsSes = DirectCast(Session("Usuario"), Servicios.Usuario)
        Dim oManager As New EE.Persona
        Dim oPersonaBLL As New BLL.Persona
        oManager = oPersonaBLL.Consultar(oUsSes.DNI)
        Empleados = oPerBLL.Listar(oManager.Empresa)
        Session("Empleados") = Empleados
        Dim oCompra As New EE.Compra
        oCompra = DirectCast(Session("CursoAsignar"), EE.Compra)
        For Each emp As EE.Persona In Empleados
            If emp.Usuario.Perfil.ID = 32 Then
                EmpleadosDisp.Add(emp)
            End If
        Next
        Me.gv_empleados.DataSource = EmpleadosDisp
        Me.gv_empleados.DataBind()
        Me.gv_empleados.Visible = True
    End Sub
    Private Function validarCheckBox() As Boolean
        Dim _flag As Boolean = False
        For Each row As GridViewRow In Me.gv_empleados.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("cb_Empleados"), System.Web.UI.WebControls.CheckBox)
            If checkbox.Checked = True Then
                Return True
            End If
        Next
        Return _flag
    End Function
    Public Function EmpleadosSeleccionado() As EE.Persona
        Dim Seleccionado As New EE.Persona
        Dim TodosEmpleados As New List(Of EE.Persona)
        TodosEmpleados = DirectCast(Session("Empleados"), List(Of EE.Persona))
        For Each row As GridViewRow In Me.gv_empleados.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("cb_Empleados"), System.Web.UI.WebControls.CheckBox)
            If checkbox.Checked = True Then
                For Each p As EE.Persona In TodosEmpleados
                    If p.DNI = gv_empleados.Rows(row.DataItemIndex).Cells(0).Text Then
                        Seleccionado = p
                    End If
                Next
            End If
        Next
        Return Seleccionado
    End Function


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            'If validarCheckBox() = True Then
            Dim oPersona As New EE.Persona
            Session("Seleccionado") = Me.EmpleadosSeleccionado.Usuario
            Response.Redirect("resultadosEmpleado.aspx")
            'Else
            'Throw New Servicios.clsExcepcionCamposIncompletos
            'End If
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionErrorBBDD
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub
End Class