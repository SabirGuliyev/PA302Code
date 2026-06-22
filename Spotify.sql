CREATE DATABASE Spotify302


USE Spotify302


CREATE TABLE Users(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) DEFAULT 'NONE',
Password NVARCHAR(36) NOT NULL CHECK(LEN(Password)>=8),
Username VARCHAR(128) NOT NULL UNIQUE,
Gender VARCHAR(10) CHECK(Gender IN('Male','Female','Others'))
)

CREATE TABLE Artists(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) DEFAULT 'NONE',
Birthday DATETIME2,
Gender VARCHAR(10) CHECK(Gender IN('Male','Female','Others'))
)

CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(100) NOT NULL UNIQUE
)

CREATE TABLE Musics(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(100) NOT NULL,
Duration INT CHECK(Duration > 0),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
ArtistId INT FOREIGN KEY REFERENCES Artists(Id)
)

CREATE TABLE Playlists(
MusicId INT REFERENCES Musics(Id),
UserId INT REFERENCES Users(Id),
PRIMARY KEY(MusicId,UserId)
)



--1. Mahnını adını, uzunluğunu, kateqoriyasını, 
--hansı ifaçı tərəfindən oxunulduğunu bildirən sorğunu özündə saxlayan view yazın
CREATE VIEW vw_MusicsWithCategoriesAndArtists
AS
SELECT m.Name, m.Duration, c.Name AS Category, a.Name AS [Artist Name] FROM Musics AS m
JOIN Categories AS c
ON m.CategoryId=c.Id
JOIN Artists AS a
ON m.ArtistId=a.Id



SELECT * FROM vw_MusicsWithCategoriesAndArtists
ORDER BY Duration

----------------------------------------



--2.Procedure yazirsiz Id qebul edir hemin Id-li userin playlistinə 
--əlavə etdiyi mahnıların siyahısını çıxarır

CREATE VIEW vw_UsersPlaylist
AS
SELECT u.Id,u.Name AS [User], m.Name, a.Name AS [Artist Name],a.Id AS ArtistId , m.Duration  FROM Musics AS m
JOIN Playlists AS p
ON m.Id=p.MusicId
JOIN Users AS u
ON p.UserId=u.Id
JOIN Artists AS a
ON m.ArtistId=a.Id


CREATE PROCEDURE usp_GetPlaylistByUser @userId INT
AS
SELECT [User],Name,[Artist Name],Duration FROM vw_UsersPlaylist
WHERE Id=@userId


EXEC usp_GetPlaylistByUser 3

EXEC usp_GetPlaylistByUser 1

EXEC usp_GetPlaylistByUser 2

-----------------------------

--4. Function yazirsiz . Id qebul edir gonderilen Id-li Userin dinlediyi 
--Ifacilarin sayini geriye qaytarir (Ifacilarin sayini mahnilarin yox)


CREATE FUNCTION dbo.GetUserArtistCount(@userId INT)
RETURNS INT
AS
BEGIN
RETURN (SELECT COUNT(DISTINCT ArtistId) FROM vw_UsersPlaylist
WHERE Id=@userId)
END

SELECT dbo.GetUserArtistCount(1)

---------------------------------------

--6. Saytda ən çox mahnı çıxaran ifaçını(ları) seçin
--(Komek ucun functionlar tapa bilersiz muxtelif cur yazmaq olur)


SELECT a.Name, COUNT(m.Name) AS [Count] FROM Artists AS a
JOIN Musics AS m
ON a.Id=m.ArtistId
GROUP BY a.Name
HAVING COUNT(m.Name)=(SELECT MAX([Count]) FROM 
(SELECT COUNT(m.Name) AS [Count] FROM Artists AS a
JOIN Musics AS m
ON a.Id=m.ArtistId
GROUP BY a.Name) AS sub)


-------------------------------





