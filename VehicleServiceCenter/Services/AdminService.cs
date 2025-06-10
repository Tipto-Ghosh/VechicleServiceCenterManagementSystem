using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;


namespace VehicleServiceCenter.Services {
    public class AdminService {

        private AdminRepository adminRepo;
        private UserRepository userRepo;
        private MechanicRepository mechanicRepo;
        private ReceptionistRepository receptionistRepo;
        private InventoryManagerRepository inventoryManagerRepo;
        private OfferedServiceRepository offeredServiceRepo;
        private InventoryItemRepository inventoryItemRepo;
        private AppointmentRepository appointmentRepo;
        private CustomerRepository customerRepo;


        // initalize all objects when cons. call
        public AdminService() {
            this.adminRepo = new AdminRepository();
            this.userRepo = new UserRepository();
            this.mechanicRepo = new MechanicRepository();
            this.receptionistRepo = new ReceptionistRepository();
            this.inventoryManagerRepo = new InventoryManagerRepository();
            this.offeredServiceRepo = new OfferedServiceRepository();
            this.inventoryItemRepo = new InventoryItemRepository();
            this.appointmentRepo = new AppointmentRepository();
            this.customerRepo = new CustomerRepository();
        }

        // Make Admin Operations

        public int AddAdmin(Admin admin) {
            int status = adminRepo.InsertAdmin(admin);
            return status;
        }

        public int UpdateAdmin(Admin admin) { 
           int status = adminRepo.UpdateAdmin(admin);
            return status;
        }

        public int DeleteAdmin(int adminId) {
            return adminRepo.DeleteAdmin(adminId);
        }

        public int AddReceptionist(Receptionist recep) {
            return receptionistRepo.InsertReceptionist(recep);
        }
        public int UpdateReceptionist(Receptionist recep) {
            return receptionistRepo.UpdateReceptionist(recep);
        }
        public int DeleteReceptionist(int id) {
            return receptionistRepo.DeleteReceptionist(id);
        }


        public int AddMechanic(Mechanic mechanic) { 
           return mechanicRepo.InsertMechanic(mechanic);
        }
        public int DeleteMechanic(int id) {
            return mechanicRepo.DeleteMechanic(id);
        }
        public int UpdateMechanic(Mechanic mech) {
            return mechanicRepo.UpdateMechanic(mech);
        }


        public int AddCustomer(Customer customer) {
           return customerRepo.InsertCustomer(customer);
        }
        public int UpdateCustomer(Customer customer) { 
           return customerRepo.UpdateCustomer(customer);
        }

        public int DeleteCustomer(int id) {
            return customerRepo.DeleteCustomer(id);
        }


        public int AddInventoryManager(InventoryManager manager) {
            return inventoryManagerRepo.InsertInventoryManager(manager);
        }
        public int UpdateInventoryManager(InventoryManager manager) { 
            return inventoryManagerRepo.UpdateInventoryManager(manager);
        }
        public int DeleteInventoryManager(int id) {
            return inventoryManagerRepo.DeleteInventoryManager(id);
        }


        public int AddInventoryItem(InventoryItem item) { 
           return inventoryItemRepo.InsertItem(item);
        }
        public int UpdateInventoryItem(InventoryItem item) { 
           return inventoryItemRepo.UpdateItem(item);
        }
        public int DeleteInventoryItem(int id) { 
           return inventoryItemRepo.DeleteItem(id);
        }


        public int AddOfferedService(OfferedService offeredService) { 
           return offeredServiceRepo.InsertService(offeredService);
        }
        public int UpdateOfferedService(OfferedService offeredService) {
            return offeredServiceRepo.UpdateService(offeredService);
        }
        
        public int DeleteOfferedService(int serviceId) {
            return offeredServiceRepo.DeleteService(serviceId);
        }


        public int AddAppointment(Appointment appointment) {
            return appointmentRepo.CreateAppointment(appointment);
        }
        public int UpdateAppointment(Appointment appointment) {
            return appointmentRepo.UpdateAppointment(appointment);
        }
        public int CancelAppointment(int appointmentId) {
           return  appointmentRepo.CancelAppointment(appointmentId);
        }

        public int AssignMechanic(int appointmentId, int mechanicId) {
            return appointmentRepo.AssignMechanic(appointmentId, mechanicId);
        }
    }     
}