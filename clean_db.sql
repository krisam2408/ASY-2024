DELETE FROM [FerraDB].[dbo].[Purchases]
DELETE FROM [FerraDB].[dbo].[Cart]
DELETE FROM [FerraDB].[dbo].[Subscriptions]

SELECT * FROM [FerraDB].[dbo].[Purchases]
SELECT * FROM [FerraDB].[dbo].[Cart]
SELECT * FROM [FerraDB].[dbo].[Subscriptions]

  select * from cart c
  join Purchases p on(p.CartId = c.Id)
  where c.PurchasePending = 1 and p.Accepted = 0