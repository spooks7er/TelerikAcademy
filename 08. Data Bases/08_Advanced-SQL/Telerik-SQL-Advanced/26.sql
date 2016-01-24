--Write a SQL query to display the minimal employee salary by department and job title along 
--with the name of some of the employees that take it.
SELECT ROUND(MIN(e.Salary), 2) AS [Minimal Salary]
	,d.NAME AS Department
	,e.JobTitle
	,MIN(CONCAT (e.FirstName,' ',e.LastName)) AS Employee
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.NAME
	,e.JobTitle
ORDER BY d.NAME