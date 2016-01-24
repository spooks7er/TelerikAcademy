--Write a SQL query to find the count of all employees in each department and for each town.
SELECT count(*) [Emp. Count]
	,d.NAME AS [Dept.]
	,t.NAME AS [Town]
FROM Employees e
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON a.TownID = t.TownID
JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY t.NAME
	,d.NAME