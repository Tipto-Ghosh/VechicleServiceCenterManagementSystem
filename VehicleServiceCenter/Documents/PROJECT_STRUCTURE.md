### `PROJECT_STRUCTURE.md`

# Vehicle Service Center Management System - Project Structure

### `Project Structure`

VehicleServiceCenter/
│
├── Models/                       # Entity classes (map to DB tables)
│   ├── User.cs                   # Base class for all user types
│   ├── Admin.cs                  # Inherits from User
│   ├── Mechanic.cs               # Inherits from User
│   ├── Receptionist.cs           # Inherits from User
│   ├── InventoryManager.cs       # Inherits from User
│   ├── Customer.cs               # Inherits from User
│   ├── Appointment.cs            # Appointment entity
│   ├── Vehicle.cs                # Vehicle entity
│   ├── InventoryItem.cs          # Spare part entity
│   └── OfferedService.cs         # Predefined service offerings
│
├── Repositories/                 
│   ├── UserRepository.cs
│   ├── AdminRepository.cs
│   ├── MechanicRepository.cs
│   ├── ReceptionistRepository.cs
│   ├── InventoryManagerRepository.cs
│   ├── CustomerRepository.cs
│   ├── AppointmentRepository.cs
│   ├── VehicleRepository.cs
│   ├── InventoryItemRepository.cs
│   └── OfferedServiceRepository.cs
│         
├── Services/                    
│   ├── UserService.cs
│   ├── AdminService.cs
│   ├── MechanicService.cs
│   ├── ReceptionistService.cs
│   ├── InventoryManagerService.cs
│   ├── CustomerService.cs
│   ├── AppointmentService.cs
│   ├── VehicleService.cs
│   ├── InventoryItemService.cs
│   └── OfferedServiceService.cs
│
├── Forms/                        
│   ├── LoginForm.cs
│   ├── AdminDashboard.cs
│   ├── ReceptionistPanel.cs
│   ├── MechanicPanel.cs
│   ├── CustomerForm.cs
│   ├── InventoryManagerForm.cs
│   └── AppointmentForm.cs
│
├── Config/                       
│   └── DbConfig.cs               # DB connection string and setup
│
└── Program.cs                    # Main application entry point
