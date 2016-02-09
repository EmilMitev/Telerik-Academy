USE TelerikAcademy

SELECT COUNT(*) AS EmployeeWithManager
FROM Employees
WHERE ManagerID IS NOT NULL