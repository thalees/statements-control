CREATE PROCEDURE usp_InsertEnvironment(
	@name VARCHAR(50), 
    @description VARCHAR(100)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO [Environments] ([name], [description])
			VALUES (@name, @description)
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_UpdateEnvironment(
    @id INT,
	@name VARCHAR(50), 
    @description VARCHAR(100)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [Environments] SET
				[name] = @name, 
				[description] = @description
			WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_DeleteEnvironment (@id INT) AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE [Environments] WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_ListAllEnvironments (
	@userId INT
) 
AS
BEGIN
	SELECT [environments].[id], [environments].[name], [environments].[description] 
	FROM Statements statements
	INNER JOIN [Environments] [environments] ON [environments].id = statements.environmentId
	WHERE statements.userId = @userId
END
GO

CREATE PROCEDURE usp_FilterEnvironmentsByName(
	@name VARCHAR(20)
)
AS
BEGIN
	DECLARE @nameLowercase VARCHAR(20) = LOWER(@name)
	SELECT * FROM [Environments] WHERE LOWER([name]) LIKE '%'+ @nameLowercase + '%'
END
GO

CREATE PROCEDURE usp_FirstEnvironment AS
BEGIN
	SELECT TOP 1 * FROM [Environments] [environment] order by environment.id
END
GO

CREATE PROCEDURE usp_LastEnvironment AS
BEGIN
	SELECT TOP 1 * FROM [Environments] [environment] order by environment.id DESC
END
GO

CREATE PROCEDURE usp_NextEnvironment (
	@currentId INT
)
AS
BEGIN
	SELECT TOP 1 * FROM [Environments] [environment] WHERE [environment].id > @currentId 
	order by environment.id
END
GO

CREATE PROCEDURE usp_PreviousEnvironment (
	@currentId INT
)
AS
BEGIN
	SELECT TOP 1 * FROM [Environments] [environment] WHERE [environment].id < @currentId 
	order by environment.id DESC
END
GO