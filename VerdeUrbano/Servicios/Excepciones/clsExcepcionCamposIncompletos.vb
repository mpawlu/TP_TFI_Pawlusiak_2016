Namespace Servicios
    Public Class clsExcepcionCamposIncompletos
        Inherits clsExcepcionPersonalizada


        Public Overrides Function Mensaje() As String
            Return "Debe completar todos los campos para continuar"
        End Function
    End Class

End Namespace