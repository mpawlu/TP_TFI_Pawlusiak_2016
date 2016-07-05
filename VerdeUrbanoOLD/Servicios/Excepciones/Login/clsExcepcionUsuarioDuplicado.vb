Namespace Servicios
    Public Class clsExcepcionUsuarioDuplicado
        Inherits clsExcepcionPersonalizada




        'Public Overrides Function Mensaje() As String
        '    Return "El Usuario se encuentra Duplicado"
        'End Function

        Public Overrides Function ObtenerID() As String
            Return "msg_6"
        End Function
    End Class

End Namespace