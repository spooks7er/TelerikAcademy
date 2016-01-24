--Start a database transaction, delete all employees from the 'Sales' department along 
--with all dependent records from the pother tables.
--At the end rollback the transaction.
BEGIN TRAN

ALTER TABLE [dbo].[Departments] DROP CONSTRAINT [FK_Departments_Employees]
GO

DELETE
FROM Employees
WHERE DepartmentID = (
		SELECT DepartmentID
		FROM Departments
		WHERE NAME = 'Sales'
		)

ROLLBACK TRAN