--Write a SQL query to find the number of all employees that have manager.
SELECT count(*)
FROM Employees
WHERE ManagerID IS NOT NULL

-- OR

SELECT count(ManagerID)
FROM Employees