<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadClientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoBusca = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadastroDataSet = New ProjetoCadastroAccess.cadastroDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.ClientesTableAdapter = New ProjetoCadastroAccess.cadastroDataSetTableAdapters.ClientesTableAdapter()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomecliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnderecocliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CadastroDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.Location = New System.Drawing.Point(177, 143)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'txtCodigoBusca
        '
        Me.txtCodigoBusca.Location = New System.Drawing.Point(16, 48)
        Me.txtCodigoBusca.Name = "txtCodigoBusca"
        Me.txtCodigoBusca.Size = New System.Drawing.Size(59, 20)
        Me.txtCodigoBusca.TabIndex = 2
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(17, 93)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(169, 20)
        Me.txtNome.TabIndex = 4
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.CadastroDataSet
        '
        'CadastroDataSet
        '
        Me.CadastroDataSet.DataSetName = "cadastroDataSet"
        Me.CadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(202, 93)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(205, 20)
        Me.txtEndereco.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Endereço"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(423, 93)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(165, 20)
        Me.txtTelefone.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(420, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefone"
        '
        'btnNovo
        '
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Location = New System.Drawing.Point(96, 143)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 9
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Location = New System.Drawing.Point(421, 143)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 10
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Location = New System.Drawing.Point(340, 143)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Location = New System.Drawing.Point(106, 45)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodcliDataGridViewTextBoxColumn, Me.NomecliDataGridViewTextBoxColumn, Me.EnderecocliDataGridViewTextBoxColumn, Me.TelcliDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 209)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(575, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'CodcliDataGridViewTextBoxColumn
        '
        Me.CodcliDataGridViewTextBoxColumn.DataPropertyName = "cod_cli"
        Me.CodcliDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodcliDataGridViewTextBoxColumn.Name = "CodcliDataGridViewTextBoxColumn"
        Me.CodcliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomecliDataGridViewTextBoxColumn
        '
        Me.NomecliDataGridViewTextBoxColumn.DataPropertyName = "nome_cli"
        Me.NomecliDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomecliDataGridViewTextBoxColumn.Name = "NomecliDataGridViewTextBoxColumn"
        Me.NomecliDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomecliDataGridViewTextBoxColumn.Width = 130
        '
        'EnderecocliDataGridViewTextBoxColumn
        '
        Me.EnderecocliDataGridViewTextBoxColumn.DataPropertyName = "endereco_cli"
        Me.EnderecocliDataGridViewTextBoxColumn.HeaderText = "Endereço"
        Me.EnderecocliDataGridViewTextBoxColumn.Name = "EnderecocliDataGridViewTextBoxColumn"
        Me.EnderecocliDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnderecocliDataGridViewTextBoxColumn.Width = 200
        '
        'TelcliDataGridViewTextBoxColumn
        '
        Me.TelcliDataGridViewTextBoxColumn.DataPropertyName = "tel_cli"
        Me.TelcliDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelcliDataGridViewTextBoxColumn.Name = "TelcliDataGridViewTextBoxColumn"
        Me.TelcliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CadastroDataSetBindingSource
        '
        Me.CadastroDataSetBindingSource.DataSource = Me.CadastroDataSet
        Me.CadastroDataSetBindingSource.Position = 0
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Location = New System.Drawing.Point(258, 143)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 16
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Abrir Form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 371)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoBusca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalvar)
        Me.Name = "frmCadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoBusca As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents CadastroDataSet As cadastroDataSet
    Friend WithEvents ClientesTableAdapter As cadastroDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CadastroDataSetBindingSource As BindingSource
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents CodcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomecliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnderecocliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnEditar As Button
    Friend WithEvents Button1 As Button
End Class
