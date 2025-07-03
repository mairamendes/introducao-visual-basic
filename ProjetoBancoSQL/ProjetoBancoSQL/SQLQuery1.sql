Use CadastroM

create proc SP_ExcluirCliente
@CodCliente as int
as 
delete from clientes WHERE cod_cli=@CodCliente
go

create proc SP_InserirCliente

@NomeCliente as varchar(50),
@EnderecoCliente as varchar(100),
@TelefoneCliente as varchar(50)
as 
insert into clientes VALUES (@NomeCliente, @EnderecoCliente, @TelefoneCliente)

go

select * from clientes