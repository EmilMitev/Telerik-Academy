USE PersonalAccount
GO

CREATE PROC dbo.usp_GiveInterestToPerson(@accountId int,@interestRate decimal)
AS

DECLARE @sum MONEY = (SELECT Balance FROM Accounts WHERE Id = @accountID)
UPDATE Accounts
SET Balance = (@sum+@sum*(@interestRate/100)/12)
WHERE Id = @accountID

GO


--EXEC usp_GiveInterestToPerson 2, 12