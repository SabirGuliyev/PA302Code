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


