Namespace Servicios
    Public Class clsExcepcionPasswordDiferentes
        Inherits clsExcepcionPersonalizada

        'Public Overrides Function Mensaje() As String
        '    Return "Las contraseñas ingresadas no coinciden"
        'End Function

        Public Overrides Function ObtenerID() As String
            Return "msg_3"
        End Function
    End Class

End Namespace
