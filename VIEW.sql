
CREATE DATABASE ViewExample302

USE ViewExample302


CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) DEFAULT 'XXX',
Point INT NOT NULL CHECK(Point BETWEEN 0 AND 100),
Age TINYINT NOT NULL CHECK(Age BETWEEN 10 AND 65),
Email VARCHAR(256) NOT NULL UNIQUE,
IsDeleted BIT 
)

ALTER TABLE Students ADD CreatedAt SMALLDATETIME 

ALTER TABLE Students ADD IsDeleted BIT 



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



ALTER TRIGGER TriggerOnStudentsDelete
ON Students
AFTER DELETE
AS
SELECT * FROM DELETED



--14-Sabir Guliyev 20 Email


CREATE TRIGGER TriggerOnStudentsInsert
ON Students
AFTER INSERT
AS
UPDATE Students SET CreatedAt=SYSDATETIME() WHERE Id=(SELECT Id FROM INSERTED)
GETDATE()

INSERT INTO Students(Name, Surname, Email, Age, Point) VALUES('Test','Testov','aaaa@',23,88)



DELETE FROM Students WHERE Id IN(6,10)


SELECT * FROM Students WHERE IsDeleted=0


SELECT * FROM Students WHERE IsDeleted=1




CREATE TRIGGER StudentsSoftDelete
ON Students
INSTEAD OF DELETE
AS
DECLARE @isDeleted BIT
DECLARE @id INT

SELECT @isDeleted=IsDeleted, @id=Id FROM DELETED

IF(@isDeleted = 0)
	BEGIN
	UPDATE Students SET IsDeleted=1 WHERE Id=@id
	END
ELSE
	BEGIN
	DELETE FROM Students WHERE Id=@id
	END




DELETE FROM Students WHERE Id=12



T-SQL
PL SQL