CREATE TABLE [dbo].[ExtraOnOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdOrder] INT NULL, 
    [IdExtra] INT NULL
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Chave Primaria',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'ExtraOnOrder',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'FK Pedido',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'ExtraOnOrder',
    @level2type = N'COLUMN',
    @level2name = N'IdOrder'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'FK Adicional',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'ExtraOnOrder',
    @level2type = N'COLUMN',
    @level2name = N'IdExtra'