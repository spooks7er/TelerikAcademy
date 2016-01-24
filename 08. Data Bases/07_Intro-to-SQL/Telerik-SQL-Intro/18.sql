--Write a SQL query to find all employees, along with their manager and their address.
--Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT e.LastName AS EmpLastName
	,m.LastName AS MgrLastName
	,a.AddressText
FROM Employees e
INNER JOIN Employees m ON e.ManagerID = m.EmployeeID
INNER JOIN Addresses a ON a.AddressID = e.AddressID