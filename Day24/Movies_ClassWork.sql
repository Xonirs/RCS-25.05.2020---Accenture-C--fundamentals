/*
1.1)Create a database ‘Cinema’ and a table called ‘Movies’
1.2)Table has the following columns:
MovieId 
Title
Director
Year
Genre
LengthInMinutes
1.3)Fill the table with at least 10 records
2)Create the following select statements:
2.1)Find all movie titles and their directors
2.2)Find the movie with id = 3
2.3)Find all movies made in the last decade
2.4)Find all movies longer than 1h 20min
2.5)Find all movies directed by Steven Spielberg
2.6)Find all movies whose title start with ‘p’
2.7)Find all directors without duplicates
2.8)List the first 5 movies sorted by Title alphabetically
2.9)Find all movies made between 1990 and 2000
2.10)Find all movies except the ones made in 2002, 2004, 2006	
2.11)Find all movies with genre containing letter ‘m’
*/

CREATE DATABASE Cinema;
USE Cinema;

CREATE TABLE Movies(
	MovieId int,
	Title varchar(50),
	Director varchar(50),
	Year int,
	Genre varchar(20),
	LengthInMinutes int
);

INSERT INTO Movies VALUES (1, 'Title1', 'Director', 1989, 'Comedry', 120);
INSERT INTO Movies VALUES (2, 'Title2', 'Steven Spielberg', 1994, 'Drama', 81);
INSERT INTO Movies VALUES (3, 'Title3', 'Director2', 1999, 'Romance', 60);
INSERT INTO Movies VALUES (4, 'Title4', 'Director2', 2004, 'Comedry', 81);
INSERT INTO Movies VALUES (5, 'Title5', 'Director3', 2009, 'Romance', 180);
INSERT INTO Movies VALUES (6, 'Title6', 'Director', 2014, 'Drama', 20);
INSERT INTO Movies VALUES (7, 'Title7', 'Director2', 2019, 'Comedry', 60);
INSERT INTO Movies VALUES (8, 'Title8', 'Director3', 2020, 'Drama', 60);
INSERT INTO Movies VALUES (9, 'Title9', 'Director4', 2006, 'Romance', 81);
INSERT INTO Movies VALUES (10, 'Title10', 'Director5', 2013, 'Comedry', 60);

SELECT * FROM Movies

--2)Create the following select statements:
--2.1)Find all movie titles and their directors
SELECT Title, Director FROM Movies
--2.2)Find the movie with id = 3
SELECT * FROM Movies WHERE MovieId = 3
--2.3)Find all movies made in the last decade
SELECT * FROM Movies WHERE Year >= 2010
--2.4)Find all movies longer than 1h 20min
SELECT * FROM Movies WHERE LengthInMinutes > 80
--2.5)Find all movies directed by Steven Spielberg
SELECT * FROM Movies WHERE Director = 'Steven Spielberg'
--2.6)Find all movies whose title start with ‘p’
SELECT * FROM Movies WHERE Title LIKE 'p%'
--2.7)Find all directors without duplicates
SELECT DISTINCT Director FROM Movies 
--2.8)List the first 5 movies sorted by Title alphabetically
SELECT TOP 5 * FROM Movies ORDER BY Title ASC
--2.9)Find all movies made between 1990 and 2000
SELECT * FROM Movies WHERE Year BETWEEN 1990 AND 2000
--2.10)Find all movies except the ones made in 2002, 2004, 2006	
SELECT * FROM Movies WHERE Year NOT IN (2002, 2004, 2006)
--2.11)Find all movies with genre containing letter ‘m’
SELECT * FROM Movies WHERE Genre LIKE '%m%'