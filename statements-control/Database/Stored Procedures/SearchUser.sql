 CREATE PROCEDURE usp_ValidadeUser 
 ( 	
	@name VARCHAR(20), 	
	@password VARCHAR(MAX) 
 ) 
 AS 
BEGIN 	
	SELECT u.id, u.dateBirth, u.picture, u.[name]  
	FROM [Users] u
	WHERE u.name = @name and u.passwordHash = HASHBYTES('SHA2_512', @password)
END

