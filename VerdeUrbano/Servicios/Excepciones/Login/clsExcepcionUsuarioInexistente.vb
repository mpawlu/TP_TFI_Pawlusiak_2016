Public Class clsExcepcionUsuarioInexistente
    Inherits clsExcepcionPersonalizada

    Public Overrides Function Mensaje() As String
        Return "El Usuario no se encuentra registrado en el Sistema"
    End Function
End Class
