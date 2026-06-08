
CREATE DATABASE ViewExample302

USE ViewExample302


CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) DEFAULT 'XXX',
Point INT NOT NULL CHECK(Point BETWEEN 0 AND 100),
Age TINYINT NOT NULL CHECK(Age BETWEEN 10 AND 65),
Email VARCHAR(256) NOT NULL UNIQUE
)

CREATE TABLE Grades(
Id INT PRIMARY KEY IDENTITY,
Letter CHAR(1) UNIQUE NOT NULL,
[Min] INT CHECK([Min] BETWEEN 0 AND 91),
[Max] INT CHECK([Max] BETWEEN 50 AND 100)
)



SELECT s.Name, s.Point, g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point BETWEEN g.[Min] AND g.[Max]
ORDER BY g.Letter ASC


SELECT s.Name, s.Point, g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point BETWEEN g.[Min] AND g.[Max]
ORDER BY s.Point ASC


SELECT s.Name, s.Point, g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point BETWEEN g.[Min] AND g.[Max]
WHERE s.Age<20



SELECT s.Name, s.Point, g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point BETWEEN g.[Min] AND g.[Max]
WHERE s.Age<20 AND s.Point>80
ORDER BY s.Name



CREATE VIEW StudentsWithGrades
AS
SELECT s.Name,s.Surname, s.Point, g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point BETWEEN g.[Min] AND g.[Max]




CREATE VIEW BestStudent
AS
SELECT * FROM StudentsWithGrades
WHERE Point=(SELECT MAX(Point)  FROM StudentsWithGrades)



SELECT * FROM BestStudent




SELECT sub.Name FROM (SELECT s.Name,s.Surname, s.Point, g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point BETWEEN g.[Min] AND g.[Max]) AS sub
WHERE Point=(SELECT MAX(Point)  FROM StudentsWithGrades)



--CLUSTERED    NON-CLUSTERED  VIEW