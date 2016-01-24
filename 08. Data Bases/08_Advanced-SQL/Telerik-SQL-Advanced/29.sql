--Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
--Don't forget to define identity, primary key and appropriate foreign key.
--Issue few SQL statements to insert, update and delete of some data in the table.
--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
--For each change keep the old record data, the new record data and the command (insert / update / delete).
--- TABLE: WorkHours
CREATE TABLE WorkHours (
	WorkReportId INT IDENTITY
	,EmployeeId INT NOT NULL
	,OnDate DATETIME NOT NULL
	,Task NVARCHAR(256) NOT NULL
	,Hours INT NOT NULL
	,Comments NVARCHAR(256)
	,CONSTRAINT PK_Id PRIMARY KEY (WorkReportId)
	,CONSTRAINT FK_Employees_WorkHours FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId)
	)
GO

--- INSERT
DECLARE @counter INT;

SET @counter = 20;

WHILE @counter > 0
BEGIN
	INSERT INTO WorkHours (
		EmployeeId
		,OnDate
		,Task
		,[Hours]
		)
	VALUES (
		@counter
		,GETDATE()
		,'TASK: ' + CONVERT(VARCHAR(10), @counter)
		,@counter
		)

	SET @counter = @counter - 1
END

--- UPDATE
UPDATE WorkHours
SET Comments = 'Time for work ;P'
WHERE [Hours] > 10

--- DELETE
DELETE
FROM WorkHours
WHERE EmployeeId IN (
		1
		,3
		,5
		,7
		,13
		)

--- TABLE: WorkHoursLogs
CREATE TABLE WorkHoursLogs (
	WorkLogId INT
	,EmployeeId INT NOT NULL
	,OnDate DATETIME NOT NULL
	,Task NVARCHAR(256) NOT NULL
	,Hours INT NOT NULL
	,Comments NVARCHAR(256)
	,[Action] NVARCHAR(50) NOT NULL
	,CONSTRAINT FK_Employees_WorkHoursLogs FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId)
	,CONSTRAINT [CC_WorkReportsLogs] CHECK (
		[Action] IN (
			'Insert'
			,'Delete'
			,'DeleteUpdate'
			,'InsertUpdate'
			)
		)
	)
GO

--- TRIGGER FOR INSERT
CREATE TRIGGER tr_InsertWorkReports ON WorkHours
FOR INSERT
AS
INSERT INTO WorkHoursLogs (
	WorkLogId
	,EmployeeId
	,OnDate
	,Task
	,[Hours]
	,Comments
	,[Action]
	)
SELECT WorkReportId
	,EmployeeID
	,OnDate
	,Task
	,[Hours]
	,Comments
	,'Insert'
FROM inserted
GO

--- TRIGGER FOR DELETE
CREATE TRIGGER tr_DeleteWorkReports ON WorkHours
FOR DELETE
AS
INSERT INTO WorkHoursLogs (
	WorkLogId
	,EmployeeId
	,OnDate
	,Task
	,[Hours]
	,Comments
	,[Action]
	)
SELECT WorkReportId
	,EmployeeID
	,OnDate
	,Task
	,[Hours]
	,Comments
	,'Delete'
FROM deleted
GO

--- TRIGGER FOR UPDATE
CREATE TRIGGER tr_UpdateWorkReports ON WorkHours
FOR UPDATE
AS
INSERT INTO WorkHoursLogs (
	WorkLogId
	,EmployeeId
	,OnDate
	,Task
	,[Hours]
	,Comments
	,[Action]
	)
SELECT WorkReportId
	,EmployeeID
	,OnDate
	,Task
	,[Hours]
	,Comments
	,'InsertUpdate'
FROM inserted

INSERT INTO WorkHoursLogs (
	WorkLogId
	,EmployeeId
	,OnDate
	,Task
	,[Hours]
	,Comments
	,[Action]
	)
SELECT WorkReportId
	,EmployeeID
	,OnDate
	,Task
	,[Hours]
	,Comments
	,'DeleteUpdate'
FROM deleted
GO

--- TEST TRIGGERS
DELETE
FROM WorkHoursLogs

INSERT INTO WorkHours (
	EmployeeId
	,OnDate
	,Task
	,[Hours]
	)
VALUES (
	25
	,GETDATE()
	,'TASK: 25'
	,25
	)

DELETE
FROM WorkHours
WHERE EmployeeId = 25

UPDATE WorkHours
SET Comments = 'Updated'
WHERE EmployeeId = 2