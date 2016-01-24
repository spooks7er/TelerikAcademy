--Write a SQL query to find all employees along with their address. Use inner join with ON clause.
SELECT e.FirstName
	,e.LastName
	,a.AddressText
FROM Employees e
INNER JOIN Addresses a ON a.AddressID = e.AddressID