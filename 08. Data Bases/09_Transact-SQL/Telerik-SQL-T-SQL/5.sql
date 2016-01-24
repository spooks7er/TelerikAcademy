ALTER PROC dbo.usp_WithdrawMoney (
	@accountId INT
	,@ammount MONEY
	)
AS
BEGIN TRAN
IF (SELECT Balance FROM Accounts WHERE Id = @accountId) < @ammount
	RAISERROR ('Not enough money in this account', 16 , 1)
ELSE
	BEGIN
		UPDATE Accounts
		SET Balance -= @ammount
		WHERE Id = @accountId
	END
COMMIT TRAN
GO

ALTER PROC dbo.usp_DepositMoney (
	@accountId INT
	,@ammount MONEY
	)
AS
BEGIN TRAN
	UPDATE Accounts
	SET Balance += @ammount
	WHERE Id = @accountId
COMMIT TRAN
GO

EXEC usp_WithdrawMoney 2
	,3000

EXEC usp_DepositMoney 2
	,3000

SELECT Balance
FROM Accounts
WHERE Id = 2