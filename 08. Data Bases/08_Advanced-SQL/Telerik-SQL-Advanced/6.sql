--Write a SQL query to find the number of employees in the "Sales" department.
SELECT count(*) AS [Sales Employees Count]
FROM Employees
WHERE DepartmentID = (
		SELECT DepartmentID
		FROM Departments
		WHERE NAME = 'Sales'
		)

--with join
SELECT count(*) AS [Sales Employees Count]
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE d.NAME = 'Sales'