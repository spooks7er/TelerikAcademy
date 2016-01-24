--Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
UPDATE Users
SET [Password] = NULL
WHERE DATEDIFF(DAY, LastLogInTime, '2010-3-10 00:00:00') > 0