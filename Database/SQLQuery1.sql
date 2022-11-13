-- create and use Database
IF DB_ID('W_Z_International_Languages') IS NULL
create database W_Z_International_Languages
go


USE W_Z_International_Languages;
go

-- create tables
IF OBJECT_ID('course_student') IS NOT NULL
  DROP TABLE course_student;
GO

IF OBJECT_ID('course') IS NOT NULL
  DROP TABLE course;
GO

IF OBJECT_ID('student') IS NOT NULL
  DROP TABLE student;
GO



CREATE TABLE student (
	student_id int identity(1000,1) PRIMARY KEY,
	Username NVARCHAR (50),
	Password  NVARCHAR (50),
	FirstName NVARCHAR (50) NOT NULL,
	LastName NVARCHAR (50) NOT NULL,
	Birthday date NOT NULL,
	Gender bit ,
	--1 is Male , 0 is Female
	Phone  NVARCHAR (25),
	Adress NVARCHAR (50) 
);

CREATE TABLE course (
	courseID INT identity(2000,1) PRIMARY KEY ,
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
	CONSTRAINT fk_course FOREIGN KEY (courseID)
					REFERENCES course(courseID)

);

INSERT INTO student(Username,Password,FirstName,LastName, Birthday,Gender,Phone,Adress)
			  VALUES     ('Waelz','12','wael','Zobani','06-10-1993','1','01766456565','66386 Sankt Ingbert , langstr.12')


INSERT INTO student(FirstName,LastName, Birthday,Gender,Phone,Adress)
			  VALUES     ('Mohammad','Zobani','10-08-2021','1','01766456565','66386 Sankt Ingbert , kurzstr.2'),
						 ('lila','Mueller','30-03-2010','0','01766456565','66111 Saarbrücken, albertallestr.31'),
						 ('Layla','Schmitt','30-03-2001','0','01766456565','66111 Saarbrücken, albertallestr.31'),
					 	 ('markus','Habeb','30-03-2002','1','017664655999','66111 Saarbrücken, albertallestr.31'),
					   	 ('Thomas','Braun','30-03-2001','1','01766456565','66111 Saarbrücken, albertallestr.31'),
						 ('Sam','Oha','30-03-2005','1','017664655999','66111 Saarbrücken, albertallestr.31'),
						 ('Max','Mueller','30-03-2003','1','01766456565','66111 Saarbrücken, albertallestr.31'),
						 ('Frans','Muaster','30-03-1999','1','01766456565','66111 Saarbrücken, albertallestr.31'),
						('lamis','Ohr','30-03-1988','0','01766456565','66111 Saarbrücken, albertallestr.31'),
						('waled','Scmidt','30-03-1997','1','01766456565','66111 Saarbrücken, albertallestr.31'),
						('nina','walder','30-03-2000','0','01766456565','66111 Saarbrücken, albertallestr.31'),
						('alia','Mueller','30-03-1996','0','01766456565','66111 Saarbrücken, albertallestr.31'),
						('wesam','Schmitt','30-03-2001','1','01766456565','66111 Saarbrücken, albertallestr.31'),
						('emily','Mueller','30-03-2001','0','01766456565','66111 Saarbrücken, albertallestr.31'),
						('Farhan','Mueller','30-03-2005','1','01766456565','66111 Saarbrücken, albertallestr.31'),
						('lia','Habeb','30-03-2006','0','01766456565','66111 Saarbrücken, albertallestr.31'),
						('smoil','Mueller','30-03-2000','1','01766456565','66111 Saarbrücken, albertallestr.31'),
						('kinan','Braun','30-03-1998','1','01766456565','66111 Saarbrücken, albertallestr.31'),
						('Hayya','Oha','30-03-1997','0','01766456565','66111 Saarbrücken, albertallestr.31'),
						('haydi','Muaster','30-03-2000','0','01766456565','66111 Saarbrücken, albertallestr.31')



INSERT INTO course(course_Name,courseHour, Description)
			  VALUES('Englisch',700,'Grammar and Composition I'),
			  ('Frensch',600,'Reading and Vocabulary'),
			  ('Germany',800,'Oral Communication')


			  

INSERT INTO course_student(course_student_datum,student_id, courseID)
			  VALUES('15-02-2023',1000,2000)
			  ,('15-02-2023',1001,2000),('15-02-2023',1002,2000),('15-02-2023',1003,2000),('15-02-2023',1004,2000),('15-02-2023',1005,2000),
			 ('01-03-2023',1006,2001),('01-03-2023',1007,2001),('01-03-2023',1008,2001),('01-03-2023',1009,2001) ,('01-03-2023',1010,2001),('01-03-2023',1011,2001),
			 ('05-05-2023',1012,2002),('05-05-2023',1013,2002) ,('05-05-2023',1014,2002),('05-05-2023',1015,2002),('05-05-2023',1016,2002),('05-05-2023',1017,2002),
			 ('05-05-2023',1018,2002),('05-05-2023',1019,2002),('05-05-2023',1020,2002)
			select * from course_student
						select * from student
