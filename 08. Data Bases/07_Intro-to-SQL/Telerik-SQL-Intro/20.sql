--Write a SQL query to find all the employees and the manager for each of them along with the employees that
--do not have manager. Use right outer join. Rewrite the query to use left outer join.
SELECT e.LastName AS EmpLastName
	,m.EmployeeID AS MgrID
	,m.LastName AS MgrLastName
FROM Employees e
LEFT OUTER JOIN Employees m ON e.ManagerID = m.EmployeeID
GO

SELECT e.LastName AS EmpLastName
	,m.EmployeeID AS MgrID
	,m.LastName AS MgrLastName
FROM Employees e
RIGHT OUTER JOIN Employees m ON e.ManagerID = m.EmployeeID