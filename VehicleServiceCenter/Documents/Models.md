# Vehicle Service Center Management System - Model Classes

### `Models/`

This folder contains the core entity classes that map directly to the database tables. These models define the schema and relationships between entities.

---

#### `User.cs`

**Description:**
Base class representing all types of users in the system.

**Properties:**

* `int UserID`
* `string Name`
* `string Gender`
* `string Password`
* `DateTime DateOfBirth`
* `string BloodGroup`
* `string Email`
* `string UserType` *(e.g., Admin, Customer, Mechanic, etc.)*

---

#### `Admin.cs`

**Inherits:** `User`
**Description:**
Represents an admin user who can manage the system.

**Additional Properties:**

* `string Type` *(CEO or Manager)*
* `DateTime CreatedDate`

---

#### `Mechanic.cs`

**Inherits:** `User`
**Description:**
Mechanic entity who performs services.

**Additional Properties:**

* `float Rating`
* `string Status` *(Available, Busy, etc.)*

---

#### `Receptionist.cs`

**Inherits:** `User`
**Description:**
Handles customer bookings and appointment logistics.

**Additional Properties:**

* `string ShiftTime`

---

#### `InventoryManager.cs`

**Inherits:** `User`
**Description:**
Manages inventory items and restocking operations.

**Additional Properties:**

* *(None beyond inherited `User` fields)*

---

#### `Customer.cs`

**Inherits:** `User`
**Description:**
Represents the service customers.

**Additional Properties:**

* `string PhoneNumber`

---

#### `Appointment.cs`

**Description:**
Tracks appointments between customers and mechanics.

**Properties:**

* `int AppointmentID`
* `int CustomerID`
* `int MechanicID`
* `DateTime ScheduledDate`
* `string Status`
* `int CreatedBy`
* `int TokenNumber`

---

#### `Vehicle.cs`

**Description:**
Represents vehicles owned by customers.

**Properties:**

* `int VehicleID`
* `int CustomerID`
* `string LicensePlate`
* `string Model`

---

#### `InventoryItem.cs`

**Description:**
Represents spare parts in stock.

**Properties:**

* `int InventoryItemID`
* `string ItemName`
* `int RemainingNumber`
* `decimal Price`

---

#### `OfferedService.cs`

**Description:**
Represents predefined services offered by the service center.

**Properties:**

* `int ServiceID`
* `string ServiceName`
* `string Description`
* `decimal Price`
* `int EstimatedDurationMinutes`

