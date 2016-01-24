--Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Groups
VALUES ( 'Bomb Squad'                             )
,      ( 'Some Group That Is Going To Be Deleted' )
GO

INSERT INTO Users
VALUES ( 'Pesho', 'parola',  'Pesho Petrov', GETDATE(), 1 )
,      ( 'User1', 'parola1', 'User1 User1',  GETDATE(), 2 )
