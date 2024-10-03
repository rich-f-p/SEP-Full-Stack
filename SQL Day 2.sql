USE AdventureWorks2019
GO

--1) number of products found in the table(504)
SELECT COUNT(*) AS NumOfProducts
FROM Production.Product

--2) query number of products included in a subcategory,not including null
SELECT COUNT(ProductSubcategoryID) AS NumInSubcategory
FROM Production.Product

--3) query display count of products in each subcategory
SELECT ProductSubcategoryID,Count(ProductSubcategoryID) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID

--4) products that do not have a product subcategory(209)
SELECT COUNT(*) AS NullSubCategory
FROM Production.Product
Where ProductSubcategoryID IS NULL

--5)query to list the sum of products quantity of each product
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
GROUP BY ProductID

--6) query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40 AND Quantity < 100
GROUP BY ProductID

--7) query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
SELECT Shelf,ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40 AND Quantity < 100
GROUP BY ProductID, Shelf

--8) query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table
SELECT AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE LocationID = 10

--9) query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
SELECT ProductID,Shelf,AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID,Shelf

--10) query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
SELECT ProductID,Shelf,AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID,Shelf

--11) List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS TheAvg
FROM Production.Product
WHERE Color IS NOT NULL AND CLASS IS NOT NULL
GROUP BY Color, Class

--12) query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following
SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode

--13) query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada
SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name IN ('Germany','Canada')

USE Northwind
GO
--14) List all Products that has been sold at least once in last 27 years.
SELECT DISTINCT p.ProductName
FROM [Order Details] od JOIN Orders o ON od.OrderID=o.OrderID JOIN Products p ON p.ProductID=od.ProductID
WHERE o.OrderDate > DATEADD(year,-27,GETDATE())

--15) List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS QuantityOfProducts
FROM [Order Details] od JOIN Orders o ON od.OrderID=o.OrderID
GROUP BY o.ShipPostalCode
ORDER BY SUM(od.Quantity) DESC

--16) List top 5 locations (Zip Code) where the products sold most in last 27 years.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS QuantityOfProducts
FROM [Order Details] od JOIN Orders o ON od.OrderID=o.OrderID
WHERE o.OrderDate > DATEADD(year,-27,GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY SUM(od.Quantity) DESC

--17) List all city names and number of customers in that city.  
SELECT City, COUNT(CustomerID) AS Count
FROM Customers
GROUP BY City

--18) List city names which have more than 2 customers, and number of customers in that city
SELECT City, COUNT(CustomerID) AS Count
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >2

--19) List the names of customers who placed orders after 1/1/98 with order date.
SELECT c.CompanyName,o.OrderDate
FROM Orders o JOIN Customers c ON o.CustomerID=c.CustomerID
WHERE o.OrderDate > '1998-1-1'

--20) List the names of all customers with most recent order dates
SELECT c.CompanyName, MAX(o.OrderDate) AS Recent
FROM Orders o JOIN Customers c ON o.CustomerID=c.CustomerID
GROUP BY c.CompanyName
ORDER BY Recent DESC

--21) Display the names of all customers  along with the  count of products they bought
SELECT c.CompanyName, SUM(od.Quantity) AS ProductsBought
FROM Orders o JOIN Customers c ON o.CustomerID=c.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.CompanyName

--22) Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CompanyName, SUM(od.Quantity) AS ProductsBought
FROM Orders o JOIN Customers c ON o.CustomerID=c.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.CompanyName
HAVING SUM(od.Quantity) >100

--23)  List all of the possible ways that suppliers can ship their products
SELECT DISTINCT su.CompanyName AS [Supplier Company Name], sh.CompanyName AS [Shipping Company Name]
FROM Suppliers su JOIN Products p ON su.SupplierID=p.SupplierID 
JOIN [Order Details] od ON p.ProductID=od.ProductID 
JOIN Orders o ON od.OrderID=o.OrderID
JOIN Shippers sh on o.ShipVia=sh.ShipperID
ORDER BY su.CompanyName

--24) Display the products order each day. Show Order date and Product Name.
SELECT o.OrderDate AS [Order date], p.ProductName AS [Product Name]
FROM Orders o JOIN [Order Details] od ON o.OrderID= od.OrderID JOIN Products p ON od.ProductID=p.ProductID
ORDER BY o.OrderDate

--25) Displays pairs of employees who have the same job title.
SELECT e.EmployeeID,m.EmployeeID, e.Title,m.Title
FROM Employees e JOIN Employees m ON e.Title=m.Title 
WHERE e.EmployeeID < m.EmployeeID
ORDER BY e.EmployeeID

--26) Display all the Managers who have more than 2 employees reporting to them.
SELECT e.EmployeeID,e.FirstName,e.LastName, Count(e.EmployeeID) AS Manage
FROM Employees e Join Employees m ON e.EmployeeID = m.ReportsTo
GROUP BY e.EmployeeID,e.FirstName,e.LastName
HAVING COUNT(e.EmployeeID)>2

--27) Display the customers and suppliers by city.
SELECT City,CompanyName AS Name,ContactName AS 'Contact Name,','Customer' AS Type
FROM Customers
UNION
SELECT City,CompanyName AS Name,ContactName AS 'Contact Name,', 'Supplier' As Type 
FROM Suppliers
