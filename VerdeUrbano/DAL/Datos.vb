Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Text
Namespace DAL
    Public Class Datos

        Private Str As String = "Data Source=.\SQLEXPRESS;Initial Catalog=EjemploCapas;Integrated Security=True"

        Private Shared ComandoRestore As SqlCommand
        Private Cnn As New SqlConnection(Str)
        Private Tranx As SqlTransaction
        Private Cmd As SqlCommand


        Public Function Leer(ByVal consulta As String, ByVal hdatos As Hashtable) As DataSet

            Dim Ds As New DataSet
            Cmd = New SqlCommand

            Cmd.Connection = Cnn
            Cmd.CommandText = consulta
            Cmd.CommandType = CommandType.StoredProcedure

            If Not hdatos Is Nothing Then

                'si la hashtable no esta vacia, y tiene el dato q busco 
                For Each dato As String In hdatos.Keys
                    'cargo los parametros que le estoy pasando con la Hash
                    Cmd.Parameters.AddWithValue(dato, hdatos(dato))
                Next
            End If

            Dim Adaptador As New SqlDataAdapter(Cmd)
            Adaptador.Fill(Ds)
            Return Ds
            Cnn.Close()


        End Function

        Public Function Escribir(ByVal consulta As String, ByVal hdatos As Hashtable) As Boolean

            If Cnn.State = ConnectionState.Closed Then
                Cnn.ConnectionString = Str
                Cnn.Open()
            End If

            Try
                Tranx = Cnn.BeginTransaction
                Cmd = New SqlCommand
                Cmd.Connection = Cnn
                Cmd.CommandText = consulta
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Transaction = Tranx

                If Not hdatos Is Nothing Then

                    For Each dato As String In hdatos.Keys
                        'cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(dato, hdatos(dato))
                    Next
                End If

                Dim respuesta As Integer = Cmd.ExecuteNonQuery
                Tranx.Commit()
                Return True

            Catch ex As Exception
                Tranx.Rollback()
                Return False
            Finally
                Cnn.Close()
            End Try

        End Function
        Public Function crear_backup(ByVal Directorio As String, ByVal nombre As String, ByVal descripcion As String) As Boolean
            If Directorio.Length <> 3 Then
                Directorio = Directorio & "\" & nombre & ".bak"
            Else
                Directorio = Directorio & nombre & ".bak"
            End If
            If Cnn.State = ConnectionState.Closed Then
                Cnn.ConnectionString = Str
                Cnn.Open()
            End If
            Using Cnn
                Try
                    Dim sCmd As New StringBuilder
                    sCmd.Append("BACKUP DATABASE [EjemploCapas] TO  DISK = '" & Directorio & "' ")
                    sCmd.Append("WITH DESCRIPTION = '" & descripcion & "', NOFORMAT, NOINIT, ")
                    sCmd.Append("NAME = '" & nombre & "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
                    Dim cmd As New SqlCommand(sCmd.ToString, Cnn)
                    cmd.ExecuteNonQuery()
                    crear_backup = True
                Catch ex As Exception
                    crear_backup = False
                Finally
                    Cnn.Close()
                End Try
            End Using
        End Function
        Public Function crear_restore(ByVal directorio As String) As Boolean
            If Cnn.State = ConnectionState.Closed Then
                Cnn.ConnectionString = Str
                Cnn.Open()
            End If

            Try
                retornaComandoRestore(" ALTER DATABASE  [BestToy] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [EjemploCapas] FROM DISK = '" & directorio & "'  With Replace ALTER DATABASE [BestToy] SET MULTI_USER ", Cnn)
                crear_restore = True
            Catch ex As Exception
                crear_restore = False
            Finally
                Cnn.Close()
            End Try
        End Function
        Public Shared Sub retornaComandoRestore(ByVal SelectCommand As String, ByVal conexion As SqlConnection)
            ComandoRestore = New SqlCommand
            ComandoRestore.CommandText = SelectCommand
            ComandoRestore.CommandType = CommandType.Text
            ComandoRestore.Connection = conexion
            ComandoRestore.ExecuteNonQuery()
        End Sub
    End Class

End Namespace
