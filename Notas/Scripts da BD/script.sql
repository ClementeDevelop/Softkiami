
CREATE DATABASE BDSoftkiami

CREATE TABLE [dbo].[Categoria](
	[CodCateg] [int] IDENTITY(1,1) NOT NULL,
	[DesigCateg] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodCateg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[CodCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[NIF] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[NumTel] [nvarchar](100) NOT NULL,
	[DataRegist] [date] NOT NULL,
 CONSTRAINT [PK__Cliente__DF8324D755E831DC] PRIMARY KEY CLUSTERED 
(
	[CodCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Cliente__A9D1053405F23BC1] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Cliente__C7DEC3306C6546E7] UNIQUE NONCLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[CodFornec] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[DataNasc] [date] NOT NULL,
	[NIF] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Genero] [nvarchar](100) NOT NULL,
	[EstadoCivil] [nvarchar](100) NOT NULL,
	[NumTel] [nvarchar](100) NOT NULL,
	[Provincia] [nvarchar](100) NOT NULL,
	[Municipio] [nvarchar](100) NOT NULL,
	[Bairro] [nvarchar](100) NOT NULL,
	[Rua] [nvarchar](100) NOT NULL,
	[DataRegist] [date] NOT NULL,
 CONSTRAINT [PK__Forneced__E5DC03B3C3885E84] PRIMARY KEY CLUSTERED 
(
	[CodFornec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Forneced__A9D10534D37FFD7E] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Forneced__C7DEC330DC3899C7] UNIQUE NONCLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[CodFunc] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[DataNasc] [date] NOT NULL,
	[NIF] [nvarchar](100) NOT NULL,
	[Funcao] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Genero] [nvarchar](100) NOT NULL,
	[EstadoCivil] [nvarchar](100) NOT NULL,
	[NumTel] [nvarchar](100) NOT NULL,
	[Provincia] [nvarchar](100) NOT NULL,
	[Municipio] [nvarchar](100) NOT NULL,
	[Bairro] [nvarchar](100) NOT NULL,
	[Rua] [nvarchar](100) NOT NULL,
	[DataRegist] [date] NOT NULL,
 CONSTRAINT [PK__Funciona__CBDB940B2E25B3BE] PRIMARY KEY CLUSTERED 
(
	[CodFunc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Funciona__C7DEC330155DB4CA] UNIQUE NONCLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Produto]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[CodProdut] [int] IDENTITY(1,1) NOT NULL,
	[CodCateg] [int] NOT NULL,
	[Designacao] [nvarchar](100) NOT NULL,
	[IVA] [float] NOT NULL,
	[PUnitario] [decimal](18, 0) NOT NULL,
	[Desconto] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodProdut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Relatorio]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relatorio](
	[CodRelat] [int] IDENTITY(1,1) NOT NULL,
	[CodUtilizador] [int] NOT NULL,
	[Título] [nvarchar](100) NOT NULL,
	[DataRelat] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodRelat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stock]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[CodStock] [int] IDENTITY(1,1) NOT NULL,
	[CodProdut] [int] NOT NULL,
	[CodCateg] [int] NOT NULL,
	[Qtd] [int] NOT NULL,
	[DataFabrico] [date] NOT NULL,
	[DataExpiracao] [date] NOT NULL,
	[DataEntrada] [date] NOT NULL,
	[Origem] [nvarchar](50) NOT NULL,
	[StockMax] [int] NOT NULL,
	[StockMin] [int] NOT NULL,
 CONSTRAINT [PK__Stock__BC357DE36B86F53E] PRIMARY KEY CLUSTERED 
(
	[CodStock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoPGT]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPGT](
	[CodTipo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Utilizador]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilizador](
	[CodUtilizador] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[DataNasc] [date] NOT NULL,
	[NIF] [nvarchar](100) NOT NULL,
	[Utiliza] [nvarchar](100) NOT NULL,
	[Senha] [nvarchar](100) NOT NULL,
	[Funcao] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Genero] [nvarchar](100) NOT NULL,
	[EstadoCivil] [nvarchar](100) NOT NULL,
	[NumTel] [nvarchar](100) NOT NULL,
	[Provincia] [nvarchar](100) NOT NULL,
	[Municipio] [nvarchar](100) NOT NULL,
	[Bairro] [nvarchar](100) NOT NULL,
	[Rua] [nvarchar](100) NOT NULL,
	[DataRegist] [date] NOT NULL,
 CONSTRAINT [PK__Utilizad__8EB166A5532B0D58] PRIMARY KEY CLUSTERED 
(
	[CodUtilizador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Utilizad__C7DEC330AAF33531] UNIQUE NONCLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venda]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[CodVenda] [int] IDENTITY(1,1) NOT NULL,
	[CodUtilizador] [int] NOT NULL,
	[CodProdut] [int] NOT NULL,
	[CodCliente] [int] NOT NULL,
	[Artigo] [nvarchar](100) NOT NULL,
	[Qtd] [int] NOT NULL,
	[TipoPGT] [nvarchar](25) NOT NULL,
	[DataVenda] [date] NOT NULL,
	[PTotal] [money] NOT NULL,
 CONSTRAINT [PK__Venda__28196782A8EF2748] PRIMARY KEY CLUSTERED 
(
	[CodVenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD FOREIGN KEY([CodCateg])
REFERENCES [dbo].[Categoria] ([CodCateg])
GO
ALTER TABLE [dbo].[Relatorio]  WITH CHECK ADD  CONSTRAINT [FK__Relatorio__CodUt__558AAF1E] FOREIGN KEY([CodUtilizador])
REFERENCES [dbo].[Utilizador] ([CodUtilizador])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Relatorio] CHECK CONSTRAINT [FK__Relatorio__CodUt__558AAF1E]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK__Stock__CodCateg__75235608] FOREIGN KEY([CodCateg])
REFERENCES [dbo].[Categoria] ([CodCateg])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK__Stock__CodCateg__75235608]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK__Stock__CodProdut__742F31CF] FOREIGN KEY([CodProdut])
REFERENCES [dbo].[Produto] ([CodProdut])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK__Stock__CodProdut__742F31CF]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK__Venda__CodClient__26EFBBC6] FOREIGN KEY([CodCliente])
REFERENCES [dbo].[Cliente] ([CodCliente])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK__Venda__CodClient__26EFBBC6]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK__Venda__CodProdut__25FB978D] FOREIGN KEY([CodProdut])
REFERENCES [dbo].[Produto] ([CodProdut])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK__Venda__CodProdut__25FB978D]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK__Venda__CodUtiliz__25077354] FOREIGN KEY([CodUtilizador])
REFERENCES [dbo].[Utilizador] ([CodUtilizador])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK__Venda__CodUtiliz__25077354]
GO
/****** Object:  StoredProcedure [dbo].[Buscar_CodCliente]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Buscar_CodCliente]
@CodCliente int

as
begin

select * from cliente where CodCliente = @codcliente

end
GO
/****** Object:  StoredProcedure [dbo].[Buscar_CodFunc]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Buscar_CodFunc]
@CodFunc int
as
begin
select * from funcionario where codfunc = @CodFunc
end
GO
/****** Object:  StoredProcedure [dbo].[Buscar_CodProdut]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Buscar_CodProdut]
@CodProdut int
as
begin
select Designacao, IVA, PUnitario, Desconto, DesigCateg
from produto
inner join categoria on produto.codcateg=categoria.CodCateg
where CodProdut = @CodProdut
end
GO
/****** Object:  StoredProcedure [dbo].[BuscarCodFornecedor]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarCodFornecedor]

@CodFornec int

as
begin
select * from fornecedor
where CodFornec = @CodFornec
end

GO
/****** Object:  StoredProcedure [dbo].[BuscarCodUtilizador]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscarCodUtilizador]
@CodUtilizador int
as
begin

SELECT * FROM Utilizador WHERE CodUtilizador = @CodUtilizador
end 

GO
/****** Object:  StoredProcedure [dbo].[ConsultarCategoria]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ConsultarCategoria]
as
begin
select * from categoria order by desigcateg asc
end

GO
/****** Object:  StoredProcedure [dbo].[ConsultarCliente]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ConsultarCliente]

@Nome nvarchar(100),
@NIF nvarchar(100),
@Email nvarchar(100),
@NumTel nvarchar(100)

as
begin

SELECT CodCliente, Nome, NIF,Email, NumTel
FROM Cliente  WHERE
Nome like @Nome or NIF like @NIF or Email like @Email or NumTel like @NumTel
end

GO
/****** Object:  StoredProcedure [dbo].[ConsultarFornecedor]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ConsultarFornecedor]

@Nome nvarchar(100),
@Email nvarchar(100),
@NIF nvarchar(100),
@NumTel nvarchar(100)

as
begin

SELECT CodFornec, Nome, Email, NIF, NumTel
FROM fornecedor  WHERE
Nome like @Nome or Email like @Email or NIF like @NIF or  NumTel like @NumTel
end

GO
/****** Object:  StoredProcedure [dbo].[ConsultarFuncionario]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ConsultarFuncionario]

@Nome nvarchar(100),
@Email nvarchar(100),
@NIF nvarchar(100),
@NumTel nvarchar(100)

as
begin

SELECT CodFunc, Nome, Email, NIF, NumTel
FROM funcionario  WHERE
Nome like @Nome or Email like @Email or NIF like @NIF or  NumTel like @NumTel
end

GO
/****** Object:  StoredProcedure [dbo].[ConsultarUtilizador]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ConsultarUtilizador]

@Nome nvarchar(100),
@NIF nvarchar(100),
@Funcao nvarchar(100)

as
begin

SELECT CodUtilizador, Nome, 
Email, NIF, Funcao 
FROM Utilizador  
WHERE Nome like @Nome 
or NIF like @NIF 
or Funcao like @Funcao
end

GO
/****** Object:  StoredProcedure [dbo].[Count_Cliente]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Count_Cliente]
as
begin
select count(*) from cliente
end

GO
/****** Object:  StoredProcedure [dbo].[Count_Fornecedor]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Count_Fornecedor]
as
begin
select count(*) from fornecedor
end

GO
/****** Object:  StoredProcedure [dbo].[Count_Funcionario]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Count_Funcionario]
as
begin
select count(*) from Funcionario
end

GO
/****** Object:  StoredProcedure [dbo].[Count_Produto]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Count_Produto]
as
begin
select count(*) from produto
end

GO
/****** Object:  StoredProcedure [dbo].[Count_Utilizador]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Count_Utilizador]
as
begin
select count(*) from utilizador
end

GO
/****** Object:  StoredProcedure [dbo].[EditarCliente]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarCliente]
@CodCliente int,
@Nome nvarchar(100),
@NIF nvarchar(100),
@Email nvarchar(100),
@NumTel nvarchar(100),
@DataRegist datetime

as
begin

update Cliente set
Nome = @Nome,
NIF = @NIF,
Email = @Email,
NumTel = @NumTel,
DataRegist = @DataRegist

WHERE codCliente = @Codcliente

end

GO
/****** Object:  StoredProcedure [dbo].[EditarFornecedor]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarFornecedor]
@CodFornec int,
@DataNasc datetime,
@Nome nvarchar(100),
@NIF nvarchar(100),
@Email nvarchar(100),
@Genero nvarchar(100),
@EstadoCivil nvarchar(100),
@NumTel nvarchar(100),
@Provincia nvarchar(100),
@Municipio nvarchar(100),
@Bairro nvarchar(100),
@Rua nvarchar(100),
@DataRegist datetime

as
begin

update fornecedor set
DataNasc = @DataNasc,
Nome = @Nome,
NIF = @NIF,
Email = @Email,
Genero = @Genero,
EstadoCivil = @EstadoCivil,
NumTel = @NumTel,
Provincia = @Provincia,
Municipio = @Municipio,
Bairro = @Bairro,
Rua = @Rua,
DataRegist = @DataRegist

WHERE CodFornec = @CodFornec

end

GO
/****** Object:  StoredProcedure [dbo].[EditarFuncionario]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarFuncionario]
@CodFunc int,
@Nome nvarchar(100),
@DataNasc date,
@NIF nvarchar(100),
@Funcao nvarchar(100),
@Email nvarchar(100),
@Genero nvarchar(100),
@EstadoCivil nvarchar(100),
@NumTel nvarchar(100),
@Provincia nvarchar(100),
@Municipio nvarchar(100),
@Bairro nvarchar(100),
@Rua nvarchar(100),
@DataRegist date
as
begin
update Funcionario set 
Nome = @Nome,
DataNasc = @DataNasc,
NIF = @NIF,
Funcao = @Funcao,
Email = @Email,
Genero = @Genero,
EstadoCivil = @EstadoCivil,
NumTel = @NumTel,
Provincia = @Provincia,
Municipio = @Municipio,
Bairro = @Bairro,
Rua = @Rua,
DataRegist = @DataRegist
WHERE CodFunc = @CodFunc
end

GO
/****** Object:  StoredProcedure [dbo].[EditarProduto]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EditarProduto]
@CodProdut int,
@Designacao nvarchar,
@IVA float,
@PUnitario decimal,
@Desconto float,
@CodCateg int
as
begin
update produto set
Designacao = @Designacao,
IVA = @IVA,
PUnitario = @PUnitario,
Desconto =  @Desconto,
CodCateg = @CodCateg 
where CodProdut = @CodProdut 
end
GO
/****** Object:  StoredProcedure [dbo].[EditarUtilizador]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarUtilizador]
@CodUtilizador int,
@Nome nvarchar(100), 
@DataNasc datetime,
@NIF nvarchar(100), 
@Utiliza nvarchar(100), 
@Senha nvarchar(100), 
@Funcao nvarchar(100),
@Email nvarchar(100),
@Genero nvarchar(100), 
@EstadoCivil nvarchar(100),
@NumTel nvarchar(100), 
@Provincia nvarchar(100),
@Municipio nvarchar(100), 
@Bairro nvarchar(100), 
@Rua nvarchar(100), 
@DataRegist datetime

as
begin

UPDATE Utilizador SET 
Nome = @Nome, DataNasc = @DataNasc, NIF = @NIF, 
Utiliza = @Utiliza, Senha = @Senha, Funcao = @Funcao,
Email = @Email, Genero = @Genero, EstadoCivil = @EstadoCivil,
NumTel = @NumTel, Provincia = @Provincia,
Municipio =  @Municipio, 
Bairro = @Bairro, Rua = @Rua, DataRegist = @DataRegist 

WHERE CodUtilizador =  @CodUtilizador

end 

GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarCliente]

@CodCliente int
as
begin

delete  from cliente 
where codcliente = @codcliente
end

GO
/****** Object:  StoredProcedure [dbo].[EliminarFornecedor]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarFornecedor]
@CodFornec int


as
begin

delete from fornecedor

WHERE CodFornec = @CodFornec

end

GO
/****** Object:  StoredProcedure [dbo].[EliminarFuncionario]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarFuncionario]
@CodFunc int
as
begin
delete from Funcionario
WHERE CodFunc = @CodFunc
end

GO
/****** Object:  StoredProcedure [dbo].[EliminarProduto]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarProduto]
@CodProdut int
as
begin

delete  from Produto 
where CodProdut = @CodProdut
end

GO
/****** Object:  StoredProcedure [dbo].[EliminarUtilizador]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarUtilizador]

@CodUtilizador int
as
begin

DELETE FROM Utilizador WHERE CodUtilizador = @CodUtilizador
end

GO
/****** Object:  StoredProcedure [dbo].[InserirCliente]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InserirCliente]

@Nome nvarchar (100),
@NIF nvarchar (100),
@Email nvarchar (100), 
@NumTel nvarchar (100), 
@DataRegist datetime

as
begin

insert into cliente 
values
(
@Nome,
@NIF,
@Email, 
@NumTel, 
@DataRegist
)
end

GO
/****** Object:  StoredProcedure [dbo].[InserirFornecedor]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InserirFornecedor]

@Nome nvarchar(100),
@DataNasc datetime,
@NIF nvarchar(100),
@Email nvarchar(100),
@Genero nvarchar(100),
@EstadoCivil nvarchar(100),
@NumTel nvarchar(100),
@Provincia nvarchar(100),
@Municipio nvarchar(100),
@Bairro nvarchar(100),
@Rua nvarchar(100),
@DataRegist datetime
as
begin

insert into fornecedor values(
@Nome,
@DataNasc,
@NIF,
@Email,
@Genero,
@EstadoCivil,
@NumTel,
@Provincia,
@Municipio,
@Bairro,
@Rua,
@DataRegist
)
end

GO
/****** Object:  StoredProcedure [dbo].[InserirFuncionario]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InserirFuncionario]
--@CodUtilizador int,
@Nome nvarchar(100),
@DataNasc datetime,
@NIF nvarchar(100),
@Funcao nvarchar(100),
@Email nvarchar(100),
@Genero nvarchar(100),
@EstadoCivil nvarchar(100),
@NumTel nvarchar(100),
@Provincia nvarchar(100),
@Municipio nvarchar(100),
@Bairro nvarchar(100),
@Rua nvarchar(100),
@DataRegist datetime
as
begin
insert into Funcionario values
(
--@CodUtilizador,
@Nome,
@DataNasc,
@NIF,
@Funcao,
@Email,
@Genero,
@EstadoCivil,
@NumTel,
@Provincia,
@Municipio,
@Bairro,
@Rua,
@DataRegist
)
end

GO
/****** Object:  StoredProcedure [dbo].[InserirProduto]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InserirProduto]
@CodCateg int,
@Designacao nvarchar(100),
@IVA float,
@PUnitario money,
@Desconto float
as
begin
insert into Produto values
(
@CodCateg,
@Designacao,
@IVA,
@PUnitario,
@Desconto
)
end

GO
/****** Object:  StoredProcedure [dbo].[InserirUtilizador]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InserirUtilizador]

@Nome nvarchar(100),
@DataNasc datetime,
@NIF nvarchar(100),
@Utiliza nvarchar(100),
@Senha nvarchar(100),
@Funcao  nvarchar(100),
@Email nvarchar(100),
@Genero nvarchar(100),
@EstadoCivil nvarchar(100),
@NumTel nvarchar(100),
@Provincia nvarchar(100),
@Municipio nvarchar(100),
@Bairro nvarchar(100),
@Rua nvarchar(100),
@DataRegist datetime 

as
begin

insert into utilizador values 
(
@Nome,
@DataNasc,
@NIF,
@Utiliza,
@Senha,
@Funcao,
@Email,
@Genero,
@EstadoCivil,
@NumTel,
@Provincia,
@Municipio,
@Bairro,
@Rua,
@DataRegist
)
end

GO
/****** Object:  StoredProcedure [dbo].[ListarProdutos]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarProdutos]
as
begin
select codprodut as codigo, designacao, iva, punitario, desconto, desigcateg
from produto
inner join categoria on produto.codcateg=categoria.codcateg
end
GO
/****** Object:  StoredProcedure [dbo].[ListarTipoPGT]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListarTipoPGT]
as
begin
select * from TipoPGT
end

GO
/****** Object:  StoredProcedure [dbo].[LoginUser]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LoginUser]

@Utiliza nvarchar(100),
@Senha nvarchar(100)

as
begin

select * from utilizador where Utiliza = @Utiliza and Senha = @Senha

end

GO
/****** Object:  StoredProcedure [dbo].[ProcurarProduto]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcurarProduto]
@Designacao nvarchar(100)
as
begin
select codprodut as codigo, designacao, iva, punitario, desconto, desigcateg
from produto
inner join categoria on produto.codcateg=categoria.codcateg
where  Designacao like @Designacao
end

GO
/****** Object:  StoredProcedure [dbo].[SelecionarProdutos]    Script Date: 24/07/2024 18:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecionarProdutos]
as
begin
select codprodut as codigo, designacao,iva, punitario, desconto, desigcateg
from produto
inner join categoria on produto.codcateg=categoria.codcateg
end

