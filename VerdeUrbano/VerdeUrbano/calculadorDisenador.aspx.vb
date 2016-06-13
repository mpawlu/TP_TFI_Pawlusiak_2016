Public Class calculadorDisenador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oRanking As New List(Of EE.CalculadoraIE)
        Dim oCat As New EE.Categoria
        oCat.ID = 2
        Dim _bllUsuario As New BLL.clsUsuario
        Dim _listaUsuarios As New List(Of Servicios.Usuario)
        _listaUsuarios = _bllUsuario.ObtenerDisenadores
        Dim ie As New BLL.CalculadoraIE
        oRanking = ie.RankearDiseñadores(_listaUsuarios, oCat)
        mostrarTop5(oRanking)
    End Sub

    Private Sub btn_Seleccionar1_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar1.Click

    End Sub

    Private Sub btn_Seleccionar2_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar2.Click

    End Sub

    Private Sub btn_Seleccionar3_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar3.Click

    End Sub

    Private Sub btn_Seleccionar4_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar4.Click

    End Sub

    Private Sub btn_Seleccionar5_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar5.Click

    End Sub

    Private Sub mostrarTop5(ByVal paramRanking As List(Of EE.CalculadoraIE))
        Dim _contador As Integer = 1
        For Each _ranking As EE.CalculadoraIE In paramRanking
            If _contador <= 5 Then
                Dim lbl_NombreDisenador As Label = calculadorEA.FindControl("lbl_NombreDisenador" & _contador)
                Dim lbl_CantidadCursosRealizado As Label = calculadorEA.FindControl("lbl_CantidadCursosRealizado" & _contador)
                Dim lbl_DetalleUltimoCurso As Label = calculadorEA.FindControl("lbl_DetalleUltimoCurso" & _contador)
                Dim lbl_rating As Label = calculadorEA.FindControl("lbl_rating" & _contador)
                lbl_NombreDisenador.Text = _ranking.Dieseñador.NombreUsuario
                lbl_CantidadCursosRealizado.Text = _ranking.Cursos.Count.ToString
                lbl_DetalleUltimoCurso.Text = _ranking.Reproducciones(_ranking.Reproducciones.Count - 1).Curso.Nombre
                lbl_rating.Text = _ranking.IndiceDeSatisfaccion.ToString
                Dim _divTop As HtmlControl = calculadorEA.FindControl("top" & _contador)
                _divTop.Visible = True
                _contador = _contador + 1
            Else
                Exit For
            End If
        Next
    End Sub

End Class