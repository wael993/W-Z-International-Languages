-- create and use Database
IF DB_ID('W_Z_International_Languages') IS NULL
create database W_Z_International_Languages
go


USE W_Z_International_Languages;
go

-- create tables
IF OBJECT_ID('course_student') IS NOT NULL
  DROP TABLE ausleihe_Prozess;
GO

IF OBJECT_ID('course') IS NOT NULL
  DROP TABLE Auftraege;
GO

IF OBJECT_ID('student') IS NOT NULL
  DROP TABLE Benutzer;
GO



CREATE TABLE student (
	student_id int PRIMARY KEY,
	UserName NVARCHAR (50) NOT NULL,
	Passwort NVARCHAR (50) NOT NULL,
	FirstName NVARCHAR (50) NOT NULL,
	LastName NVARCHAR (50) NOT NULL,
	Birthday date NOT NULL,
	Gender NVARCHAR (50) ,
	Phone int,
	Adress NVARCHAR (50) 
);

CREATE TABLE course (
	courseID INT PRIMARY KEY ,
	course_Name NVARCHAR (255) NOT NULL,
	courseHour int NOT NULL,
	Description NVARCHAR (255)
	);


CREATE TABLE course_student(
	course_student_id INT identity(3000,1) PRIMARY KEY,
	course_student_datum DATE NOT NULL,
	student_id int ,
	courseID INT ,
	CONSTRAINT fk_student FOREIGN KEY (student_id)
					REFERENCES student(student_id),
	CONSTRAINT fk_Buch FOREIGN KEY (courseID)
					REFERENCES course(courseID)

);


