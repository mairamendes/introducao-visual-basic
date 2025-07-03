Imports System.Data.SqlClient

Public Class FuncoesClientes
    Dim cn As New SqlConnection(My.Settings.conexao)
    Dim cmd As New SqlCommand()

    Public Function Excluir_Cliente(ByVal data As Clientes) As Boolean
        Try
            cn.Open()
            cmd = New SqlCommand("SP_ExcluirCliente", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodCLiente", data.CODCLI)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cn.Close()
        End Try
    End Function

    Public Function Inserir_Cliente(ByVal data As Clientes) As Boolean
        Try
            cn.Open()
            cmd = New SqlCommand("SP_InserirCliente", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@NomeCLiente", data.NOMECLI)
            cmd.Parameters.AddWithValue("@EnderecoCLiente", data.ENDCLI)
            cmd.Parameters.AddWithValue("@TelefoneCLiente", data.TELCLI)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cn.Close()
        End Try
    End Function

End Class
