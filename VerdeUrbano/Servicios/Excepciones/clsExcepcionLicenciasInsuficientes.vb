Namespace servicios
    Public Class clsExcepcionLicenciasInsuficientes
        Inherits servicios.clsExcepcionPersonalizada

        Public Overrides Function ObtenerID() As String
            Return "msg_12"
        End Function
    End Class
End Namespace
