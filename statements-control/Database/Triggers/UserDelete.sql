USE [StatementsControl]
GO

CREATE TRIGGER tr_UserDelete ON [Users] 
INSTEAD OF DELETE AS
	BEGIN
		DECLARE @userId INT = (SELECT [id] from deleted)
		DELETE FROM [Investments] WHERE [userId] = @userId
		DELETE FROM [Goals] WHERE [userId] = @userId
		DELETE FROM [Statements] WHERE [userId] = @userId
		DELETE FROM [Users] WHERE [id] = @userId
	END