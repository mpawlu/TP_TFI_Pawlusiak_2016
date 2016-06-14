Namespace BLL
    Public Class SatisfaccionCliente
        Public Function CalcularSatisfaccion(ByVal QueEmpresa As EE.Empresa) As Double
            Dim oPerMPP As New MPP.Persona
            Dim oListaPer As New List(Of EE.Persona)
            oListaPer = oPerMPP.Listar(QueEmpresa)
            Dim oListaEmpleados As New List(Of EE.Persona)
            For Each p As EE.Persona In oListaPer
                If Me.TienePermiso(p.Usuario) = True Then
                    oListaEmpleados.Add(p)
                End If
            Next
        End Function

        Public Function TienePermiso(ByVal _usu As Servicios.Usuario) As Boolean
            Dim resultado As Boolean
            resultado = False
            For Each p As Servicios.PermisoBase In _usu.Perfil.ListaPermisos
                If p.TieneHijos = True Then
                    If p.ID = 27 Then
                        resultado = True
                        Return resultado
                    Else
                        resultado = Me.RecorrerHijos(p)
                    End If
                Else
                    If p.ID = 48 Then
                        resultado = True
                        Return resultado
                    End If
                End If

            Next
            Return resultado
        End Function
        Public Function RecorrerHijos(ByVal _hijo As Servicios.PermisoBase) As Boolean
            If _hijo.TieneHijos = True Then
                If _hijo.ID = 27 Then
                    Return True
                Else
                    _hijo = New Servicios.PermisoCompuesto
                    For Each pHijo As Servicios.PermisoBase In _hijo.ObtenerHijos
                        Me.RecorrerHijos(_hijo)
                    Next
                End If
            Else
                If _hijo.ID = 48 Then
                    Return True
                End If
            End If

        End Function
    End Class
End Namespace

