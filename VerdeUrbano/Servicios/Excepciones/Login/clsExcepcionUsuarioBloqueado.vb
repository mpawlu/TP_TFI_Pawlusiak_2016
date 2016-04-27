Public Class clsExcepcionUsuarioBloqueado
    Inherits clsExcepcionPersonalizada

    Public Overrides Function Mensaje() As String
        Return "El Usuario se encuentra Bloqueado"
    End Function
End Class
