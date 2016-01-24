--Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 t.NAME AS Town
	,COUNT(e.EmployeeID) AS [Employee Count]
FROM Employees e
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON a.TownID = t.TownID
GROUP BY t.NAME
ORDER BY [Employee Count] DESC