--Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 FirstName
	,LastName
	,Salary
FROM Employees
ORDER BY Salary DESC