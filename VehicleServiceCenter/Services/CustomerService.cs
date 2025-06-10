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
    public class CustomerService {
        private CustomerRepository customerRepo;
        private AppointmentRepository appointmentRepo;

        public CustomerService() {
            this.customerRepo = new CustomerRepository();
            this.appointmentRepo = new AppointmentRepository();
        }

        public int BookService(Appointment appointment) {
            return appointmentRepo.CreateAppointment(appointment);
        }

        //public int RateService(int appointmentId, int rating) {
            
        //}


    }
}