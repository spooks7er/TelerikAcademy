--Write a SQL query to find all employees along with their managers. 
--For employees that do not have manager display the value "(no manager)".
SELECT e.LastName AS EmpLastName
	,isnull(m.LastName, 'no manager') AS MgrLastName
FROM Employees e
LEFT OUTER JOIN Employees m ON e.ManagerID = m.EmployeeID