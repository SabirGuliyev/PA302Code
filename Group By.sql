CREATE DATABASE Group302

USE Group302



CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(200) NOT NULL UNIQUE,
)

CREATE TABLE Products(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(200) NOT NULL UNIQUE,
Price DECIMAL(6,2) CHECK(Price>0)NOT NULL,
Cost DECIMAL(6,2) CHECK(Cost>=0) NOT NULL,
CategoryId INT REFERENCES Categories(Id)
)

CREATE TABLE Sizes(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(50) NOT NULL UNIQUE
)


CREATE TABLE ProductSizes(
ProductId INT REFERENCES Products(Id),
SizeId INT REFERENCES Sizes(Id),
PRIMARY KEY(ProductId, SizeId)
)












SELECT p.Name, s.Name AS Size FROM Products AS p
CROSS JOIN Sizes AS s






SELECT p.Name, c.Name AS Category, s.Name AS Size
FROM Products AS p 
LEFT JOIN Categories AS c
ON p.CategoryId=c.Id
LEFT JOIN ProductSizes AS ps
ON p.Id=ps.ProductId
JOIN Sizes AS s
ON ps.SizeId=s.Id









SELECT p.Name, COUNT(s.Name) AS [Size Count]
FROM Products AS p 
LEFT JOIN Categories AS c
ON p.CategoryId=c.Id
LEFT JOIN ProductSizes AS ps
ON p.Id=ps.ProductId
JOIN Sizes AS s
ON ps.SizeId=s.Id
WHERE p.Price>200
GROUP BY p.Name
HAVING COUNT(s.Name) >3



SELECT p.Name, LEN(s.Name) 
FROM Products AS p 
LEFT JOIN Categories AS c
ON p.CategoryId=c.Id
LEFT JOIN ProductSizes AS ps
ON p.Id=ps.ProductId
JOIN Sizes AS s
ON ps.SizeId=s.Id



