USE TelerikAcademy
GO
CREATE FUNCTION ufn_CheckName (@nameToCheck NVARCHAR(50),@letters NVARCHAR(50)) RETURNS INT
AS
BEGIN
        DECLARE @i INT = 1
		DECLARE @currentChar NVARCHAR(1)
        WHILE (@i <= LEN(@nameToCheck))
			BEGIN
				SET @currentChar = SUBSTRING(@nameToCheck,@i,1)
					IF (CHARINDEX(LOWER(@currentChar),LOWER(@letters)) <= 0) 
						BEGIN  
							RETURN 0
						END
				SET @i = @i + 1
			END
        RETURN 1
END
GO


--WITH WHERE AS TABLE
SELECT e.FirstName, e.LastName,t.Name FROM Employees e
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON a.TownID=t.TownID
WHERE 
dbo.ufn_CheckName(e.FirstName,'oistmiahf') = 1 OR 
dbo.ufn_CheckName(e.LastName,'oistmiahf') = 1 OR
dbo.ufn_CheckName(t.Name,'oistmiahf') = 1

--WITH CURSOR AS PRINT
DECLARE employeeTownCursor CURSOR READ_ONLY FOR
  (SELECT e.FirstName, e.LastName, t.Name FROM Employees e
  JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID=t.TownID)

OPEN employeeTownCursor
DECLARE @firstName NVARCHAR(50), @lastName NVARCHAR(50), @town NVARCHAR(50)
DECLARE @searchString NVARCHAR(50) ='oistmiahf'
FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName, @town

WHILE @@FETCH_STATUS = 0
  BEGIN
    IF(dbo.ufn_CheckName(@firstName,@searchString)=1)
		BEGIN
			PRINT 'First name: ' + @firstName
		END
	IF(dbo.ufn_CheckName(@lastName,@searchString)=1)
		BEGIN
			PRINT 'Last name: ' + @lastName
		END
	IF(dbo.ufn_CheckName(@town,@searchString)=1)
		BEGIN
			PRINT 'Town: ' + @town
		END
	FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName, @town
  END

CLOSE employeeTownCursor
DEALLOCATE employeeTownCursor