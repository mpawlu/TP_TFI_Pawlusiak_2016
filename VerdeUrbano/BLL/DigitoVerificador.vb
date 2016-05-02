﻿Option Compare Text
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
                    DVVcalc = "sdfdsf"
                    If DVVtabla <> DVVcalc Then
                        'Dim oBitacora As New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "La encontro un registro alterado en la tabla " & dr.Item("Nombre_table"))
                        'oBitacoraMPP.CrearEvento(oBitacora)
                        Return False
                        Exit For
                    End If
                Next
                Return True
            End If

        End Function
    End Class
End Namespace
