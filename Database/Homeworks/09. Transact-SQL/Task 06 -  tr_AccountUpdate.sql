USE PersonalAccount
GO

CREATE TRIGGER tr_AccountUpdate 
ON Accounts
FOR UPDATE
AS
INSERT INTO Logs  
SELECT
i.Id,
d.Balance,
i.Balance
FROM INSERTED i, DELETED d
GO