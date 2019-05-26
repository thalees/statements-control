
CREATE PROCEDURE usp_InsertInvestment(
    @userId INT,
    @name VARCHAR(20), 
    @value DECIMAL(18, 2), 
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
    @value DECIMAL(18, 2), 
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


CREATE PROCEDURE usp_ListAllInvestments (
	@userId INT
) 
AS
BEGIN
	SELECT [investments].[id], [investments].[value], [investments].[startDate], [investments].[endDate]
	FROM [Investments] [investments] WHERE [investments].[userId] = @userId
END
GO

CREATE PROCEDURE usp_FilterInvestmentsByName(
	@name VARCHAR(20)
)
AS
BEGIN
	DECLARE @nameLowercase VARCHAR(20) = LOWER(@name)
	SELECT * FROM [Investments] WHERE LOWER([name]) LIKE '%'+ @nameLowercase + '%'
END
GO

CREATE PROCEDURE usp_FilterInvestmentsByDate(
	@startDate SMALLDATETIME,
	@endDate SMALLDATETIME
)
AS
BEGIN
	SELECT * FROM [Investments] [investments] 
	WHERE [investments].[startDate] BETWEEN @startDate AND @endDate
END
GO

CREATE PROCEDURE usp_FilterInvestmentsByValue(
	@minValue DECIMAL(18, 2),
	@maxValue DECIMAL(18, 2)
)
AS
BEGIN
	SELECT * FROM [Investments] [investments] 
	WHERE [investments].[value] BETWEEN @minValue AND @maxValue
END
GO