--Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT FirstName
	,LastName
	,JobTitle
FROM Employees
WHERE FirstName LIKE 'Sa%'