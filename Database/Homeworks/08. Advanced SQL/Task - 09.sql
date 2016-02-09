USE TelerikAcademy

SELECT AVG(Salary) AS AverageSalary,
		d.Name AS [DepartmentName]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
ORDER BY AverageSalary