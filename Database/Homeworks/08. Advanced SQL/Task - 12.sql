USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS EmployeeName,
	   COALESCE(emp.FirstName + ' '+ emp.LastName, 'no manager') AS ManagerName
FROM Employees e
	LEFT JOIN Employees emp
		ON e.ManagerID = emp.EmployeeID