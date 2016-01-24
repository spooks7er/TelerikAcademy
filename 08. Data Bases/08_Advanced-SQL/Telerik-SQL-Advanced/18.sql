--Write a SQL statement to add a column GroupID to the table Users.
--Fill some data in this new column and as well in the `Groups table.
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
ALTER TABLE Users ADD GroupID INT NOT NULL
GO

--INSERT INTO Groups
--VALUES ( 'Bomb Squad' )

--INSERT INTO Users
--VALUES ( 'Pesho', 'parola', 'Pesho Petrov', GETDATE(), 1 )

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY (GroupID)
REFERENCES Groups (GroupID)
