ALTER FUNCTION dbo.ufn_CalculateCompoundInerest (
	@sum MONEY
	,@yearlyRate FLOAT
	,@periods TINYINT
	,@years TINYINT
	)
RETURNS MONEY
AS
BEGIN
	RETURN @sum * POWER((1 + @yearlyRate / @periods), @periods * @years)
END
GO

SELECT Balance
	,Round(dbo.ufn_CalculateCompoundInerest(Balance, 0.07, 12, 3), 2) AS [Interest]
FROM Accounts