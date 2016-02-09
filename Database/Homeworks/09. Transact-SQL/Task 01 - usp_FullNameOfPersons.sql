USE PersonalAccount
GO

CREATE PROC dbo.usp_FullNameOfPersons
AS
SELECT FirstName + ' ' + LastName AS [Full name]
FROM Persons

GO

--EXEC dbo.usp_FullNameOfPersons