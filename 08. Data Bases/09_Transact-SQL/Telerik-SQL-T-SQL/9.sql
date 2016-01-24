DECLARE CURSR CURSOR READ_ONLY FOR
    SELECT t.Name, CONCAT(CHAR(9), e.FirstName, ' ', e.LastName)
    FROM Towns t
    JOIN Addresses a
        ON t.TownID = a.TownID
    JOIN Employees e
        ON a.AddressID = e.AddressID
    GROUP BY t.Name, e.FirstName, e.LastName
    ORDER BY t.Name

DECLARE @townName nvarchar(50), 
        @empName nvarchar(100),
		@empNames nvarchar(max),
		@currentTown nvarchar(50)

		SET @empNames = ''

OPEN CURSR    
	FETCH NEXT FROM CURSR 
	INTO @townName, @empName

	SET @empNames += @empName
	SET @currentTown = @townName

WHILE @@FETCH_STATUS = 0
BEGIN
    FETCH NEXT FROM CURSR 
    INTO @townName, @empName
	
	IF @@FETCH_STATUS < 0
	BEGIN
		SET @townName = null
	END

	IF @currentTown = @townName
	BEGIN
		SET @empNames += (', ' + CHAR(13) + CHAR(10))
	END
	ELSE
	BEGIN
		PRINT CONCAT(@currentTown, ' -> ', CHAR(13), CHAR(10), @empNames)
		SET @currentTown = @townName
		SET @empNames = ''
	END
	SET @empNames += @empName
END

CLOSE CURSR
DEALLOCATE CURSR
GO