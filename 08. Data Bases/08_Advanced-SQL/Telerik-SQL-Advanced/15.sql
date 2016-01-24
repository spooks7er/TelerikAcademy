--Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
--Choose appropriate data types for the table fields. 
--Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames.
--Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users (
	UserID INT identity PRIMARY KEY
	,UserName NVARCHAR(50) NOT NULL UNIQUE
	,[Password] NVARCHAR(50) NOT NULL CHECK (len([Password]) > 5)
	,FullName NVARCHAR(100) NOT NULL
	,LastLogInTime DATETIME NOT NULL
	)