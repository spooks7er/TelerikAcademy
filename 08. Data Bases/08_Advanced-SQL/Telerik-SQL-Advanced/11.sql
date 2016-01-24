--Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT m.EmployeeID AS [Manager ID]
	,m.FirstName + ' ' + m.LastName AS [Manager Name]
	,count(e.EmployeeID) AS [Emp. Count]
FROM Employees m
JOIN Employees e ON m.EmployeeID = e.ManagerID
GROUP BY m.EmployeeID
	,m.FirstName
	,m.LastName
HAVING count(e.EmployeeID) = 5