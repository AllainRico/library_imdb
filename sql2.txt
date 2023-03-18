USE [libsysdb]
GO

UPDATE [dbo].[usersTable]
   SET [pass] = 'oten'
 WHERE [username] = 'allain'
GO


ALTER TABLE borrowersTable
DROP COLUMN bookID;
GO

Drop table borrowersTable
select * from usersTable
select * from borrowersTable


CREATE TABLE borrowersTable(
	borrowerID int IDENTITY(1111,1) PRIMARY KEY,
	userID int FOREIGN KEY REFERENCES usersTable(userID),
    FirstName varchar(255),
	LastName varchar(255),
    ContactNumber varchar(255),
	booksBorrowed smallint,
	booksreturned smallint
);

CREATE TABLE 

CREATE TABLE borrowTable(
	transactionNumber int IDENTITY(1111110,1) PRIMARY KEY,
	username nvarchar(255) FOREIGN KEY references usersTable(username),
	bookID smallint FOREIGN KEY references booksTable(bookID)
);



CREATE TABLE borrowersTable(
	borrowerID int IDENTITY(1111,1) PRIMARY KEY,
	username nvarchar(255) FOREIGN KEY REFERENCES usersTable(username),
    FirstName varchar(255),
	LastName varchar(255),
    ContactNumber varchar(255),
	booksBorrowed smallint,
	booksreturned smallint
);

insert into borrowersTable values 

select * from borrowersTable

CREATE TABLE returnTable(
	transactionNumber int IDENTITY(1111110,1) PRIMARY KEY,
	username nvarchar(255) FOREIGN KEY references usersTable(username),
	bookID smallint FOREIGN KEY references booksTable(bookID)
);

ALTER TABLE booksTable
ADD Status AS CASE 
                 WHEN Quantity > 0 THEN 'Available'
                 ELSE 'Out of Stock'
             END

ALTER TABLE borrowTable
ADD isReturned int DEFAULT 0; 

ALTER TABLE borrowTable
ADD Status AS CASE 
                 WHEN isReturned = 0 THEN 'Outstanding'
                 ELSE 'Returned'
             END

ALTER TABLE borrowersTable
ADD Status AS CASE 
                 WHEN  booksBorrowed IS NULL THEN 'OK'
                 WHEN  booksreturned = booksBorrowed THEN 'OK'
                 ELSE 'Not OK'
             END;

alter table borrowersTable
drop column Status

select * from booksTable
select * from borrowersTable
select * from usersTable
select * from borrowTable
select * from returnTable

update booksTable set Quantity = 3 where BookID = 12345;
update borrowersTable set booksBorrowed = NULL where username = 'allain'

UPDATE booksTable SET Quantity = Quantity - 1 WHERE BookID = @bookID;
UPDATE borrowersTable SET booksBorrowed = ISNULL(booksborrowed, 0) + 1 where username = 'user1';

DELETE FROM borrowTable where transactionNumber = 1111116;

UPDATE borrowTable SET isReturned = isReturned + 1 WHERE BookID = [insert the book ID here];
