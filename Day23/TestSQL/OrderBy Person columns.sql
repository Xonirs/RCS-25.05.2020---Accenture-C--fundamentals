Use Test;

--by default ORDER BY sorts results in ASCENDING order
--we can use ASC/DESC
SELECT * 
FROM Persons
ORDER BY Age ASC

SELECT * 
FROM Persons
ORDER BY Age DESC, LastName ASC

SELECT LastName 
FROM Persons
ORDER BY Age DESC