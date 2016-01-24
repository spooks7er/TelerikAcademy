--Write a SQL query to find the average salary in the "Sales" department.
SELECT round(avg(Salary), 2) AS 'Average Salary'
FROM Employees
WHERE DepartmentID = (
		SELECT DepartmentID
		FROM Departments
		WHERE NAME = 'Sales'
		)

--with join
SELECT round(avg(e.Salary), 2) AS 'Average Salary'
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE d.NAME = 'Sales'