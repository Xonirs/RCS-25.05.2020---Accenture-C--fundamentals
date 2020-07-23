CREATE DATABASE CompanyInventory

USE CompanyInventory

CREATE TABLE InventoryItems(
	Id INT NOT NULL PRIMARY KEY,
	Description VARCHAR(100) NOT NULL,
	Quantity INT
);

SELECT * FROM InventoryItems

ALTER TABLE InventoryItems
ADD Color VARCHAR(20)


INSERT INTO [dbo].[InventoryItems]
           ([Id]
           ,[Description]
           ,[Quantity]
           ,[Color])
     VALUES
           (1
           ,'Medium chair'
           ,20
           ,'black')

INSERT INTO [dbo].[InventoryItems] VALUES (2,'Large chair',2,'green')
INSERT INTO [dbo].[InventoryItems] VALUES (3,'Small chair',7,'black')
INSERT INTO [dbo].[InventoryItems] VALUES (4,'Medium table',33,'green')
INSERT INTO [dbo].[InventoryItems] VALUES (5,'Laptops',51,'red')
INSERT INTO [dbo].[InventoryItems] VALUES (6,'TV',14,'red')
INSERT INTO [dbo].[InventoryItems] VALUES (7,'Printers',6,'yellow')
INSERT INTO [dbo].[InventoryItems] VALUES (8,'Pencils',0,'pink')
INSERT INTO [dbo].[InventoryItems] VALUES (9,'Paper',0,'pink')
INSERT INTO [dbo].[InventoryItems] VALUES (10,'Pens',24,'yellow')

INSERT INTO [dbo].[InventoryItems] VALUES (11,'Ice',0,NULL)
INSERT INTO [dbo].[InventoryItems] VALUES (12,'Lamps',24,NULL)

SELECT * FROM InventoryItems WHERE Color IN ('black', 'green')
SELECT * FROM InventoryItems WHERE Id = 7

DELETE FROM InventoryItems --deletes everything
DELETE FROM InventoryItems WHERE Color IS NULL --deletes by using condition

--updates everything
UPDATE InventoryItems
SET Color = 'white'

--updates by using condition
UPDATE InventoryItems
SET Color = 'white'
WHERE Color IS NULL

UPDATE InventoryItems
SET Quantity = NULL
WHERE Color = 'pink'

UPDATE InventoryItems
SET Color = NULL
WHERE Color = 'white'







