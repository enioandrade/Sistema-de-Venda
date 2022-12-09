CREATE DATABASE Vendas
go

use Vendas
go

create table [dbo].[funcionario](
[id] [int] IDENTITY (1,1) NOT NULL,
[func_nome] [varchar](100) NOT NULL,
[func_telefone] [varchar](20) NOT NULL,
[func_cpf] [varchar](30) NOT NULL,
[func_email] [varchar](100) NOT NULL,
[func_data_nasc] [varchar](10) NOT NULL,
[func_end] [varchar](100) NOT NULL,
[func_usuario] [varchar](20) NOT NULL,
[func_senha] [varchar](20) NOT NULL,
[admin][varchar](3) NOT NULL,
) ON [PRIMARY]
GO

create table [dbo].[produtos](
[id_produto] [int] IDENTITY (1,1) NOT NULL,
[nome_produto] [varchar](15) NOT NULL,
[valor_produto] [decimal](10,2) NOT NULL,
[quant_produto] [int] NOT NULL,
[produto_foto] [varbinary](max),
) ON [PRIMARY]
GO



DROP TABLE  [dbo].[funcionario]
GO



INSERT INTO [dbo].[funcionario] VALUES('ENIO','12997004461', '43685245864','enioandeade','12-03-1999','rua','dan','dan','SIM') 
GO
INSERT INTO [dbo].[funcionario] VALUES('ENIO','12997004461', '43685245864','enioandeade','12-03-1999','rua','enio','enio','NAO') 
GO

select * from [dbo].[funcionario]
go

SELECT
	func_usuario,
	admin
FROM [dbo].[funcionario]
WHERE (func_usuario = 'enioandrade' AND func_senha = 'enio')
GO