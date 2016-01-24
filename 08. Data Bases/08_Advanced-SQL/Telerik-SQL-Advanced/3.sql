--Write a SQL query to find the full name, salary and department of the employees 
--that take the minimal salary in their department.
--Use a nested SELECT statement.
SELECT e.FirstName + ' ' + e.LastName AS EmpName
	,e.Salary
	,d.NAME
FROM Employees e
JOIN Departments d ON d.DepartmentID = e.DepartmentID
WHERE Salary = (
		SELECT min(Salary)
		FROM Employees e
		WHERE e.DepartmentID = d.DepartmentID
		)