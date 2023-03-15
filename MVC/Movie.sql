create database MoviesDB3

Create Table Movie3(
 Mid int Primary Key NOT NULL,
 Moviename Varchar(50) NOT NULL,
 DateofRelease Date NOT NULL
);

INSERT INTO Movie3 Values (1, 'THE FURY','2016-08-23');
INSERT INTO Movie3 Values (2, 'Avengers','2012-02-12');
INSERT INTO Movie3 Values (3, 'AntMan','2015-07-21');
INSERT INTO Movie3 Values (4, 'Squid Game','2020-11-22');


SELECT * FROM Movie3;


