USE VehicleServiceCenterDB;


-- Insert Users
INSERT INTO Users (Name, Gender, Password, DateOfBirth, BloodGroup, Email, UserType) VALUES
('Alice', 'Female', 'pass123', '1975-01-10', 'A+', 'alice.ceo@example.com', 'Admin'),        
('Bob', 'Male', 'pass123', '1980-05-20', 'B+', 'bob.manager@example.com', 'Admin'),          
('Charlie', 'Male', 'pass123', '1985-03-15', 'O+', 'charlie.inv@example.com', 'InventoryManager'), 
('David', 'Male', 'pass123', '1990-04-01', 'A-', 'david1@example.com', 'Customer'),          
('Eva', 'Female', 'pass123', '1992-06-17', 'B-', 'eva2@example.com', 'Customer'),            
('Frank', 'Male', 'pass123', '1988-12-12', 'AB+', 'frank3@example.com', 'Customer'),        
('Grace', 'Female', 'pass123', '1995-07-22', 'O-', 'grace4@example.com', 'Customer'),       
('Henry', 'Male', 'pass123', '1989-11-11', 'A+', 'henry5@example.com', 'Customer'),          
('Ivy', 'Female', 'pass123', '1982-08-08', 'B+', 'ivy.mechanic1@example.com', 'Mechanic'),   
('Jack', 'Male', 'pass123', '1979-09-09', 'O+', 'jack.mechanic2@example.com', 'Mechanic'),  
('Kate', 'Female', 'pass123', '1984-10-10', 'A-', 'kate.mechanic3@example.com', 'Mechanic'),  
('Liam', 'Male', 'pass123', '1991-02-02', 'B-', 'liam.recept1@example.com', 'Receptionist'),  
('Mia', 'Female', 'pass123', '1993-03-03', 'AB+', 'mia.recept2@example.com', 'Receptionist'); 



-- Insert Admins (CEO and Manager)
INSERT INTO Admins (UserID, Type, CreatedDate) VALUES
(1000, 'CEO', '2020-01-01'),
(1001, 'Manager', '2021-05-01');


-- Intert into customer
INSERT INTO Customers (UserID, PhoneNumber) VALUES
(1003, '01711111111'),
(1004, '01722222222'),
(1005, '01733333333'),
(1006, '01744444444'),
(1007, '01755555555');


--inssert mechanics
INSERT INTO Mechanics (UserID, Rating, Status) VALUES
(1008, 4.5, 'Available'),
(1009, 4.2, 'Busy'),
(1010, 4.7, 'Available');


INSERT INTO Receptionists (UserID, ShiftTime) VALUES
(1011, 'Morning'),
(1012, 'Evening');

INSERT INTO InventoryManagers (UserID) VALUES
(1002);


INSERT INTO Vehicles (CustomerID, LicensePlate, Model) VALUES
(1003, 'DHK1234', 'Toyota Corolla'),
(1004, 'CTG5678', 'Honda Civic'),
(1005, 'SYL9101', 'Mazda Axela'),
(1006, 'RAJ2345', 'Hyundai Elantra'),
(1007, 'BAR6789', 'Ford Focus');


INSERT INTO InventoryItems (ItemName, RemainingNumber) VALUES
('Oil Filter', 50),
('Air Filter', 40),
('Brake Pads', 30),
('Spark Plugs', 20),
('Coolant', 60);


INSERT INTO Appointments (CustomerID, MechanicID, ScheduledDate, Status, CreatedBy, TokenNumber) VALUES
(1003, 1008, '2025-06-10', 'Pending', 1011, 100),
(1004, 1008, '2025-06-11', 'Confirmed', 1011, 101),
(1005, 1009, '2025-06-12', 'Completed', 1012, 102),
(1006, 1010, '2025-06-13', 'Pending', 1012, 103),
(1007, 1009, '2025-06-14', 'Cancelled', 1001, 104);   -- create by Manager
