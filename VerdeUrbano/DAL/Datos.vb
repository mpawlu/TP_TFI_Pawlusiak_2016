Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Text
Namespace DAL
    Public Class Datos

        Private Str As String = "Data Source=PROGRAMADORA-PC;Initial Catalog=VerdeUrbano;Integrated Security=True"
        '  Private Str As String = "Data Source=.\SQLEXPRESS;Initial Catalog=VerdeUrbano;Integrated Security=True"
        Private Shared ComandoRestore As SqlCommand
        Private Cnn As New SqlConnection(Str)
        Private Tranx As SqlTransaction
        Private Cmd As SqlCommand

        Shared Function retornaConexionMaestra() As SqlConnection
            Dim _objConexionMaster As New SqlConnection
            _objConexionMaster.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"
            Return _objConexionMaster
        End Function

        Public Function Leer(ByVal consulta As String, ByVal hdatos As Hashtable) As DataSet
            Try
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

            Catch ex As Exception
            End Try

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

        Public Function BackupRestore(ByVal Comando As SqlCommand, ByVal Cnn As SqlConnection) As Boolean
            Try
                Cnn.Open()
                Comando.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Return False
            End Try

        End Function

    End Class

End Namespace
