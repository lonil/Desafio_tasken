USE [Tasken]
GO

INSERT INTO [dbo].[CLIENTES]
           ([Nome]
           ,[CPF]
           ,[Idade])
     VALUES
           ('JO�O'
           ,'11111111111'
           ,22),('MARIA'
           ,'11111111112'
           ,23),('JOSE','11111111113',21),('JOSE SANTOS','11111111114',21),('SANTOS JOSE','11111111115',21);
GO

INSERT INTO [dbo].[TELEFONES]
           ([CPF_CLIENTE]
           ,[DDD]
           ,[TELEFONE])
     VALUES
           (11111111111
           ,21,222222223),(11111111111
           ,21,222222222),(11111111111
           ,22,222222223),(11111111111
           ,22,222222221),(11111111112
           ,21,222222225),(11111111112
           ,21,222222224),(11111111111
           ,21,222222226);
GO

