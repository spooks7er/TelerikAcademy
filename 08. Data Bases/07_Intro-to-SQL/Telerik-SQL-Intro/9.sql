--Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT FirstName
	,LastName
	,JobTitle
FROM Employees
WHERE LastName LIKE '%ei%'