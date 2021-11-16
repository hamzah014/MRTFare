CREATE PROCEDURE spUpdateBooking
@id int,
@indexorigin int,
@indexdestination int,
@indexcategory int,
@indextrip int,
@quantity int,
@totalprice float
AS
UPDATE booking
SET 
	indexOrigin = @indexorigin,
	indexDestination = @indexdestination,
	indexCategory = @indexcategory,
	indexTrip = @indextrip,
	quantity = @quantity,
	totalPrice = @totalprice
WHERE
Id = @id;