Namespace servicios


    Public Class clsExcepcionLeyendasIncompletas


        Inherits clsExcepcionPersonalizada


        'Sub New()
        '    Titulo = "Leyendas incompletas"
        '    Mensaje = "Por favor verifique que todas las leyendas esten completas"
        'End Sub


        Public Overrides Function ObtenerID() As String
            Return "msg_8"
        End Function
    End Class
End Namespace