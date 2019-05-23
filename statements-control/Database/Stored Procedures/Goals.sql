USE [StatementsControl]
GO

-- Insert
CREATE PROCEDURE usp_InsertGoal(
    @userId INT,
    @name VARCHAR(20), 
    @value DECIMAL(18, 2),
    @endDate SMALLDATETIME
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO Goals (userId, [name], [value], [endDate])
			VALUES (@userId, @name, @value, @endDate)
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_UpdateGoal(
	@id INT,
    @userId INT,
    @name VARCHAR(20), 
    @value DECIMAL(18, 2), 
    @endDate SMALLDATETIME
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Goals SET
				userId = @userId, 
				[name] = @name, 
				[value] = @value, 
				[endDate] = @endDate
			WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_DeleteGoal (@id INT) AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE Goals WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_ListAllGoals (
	@userId INT
) 
AS
BEGIN
	SELECT [goals].[id], [goals].[name], [goals].[endDate]
	FROM [Goals] [goals] WHERE [goals].[userId] = @userId
END
GO

CREATE PROCEDURE usp_FilterGoalsByName(
	@name VARCHAR(20)
)
AS
BEGIN
	DECLARE @nameLowercase VARCHAR(20) = LOWER(@name)
	SELECT * FROM [Goals] WHERE LOWER([name]) LIKE '%'+ @nameLowercase + '%'
END
GO

CREATE PROCEDURE usp_FilterGoalsByDate(
	@endDate SMALLDATETIME
)
AS
BEGIN
	SELECT * FROM [Goals] [goals] 
	WHERE [goals].[endDate] >= @endDate
END
GO

CREATE PROCEDURE usp_FilterGoalsByValue(
	@minValue DECIMAL(18, 2),
	@maxValue DECIMAL(18, 2)
)
AS
BEGIN
	SELECT * FROM [Goals] [goals] 
	WHERE [goals].[value] BETWEEN @minValue AND @maxValue
END
GO