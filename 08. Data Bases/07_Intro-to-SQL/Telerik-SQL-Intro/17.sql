--Write a SQL query to find all employees along with their manager.
SELECT e.LastName as EmpLastName
	,m.LastName AS MgrLastName
FROM Employees e
INNER JOIN Employees m ON e.ManagerID = m.EmployeeID

--Equi Join
SELECT e.LastName as EmpLastName
	,m.LastName AS MgrLastName
FROM Employees e
	,Employees m
WHERE e.ManagerID = m.EmployeeID