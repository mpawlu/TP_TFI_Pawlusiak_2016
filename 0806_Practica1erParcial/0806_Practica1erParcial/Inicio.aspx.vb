Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Integer
        valor = 0
        If CheckBox1.Checked = True Then
            valor = valor + 1000
        End If
        If CheckBox2.Checked = True Then
            valor = valor + 1500
        End If
        If CheckBox3.Checked = True Then
            valor = valor + 2000
        End If

        Dim oCompra As New Compra(valor, Me.DropDownList1.SelectedValue)
        Session("Compra") = oCompra
        Response.Redirect("DetalleDeCompra.aspx")
    End Sub

 
End Class