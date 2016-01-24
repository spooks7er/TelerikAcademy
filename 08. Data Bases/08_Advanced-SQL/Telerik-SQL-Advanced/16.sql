--Write a SQL statement to create a view that displays the users from the Users table
--that have been in the system today.
--Test if the view works correctly.
Create view [Users logged today] as
SELECT UserName
FROM Users
WHERE DATEDIFF(DAY, LastLogInTime, GETDATE()) = 0