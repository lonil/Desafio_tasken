USE [Tasken]
GO
SELECT [Nome]
      ,[CPF]
      ,[Idade]
  FROM [dbo].[CLIENTES]
GO

SELECT [Nome]
      ,[CPF]
      ,[Idade]
  FROM [dbo].[CLIENTES]
  WHERE [IDADE] >= 22
  ORDER BY [IDADE] ASC

GO

SELECT C.[Nome], COUNT(T.[TELEFONE]) AS N_TELEFONES
      
  FROM [dbo].[CLIENTES] as C
  LEFT JOIN[dbo].[TELEFONES] as T
  ON C.[CPF] = T.[CPF_CLIENTE]
  GROUP BY C.[NOME]
  HAVING COUNT(T.[TELEFONE]) > 0

GO

DELETE FROM [dbo].[CLIENTES]
      WHERE [NOME] LIKE '%SANTOS'
GO

SELECT [Nome]
      ,[CPF]
      ,[Idade]
  FROM [dbo].[CLIENTES]
GO