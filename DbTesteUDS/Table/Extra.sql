CREATE TABLE [dbo].[Extra]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Description] VARCHAR(50) NOT NULL DEFAULT (''), 
    [Amount] NUMERIC(8, 2) NOT NULL DEFAULT (0), 
    [Time] INT NOT NULL DEFAULT (0)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Chave Primaria',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Extra',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descrição',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Extra',
    @level2type = N'COLUMN',
    @level2name = N'Description'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Valor',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Extra',
    @level2type = N'COLUMN',
    @level2name = N'Amount'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tempo em Segundos',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Extra',
    @level2type = N'COLUMN',
    @level2name = N'Time'