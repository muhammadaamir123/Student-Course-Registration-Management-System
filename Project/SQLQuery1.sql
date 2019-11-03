CREATE TABLE Course(CID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
CourseID VARCHAR(50) NOT NULL,
CourseTitle VARCHAR(50) NOT NULL,
CourseCredithours int NOT NULL)

SELECT * FROM Course

INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('MA-1001', 'Calculus', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('PH-1004',	'Basic Electronic', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('ENG-1091', 'Functional English', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CS-1071' ,'Introduction to Computing', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-1072' ,'Discrete Structures', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('MA-1005', 'Linear Algebra', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('ENG-1092', 'Communication And Presentation Skills', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('HU-1092' ,'Pakistan Studies', 2)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-1071', 'Programming Fundamental', 4)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-1074', 'Digital Logic Design', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('HU-1091', 'Islamic Studies/Ethics', 2)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-2078', 'Database System', 4)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('MGT-1081', 'Principles of Management', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-2071', 'Object Oriented Programming', 4)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-2075','Computer Organization & Assembly Language', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-2076', 'Theory Of Automata & Formal Language', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('STAT-2003','Probability & Statistics', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('MA-2002', 'Multivariable Calculus', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('ENG-3091', 'Technical Writing', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-2077', 'Data Structures', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-2073', 'Sofware Engineering Fundamentals', 3)
INSERT INTO Course (CourseID,CourseTitle,CourseCredithours) VALUES ('CSC-2074', 'Data Communication & Networks', 3)

CREATE TABLE Technology (TID int identity(1,1) NOT NULL PRIMARY KEY,
TechnologyName VARCHAR(50) NOT NULL)

CREATE TABLE UTData ([UID] INT NOT NULL,
Usertype VARCHAR(50) NOT NULL PRIMARY KEY)


select * from UTData
ORDER BY (UID)ASC

SELECT * FROM UserData

ALTER TABLE UserData
DROP Usertype

select * from DepartmentData

ALTER TABLE UserData
ADD Usertype VARCHAR(50) foreign key REFERENCES UType(Usertype)

select * from UserData d inner join UTData t
on d.Usertype = t.Usertype

select FirstName From UserData
where Usertype = 'Faculty'

CREATE TABLE Department (TID int NOT NULL,
DepTitle VARCHAR(50) NOT NULL PRIMARY KEY)

select * from Department

