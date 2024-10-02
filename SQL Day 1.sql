USE AdventureWorks2019
GO
--1) query that retrieves ProductID, Name, Color and ListPrice, with no filter
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

--2) query that retrieves ProductID, Name, Color and ListPrice, excludes the rows that ListPrice is 0
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0

--3) query that retrieves ProductID, Name, Color and ListPrice, the rows that are NULL for the Color column
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL

--4) query that retrieves ProductID, Name, Color and ListPrice, the rows that are not NULL for the Color column
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE NOT Color IS NULL

--5) query that retrieves ProductID, Name, Color and ListPrice, the rows that are not NULL for the column Color, and the column ListPrice has a value greater than zero
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE NOT Color IS NULL AND ListPrice > 0

--6) query that concatenates the columns Name and Color from the Production.Product table by excluding the rows that are null for color
SELECT Name +' '+ Color AS ProductNameAndColor
FROM Production.Product
WHERE NOT Color IS NULL 

--7) generates results that match
SELECT 'NAME: ' + Name+ ' -- COLOR: ' + Color AS result
FROM Production.Product
WHERE Name IN ('LL Crankarm','ML Crankarm','HL Crankarm','Chainring Bolts','Chainring Nut','Chainring') 

--8) query that retrieves ProductID and name, filtered by ProductID from 400 to 500
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

--9) query to retrieve ProductID, Name and color restricted to the colors black and blue
SELECT ProductID, Name, Color
FROM Production.Product 
WHERE Color IN ('Black','Blue')

--10) query to get products that begin with the letter S
SELECT Name
FROM Production.Product
WHERE Name LIKE 'S%'

--11) query for Name and ListPrice, that begin with S and are ordered by Name
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'S%'
ORDER BY Name

--12) query for Name and ListPrice, that start with A or S and are ordered by Name
SELECT Name, ListPrice
FROM Production.Product
WHERE Name Like '[A,S]%'
ORDER BY Name

--13) query to retrieve Names that begin with the letters SPO, but not followed by the letter K and are ordered by Name
SELECT Name, ListPrice
FROM Production.Product
WHERE Name Like 'SPO[^K]%'
ORDER BY Name

--14) query for unique colors in descending order
SELECT DISTINCT Color
FROM Production.Product
ORDER BY Color DESC
