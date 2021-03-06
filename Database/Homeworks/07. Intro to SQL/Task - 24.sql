USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS FullName,
		d.Name AS DepartmentName,
		e.HireDate
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name = 'Finance')
		AND (e.HireDate BETWEEN '1995-01-01' AND '2005-12-31')