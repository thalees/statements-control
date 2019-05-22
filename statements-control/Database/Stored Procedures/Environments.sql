

-- Insert
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