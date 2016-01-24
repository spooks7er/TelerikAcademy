ALTER FUNCTION dbo.ufn_CalculateSimpleInerest (
	@sum MONEY
	,@yearlyRate FLOAT
	,@months TINYINT
	)
RETURNS MONEY
AS
BEGIN
	RETURN @sum * ((1 + (@yearlyRate / 12) * @months))
END
GO

ALTER PROC usp_CalculateInterestFor1Month (
	@accountId INT
	,@interesRate FLOAT
	)
AS
SELECT p.FirstName
	,p.LastName
	,a.Balance
	,Round(dbo.ufn_CalculateSimpleInerest(Balance, 0.07, 1), 2) AS [Interest]
FROM Persons p
JOIN Accounts a ON p.id = a.PersonnId
WHERE a.Id = @accountId
ORDER BY a.Balance
GO

EXEC usp_CalculateInterestFor1Month 2
	,0.07