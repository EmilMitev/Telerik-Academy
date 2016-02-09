USE PersonalAccount
GO

CREATE PROC dbo.usp_PersonsWithMoreMoneyThanParameter(@amoutToCheck int)
AS
SELECT p.FirstName, p.LastName, a.Balance
FROM Persons p
	JOIN Accounts a
	ON p.Id = a.PersonId
	WHERE Balance > @amoutToCheck

GO

--EXEC dbo.usp_PersonsWithMoreMoneyThanParameter 1000