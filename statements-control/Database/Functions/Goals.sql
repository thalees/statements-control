USE [StatementsControl]
GO


-- Functions About Goals
CREATE FUNCTION fn_ListAllGoals (
	@userId INT
) RETURNS TABLE
AS 
	RETURN ( 
		SELECT [goals].[id], [goals].[name], [goals].[endDate]
		FROM [Goals] [goals] WHERE [goals].[userId] = @userId
	)
GO

CREATE FUNCTION fn_FilterGoalsByName(
	@name VARCHAR(20)
) RETURNS TABLE
AS 
	RETURN (
		SELECT * FROM [Goals] WHERE LOWER([name]) LIKE '%'+ LOWER(@name) + '%'
	)
GO

CREATE FUNCTION fn_FilterGoalsByDate(
	@endDate SMALLDATETIME
) RETURNS TABLE
AS
	RETURN (
		SELECT * FROM [Goals] [goals] 
		WHERE [goals].[endDate] >= @endDate
	)
GO

CREATE FUNCTION fn_FilterGoalsByValue(
	@minValue DECIMAL(18, 2),
	@maxValue DECIMAL(18, 2)
) RETURNS TABLE
AS 
	RETURN (
		SELECT * FROM [Goals] [goals] 
		WHERE [goals].[value] BETWEEN @minValue AND @maxValue
	)
GO
