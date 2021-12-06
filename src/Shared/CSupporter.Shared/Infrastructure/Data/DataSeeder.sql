--procedure for calculate facture value

--products
INSERT INTO [dbo].[Products] ([Name], [Category], [Price], [Details])
	 VALUES ('Laptop Lenovo', 'Electronics', 3100, 'Intel Core i5, 240SSD, 16GB RAM')
INSERT INTO [dbo].[Products] ([Name], [Category], [Price], [Details])
	 VALUES ('IPhone 6S', 'Electronics', 1200, 'Apple A9 1.85GHz dual-core, 48Mpx, 4/64GB')
INSERT INTO [dbo].[Products] ([Name], [Category], [Price], [Details])
	 VALUES ('Headphone Huawei AM61', 'Electronics', 119.99, 'Bluetooth, microUSB, microphone')

--factures
INSERT INTO [dbo].[Factures] ([FactureNo], [FactureType], [ContractorId], [FactureDate], [UpdateDate], [InsertDate], [Value])
     VALUES (('FV13/11/2021'), ('INCOME'), 'F485167A-FF16-4A8C-83D5-1379A86CA8FF', GETDATE(), GETDATE(), GETDATE(), 0)
INSERT INTO [dbo].[Factures] ([FactureNo], [FactureType], [ContractorId], [FactureDate], [UpdateDate], [InsertDate], [Value])
     VALUES (('FV12/11/2021'), ('INCOME'), '955FB204-A56D-43C6-8117-31FE22537483', GETDATE(), GETDATE(), GETDATE(), 0)
INSERT INTO [dbo].[Factures] ([FactureNo], [FactureType], [ContractorId], [FactureDate], [UpdateDate], [InsertDate], [Value])
     VALUES (('FV22/11/2021'), ('INCOME'), 'F6738F1F-5D8A-442C-8386-98668E83493D', GETDATE(), GETDATE(), GETDATE(), 0)

--position factures	 
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('TV Samsung', 1, 1200.20, 1)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('Laptop ASUS', 1, 3500, 1)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('Smartphone Samsung', 1, 999.99, 2)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('Headphone', 1, 100, 2)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('IPhone 6S', 1, 999.99, 3)
INSERT INTO [dbo].[Positions] ([ProductName], [ProductAmount], [ProductPrice], [FactureId])
	 VALUES ('Laptop Lenovo', 1, 3100, 3)