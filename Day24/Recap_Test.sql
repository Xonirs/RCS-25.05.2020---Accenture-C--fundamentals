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

SELECT TOP 5 Description 
FROM Tasks
ORDER BY Priority DESC

------------------------------------
/*
SELECT column1, column2, ...
FROM tableName
WHERE condition;
*/

SELECT * FROM Tasks WHERE TaskId = 5
SELECT * FROM Tasks WHERE Creator = 'Mom'
SELECT * FROM Tasks WHERE Priority > 7 ORDER BY Priority
SELECT * FROM Tasks WHERE Priority <= 6 

-- <> is NOT EQUAL operator
SELECT * FROM Tasks WHERE Creator <> 'Mom'

SELECT * FROM Tasks WHERE Priority BETWEEN 7 AND 9

SELECT * FROM Tasks WHERE Priority NOT BETWEEN 7 AND 9

-- IN is an operator which helps to choose multiple possible values for a column
SELECT * FROM Tasks WHERE Priority IN (5,7,10)
SELECT * FROM Tasks WHERE Creator IN ('Mom', 'Me')
SELECT * FROM Tasks WHERE TaskId NOT IN (1,2,3,6,7,8)

-- LIKE means that we are using a pattern
-- '%' used anywhere in a string to match a sequence of zero or more characters (works only with LIKE and NOT LIKE)
-- '_' used anywhere in a string to match a single character (works only with LIKE and NOT LIKE)
SELECT * FROM Tasks
SELECT * FROM Tasks WHERE Creator LIKE 'M%' --all tasks when creator starts with letter M
SELECT * FROM Tasks WHERE Creator LIKE 'M_' --all tasks when creator starts with letter M and continues with a single character

SELECT * FROM Tasks WHERE Description LIKE '%room%' --all tasks when description contains 'room'

SELECT * FROM Tasks WHERE Description LIKE '%work' --all tasks when description end with 'work'

-- '%xxx' = ends with
-- 'xxx%' = starts with
-- '%xxx%' = contains

SELECT * FROM Tasks WHERE Description LIKE '%ou_%'

-- DISTINCT used to remove duplicates
SELECT DISTINCT Creator FROM Tasks --all creators without duplicates

--in the case below, a unique record will consist of both values, not just one
SELECT DISTINCT Creator, Priority FROM Tasks






