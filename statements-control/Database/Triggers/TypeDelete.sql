USE [StatementsControl]
GO

CREATE TRIGGER tr_TypeDelete ON [Types] 
INSTEAD OF DELETE AS
	BEGIN
		DECLARE @typeId INT = (SELECT [id] from deleted)
		DELETE FROM [Statements] WHERE [typeId] = @typeId
		DELETE FROM [Types] WHERE [id] = @typeId
	END