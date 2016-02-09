USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS EmployeeName,
		em.FirstName + ' ' + em.LastName AS ManagerName, 
		a.AddressText AS EmployeeAdress
FROM Employees e
	INNER JOIN Employees em
		ON e.ManagerID = em.EmployeeID
			INNER JOIN Addresses a
				ON e.AddressID = a.AddressID