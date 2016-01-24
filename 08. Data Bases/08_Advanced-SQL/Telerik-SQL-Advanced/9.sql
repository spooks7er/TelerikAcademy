--Write a SQL query to find all departments and the average salary for each of them.
SELECT AVG(e.Salary) AS [Average Salary]
	,d.NAME
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.NAME
ORDER BY [Average Salary] DESC