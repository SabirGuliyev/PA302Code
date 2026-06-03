CREATE DATABASE Relation302

USE Relation302



CREATE TABLE Groups(
Id INT PRIMARY KEY IDENTITY,
Name CHAR(5) NOT NULL UNIQUE
)


CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) DEFAULT 'XXX',
Point FLOAT CHECK(Point BETWEEN 0 AND 100),
GroupId INT FOREIGN KEY REFERENCES Groups(Id)
)

CREATE TABLE Subjects(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(100) NOT NULL UNIQUE
)

CREATE TABLE StudentSubjects(
StudentId INT FOREIGN KEY REFERENCES Students(Id),
SubjectId INT REFERENCES Subjects(Id),
PRIMARY KEY(StudentId, SubjectId)
)



SELECT s.Name, g.Name AS [Group] FROM Students AS s
JOIN Groups AS g
ON s.GroupId=g.Id
WHERE g.Name IN('M400','C670')


SELECT s.Name+' '+s.Surname AS FullName, g.Name AS [Group] ,sb.Name AS Subject FROM Students AS s
JOIN StudentSubjects AS ss
ON s.Id=ss.StudentId
JOIN Subjects AS sb
ON ss.SubjectId=sb.Id
JOIN Groups AS g
ON s.GroupId=g.Id






SELECT s.Name, g.Name AS [Group] FROM Students AS s
LEFT JOIN Groups AS g
ON s.GroupId=g.Id

--
SELECT s.Name, g.Name AS [Group] FROM Students AS s
RIGHT JOIN Groups AS g
ON s.GroupId=g.Id
WHERE s.GroupId IS NULL




SELECT s.Name, g.Name AS [Group] FROM Students AS s
FULL OUTER JOIN Groups AS g
ON s.GroupId=g.Id
WHERE s.GroupId IS NULL



CREATE TABLE Grades(
Id INT PRIMARY KEY IDENTITY,
Letter CHAR(1) NOT NULL UNIQUE,
[Min] INT CHECK([MIN] BETWEEN 0 AND 91),
[Max] INT CHECK([MAX] BETWEEN 50 AND 100)
)


SELECT s.Name,s.Point,gd.Letter FROM Students AS s
JOIN Grades AS gd
ON s.Point BETWEEN gd.[Min] and gd.[Max]




CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	Position VARCHAR(200) NOT NULL,
	DependId INT FOREIGN KEY REFERENCES Employees(Id) 
)

--DROP TABLE Employees

--SELF join
SELECT e.Name, d.Name AS Chief FROM Employees AS e
LEFT JOIN Employees AS d
ON e.DependId = d.Id


CREATE TABLE KHProducts(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(250) NOT NULL UNIQUE,
Price DECIMAL(8,2)
)

CREATE TABLE IrshadProducts(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(250) NOT NULL UNIQUE,
Price DECIMAL(8,2)
)


SELECT Name FROM IrshadProducts
EXCEPT
SELECT Name FROM KHProducts

SELECT Price FROM KHProducts
UNION 
SELECT Price FROM IrshadProducts






-- A  min 91   max 100
-- B  min 81   max 90
-- C  min 71   max 80
-- D  min 61   max 70
-- E  min 51   max 60
-- F  min 0    max 50

 
--Jamal, 2, 2, PA302

--NULL, NULL,4, E999

--EQUI


