
USE Test; --switch DB usage to the selected one
--PRINT('Using the database {Test}');

--Creating a table called Persons with column PersonID, LastName, FirstName, Address, City
--PersonID, LastName, FirstName MUST have values (OR it CAN'T be NULL)
--Address, City doesn't have to have a value (OR it can be NULL)
CREATE TABLE Persons (
    PersonID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255) NOT NULL,
	Age int NOT NULL,
    Address varchar(255),
    City varchar(255)
);

--to delete Persons:
--DROP TABLE Persons;



