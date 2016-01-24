DECLARE @count INT = 1

WHILE @count < 10000000
BEGIN
	INSERT INTO Test (
		[Text]
		,[Date]
		)
	VALUES (
		'Test_' + cast(@count AS NVARCHAR)
		,GETDATE()
		)

	SET @count += 1
END
GO