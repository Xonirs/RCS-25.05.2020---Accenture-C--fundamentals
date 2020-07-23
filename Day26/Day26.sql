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




