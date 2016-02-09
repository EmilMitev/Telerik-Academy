USE TelerikAcademy

UPDATE Users
SET FullName = 'Warren Buffett'
WHERE UserId = 1;

UPDATE Groups
SET Name = 'Professional Gaming'
WHERE Name LIKE '%Gaming';