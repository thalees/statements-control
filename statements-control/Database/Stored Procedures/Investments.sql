

-- Insert
CREATE PROCEDURE usp_InsertInvestment(
    @userId INT,
    @name VARCHAR(20), 
    @value DECIMAL, 
    @startDate SMALLDATETIME,
	@endDate SMALLDATETIME
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO Investments (userId, [name], [value], startDate, endDate)
			VALUES (@userId, @name, @value, @startDate, @endDate)
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_UpdateInvestment(
	@id INT,
    @userId INT,
    @name VARCHAR(20), 
    @value DECIMAL, 
    @startDate SMALLDATETIME,
	@endDate SMALLDATETIME
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Investments SET
				userId = @userId, 
				[name] = @name, 
				[value] = @value, 
				startDate = @startDate, 
				endDate = @endDate
			WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

CREATE PROCEDURE usp_DeleteInvestment (@id INT) AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE Investments WHERE id = @id
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO