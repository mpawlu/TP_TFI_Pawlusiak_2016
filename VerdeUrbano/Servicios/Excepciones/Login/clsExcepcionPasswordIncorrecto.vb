Public Class clsExcepcionPasswordIncorrecto
    Inherits clsExcepcionPersonalizada

    Public Overrides Function Mensaje() As String
        Return "La Contraseña es Incorrecta"
    End Function
End Class
