USE [StatementsControl]
GO

-- Insert
CREATE PROCEDURE usp_InsertUser (
    @name VARCHAR(20), 
    @picture VARCHAR(MAX), 
    @dateBirth SMALLDATETIME,
	@password VARCHAR(20)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION  
			INSERT INTO Users ([name], picture, dateBirth, passwordHash)
			VALUES (@name, @picture, @dateBirth, HASHBYTES('SHA2_512', @password))
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_UpdateUser(
	@id INT,
    @name VARCHAR(20), 
    @picture VARCHAR(MAX), 
    @dateBirth SMALLDATETIME,
	@password VARCHAR(20)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Users SET
				[name] = @name, 
				picture = @picture, 
				dateBirth = @dateBirth, 
				[passwordHash] = HASHBYTES('SHA2_512', @password)
			WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_DeleteUser (@id INT) AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE Users WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_FilterUsersByName(
	@name VARCHAR(20)
)
AS
BEGIN
	DECLARE @nameLowercase VARCHAR(20) = LOWER(@name)
	SELECT * FROM [Users] WHERE LOWER([name]) LIKE '%'+ @nameLowercase + '%'
END
GO