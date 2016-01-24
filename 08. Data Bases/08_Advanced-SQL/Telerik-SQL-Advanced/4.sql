--Write a SQL query to find the average salary in the department #1.
SELECT round(avg(Salary), 2) as 'Average Salary'
FROM Employees
WHERE DepartmentID = 1