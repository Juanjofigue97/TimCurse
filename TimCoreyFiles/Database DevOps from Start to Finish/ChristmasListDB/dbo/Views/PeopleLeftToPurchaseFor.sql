CREATE VIEW [dbo].[PeopleLeftToPurchaseFor]
	AS 
	select per.FirstName, per.LastName, per.BudgetAmount, pur.TotalSpent, 
		(per.BudgetAmount - COALESCE(pur.TotalSpent, 0)) AS AmountLeftToSpend
	from dbo.Person per
	left join (SELECT PurchasedForId, sum(Price) AS TotalSpent
		from dbo.Purchase
		GROUP BY PurchasedForId
		) AS pur on per.Id = pur.PurchasedForId
	WHERE (per.BudgetAmount - COALESCE(pur.TotalSpent, 0)) > 0