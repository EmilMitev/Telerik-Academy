USE TelerikAcademy

SELECT MIN(e.Salary) AS MinimalSalary, d.Name AS Department, e.JobTitle
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle