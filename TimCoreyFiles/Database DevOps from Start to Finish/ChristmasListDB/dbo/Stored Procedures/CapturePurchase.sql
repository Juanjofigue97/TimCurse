CREATE PROCEDURE [dbo].[CapturePurchase]
	@ItemName varchar(50),
	@Price MONEY,
	@PurchasedForId int
AS
	insert into dbo.Purchase (ItemName, Price, PurchasedForId)
	values (@ItemName, @Price, @PurchasedForId);
RETURN 0