--Write a SQL query to display the average employee salary by department and job title.
SELECT ROUND(AVG(e.Salary), 2) AS [Average Salary]
	,d.NAME AS Department
	,e.JobTitle
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.NAME
	,e.JobTitle
ORDER BY d.NAME