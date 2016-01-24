--Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE
FROM Users
WHERE UserID = 2

DELETE
FROM Groups
WHERE NAME = 'Some Group That Is Going To Be Deleted'