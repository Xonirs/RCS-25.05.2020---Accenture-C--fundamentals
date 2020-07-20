CREATE DATABASE MondayDB;
USE MondayDB;

/*
CREATE TABLE TableName(
	column1 datatype,
	column2 datatype,
	column3 datatype,
	column4 datatype
);
*/

CREATE TABLE Tasks (
	TaskId INT NOT NULL,
	Description VARCHAR(100) NOT NULL,
	Priority INT,
	CreatedOn DATETIME,
	Creator VARCHAR(50),
	Done BIT
);

--SELECT gets the data from table
SELECT TaskId, Description
FROM Tasks

INSERT INTO Tasks (TaskId, Description, Priority) VALUES (1, 'Finish creating DB', 5)
INSERT INTO Tasks (TaskId, Description, Priority) VALUES (2, 'Start working on Final work', 9)
INSERT INTO Tasks (TaskId, Description, Priority) VALUES (3, 'Finish all homework', 8)

INSERT INTO Tasks VALUES (4, 'Clean our room', 7, CONVERT(DATETIME, '20.07.2020', 104), 'Mom', 0)
INSERT INTO Tasks VALUES (5, 'LONG description 123456987adsadasdadsaheethrtewwqrxc 123456987adsadasdadsaheethrtewwqrxc', 7, CONVERT(DATETIME, '20.07.2020', 104), 'Mom', 0)

INSERT INTO Tasks VALUES (6, 'Take out the trash', 6, CONVERT(DATETIME, '18.07.2020', 104), 'Mom', 0)
INSERT INTO Tasks VALUES (7, 'Fold clothes', 4, CONVERT(DATETIME, '16.07.2020', 104), 'Me', 0)
INSERT INTO Tasks VALUES (8, 'Vacuum living room', 9, CONVERT(DATETIME, '15.07.2020', 104), 'Dad', 0)
INSERT INTO Tasks VALUES (9, 'Cook dinner', 7, CONVERT(DATETIME, '02.07.2020', 104), 'Sister', 0)
INSERT INTO Tasks VALUES (10, 'Clean teeth', 10, CONVERT(DATETIME, '20.07.2020', 104), 'Me', 0)
INSERT INTO Tasks VALUES (11, 'Drink 5 glasses of water', 8, CONVERT(DATETIME, '05.07.2020', 104), 'Me', 0)

SELECT * FROM Tasks

SELECT TOP 5 * FROM Tasks


SELECT * 
FROM Tasks
ORDER BY Priority ASC

SELECT * 
FROM Tasks
ORDER BY Priority DESC, Description

SELECT * 
FROM Tasks
ORDER BY CreatedOn 




