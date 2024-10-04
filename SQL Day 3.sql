USE Northwind
GO

--1.List all cities that have both Employees and Customers.
SELECT DISTINCT e.City
FROM Employees e JOIN Customers c ON e.City=c.City

--2.List all cities that have Customers but no Employee.
--a.Use sub-query
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN(
	SELECT DISTINCT City
	FROM Employees
)
--b.Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City=e.City
WHERE e.city IS NULL
--3.List all products and their total order quantities throughout all orders.
SELECT p.ProductID, SUM(od.Quantity) AS OrderQuantity
FROM [Order Details] od JOIN Products p ON p.ProductID=od.ProductID 
GROUP BY p.ProductID
ORDER BY p.ProductID
--4.List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(od.Quantity)  AS OrderQuantity
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID=od.OrderID
GROUP BY c.City
ORDER BY c.City

--5.List all Customer Cities that have at least two customers.
SELECT City, COUNT(City) AS cnt
FROM Customers
GROUP BY City
HAVING COUNT(City)>=2

--6.List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City, COUNT(DISTINCT od.ProductID)
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID=od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID)>=2
ORDER BY c.City

--7.List all Customers who have ordered products, but have the �ship city� on the order different from their own customer cities.
SELECT DISTINCT c.CompanyName, c.City, o.ShipCity
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity

--8.List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT TOP 5 p.ProductName,  AVG(od.UnitPrice) AS AveragePrice, c.City
FROM Products p JOIN [Order Details] od ON p.ProductID=od.ProductID JOIN  Orders o ON od.OrderID=o.OrderID JOIN Customers c ON o.CustomerID=c.CustomerID
GROUP BY p.ProductName, c.City
ORDER BY SUM(od.Quantity) DESC

--9.List all cities that have never ordered something but we have employees there.
--a.Use sub-query
SELECT City
FROM Employees
WHERE City NOT IN(
	SELECT City
	FROM Customers
)
--b.Do not use sub-query
SELECT e.City
FROM Employees e LEFT JOIN Customers c ON e.City = c.City
WHERE c.city IS NULL

--10.List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT TOP 1 emo.ShipCity AS City
FROM (
	SELECT ShipCity, COUNT(EmployeeID) AS cntOrder
	FROM Orders
	GROUP BY ShipCity
) AS emo JOIN (
	SELECT c.City, SUM(od.Quantity)  AS OrderQuantity
	FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID=od.OrderID
	GROUP BY c.City
) AS cmq ON emo.ShipCity=cmq.City
GROUP BY emo.ShipCity,cmq.City,emo.cntOrder,cmq.OrderQuantity
ORDER BY emo.cntOrder DESC,cmq.OrderQuantity DESC

--11.How do you remove the duplicates record of a table?
CREATE TABLE TestDuplicate(
	Id INT,
	EName VARCHAR(20) NOT NULL,
	Age INT
)

INSERT INTO TestDuplicate VALUES (1,'Sam',45)
INSERT INTO TestDuplicate VALUES (2,'Fiona',45)
INSERT INTO TestDuplicate VALUES (2,'Fiona',45)
INSERT INTO TestDuplicate VALUES (2,'Fiona',45)


SELECT * FROM TestDuplicate
-- code below search table for duplicate value(Id) and deletes the rows excessive number of rows so that only one instance of the value is present
DELETE Temp
FROM(
SELECT *
, Duplicate = ROW_NUMBER() OVER (
		PARTITION BY Id
		ORDER BY (SELECT NULL)
		)
FROM TestDuplicate
) AS Temp
WHERE Duplicate >1
