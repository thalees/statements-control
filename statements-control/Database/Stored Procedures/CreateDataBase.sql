USE [master]
GO
CREATE DATABASE [StatementsControl]
GO
USE [StatementsControl]
GO

CREATE TABLE [dbo].[Investments] (
	 [id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	 [userId] INT NOT NULL,
	 [name] VARCHAR (20) NOT NULL,
	 [value] DECIMAL NOT NULL,
	 [startDate] SMALLDATETIME NOT NULL,
	 [endDate] SMALLDATETIME NOT NULL
)
GO

CREATE TABLE [dbo].[Goals] (
	 [id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	 [userId] INT NOT NULL,
	 [value] DECIMAL NOT NULL,
	 [name] VARCHAR (100) NOT NULL,
	 [endDate]	SMALLDATETIME NOT NULL
)
GO

CREATE TABLE [dbo].[Users] (
	 [id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	 [name] VARCHAR (100) NOT NULL,
	 [picture] VARCHAR(MAX) NULL,
	 [dateBirth] SMALLDATETIME NOT NULL,
	 [passwordHash] BINARY(64) NOT NULL
)
GO

CREATE TABLE [dbo].[Statements] (
	 [id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	 [userId] INT NOT NULL,
	 [typeId] INT NOT NULL,
	 [environmentId] INT NOT NULL,
	 [name] VARCHAR (50) NOT NULL,
	 [value] DECIMAL NOT NULL,
	 [date] SMALLDATETIME NOT NULL
)
GO

CREATE TABLE [dbo].[Types] (
	 [id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	 [name] VARCHAR (50) NOT NULL,
	 [description] VARCHAR (100) NULL,
	 [action] VARCHAR(10) NOT NULL,
)
GO

CREATE TABLE [dbo].[Environments] (
	 [id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	 [name] VARCHAR (50) NOT NULL,
	 [description] VARCHAR (100) NULL
)
GO

ALTER TABLE [Goals]
	ADD CONSTRAINT fk_goals_users
		FOREIGN KEY (userId)
		REFERENCES [Users](id)

ALTER TABLE [Investments]
	ADD CONSTRAINT fk_investments_users
		FOREIGN KEY (userId)
		REFERENCES [Users](id)

ALTER TABLE [Statements]
	ADD CONSTRAINT fk_statements_users
		FOREIGN KEY (userId)
		REFERENCES [Users](id),

		CONSTRAINT fk_statements_types
		FOREIGN KEY (typeId)
		REFERENCES [Types](id),

		CONSTRAINT fk_statements_environments
		FOREIGN KEY (environmentId)
		REFERENCES [Environments](id)