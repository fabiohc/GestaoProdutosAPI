# GestaoProdutosAPI
Desenvolvimento de API para gestão de produtos

Fala ia Dev. BELEZA.. Que Bom!


Nesse projeto temos a implementação de uma API para Gestão de produtos e fornecedor.

Em breve alterações serão feitas para separar as entidades PRODUTO e FORNECENDO. Então fica ligado, porque refatorar é aprender.

AQUI ESTA O SCRIPT DO BANCO, PRA QUEM NÃO QUER PERDER TEMPO.. BELEZZZ

CREATE TABLE [dbo].[ProdutoFornecedor](
	[CodigoProduto] [int] IDENTITY(1,1) NOT NULL ,
	[DescricaoProduto] [varchar](255) NOT NULL,
	[Situacao] varchar (7) NOT NULL,
	[DataFabricacao] [date] NULL,
	[DataValidade] [date] NULL,	
	[CodigoFornecedor] [int],
	[DescricaoFornecedor] [varchar](255) NULL,
	[CNPJ] [varchar](14) NULL,	 
)


