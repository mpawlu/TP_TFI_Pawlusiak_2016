Namespace Servicios
    Public Class clsExcepcionUsuarioDuplicado
        Inherits clsExcepcionPersonalizada



        Public Overrides Function Mensaje() As String
            Return "El Usuario se encuentra Duplicado"
        End Function

    End Class

End Namespace