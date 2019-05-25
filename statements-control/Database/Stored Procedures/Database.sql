CREATE PROCEDURE usp_CreateDatabase (
	@databaseName VARCHAR(20)
)
AS
BEGIN
	DECLARE @SQL_script VARCHAR(35) = 'CREATE DATABASE ' + @databaseName
	EXEC (@SQL_script)
END
   