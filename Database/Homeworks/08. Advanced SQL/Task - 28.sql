USE TelerikAcademy

SELECT t.Name AS Town, COUNT(DISTINCT e.ManagerID) AS NumberOfManagers
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.ManagerID
	JOIN Addresses a
		ON m.AddressID = a.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY t.Name