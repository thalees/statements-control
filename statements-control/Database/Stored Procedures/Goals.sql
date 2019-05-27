
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
			INSERT INTO Goals (userId, [name], [value], endDate)
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
				endDate = @endDate
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

CREATE PROCEDURE usp_FirstGoal AS
BEGIN
	SELECT TOP 1 * FROM [Goals] [goal] order by [goal].id
END
GO

CREATE PROCEDURE usp_LastGoal AS
BEGIN
	SELECT TOP 1 * FROM [Goals] [goal] order by [goal].id DESC
END
GO

CREATE PROCEDURE usp_NextGoal (
	@currentId INT
)
AS
BEGIN
	SELECT TOP 1 * FROM [Goals] [goal] WHERE [goal].id > @currentId 
	order by [goal].id
END
GO

CREATE PROCEDURE usp_PreviousGoal (
	@currentId INT
)
AS
BEGIN
	SELECT TOP 1 * FROM [Goals] [goal] WHERE [goal].id < @currentId 
	order by [goal].id DESC
END
GO