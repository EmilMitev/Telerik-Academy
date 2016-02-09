DECLARE employeeTownCursor CURSOR READ_ONLY FOR
  (SELECT e.FirstName, e.LastName, t.Name FROM Employees e
	JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID=t.TownID)


OPEN employeeTownCursor
DECLARE @firstName NVARCHAR(50), @lastName NVARCHAR(50), @town NVARCHAR(50)

FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName,@town

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE employeeTownCursor1 CURSOR READ_ONLY FOR
		(SELECT e.FirstName, e.LastName, t.Name FROM Employees e
		JOIN Addresses a ON e.AddressID = a.AddressID
		JOIN Towns t ON a.TownID=t.TownID)
	OPEN employeeTownCursor1
		DECLARE @firstName1 NVARCHAR(50), @lastName1 NVARCHAR(50), @town1 NVARCHAR(50)
		FETCH NEXT FROM employeeTownCursor1 INTO @firstName1, @lastName1,@town1
			WHILE @@FETCH_STATUS = 0
			BEGIN
		
				IF(@town = @town1)
				BEGIN
					PRINT @lastname1 + ': ' + @firstname + ' ' +  @lastname + ' ' + @town + ' ' + @firstname1 
				END

			FETCH NEXT FROM employeeTownCursor1 INTO @firstName1, @lastName1,@town1
			END

	CLOSE employeeTownCursor1
	DEALLOCATE employeeTownCursor1

FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName,@town
END

CLOSE employeeTownCursor
DEALLOCATE employeeTownCursor
