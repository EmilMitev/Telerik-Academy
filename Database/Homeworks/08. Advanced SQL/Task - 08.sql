USE TelerikAcademy

SELECT COUNT(*) AS EmployeeWithOutManeger
FROM Employees
WHERE ManagerID IS NULL