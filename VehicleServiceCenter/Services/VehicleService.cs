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
    public class VehicleService {
        private VehicleRepository vehicleRepo;
        private CustomerRepository customerRepo;

        public VehicleService() {
            this.vehicleRepo = new VehicleRepository();
            this.customerRepo = new CustomerRepository();
        }

        public int AddVehicle(Vehicle vehicle) {
            return vehicleRepo.InsertVehicle(vehicle);
        }

        public int UpdateVehicle(Vehicle vehicle) {
            return vehicleRepo.UpdateVehicle(vehicle);
        }
        public int DeleteVehicle(int vehicleId) {
            return vehicleRepo.DeleteVehicle(vehicleId);
        }

        public List<Vehicle> GetVehiclesByCustomer(int customerId) {
            return customerRepo.GetCustomerVehicles(customerId);
        }


    }
}