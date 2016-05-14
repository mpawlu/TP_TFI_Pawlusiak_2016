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
            Try
                Dim oBitacoraMPP As New MPP.Bitacora
                Dim oDV As New MPP.DigitoVerificador
                If Not oDV.ListarDVV Is Nothing Then

                    For Each dr As DataRow In oDV.ListarDVV.Rows
                        Dim dt As DataTable
                        Dim campo As String
                        Dim fila As String
                        Dim DVVcalc As String
                        Dim DVVtabla As String = dr.Item("DVV").ToString
                        dt = MPP.DigitoVerificador.RecorrerTabla(dr.Item("Nombre_Table"))
                        Dim cont As Integer = 0
                        For Each dr2 As DataRow In dt.Rows
                            For Each item In dr2.ItemArray
                                cont += 1
                            Next
                        Next
                        For Each dr2 As DataRow In dt.Rows
                            For i As Integer = 0 To cont
                                campo = dr2.Item(cont).ToString
                                fila = fila & campo
                            Next
                        Next
                        fila = MPP.DigitoVerificador.CalcularDVH(fila)
                        DVVcalc = MPP.DigitoVerificador.CalcularDVH(fila)
                        ' DVVcalc = "sdfdsf"
                        If DVVtabla <> DVVcalc Then
                            Return False
                            Exit For
                        End If
                    Next
                    Return True
                End If
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function
    End Class
End Namespace
