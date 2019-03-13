ALTER TABLE [dbo].[Order] ADD CONSTRAINT [FK_Order_Size] FOREIGN KEY (IdSize) REFERENCES [Size] (Id)
Go

ALTER TABLE [dbo].[Order] ADD CONSTRAINT [FK_Order_Pizza] FOREIGN KEY (IdPizza) REFERENCES [Pizza] (Id)
Go

ALTER TABLE [dbo].[ExtraOnOrder] ADD CONSTRAINT [FK_ExtraOnOrder_Order] FOREIGN KEY (IdOrder) REFERENCES [Order] (Id)
Go

ALTER TABLE [dbo].[ExtraOnOrder] ADD CONSTRAINT [FK_ExtraOnOrder_Extra] FOREIGN KEY (IdExtra) REFERENCES [Extra] (Id)
Go