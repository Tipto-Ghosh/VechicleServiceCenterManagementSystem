using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;


namespace VehicleServiceCenter.Services
{
    public class CustomerService
    {
        private CustomerRepository customerRepo;
        private AppointmentRepository appointmentRepo;

        public CustomerService()
        {
            this.customerRepo = new CustomerRepository();
            this.appointmentRepo = new AppointmentRepository();
        }

        public int BookService(Appointment appointment)
        {
            return appointmentRepo.CreateAppointment(appointment);
        }

        //public int RateService(int appointmentId, int rating) {

        //}


    }
}