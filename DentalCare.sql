create database DentalCare;
use DentalCare;
Create Table Patients(
PatientID int auto_increment  Primary key,
Patient_Name Varchar(200),
Patient_Address Varchar (200),
DOB Datetime,
Gender varchar(100),
NIC varchar (20),
ContactNO varchar(10),
Medical_Details varchar(300)
);
Create Table Dentist(
DentistID int auto_increment Primary key,
Dentist_Name Varchar (100),
Dentist_Address varchar (200),
ContactNo varchar (10),
JoindDate datetime,
Specialization varchar(100)
);
Create Table Appoinments(
AppoinmentID int auto_increment Primary Key,
Appoinment_Date Datetime ,
DentistID int,
PatientID int,
Appoinment_Status Varchar(100),
FOREIGN KEY (DentistID) REFERENCES Dentist(DentistID),
FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
);

CREATE TABLE Services (
    ServiceID INT auto_increment PRIMARY KEY,
    ServiceName VARCHAR(200),
    Price DECIMAL(10, 2), 
    ServiceDescription VARCHAR(200)
);

CREATE TABLE Invoice (
    InvoiceID int auto_increment PRIMARY KEY,
    InvoiceDate Date,
    PatientID int,
    Total decimal,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
);

create table Register(
First_Name varchar(100),
Last_Name varchar (100),
Address varchar(300),
Gender varchar (10),
DOB date,
UserType varchar (20),
Username varchar (20) unique,
Password varchar (10));