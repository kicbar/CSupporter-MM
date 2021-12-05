
--factures
INSERT INTO [dbo].[Factures] ([FactureNo], [FactureType], [ContractorId], [FactureDate], [UpdateDate], [InsertDate], [Value])
     VALUES (('FV13/11/2021'), ('INCOME'), 1, GETDATE(), GETDATE(), GETDATE(), 0)
INSERT INTO [dbo].[Factures] ([FactureNo], [FactureType], [ContractorId], [FactureDate], [UpdateDate], [InsertDate], [Value])
     VALUES (('FV12/11/2021'), ('INCOME'), 2, GETDATE(), GETDATE(), GETDATE(), 0)
INSERT INTO [dbo].[Factures] ([FactureNo], [FactureType], [ContractorId], [FactureDate], [UpdateDate], [InsertDate], [Value])
     VALUES (('FV22/11/2021'), ('INCOME'), 3, GETDATE(), GETDATE(), GETDATE(), 0)

--position factures	 
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('TV Samsung', 1, 1200.20, 5)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('Laptop ASUS', 1, 3500, 5)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('Smartphone Samsung', 1, 999.99, 6)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('Headphone', 1, 100, 6)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('IPhone 6S', 1, 999.99, 7)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('Laptop Lenovo', 1, 3100, 7)actureId])
