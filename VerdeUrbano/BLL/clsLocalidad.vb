Imports EE
Imports MPP
Namespace BLL

    Public Class clsLocalidad

        Public Function ListarLocalidades() As List(Of EE.clsLocalidad)
            Dim oMapper As New MPP.clsLocalidad
            Dim listaLocaliades As New List(Of EE.clsLocalidad)

            listaLocaliades = oMapper.ListarLocalidades()

            Return listaLocaliades
        End Function
    End Class
End Namespace

