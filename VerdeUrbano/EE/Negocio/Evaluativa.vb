Namespace EE
    Public Class Evaluativa
        Inherits Seccion

        Sub New(ByVal Titulo As String, ByVal Descripcion As String)
            MyBase.New(Titulo, Descripcion)
            Me.Titulo = Titulo
            Me.Descripcion = Descripcion
        End Sub


    End Class
End Namespace