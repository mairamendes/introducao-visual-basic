Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cli As New Clientes
        Dim func As New FuncoesClientes

        If Me.ValidateChildren = True And TextBox1.Text <> "" Then
            Try
                cli.CODCLI = TextBox1.Text

                If func.Excluir_Cliente(cli) Then
                    MessageBox.Show("Exclusão realizada com sucesso", "Cliente")
                    TextBox1.Text = ""
                    AtualizarGrid()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Insira o código do cliente para exclusão", "Cliente")
        End If
    End Sub

    Public Function AtualizarGrid()
        Dim conexao As New SqlConnection(My.Settings.conexao)
        Dim sql As String = "SELECT cod_cli, nome_cli, end_cli, tel_cli FROM clientes"
        Dim cmd As New SqlCommand(sql, conexao)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds, "clientes")

            Me.DataGridView1.DataSource = ds.Tables("clientes")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cli As New Clientes
        Dim func As New FuncoesClientes

        If Me.ValidateChildren = True And TextBox2.Text <> "" _
            And TextBox3.Text <> "" And TextBox4.Text <> "" Then
            Try
                cli.NOMECLI = TextBox2.Text
                cli.ENDCLI = TextBox3.Text
                cli.TELCLI = TextBox4.Text

                If func.Inserir_Cliente(cli) Then
                    MessageBox.Show("Inserção realizada com sucesso", "Cliente")
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    AtualizarGrid()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Preencha os campos", "Cliente")
        End If
    End Sub
End Class
