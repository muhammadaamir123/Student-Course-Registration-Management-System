CREATE TABLE UserData (UserID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
FatherName VARCHAR(50),
MobileNo VARCHAR(50),
[Address] VARCHAR(50),
DOB VARCHAR(50),
Gender VARCHAR(50),
City VARCHAR(50),
Username VARCHAR(50),
Email VARCHAR(50),
[Password] VARCHAR(50)
)

ALTER TABLE UserData
ADD	UType VARCHAR(50) FOREIGN KEY REFERENCES UserType(Usertype)

ALTER TABLE UserData
ADD RegNo VARCHAR(50)

ALTER TABLE UserData
ADD Department VARCHAR(50) FOREIGN KEY REFERENCES Department(DepTitle)

ALTER TABLE UserData
ADD Displine VARCHAR(50) FOREIGN KEY REFERENCES Displine(Technology)


CREATE TABLE UType (UTypeID varchar(50) PRIMARY KEY,
Usertype VARCHAR(50))



CREATE TABLE Department (DepID INT,
DepTitle VARCHAR(50) primary key)

CREATE TABLE Displine (DisplineID INT,
Technology VARCHAR(50) PRIMARY KEY)

SELECT * FROM UserData inner join UType
on [UserData].UserID = [UType].UTypeID

SELECT * FROM UserData
SELECT * FROM UserType
SELECT * FROM Department
SELECT * FROM Displine

SELECT RegNo FROM UserData