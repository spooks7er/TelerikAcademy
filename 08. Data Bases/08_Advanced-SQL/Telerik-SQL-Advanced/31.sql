--Start a database transaction and drop the table EmployeesProjects.
--Now how you could restore back the lost table data?

BEGIN TRANSACTION

    DROP TABLE EmployeesProjects

ROLLBACK TRANSACTION