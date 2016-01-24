--Write a SQL query to find all employees that do not have manager.
SELECT FirstName
	,LastName
	,ManagerID
FROM Employees
WHERE ManagerID IS NULL