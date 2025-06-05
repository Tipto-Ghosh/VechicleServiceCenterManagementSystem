# Repository Classes and Their Methods

Each repository class is responsible for direct database interactions.

---

### `UserRepository.cs`

* GetUserById(int id)
* GetUserByEmail(string email)
* InsertUser(User user)
* UpdateUser(User user)
* DeleteUser(int userId)
* ChangePassword(int userId, string newPassword)

### `AdminRepository.cs`

* InsertAdmin(Admin admin)
* UpdateAdmin(Admin admin)
* DeleteAdmin(int adminId)
* GetAllAdmins()

### `MechanicRepository.cs`

* InsertMechanic(Mechanic mech)
* UpdateMechanic(Mechanic mech)
* DeleteMechanic(int mechId)
* GetMechanicJobs(int mechId)
* UpdateAvailabilityStatus(int mechId, string status)

### `ReceptionistRepository.cs`

* InsertReceptionist(Receptionist receptionist)
* UpdateReceptionist(Receptionist receptionist)
* DeleteReceptionist(int id)

### `InventoryManagerRepository.cs`

* InsertInventoryManager(InventoryManager inv)
* DeleteInventoryManager(int id)

### `CustomerRepository.cs`

* InsertCustomer(Customer customer)
* UpdateCustomer(Customer customer)
* DeleteCustomer(int id)
* GetCustomerVehicles(int customerId)

### `AppointmentRepository.cs`

* CreateAppointment(Appointment appointment)
* UpdateAppointment(Appointment appointment)
* CancelAppointment(int appointmentId)
* GetAppointmentsByCustomer(int customerId)
* GetAppointmentsByMechanic(int mechanicId)

### `VehicleRepository.cs`

* InsertVehicle(Vehicle vehicle)
* UpdateVehicle(Vehicle vehicle)
* DeleteVehicle(int vehicleId)
* GetVehicleByCustomerId(int customerId)

### `InventoryItemRepository.cs`

* InsertItem(InventoryItem item)
* UpdateItem(InventoryItem item)
* DeleteItem(int itemId)
* GetLowStockItems()
* GetAllItems()

### `OfferedServiceRepository.cs`

* InsertService(OfferedService service)
* UpdateService(OfferedService service)
* DeleteService(int serviceId)
* GetAllServices()
* GetServiceById(int serviceId)
