﻿CREATE TABLE users
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [email] VARCHAR(50) NOT NULL, 
    [name] VARCHAR(100) NOT NULL, 
    [icNo] VARCHAR(50) NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [role] VARCHAR(50) NULL
)
