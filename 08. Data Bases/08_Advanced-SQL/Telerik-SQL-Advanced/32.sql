--Find how to use temporary tables in SQL Server.
--Using temporary tables backup all records from EmployeesProjects and restore them
--back after dropping and re-creating the table.

BEGIN TRANSACTION

    SELECT * 
        INTO #TempEmployeesProjects  --- Create new table
        FROM EmployeesProjects

    DROP TABLE EmployeesProjects

    SELECT * 
        INTO EmployeesProjects --- Create new table
        FROM #TempEmployeesProjects

    DROP TABLE #TempEmployeesProjects

ROLLBACK TRANSACTION