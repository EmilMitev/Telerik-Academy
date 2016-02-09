USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, 
		em.FirstName + ' ' + em.LastName AS ManagerName
FROM Employees e
	INNER JOIN Employees em
		ON e.ManagerID = em.EmployeeID
