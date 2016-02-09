USE TelerikAcademy

DECLARE @MinSalary int = (SELECT MIN(Salary) FROM Employees)
SELECT FirstName, LastName, Salary
	FROM Employees
	WHERE Salary BETWEEN @MinSalary AND 1.1 * @MinSalary
	ORDER BY Salary