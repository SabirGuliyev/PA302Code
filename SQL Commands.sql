CREATE DATABASE Test302


USE Test302


CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) DEFAULT 'XXX',
Gmail VARCHAR(256) NOT NULL UNIQUE,
Age INT CHECK(Age > 0 AND Age<170)
)


DROP TABLE Students



TRUNCATE TABLE Students

--ALTER TABLE Students ADD FinCode CHAR(7)

--ALTER TABLE Students DROP COLUMN FinCode

--DROP TABLE Students




INSERT 
INTO Students 
VALUES(3,N'Əli',N'Keremli','ali@gmail.com'),
(4,N'Əli',N'Keremli','ali@gmail.com'),
(5,N'Əli',N'Keremli','ali@gmail.com'),
(6,N'Əli',N'Keremli','ali@gmail.com'),
(7,N'Əli',N'Keremli','ali@gmail.com')


UPDATE Students SET Name='G', Surname='Testov' WHERE Id=3

DELETE FROM Students WHERE Id=3



SELECT Id, [Name]+' '+Surname 
AS [Ad Soyad] 
FROM Students
WHERE Name LIKE '%a_'