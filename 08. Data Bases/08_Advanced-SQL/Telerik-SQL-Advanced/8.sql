--Write a SQL query to find the number of all employees that have no manager.
SELECT count(*)
FROM Employees
WHERE ManagerID IS NULL