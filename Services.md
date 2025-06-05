# Vehicle Service Center Management System - Methods Per Class


## All class's needed method
---

## 🧩 UserService.cs

Handles login, logout, profile, and common actions.

### Methods:

* `User Login(string email, string password)`
* `void Logout()`
* `User GetUserById(int userId)`
* `void ChangePassword(int userId, string oldPassword, string newPassword)`
* `void UpdateProfile(User updatedUser)`
* `DashboardDTO GetDashboardData(int userId)`

---

## 🛠 AdminService.cs

Manages all user types, appointments, services, and inventory.

### Methods:

* `void AddAdmin(Admin admin)`
* `void EditAdmin(Admin admin)`
* `void DeleteAdmin(int adminId)`
* `void AddEmployee(User user)`  ← Generic add for Mechanic/Receptionist/InventoryManager
* `void EditEmployee(User user)`
* `void DeleteEmployee(int userId)`
* `void AddOfferedService(OfferedService service)`
* `void EditOfferedService(OfferedService service)`
* `void DeleteOfferedService(int serviceId)`
* `void ManageWorkerHours(int mechanicId, string newStatus)`
* `void AddInventoryItem(InventoryItem item)`
* `void EditInventoryItem(InventoryItem item)`
* `void DeleteInventoryItem(int itemId)`
* `void AddAppointment(Appointment appointment)`
* `void EditAppointment(Appointment appointment)`
* `void RemoveAppointment(int appointmentId)`

---

## 🎧 ReceptionistService.cs

Manages appointments, customers, and payments.

### Methods:

* `void BookAppointment(Appointment appointment)`
* `void RescheduleAppointment(int appointmentId, DateTime newDate)`
* `void CancelAppointment(int appointmentId)`
* `void RegisterCustomer(Customer customer)`
* `void EditCustomer(Customer customer)`
* `void RemoveCustomer(int customerId)`
* `void AssignMechanic(int appointmentId, int mechanicId)`
* `void CompletePayment(int appointmentId, decimal amount, string paymentMethod)`

---

## 🔧 MechanicService.cs

Handles job assignments, repair notes, and part usage.

### Methods:

* `List<Appointment> GetAssignedJobs(int mechanicId)`
* `void UpdateServiceStatus(int appointmentId, string status)`
* `void UseSparePart(int appointmentId, int itemId, int quantity)`
* `void AddRepairNote(int appointmentId, string note)`
* `float GetServiceRating(int mechanicId)`
* `void ChangeAvailabilityStatus(int mechanicId, string newStatus)`

---

## 📦 InventoryManagerService.cs

Manages spare parts stock and procurement.

### Methods:

* `void AddInventoryItem(InventoryItem item)`
* `void EditInventoryItem(InventoryItem item)`
* `void DeleteInventoryItem(int itemId)`
* `List<InventoryItem> GetLowStockItems()`
* `void OrderSpareParts(string itemName, int quantity)`

---

## 👨‍🔧 CustomerService.cs

For service booking, tracking, rating, and payment.

### Methods:

* `void BookService(Appointment appointment)`
* `List<Appointment> GetServiceHistory(int customerId)`
* `Appointment GetJobStatus(int customerId)`
* `void RateService(int appointmentId, int rating)`
* `void MakeOnlinePayment(int appointmentId, decimal amount, string cardInfo)`

---

## 🚗 VehicleService.cs

Vehicle CRUD operations for customers.

### Methods:

* `void AddVehicle(Vehicle vehicle)`
* `void UpdateVehicle(Vehicle vehicle)`
* `void DeleteVehicle(int vehicleId)`
* `List<Vehicle> GetVehiclesByCustomer(int customerId)`

---

## 📅 AppointmentService.cs

Core appointment data operations (used by other services).

### Methods:

* `Appointment GetAppointmentById(int appointmentId)`
* `List<Appointment> GetAppointmentsByCustomer(int customerId)`
* `List<Appointment> GetAppointmentsByMechanic(int mechanicId)`
* `List<Appointment> GetAllAppointments()`

---

## 🔩 InventoryItemService.cs

Support service for managing inventory records.

### Methods:

* `InventoryItem GetItemById(int itemId)`
* `List<InventoryItem> GetAllItems()`
* `List<InventoryItem> GetLowStockItems()`

---

## 🧾 OfferedServiceService.cs

Support service for managing predefined services.

### Methods:

* `void AddService(OfferedService service)`
* `void EditService(OfferedService service)`
* `void DeleteService(int serviceId)`
* `List<OfferedService> GetAllServices()`
* `OfferedService GetServiceById(int serviceId)`

---
