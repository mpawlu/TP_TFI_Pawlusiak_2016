Option Compare Text
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Namespace BLL
    Public Class DigitoVerificador
        Public Shared Function Integridad() As Boolean
            'Try
            'Thread.CurrentThread.CurrentCulture = SessionBLL.SesionActual.IdiomaPredeterminado.Cultura
            'Thread.CurrentThread.CurrentUICulture = SessionBLL.SesionActual.IdiomaPredeterminado.Cultura
            Dim oBitacoraMPP As New MPP.Bitacora
            Dim oDV As New MPP.DigitoVerificador
            Dim TablaDVV As String

            If Not oDV.ListarDVV Is Nothing Then
                For Each dr As DataRow In oDV.ListarDVV.Rows
                    Dim dt As DataTable
                    Dim fila As String
                    Dim DVVcalc As String
                    Dim DVVtabla As String = dr.Item("DVV").ToString
                    dt = MPP.DigitoVerificador.RecorrerTabla(dr.Item("Nombre_Table"))
                    For Each dr2 As DataRow In dt.Rows
                        fila = fila & dr2.Item("DVH")
                    Next
                    DVVcalc = MPP.DigitoVerificador.CalcularDVH(fila)
                    If TablaDVV <> DVVcalc Then
                        Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "La encontro un registro alterado en la tabla " & dr.Item("Nombre_table"))
                        oBitacoraMPP.CrearEvento(oBitacora)
                        Return False
                        Exit For
                    End If
                Next
                Return True
            End If

            '        Dim DHBitacora As String = ""
            '        Dim DHUsuario As String = ""
            '        Dim DHEvento As String = ""
            '        DHBitacora = gestorbitacora.Integridad
            '        DHUsuario = gestorusuario.Integridad
            '        DHEvento = gestorevento.integridad
            '        If Not IsNothing(DHBitacora) Then
            '            If Not IsNothing(DHUsuario) Then
            '                If Not IsNothing(DHEvento) Then
            '                    Dim DataTabla = (New DigitoVerificadorDAL).VerificarIntegridad
            '                    For Each row As DataRow In DataTabla.Rows
            '                        If row.Item(0) = "Bitacora" And DigitoVerificadorDAL.CalcularDVH(DHBitacora) = row.Item(1) Then

            '                        ElseIf row.Item(0) = "Usuario" And DigitoVerificadorDAL.CalcularDVH(DHUsuario) = row.Item(1) Then

            '                        ElseIf row.Item(0) = "Evento" And DigitoVerificadorDAL.CalcularDVH(DHEvento) = row.Item(1) Then

            '                        Else
            '                            Return False
            '                        End If
            '                    Next
            '                    Return True
            '                Else
            '                    Throw New ExceptionIntegridadEvento
            '                End If
            '            Else
            '                Throw New ExceptionIntegridadUsuario
            '            End If
            '        Else
            '            Throw New ExceptionIntegridadBitacora
            '        End If
            '        Return False
            '    Catch ExcepcionUsuario As ExceptionIntegridadUsuario
            '        Throw ExcepcionUsuario
            '    Catch ExcepcionBitacora As ExceptionIntegridadBitacora
            '        Throw ExcepcionBitacora
            '    Catch ExcepcionEvento As ExceptionIntegridadEvento
            '        Throw ExcepcionEvento
            '    Catch FalloConexion As InvalidOperationException
            '        Throw FalloConexion
            '    Catch ex As Exception
            '        BitacoraBLL.CrearBitacora("El Metodo " & ex.TargetSite.ToString & " generó un error. Su mensaje es: " & ex.Message, TipoBitacora.Errores, (New UsuarioEntidad With {.ID_Usuario = 0, .Nombre = "Sistema"}))
            '        Throw ex
            '    End Try
        End Function
    End Class
End Namespace
