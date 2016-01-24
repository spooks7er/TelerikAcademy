--Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
--Define primary key and identity column.
CREATE TABLE Groups (
	GroupID INT identity PRIMARY KEY
	,[Name] NVARCHAR(50) NOT NULL UNIQUE
	)