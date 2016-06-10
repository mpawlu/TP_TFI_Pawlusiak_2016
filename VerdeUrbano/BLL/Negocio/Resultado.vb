Imports System.Reflection

Namespace BLL
    Public Class Resultado
        Public Function GenerarResultado(ByVal QueCursoAsignado As EE.CursoAsignado) As EE.Resultado
            Dim Resultado As New EE.Resultado
            For Each sec As EE.Informativa In QueCursoAsignado.Curso.Secciones
                Dim t As Type
                t = sec.GetType
                '    If t = EE.Evaluativa Then

                '    End If
            Next
            'Resultado.SumaIdeal = QueCursoAsignado.Curso.
        End Function
        'Private Function AcumularIdeal()

        'End Function
        Sub New()

        End Sub
    End Class
End Namespace

