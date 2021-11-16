CREATE PROCEDURE spDeleteBooking
@id int
AS 
DELETE FROM booking
WHERE Id = @id;