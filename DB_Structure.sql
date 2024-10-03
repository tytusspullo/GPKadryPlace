CREATE DATABASE employee_schedule
GO
-----------Grafiki pracownicze i ewidencja czasu pracy----------
-----------created by:Grzegorz Piszczek-------------------------
CREATE TABLE dbo.employee_schedule_type
(
ID_employee_schedule_type INT NOT NULL IDENTITY(1,1)
,[name] VARCHAR(30) NOT NULL
,avilable BIT NOT NULL DEFAULT = 1
)
GO
INSERT INTO employee_schedule_type ([name]) VALUES ('Planowany');
INSERT INTO employee_schedule_type ([name]) VALUES ('Wykonania');
GO
CREATE TABLE employee_absenteeism
(
ID_employee_absenteeism INT NOT NULL IDENTITY(1,1)
,[short_name] varchar(2) NOT NULL
,[name] VARCHAR(30) NOT NULL
,avilable BIT NOT NULL DEFAULT = 1
)
GO
INSERT INTO employee_absenteeism ([short_name],[name]) VALUES ('R','Dzienna zmiana');
INSERT INTO employee_absenteeism ([short_name],[name]) VALUES ('N','Nocna zmiana');
INSERT INTO employee_absenteeism ([short_name],[name]) VALUES ('L4','Chorobowe');
INSERT INTO employee_absenteeism ([short_name],[name]) VALUES ('UW','Urlop wypoczynkowy');
INSERT INTO employee_absenteeism ([short_name],[name]) VALUES ('UZ','Urlop na ¿¹danie');
GO
CREATE TABLE dbo.employee
(
ID_employee INT NOT NULL IDENTITY(1,1)
,employee_name VARCHAR(30) NOT NULL
,avilable BIT NOT NULL DEFAULT = 1
)
GO
CREATE TABLE dbo.employee_schedule
(
ID_employee_schedule INT NOT NULL IDENTITY(1,1)
,[year] INT not null
,[month] INT not null
,[name_of_employee_group] VARCHAR(30) NOT NULL
,[avilable] BIT NOT NULL DEFAULT = 1
)
GO
CREATE TABLE dbo.employee_schedule_position
(
[ID_employee_schedule_position] INT NOT NULL IDENTITY(1,1)
,[employee_schedule_ID] INT NOT NULL --FK as named constraint
,[employee_ID] INT NOT NULL --FK as named constraint TODO
,[for_date] DATETIME NOT NULL 
,[employee_absenteeism_ID] INT NOT NULL
,[hours] DATETIME NOT NULL
)
GO
ALTER TABLE employee_schedule_position
	ADD CONSTRAINT FK_employee_schedule_employee_schedule_position
	FOREIGN KEY (employee_schedule_ID) REFERENCES employee_schedule(ID_employee_schedule) ON DELETE CASCADE; 
GO

-----------------------------------------------
