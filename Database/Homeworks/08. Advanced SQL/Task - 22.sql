USE TelerikAcademy

INSERT INTO Users (Username, [Password], FullName)
SELECT LOWER(LEFT(FirstName, 3) + LastName),
		LOWER(LEFT(FirstName, 3) + LastName),
		FirstName + ' ' + LastName
FROM Employees