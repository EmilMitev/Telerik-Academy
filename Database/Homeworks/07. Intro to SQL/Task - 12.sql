USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS FullName
FROM Employees
WHERE FirstName LIKE '%ei%'