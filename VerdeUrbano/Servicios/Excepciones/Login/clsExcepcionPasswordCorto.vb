Namespace Servicios
    Public Class clsExcepcionPasswordCorto
        Inherits Servicios.clsExcepcionPersonalizada


        Public Overrides Function Mensaje() As String
            Return "La contraseña debe tener al menos 6 caracteres"
        End Function
    End Class

End Namespace
