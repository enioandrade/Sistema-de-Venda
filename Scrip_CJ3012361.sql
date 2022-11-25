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
[admin][bit] NOT NULL DEFAULT 0,
) ON [PRIMARY]
GO

DROP TABLE [dbo].[funcionario]
GO