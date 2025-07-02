Public Class frmCadClientes
    Private Sub frmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.Fill(Me.CadastroDataSet.Clientes)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cliList = From clientes In CadastroDataSet.Clientes
                      Where (clientes.cod_cli = CInt(txtCodigoBusca.Text))
                      Select clientes.nome_cli, clientes.endereco_cli, clientes.tel_cli

        For Each cli In cliList
            txtNome.Text = cli.nome_cli
            txtEndereco.Text = cli.endereco_cli
            txtTelefone.Text = cli.tel_cli
        Next

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.ClientesTableAdapter.UPDATE_CLI(txtNome.Text,
        txtEndereco.Text, txtTelefone.Text, txtCodigoBusca.Text)

        'Atualiza o DataGridView após a edição
        DataGridView1.DataSource = Me.ClientesTableAdapter.GetData()

        MessageBox.Show("Registro editado com sucesso!",
                       "Edição de Registro", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Asterisk)
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If txtCodigoBusca.Text = "" Then
            MessageBox.Show("Informe o código do cliente a ser excluído.",
                            "Exclusão de Registro", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error)
        Else

            Me.ClientesBindingSource.RemoveCurrent()
            Me.Validate()
            Me.ClientesBindingSource.EndEdit()
            Me.CadastroDataSet.AcceptChanges()
            Me.ClientesTableAdapter.DELETE_CLI(txtCodigoBusca.Text)

            'Atualiza o DataGridView após a edição
            DataGridView1.DataSource = Me.ClientesTableAdapter.GetData()

            MessageBox.Show("Registro excluído com sucesso!",
                            "Exclusão de Registro", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Me.ClientesBindingSource.AddNew()
        btnSalvar.Enabled = True
        btnNovo.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtNome.Text = "" Or txtEndereco.Text = "" Or txtTelefone.Text = "" Then
            MessageBox.Show("Preencha todos os campos",
                       "Salvar registro", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Asterisk)
        End If

        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.CadastroDataSet.AcceptChanges()
        Me.ClientesTableAdapter.INSERT_CLI(txtNome.Text,
        txtEndereco.Text, txtTelefone.Text)

        'Atualiza o DataGridView após a edição
        DataGridView1.DataSource = Me.ClientesTableAdapter.GetData()
        Limpar()

        btnNovo.Enabled = True
        btnSalvar.Enabled = False

        MessageBox.Show("Registro inserido com sucesso!",
                       "Inserção de Registro", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Limpar()
        txtCodigoBusca.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtTelefone.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New Tela2
        form.Show()
    End Sub
End Class
