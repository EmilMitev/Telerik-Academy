USE TelerikAcademy

SELECT COUNT(e.EmployeeID) AS EmployeesCount, 
		t.Name AS Town, 
		d.Name AS Department
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
		JOIN Addresses a
			ON e.AddressID = a.AddressID
			JOIN Towns t
				ON a.TownID = t.TownID
GROUP BY d.Name, t.Name
ORDER BY d.Name