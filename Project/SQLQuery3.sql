CREATE TABLE Course(CourseID VARCHAR(50) NOT NULL,
CourseTitle VARCHAR(50) NOT NULL,
Semester VARCHAR(50) NOT NULL,
Tech VARCHAR(50))

CREATE TABLE Tech(TechID VARCHAR(50) PRIMARY KEY,
Technology VARCHAR(50))

SELECT * FROM Course
SELECT * FROM Technology

ALTER TABLE Course
ADD FOREIGN KEY (Tech) REFERENCES Tech(TechID)


SELECT * FROM UserData

ALTER TABLE UserData
ADD Displine VARCHAR(50) FOREIGN KEY REFERENCES Tech(TechID)

ALTER TABLE UserData
ADD UNIQUE (Username)

CREATE TABLE FacultyCourse(CourseTitle VARCHAR(50),
Tech VARCHAR(50))

SELECT * FROM FacultyCourse

SELECT * FROM Tech t INNER JOIN Course c
ON t.TechID = c.Tech
WHERE Tech = 'CS'

ALTER TABLE FacultyCourse
ADD Semester VARCHAR(50)

ALTER TABLE FacultyCourse
ADD FacultyName int FOREIGN KEY REFERENCES UserData(UserID)

UPDATE UserData
SET FirstName = 'Asad'
WHERE USERID = 3

SELECT * FROM UserData WHERE UserID = 3

select * from FacultyCourse