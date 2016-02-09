USE TelerikAcademy

CREATE TABLE Users (
    UserId int IDENTITY PRIMARY KEY,
    Username nvarchar(50) NOT NULL CHECK (LEN(Username) > 3) UNIQUE,
    Pass nvarchar(256) NOT NULL CHECK (LEN(Pass) > 5),
    FullName nvarchar(50) NOT NULL CHECK (LEN(FullName) > 5),
    LastLoginTime DATETIME NOT NULL,
) 
GO