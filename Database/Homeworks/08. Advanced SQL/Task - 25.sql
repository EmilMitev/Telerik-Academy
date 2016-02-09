USE TelerikAcademy

SELECT AVG(e.Salary) AS AverageSalary, d.Name AS Department, e.JobTitle
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle