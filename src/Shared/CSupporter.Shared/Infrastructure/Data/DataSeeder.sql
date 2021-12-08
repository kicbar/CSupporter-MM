--procedure for calculate facture value
CREATE TRIGGER [dbo].[trg_calculate_facture_value]
ON [dbo].Positions
FOR INSERT, DELETE
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @factureId int;
	DECLARE @productId int;
	DECLARE @productPrice float;
	DECLARE @Action AS char(1);
	SET @Action = (CASE WHEN EXISTS(SELECT * FROM INSERTED) THEN 'I'
						WHEN EXISTS(SELECT * FROM DELETED) THEN 'D'
						ELSE NULL
				   END)

	IF @Action = 'I'
	BEGIN
		SELECT @factureId = I.FactureId FROM Inserted I;
		SELECT @productId = I.ProductId FROM Inserted I;
		SELECT @productPrice = Price FROM Products WHERE ProductId = @productId;

		UPDATE Factures 
		   SET [Value] = [Value] + @productPrice
		 WHERE FactureId = @factureId;
	 END
	IF @Action = 'D'
	BEGIN
		SELECT @factureId = D.FactureId FROM Deleted D;
		SELECT @productId = D.ProductId FROM Deleted D;
		SELECT @productPrice = Price FROM Products WHERE ProductId = @productId;

		UPDATE Factures 
		   SET [Value] = [Value] - @productPrice
		 WHERE FactureId = @factureId;
	 END
END

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
INSERT INTO [dbo].[Positions] ([PositionNo], [ProductId], [ProductAmount], [FactureId])
	 VALUES (1, 1, 1, 1)
INSERT INTO [dbo].[Positions] ([PositionNo], [ProductId], [ProductAmount], [FactureId])
	 VALUES (2, 1, 1, 1)
INSERT INTO [dbo].[Positions] ([PositionNo], [ProductId], [ProductAmount], [FactureId])
	 VALUES (1, 1, 1, 2)
INSERT INTO [dbo].[Positions] ([PositionNo], [ProductId], [ProductAmount], [FactureId])
	 VALUES (2, 1, 1, 2)
INSERT INTO [dbo].[Positions] ([PositionNo], [ProductId], [ProductAmount], [FactureId])
	 VALUES (1, 1, 1, 3)
INSERT INTO [dbo].[Positions] ([PositionNo], [ProductId], [ProductAmount], [FactureId])
	 VALUES (2, 1, 1, 3)