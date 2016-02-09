USE PersonalAccount
GO

CREATE FUNCTION ufn_CalculateInterest(@sum money, @interestRate decimal, @numberOfMonth int)
		RETURNS money
AS
BEGIN
	RETURN @sum + (@sum + (@interestRate/12/100) * @numberOfMonth)
END
GO

--SELECT Balance, dbo.ufn_CalculateInterest(Balance, 10.8, 12) AS [Current Balance]
--FROM Accounts