CREATE PROCEDURE spInsertUser
@email varchar(50),
@name varchar(100),
@icno varchar(50),
@password varchar(50),
@role varchar(50)
AS 
INSERT INTO users VALUES
(
@email, @name, @icno, @password, @role
);