Namespace Servicios
    Public Class clsExcepcionCamposIncompletos


        Inherits clsExcepcionPersonalizada

        Public Overrides Function ObtenerID() As String
            'Return "Debe completar todos los campos para continuar"
            Return "msg_1"
        End Function
    End Class


End Namespace