CREATE PROCEDURE spInsertBooking
@userid int,
@bookingid char(10),
@bookingdate datetime,
@indexorigin int,
@indexdestination int,
@indexcategory int,
@indextrip int,
@quantity int,
@totalprice float
AS 
INSERT INTO booking VALUES
(
@userid,
@bookingid ,
@bookingdate ,
@indexorigin ,
@indexdestination ,
@indexcategory ,
@indextrip,
@quantity,
@totalpric
);