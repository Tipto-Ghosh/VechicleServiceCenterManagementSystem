-- Creating the database
CREATE DATABASE VehicleServiceCenterDB;

-- using the database
USE VehicleServiceCenterDB;



-- User table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1000,1),
    Name VARCHAR(100) NOT NULL,
    Gender VARCHAR(10),
    Password VARCHAR(255) NOT NULL,
    DateOfBirth DATE,
    BloodGroup VARCHAR(10),
    Email VARCHAR(100) UNIQUE,
    UserType VARCHAR(50) NOT NULL 
);


-- Customer table
CREATE TABLE Customers (
    UserID INT PRIMARY KEY,
    PhoneNumber VARCHAR(20),
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);


-- Admin table
CREATE TABLE Admins (
    UserID INT PRIMARY KEY,
    Type VARCHAR(20) CHECK (Type IN ('CEO', 'Manager')),
    CreatedDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);


-- Mechanic table
CREATE TABLE Mechanics (
    UserID INT PRIMARY KEY,
    Rating FLOAT,
    Status VARCHAR(50),
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);


-- Receptionist table
CREATE TABLE Receptionists (
    UserID INT PRIMARY KEY,
    ShiftTime VARCHAR(50),
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);


-- Inventory Manager table
CREATE TABLE InventoryManagers (
    UserID INT PRIMARY KEY,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);


-- Vehicle table
CREATE TABLE Vehicles (
    VehicleID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,
    LicensePlate VARCHAR(20) UNIQUE NOT NULL,
    Model VARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customers(UserID) ON DELETE CASCADE
);


-- Inventory Items table
CREATE TABLE InventoryItems (
    InventoryItemID INT PRIMARY KEY IDENTITY(1,1),
    ItemName VARCHAR(100) NOT NULL,
    RemainingNumber INT DEFAULT 0
);


-- Appointments table

CREATE TABLE Appointments (
    AppointmentID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    MechanicID INT NOT NULL,
    ScheduledDate DATE,
    Status VARCHAR(20),
    CreatedBy INT NOT NULL,
    TokenNumber INT,
    CONSTRAINT FK_Appointments_CustomerID FOREIGN KEY (CustomerID) REFERENCES Customers(UserID),
    CONSTRAINT FK_Appointments_MechanicID FOREIGN KEY (MechanicID) REFERENCES Mechanics(UserID),
    CONSTRAINT FK_Appointments_CreatedBy FOREIGN KEY (CreatedBy) REFERENCES Users(UserID)
);


------------------ Here added new feature--------------------------------------------
---- run all the query from here.

USE VehicleServiceCenterDB;

drop table InventoryItems;


-- New Update: InventoryItems table now includes Price
CREATE TABLE InventoryItems (
    InventoryItemID INT PRIMARY KEY IDENTITY(1,1),
    ItemName VARCHAR(100) NOT NULL,
    RemainingNumber INT DEFAULT 0,
    Price DECIMAL(10, 2) NOT NULL
);

--New: OfferedServices table to store default services
CREATE TABLE OfferedServices (
    ServiceID INT PRIMARY KEY IDENTITY(1,1),
    ServiceName VARCHAR(100) NOT NULL,
    Description VARCHAR(255),
    Price DECIMAL(10, 2) NOT NULL,
    EstimatedDurationMinutes INT
);

-- New table To Book a Service(Connect Appointment with Service)
CREATE TABLE AppointmentServices (
    AppointmentID INT NOT NULL,
    ServiceID INT NOT NULL,
    FOREIGN KEY (AppointmentID) REFERENCES Appointments(AppointmentID) ON DELETE CASCADE,
    FOREIGN KEY (ServiceID) REFERENCES OfferedServices(ServiceID) ON DELETE CASCADE,
    PRIMARY KEY (AppointmentID, ServiceID)
);
