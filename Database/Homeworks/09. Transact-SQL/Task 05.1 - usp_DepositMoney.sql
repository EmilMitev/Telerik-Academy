USE PersonalAccount
GO

CREATE PROC dbo.usp_DepositMoney(@accountId int, @sumToDeposit money)
AS
DECLARE @currentBalance money = (SELECT Balance FROM Accounts WHERE Id = @accountId)

UPDATE Accounts
SET Balance = @currentBalance + @sumToDeposit
WHERE Id = @accountId

GO

--EXEC usp_DepositMoney 1,323

