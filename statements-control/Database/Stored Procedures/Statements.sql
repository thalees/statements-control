

-- Insert
CREATE PROCEDURE usp_InsertStatement(
	@userId INT,
	@typeId INT,
	@environmentId INT,
	@name VARCHAR(50),
	@value DECIMAL,
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
	@value DECIMAL,
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