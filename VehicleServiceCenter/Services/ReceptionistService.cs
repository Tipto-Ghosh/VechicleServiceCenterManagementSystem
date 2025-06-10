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

    public class ReceptionistService {

        private AppointmentRepository appointmentRepository;
        private CustomerRepository customerRepository;
        private MechanicRepository mechanicRepository;


        public ReceptionistService() {
            appointmentRepository = new AppointmentRepository();
            customerRepository = new CustomerRepository();
            mechanicRepository = new MechanicRepository();
        }


        public int BookAppointment(Appointment appointment) {
           return appointmentRepository.CreateAppointment(appointment);
        }
        public int UpdateAppointment(Appointment appointment) { 
           return appointmentRepository.UpdateAppointment(appointment);
        }
        public int CancelAppointment(int appointmentId) {
            return appointmentRepository.CancelAppointment(appointmentId);
        }

        public int RegisterCustomer(Customer customer) {
            return customerRepository.InsertCustomer(customer);
        }
        public int UpdateCustomer(Customer customer) { 
          return customerRepository.UpdateCustomer(customer);
        }
 
        public int RemoveCustomer(int id) {
            return customerRepository.DeleteCustomer(id);
        }

        public int AssignMechanic(int appointmentId, int mechanicId) {
            return appointmentRepository.AssignMechanic(appointmentId, mechanicId);
        }
    }
}