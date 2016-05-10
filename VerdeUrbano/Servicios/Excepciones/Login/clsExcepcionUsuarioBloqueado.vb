Namespace Servicios
    Public Class clsExcepcionUsuarioBloqueado
        Inherits clsExcepcionPersonalizada



        'Public Overrides Function Mensaje() As String
        '    Return "El Usuario se encuentra Bloqueado"
        'End Function

        Public Overrides Function ObtenerID() As String
            Return "msg_5"
        End Function
    End Class
End Namespace

