USE TelerikAcademy

INSERT INTO Users (Username, [Password], FullName, LoginTime)
VALUES('therock', '123455', 'Dwayne Johnoson', GETDATE()),
		('RKO master', '554321', 'Randy Brendy', GETDATE())

INSERT INTO Groups (Name)
VALUES ('Physics'),
		('Drawing')
