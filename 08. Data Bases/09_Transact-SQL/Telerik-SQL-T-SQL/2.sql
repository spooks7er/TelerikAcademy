CREATE PROC usp_SelectPersonWithGreaterBalanceThan (@minaBalance MONEY = 1000)
AS
SELECT *
FROM Persons p
JOIN Accounts a ON p.id = a.PersonnId
WHERE a.Balance > @minaBalance
ORDER BY a.Balance
GO

--EXEC usp_SelectPersonWithGreaterBalanceThan 20000