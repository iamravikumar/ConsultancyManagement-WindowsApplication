CREATE DATABASE DUCATPROJECT_CONSULTANCY_ERP
USE DUCATPROJECT_CONSULTANCY_ERP

CREATE TABLE JOB_SEEKER_DETAILS
(
	SERIAL_NUMBER INT NOT NULL IDENTITY(1,1),
	FIRST_NAME NVARCHAR(30) NOT NULL,
	LAST_NAME NVARCHAR(30) NOT NULL,
	AGE INT NOT NULL,
	GENDER NVARCHAR(10) NOT NULL,
	EMAIL NVARCHAR(30) NOT NULL,
	MOBILE NVARCHAR(15) NOT NULL,
	HIGHEST_QUALIFICATION NVARCHAR(20) NOT NULL,
	CONSTRAINT PK_JSD PRIMARY KEY(SERIAL_NUMBER),
)

CREATE TABLE EMPLOYER_DETAILS
(
	SERIAL_NUMBER INT NOT NULL IDENTITY(1,1),
	NAME NVARCHAR(30) NOT NULL,
	REGISTRATION_NUMBER NVARCHAR(30) NOT NULL,
	CONTACT_PERSON NVARCHAR(50) NOT NULL,
	PHONE NVARCHAR(15) NOT NULL,
	EMAIL NVARCHAR(30) NOT NULL,
	ADDRESS_LOCATION NVARCHAR(100) NOT NULL,
	CONSTRAINT PK_ED PRIMARY KEY(SERIAL_NUMBER),
	CONSTRAINT UK_ED UNIQUE (NAME, REGISTRATION_NUMBER)
)

DROP TABLE EMPLOYER_DETAILS

SP_HELP EMPLOYER_DETAILS

CREATE PROCEDURE SP_INSERT_JOBSEEKER
@FNAME NVARCHAR(30),
@LNAME NVARCHAR(30),
@AGE INT,
@GENDER NVARCHAR(10),
@EMAIL NVARCHAR(30),
@MOBILE NVARCHAR(15),
@HQLF NVARCHAR(20)
AS BEGIN
INSERT INTO JOB_SEEKER_DETAILS
(FIRST_NAME, LAST_NAME, AGE, GENDER, EMAIL, MOBILE, HIGHEST_QUALIFICATION)
VALUES
(@FNAME, @LNAME, @AGE, @GENDER, @EMAIL, @MOBILE, @HQLF)
END

CREATE PROCEDURE SP_INSERT_EMPLOYER
@NAME NVARCHAR(30),
@REGISTRATION_NUMBER NVARCHAR(30),
@CONTACT_PERSON NVARCHAR(50),
@PHONE NVARCHAR(15),
@EMAIL NVARCHAR(30),
@ADDRESS_LOCATION NVARCHAR(100)
AS BEGIN
INSERT INTO EMPLOYER_DETAILS
(NAME, REGISTRATION_NUMBER, CONTACT_PERSON, PHONE, EMAIL, ADDRESS_LOCATION)
VALUES
(@NAME, @REGISTRATION_NUMBER, @CONTACT_PERSON, @PHONE, @EMAIL, @ADDRESS_LOCATION)
END

SELECT * FROM JOB_SEEKER_DETAILS

SP_HELP JOB_SEEKER_DETAILS

CREATE TABLE LOGIN_DETAILS
(
	USERNAME NVARCHAR(30) NOT NULL,
	USER_PASSWORD NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_LD PRIMARY KEY(USERNAME)
)

SP_HELP LOGIN_DETAILS

SELECT * FROM LOGIN_DETAILS
