USE [StatementsControl]
GO

CREATE TRIGGER tr_EnvironmentDelete ON [Environments] 
INSTEAD OF DELETE AS
	BEGIN
		DECLARE @environmentId INT = (SELECT [id] from deleted)
		DELETE FROM [Statements] WHERE [environmentId] = @environmentId
		DELETE FROM [Environments] WHERE [id] = @environmentId
	END