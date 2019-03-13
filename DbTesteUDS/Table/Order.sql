CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdSize] INT NULL, 
    [IdPizza] INT NULL, 
    [Quantity] INT NOT NULL DEFAULT 0, 
    [Amount] NUMERIC(8, 2) NOT NULL DEFAULT 0, 
    [Time] INT NOT NULL DEFAULT 0, 
    [DateCreate] DATETIME NULL
)


GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Chave Primaria',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'FK Tamanho',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'IdSize'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fk Pizza',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'IdPizza'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Quantidade ',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = 'Quantity'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Valor Total',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'Amount'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tempo Total',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'Time'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de criação so pedido',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'DateCreate'