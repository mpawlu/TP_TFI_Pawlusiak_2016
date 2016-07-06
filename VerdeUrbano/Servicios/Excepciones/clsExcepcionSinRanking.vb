Namespace Servicios
    Public Class clsExcepcionSinRanking

        Inherits clsExcepcionPersonalizada

        Public Overrides Function ObtenerID() As String
            'Return "Debe completar todos los campos para continuar"
            Return "msg_13"
        End Function

    End Class
End Namespace

