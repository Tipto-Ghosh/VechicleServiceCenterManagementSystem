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

    public class MechanicService {
        private MechanicRepository mechanicRepo;
        private AppointmentRepository appointmentRepo;

        public MechanicService() {
            this.mechanicRepo = new MechanicRepository();
            this.appointmentRepo = new AppointmentRepository();
        }

        public List<Appointment> GetAssignedJobs(int mechanicId , string status) {
            return appointmentRepo.GetAssignedJobs(mechanicId, status);
        }

        public bool ChangeAvailabilityStatus(int mechanicId, string newStatus) {
            return mechanicRepo.UpdateAvailabilityStatus(mechanicId, newStatus);    
        }
    }
}