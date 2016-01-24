--Write a SQL query to find the names and salaries of the employees that have a salary
--that is up to 10% higher than the minimal salary for the company.
SELECT FirstName + ' ' + LastName AS EmpName
	,Salary
FROM Employees
WHERE Salary < (
		SELECT min(Salary) * 1.10
		FROM Employees
		)
ORDER BY Salary DESC