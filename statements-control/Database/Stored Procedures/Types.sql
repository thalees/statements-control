

-- Insert
CREATE PROCEDURE usp_InsertType(
	@name VARCHAR(50), 
    @description VARCHAR(100),
    @action VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO [Types] ([name], [description], [action])
			VALUES (@name, @description, @action)
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_UpdateType(
    @id INT,
	@name VARCHAR(50), 
    @description VARCHAR(100),
    @action VARCHAR(10)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [Types] SET
				[name] = @name, 
				[description] = @description, 
				[action] = @action
			WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_DeleteType (@id INT) AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE [Types] WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

---------------------------------------

CREATE PROCEDURE usp_ListAllTypes (
	@userId INT
) 
AS
BEGIN
	SELECT [types].[id], [types].[name], [types].[description], [types].[action] 
	FROM Statements statements
	INNER JOIN [Types] [types] ON [types].id = statements.typeId
	WHERE statements.userId = @userId
END
GO

CREATE PROCEDURE usp_FilterTypesByName(
	@name VARCHAR(20)
)
AS
BEGIN
	DECLARE @nameLowercase VARCHAR(20) = LOWER(@name)
	SELECT * FROM [Types] WHERE LOWER([name]) LIKE '%'+ @nameLowercase + '%'
END
GO