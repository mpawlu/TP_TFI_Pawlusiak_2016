Namespace BLL
    Public Class SatisfaccionCliente
        Public Function CalcularSatisfaccion(ByVal QueEmpresa As EE.Empresa) As Double
            Dim oPerMPP As New MPP.Persona
            Dim oListaPer As New List(Of EE.Persona)
            Dim oCurAsig As New List(Of EE.CursoAsignado)
            Dim oCurAsigBLL As New BLL.CursoAsignado
            Dim Resultado As Double
            oListaPer = oPerMPP.Listar(QueEmpresa)
            Dim oListaEmpleados As New List(Of EE.Persona)
            For Each p As EE.Persona In oListaPer
                If Me.TienePermiso(p.Usuario) = True Then
                    oListaEmpleados.Add(p)
                End If
            Next
            Dim Indicador As Double
            For Each _p As EE.Persona In oListaEmpleados
                If Not oCurAsigBLL.ConsultarCursosRealizados(_p) Is Nothing Then
                    For Each _CA As EE.CursoAsignado In oCurAsigBLL.ConsultarCursosRealizados(_p)
                        Indicador += Me.CaclcularValor(_CA.EncuestaAsignada)
                    Next
                    Resultado = Indicador / oCurAsigBLL.ConsultarCursosRealizados(_p).Count
                End If
            Next
            Return Resultado / oListaEmpleados.Count
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
        Public Function CaclcularValor(ByVal _Encuesta As EE.EncuestaAsignada) As Double
            Dim resultado As Double
            For Each r As EE.Respuesta In _Encuesta.Respuestas
                If r.PreguntaEncuesta.ID_Pregunta >= 3 And r.PreguntaEncuesta.ID_Pregunta <= 8 Then
                    If r.OpcionElegida = EE.Respuesta.etipoRespuesta.Pesimo Then
                        resultado += r.PreguntaEncuesta.Valor * 1
                    ElseIf r.OpcionElegida = EE.Respuesta.etipoRespuesta.Malo Then
                        resultado += r.PreguntaEncuesta.Valor * 2.5
                    ElseIf r.OpcionElegida = EE.Respuesta.etipoRespuesta.Regular Then
                        resultado += r.PreguntaEncuesta.Valor * 5
                    ElseIf r.OpcionElegida = EE.Respuesta.etipoRespuesta.Bueno Then
                        resultado += r.PreguntaEncuesta.Valor * 7.5
                    ElseIf r.OpcionElegida = EE.Respuesta.etipoRespuesta.Excelente Then
                        resultado += r.PreguntaEncuesta.Valor * 10
                    End If
                End If
            Next
            Return resultado / _Encuesta.Respuestas.Count
        End Function
    End Class
End Namespace

