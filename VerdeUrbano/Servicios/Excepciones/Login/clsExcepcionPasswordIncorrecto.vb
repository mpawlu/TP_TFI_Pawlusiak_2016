Namespace Servicios


    Public Class clsExcepcionPasswordIncorrecto
        Inherits clsExcepcionPersonalizada


        'Public Overrides Function Mensaje() As String
        '    Return "La Contraseña es Incorrecta"
        'End Function

        Public Overrides Function ObtenerID() As String
            Return "msg_4"
        End Function
    End Class
End Namespace
