USE TelerikAcademy

SELECT e.FirstName, ' ', e.LastName AS FullName, 
		e.Salary AS EmployeeSalary, 
		d.Name AS DepartmentName
FROM Employees e 
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE Salary = (
		SELECT MIN(Salary) FROM Employees emp
		WHERE emp.DepartmentID = d.DepartmentID
)
ORDER BY Salary