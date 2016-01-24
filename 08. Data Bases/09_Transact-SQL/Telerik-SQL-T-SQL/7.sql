USE TelerikAcademy
GO

CREATE FUNCTION ufn_SearchForWordsInGivenPattern(@pattern nvarchar(255))
	RETURNS @MatchedNames TABLE (Name varchar(50))
AS
BEGIN
	INSERT @MatchedNames
	SELECT * 
	FROM
		(SELECT e.FirstName FROM Employees e
        UNION
        SELECT e.LastName FROM Employees e
        UNION 
        SELECT t.Name FROM Towns t) as temp(name)
    WHERE PATINDEX('%[' + @pattern + ']', Name) > 0
	RETURN
END
GO

SELECT * FROM dbo.ufn_SearchForWordsInGivenPattern('oistmiahf')