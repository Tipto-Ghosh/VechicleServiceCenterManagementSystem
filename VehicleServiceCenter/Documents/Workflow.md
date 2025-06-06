### `WORKFLOW.md`

# Vehicle Service Center Management System – Coding Workflow

This guide explains the **exact order** in which to implement your project files so that everything is organized and layered properly.

---

## ✅ STEP-BY-STEP DEVELOPMENT PLAN

---

### 🔹 Step 1: **Set Up the Database**

1. Open SQL Server Management Studio.
2. Execute all the SQL queries provided (tables for Users, Admins, Appointments, InventoryItems, etc.).
3. Make sure `VehicleServiceCenterDB` is created successfully with all tables.

---

### 🔹 Step 2: **Create the Solution & Base Folder Structure**

1. Open Visual Studio.
2. Create a new Windows Forms App (.NET Framework) project named `VehicleServiceCenter`.
3. Inside the project, create the following folders:

   * `Models`
   * `Repositories`
   * `Services`
   * `Forms`
   * `Config`

---

### 🔹 Step 3: **Add Database Configuration**

* Create `Config/DbConfig.cs`
  ✅ Add method to return connection string

---

### 🔹 Step 4: **Build All Models**

Write the following entity classes **first** based on your DB tables:

Inside `Models/`:

* `User.cs` → base class for all users
* `Admin.cs`, `Customer.cs`, `Mechanic.cs`, `Receptionist.cs`, `InventoryManager.cs` → inherit from `User`
* `Vehicle.cs`
* `Appointment.cs`
* `InventoryItem.cs`
* `OfferedService.cs`

---

### 🔹 Step 5: **Create Repositories**

Write data access layer for each entity in `Repositories/`. Do these in this order:

1. `UserRepository.cs`
2. `AdminRepository.cs`
3. `CustomerRepository.cs`
4. `MechanicRepository.cs`
5. `ReceptionistRepository.cs`
6. `InventoryManagerRepository.cs`
7. `VehicleRepository.cs`
8. `AppointmentRepository.cs`
9. `InventoryItemRepository.cs`
10. `OfferedServiceRepository.cs`

Each repository should:

* Use `SqlConnection`, `SqlCommand`
* Have methods: `Insert`, `Update`, `Delete`, `GetById`, `GetAll`, etc.

---

### 🔹 Step 6: **Create Services**

Inside `Services/`, create service classes to handle business logic:

Start in this order:

1. `UserService.cs` → login, registration, get by email, etc.
2. `AdminService.cs` → manage users
3. `CustomerService.cs` → add/edit customers
4. `MechanicService.cs` → assign jobs, update rating/status
5. `ReceptionistService.cs` → create appointments, manage customer info
6. `InventoryManagerService.cs` → manage inventory
7. `VehicleService.cs`
8. `AppointmentService.cs` → create/update/assign appointments
9. `InventoryItemService.cs`
10. `OfferedServiceService.cs` → get available services, prices

Each service calls the corresponding Repository.

---

### 🔹 Step 7: **Build Forms (UI Layer)**

Create basic Forms for each role in `Forms/`. Do in this order:

1. `LoginForm.cs`
   🔁 Uses `UserService.Authenticate()`

2. Based on login, open:

   * `AdminDashboard.cs` → user mgmt, inventory, services
   * `ReceptionistPanel.cs` → appointments, customer handling
   * `MechanicPanel.cs` → view/complete jobs
   * `CustomerForm.cs` → book service, view status
   * `InventoryManagerForm.cs` → manage spare parts

Also include:

* `AppointmentForm.cs` (common to admin/receptionist)
* `VehicleForm.cs` (customer vehicles)

---

### 🔹 Step 8: **Hook Up the Navigation**

* From `LoginForm`, check `UserType` and open the appropriate dashboard form.
* Use `Form.Hide()` and `new Form().ShowDialog()` logic to switch views.
