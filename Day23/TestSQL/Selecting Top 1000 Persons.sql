USE Test;
SELECT TOP (10) [PersonID]
      ,[LastName]
      ,[FirstName]
      ,[Age]
      ,[Address]
      ,[City]
  FROM [Test].[dbo].[Persons]

SELECT TOP(8) PersonID, FirstName, City
FROM Persons

SELECT * FROM Persons

SELECT TOP(1) * FROM Persons