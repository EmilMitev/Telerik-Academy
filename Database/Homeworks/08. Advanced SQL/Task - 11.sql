USE TelerikAcademy

SELECT e.EmployeeID AS ManagerID,
	   e.FirstName + ' ' + e.LastName AS ManagerName,
	   COUNT(e.EmployeeID) AS EmployeesCount
FROM Employees e
	JOIN Employees emp
		ON emp.ManagerID = e.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(e.EmployeeID) = 5
    