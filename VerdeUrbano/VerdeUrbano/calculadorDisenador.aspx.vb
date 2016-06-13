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
    End Sub

End Class