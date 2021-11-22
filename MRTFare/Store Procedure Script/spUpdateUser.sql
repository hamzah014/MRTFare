CREATE PROCEDURE spUpdateUser
@id int,
@email varchar(50),
@name varchar(100),
@icno varchar(50),
@password varchar(100)
AS 
UPDATE users
SET email=@email, name=@name, icNo=@icno, password=@password
WHERE Id=@id;