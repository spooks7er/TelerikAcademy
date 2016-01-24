--Write a SQL query to display the number of managers from each town.
SELECT t.NAME AS Town
	,COUNT(DISTINCT e.ManagerID) AS [Manager Count]
FROM Employees e
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON a.TownID = t.TownID
GROUP BY t.NAME
ORDER BY [Manager Count] DESC