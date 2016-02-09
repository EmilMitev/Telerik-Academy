USE TelerikAcademy

UPDATE Users
SET Password = 'NULL'
WHERE LoginTime < CONVERT(DATETIME, '2010-03-10')