USE [StatementsControl]
GO


-- Functions About Goals
CREATE FUNCTION fn_ListAllGoals (
	@userId INT
) 
AS
BEGIN
	SELECT [goals].[id], [goals].[name], [goals].[endDate]
	FROM [Goals] [goals] WHERE [goals].[userId] = @userId
END
GO

CREATE FUNCTION fn_FilterGoalsByName(
	@name VARCHAR(20)
)
AS
BEGIN
	DECLARE @nameLowercase VARCHAR(20) = LOWER(@name)
	SELECT * FROM [Goals] WHERE LOWER([name]) LIKE '%'+ @nameLowercase + '%'
END
GO

CREATE FUNCTION fn_FilterGoalsByDate(
	@endDate SMALLDATETIME
)
AS
BEGIN
	SELECT * FROM [Goals] [goals] 
	WHERE [goals].[endDate] >= @endDate
END
GO

CREATE FUNCTION fn_FilterGoalsByValue(
	@minValue DECIMAL(18, 2),
	@maxValue DECIMAL(18, 2)
)
BEGIN
	SELECT * FROM [Goals] [goals] 
	WHERE [goals].[value] BETWEEN @minValue AND @maxValue
END
GO

-- Calculate Age of User
CREATE FUNCTION fn_ ()
	SELECT * FROM Users
END
