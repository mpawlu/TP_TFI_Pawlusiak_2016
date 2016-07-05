Namespace Servicios
    Public Class clsExcepcionUsuarioInexistente
        Inherits clsExcepcionPersonalizada


        'Public Overrides Function Mensaje() As String
        '    Return "El Usuario no se encuentra registrado en el Sistema"
        'End Function

        Public Overrides Function ObtenerID() As String
            Return "msg_7"
        End Function
    End Class

End Namespace
