USE [StatementsControl]
GO

CREATE PROCEDURE usp_ChangeAllTypeName (
	@userId INT,
	@name VARCHAR(20)
)
AS
BEGIN
	IF (@name IS NULL)
		RAISERROR('Por favor, digite um nome válido.', 16, 1)
	ELSE	
	BEGIN
		DECLARE @typeId INT
		DECLARE @typeDescription VARCHAR(100)
		DECLARE @typeAction VARCHAR(10)

		DECLARE cr_UpdateTypeNameToStatements CURSOR FOR 
		SELECT [types].[id], [types].[description], [types].[action] FROM [Statements] [statements]
		INNER JOIN [Types] [types] ON [types].[id] = [statements].[typeId]
		WHERE [statements].[userId] = @userId

		OPEN cr_UpdateTypeNameToStatements

		FETCH NEXT FROM cr_UpdateTypeNameToStatements INTO @typeId, @typeDescription, @typeAction

		WHILE @@FETCH_STATUS = 0
		BEGIN
			EXEC usp_UpdateType @typeId, @name, @typeDescription, @typeAction

			FETCH NEXT FROM cr_UpdateTypeNameToStatements INTO @typeId, @typeDescription, @typeAction
		END

		CLOSE cr_UpdateTypeNameToStatements 

		DEALLOCATE cr_UpdateTypeNameToStatements
	END
END
GO