USE [StatementsControl]
GO

-- Insert
CREATE PROCEDURE usp_InsertStatement(
	@userId INT,
	@typeId INT,
	@environmentId INT,
	@name VARCHAR(50),
	@value DECIMAL(18, 2),
	@date SMALLDATETIME
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO [Statements] ([userId], [typeId], [environmentId], [name], [value], [date])
			VALUES (@userId, @typeId, @environmentId, @name, @value, @date)
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_UpdateStatement(
    @id INT,
	@userId INT,
	@typeId INT,
	@environmentId INT,
	@name VARCHAR(50),
	@value DECIMAL(18, 2),
	@date SMALLDATETIME
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [Statements] SET
				[userId] = @userId,
				[typeId] = @typeId,
				[environmentId] = @environmentId,
				[name] = @name,
				[value] = @value, 
				[date] = @date
			WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_DeleteStatement (@id INT) AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE [Statements] WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

--------------------------------------------------------------------

CREATE PROCEDURE usp_ListAllStatements (
	@userId INT
)
AS
BEGIN
	SELECT [statements].[id], [statements].[name], [statements].[date], [statements].[value]
	FROM [Statements] [statements] WHERE [statements].userId = @userId
END
GO

CREATE PROCEDURE usp_FilterStatementsByName(
	@name VARCHAR(20)
)
AS
BEGIN
	DECLARE @nameLowercase VARCHAR(20) = LOWER(@name)
	SELECT * FROM [Statements] WHERE LOWER([name]) LIKE '%'+ @nameLowercase + '%'
END
GO

CREATE PROCEDURE usp_FilterStatementsByEnvironment(
	@environmentId INT
)
AS
BEGIN
	SELECT SUM([statements].[value]) total FROM [Statements] [statements] WHERE [statements].environmentId = @environmentId
END
GO

CREATE PROCEDURE usp_FilterStatementsByType(
	@typeId INT
)
AS
BEGIN
	SELECT SUM([statements].[value]) total FROM [Statements] [statements] WHERE [statements].typeId = @typeId
END
GO

CREATE PROCEDURE usp_FilterStatementsByDate(
	@startDate SMALLDATETIME,
	@endDate SMALLDATETIME
)
AS
BEGIN
	SELECT * FROM [Statements] [statements] 
	WHERE [statements].[date] BETWEEN @startDate AND @endDate
END
GO