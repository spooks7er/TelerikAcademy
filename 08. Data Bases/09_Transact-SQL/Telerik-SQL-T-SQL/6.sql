--CREATE TABLE Logs (
--    Id int IDENTITY PRIMARY KEY,
--    AccountId int NOT NULL FOREIGN KEY REFERENCES Accounts(Id),
--    OldSum money NOT NULL,
--    NewSum money NOT NULL
--)

ALTER TRIGGER tr_UpdateAccountBalance ON Accounts FOR UPDATE
AS
    DECLARE @oldSum money;
    SELECT @oldSum = Balance FROM deleted;

    INSERT INTO Logs(AccountId, OldSum, NewSum)
        SELECT Id, @oldSum, Balance
        FROM inserted
GO

EXEC usp_WithdrawMoney 4, 1000

EXEC usp_DepositMoney 1, 2000