CREATE DATABASE Shopping;

USE Shopping;

CREATE TABLE ShoppingItems(
	Id INT NOT NULL,
	Description VARCHAR(50) NOT NULL,
	UseBefore DATETIME,
	AvailableAmount INT
);

INSERT INTO ShoppingItems VALUES (1, 'Bread', CONVERT(DATETIME,'26.07.2020', 104), 100);
INSERT INTO ShoppingItems VALUES (2, 'Bottle of milk', CONVERT(DATETIME,'27.07.2020', 104), 5);
INSERT INTO ShoppingItems VALUES (3, 'Bottle of orange juice', CONVERT(DATETIME,'26.07.2020', 104), 6);
INSERT INTO ShoppingItems VALUES (4, 'Peas', CONVERT(DATETIME,'31.07.2020', 104), 13);
INSERT INTO ShoppingItems VALUES (5, 'Corn', CONVERT(DATETIME,'30.07.2020', 104), 51);
INSERT INTO ShoppingItems VALUES (6, 'Sausage', CONVERT(DATETIME,'26.07.2020', 104), 80);
INSERT INTO ShoppingItems VALUES (7, 'Cheese', CONVERT(DATETIME,'28.07.2020', 104), 64);
INSERT INTO ShoppingItems VALUES (8, 'Bottle of olive oil', CONVERT(DATETIME,'31.08.2020', 104), 37);
INSERT INTO ShoppingItems VALUES (9, 'Swiss cheese', CONVERT(DATETIME,'29.07.2020', 104), 18);
INSERT INTO ShoppingItems VALUES (10, 'Butter', CONVERT(DATETIME,'30.07.2020', 104), 44);

INSERT INTO ShoppingItems VALUES (11, 'Smiltenes cheese', NULL , 44);
INSERT INTO ShoppingItems VALUES (12, 'Salads', CONVERT(DATETIME,'30.07.2020', 104), NULL);
INSERT INTO ShoppingItems VALUES (13, 'Bottle of teriyaki souce', CONVERT(DATETIME,'30.07.2020', 104), 44);
INSERT INTO ShoppingItems VALUES (14, 'Eggs', NULL , 44);
INSERT INTO ShoppingItems VALUES (15, 'Greek salad', CONVERT(DATETIME,'30.07.2020', 104), NULL);

SELECT * FROM ShoppingItems

SELECT *
FROM ShoppingItems
WHERE Id = 1

--search patterns
-- % is zero or more characters
-- _ is a SINGLE charcted
SELECT * FROM ShoppingItems WHERE Description LIKE '%bottle%'
SELECT * FROM ShoppingItems WHERE Description LIKE '%a__%'

SELECT * FROM ShoppingItems WHERE Description NOT IN ('Bread', 'Cheese', 'Butter', 'Corn')
SELECT * FROM ShoppingItems WHERE Id IN (1,3,5,7)
SELECT * FROM ShoppingItems WHERE AvailableAmount NOT BETWEEN 20 AND 50 
SELECT * FROM ShoppingItems WHERE AvailableAmount BETWEEN 20 AND 50
--not equal
SELECT * FROM ShoppingItems WHERE UseBefore != CONVERT(DATETIME,'26.07.2020', 104)
SELECT * FROM ShoppingItems WHERE UseBefore <> CONVERT(DATETIME,'26.07.2020', 104)
--equal
SELECT * FROM ShoppingItems WHERE UseBefore = CONVERT(DATETIME,'26.07.2020', 104) ORDER BY Description DESC
SELECT * FROM ShoppingItems WHERE AvailableAmount > 50 ORDER BY AvailableAmount
SELECT * FROM ShoppingItems WHERE Description = 'Bread'

--deletion with condition
DELETE FROM ShoppingItems WHERE Id = 1 
--deletion without any condition
DELETE FROM ShoppingItems

--how to get specific values without duplicates
SELECT DISTINCT UseBefore FROM ShoppingItems 

-----------------------------------------------------------
-----------------------------------------------------------

--find a record which is or is not null
