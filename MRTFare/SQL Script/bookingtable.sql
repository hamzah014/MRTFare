CREATE TABLE booking
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [userId] INT NOT NULL, 
    [bookingId] CHAR(10) NOT NULL, 
    [bookingDate] DATETIME NULL, 
    [indexOrigin] BIGINT NULL, 
    [indexDestination] BIGINT NULL, 
    [indexCategory] BIGINT NULL, 
    [indexTrip] BIGINT NULL, 
    [quantity] BIGINT NULL, 
    [totalPrice] FLOAT NULL
)
