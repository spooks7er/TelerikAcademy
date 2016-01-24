--Write a SQL query to find the names of all employees
--from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT e.LastName
	,d.NAME AS 'Dept. Name'
	,year(e.HireDate) AS 'Hire Yaer'
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE year(e.HireDate) BETWEEN 1995
		AND 2005