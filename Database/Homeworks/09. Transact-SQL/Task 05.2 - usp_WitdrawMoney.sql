USE PersonalAccount
GO

CREATE PROC dbo.usp_WitdrawMoney(@accountId int, @sumToWitdraw money)
AS
DECLARE @currentBalance money = (SELECT Balance FROM Accounts WHERE Id = @accountId)

IF(@currentBalance > @sumToWitdraw)
BEGIN
UPDATE Accounts
SET Balance = @currentBalance - @sumToWitdraw
WHERE Id = @accountId
END
ELSE
BEGIN
PRINT 'Insufficient balance!'
END
GO

--EXEC usp_WitdrawMoney 4,25