Imports Servicios
Namespace BLL
    Public Class CalculadoraIE
        Public Function SeleccionarMejorDiseñador(ByVal Categoria As EE.Categoria) As Servicios.Usuario
            Dim CalculadorE As New EE.CalculadoraIE

        End Function
        Private Function CalcularIE(ByVal UtilidadEvaluada As Double, ByVal Puntaje As Double, ByVal DificultadEvaluada As Double) As Double


        End Function
        Public Sub AgregarResultado(ByVal EECalculadora As EE.CalculadoraIE, ByVal QueResultado As EE.ResultadoIE)
            EECalculadora.Resultados.Add(QueResultado)
        End Sub
        Public Function ObtenerMayorIE() As Servicios.Usuario

        End Function
        Sub New()

        End Sub
    End Class
End Namespace

