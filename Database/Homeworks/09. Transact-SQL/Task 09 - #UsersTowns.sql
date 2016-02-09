USE TelerikAcademy
GO
CREATE TABLE #UsersTowns (ID INT IDENTITY, FullName NVARCHAR(50), TownName NVARCHAR(50))
INSERT INTO #UsersTowns
SELECT e.FirstName + ' ' + e.LastName, t.Name
                FROM Employees e
                        INNER JOIN Addresses a
                                ON a.AddressID = e.AddressID
                        INNER JOIN Towns t
                                ON t.TownID = a.TownID
                GROUP BY t.Name, e.FirstName, e.LastName
DECLARE @name NVARCHAR(50)
DECLARE @town NVARCHAR(50)
 
DECLARE employeeCursor CURSOR READ_ONLY FOR
        SELECT DISTINCT ut.TownName
                FROM #UsersTowns ut     
 
OPEN employeeCursor
FETCH NEXT FROM employeeCursor
	INTO @town
 
	WHILE @@FETCH_STATUS = 0
		BEGIN
			DECLARE @empName nvarchar(MAX);
			SET @empName = N'';
			SELECT @empName += ut.FullName + N', '
			FROM #UsersTowns ut
			WHERE ut.TownName = @town
			PRINT @town + ' -> ' + LEFT(@empName,LEN(@empName)-1);
			FETCH NEXT FROM employeeCursor INTO @town
		END
CLOSE employeeCursor
DEALLOCATE employeeCursor
DROP TABLE #UsersTowns