using System;
using System.Collections.Generic;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter.Services
{
    public class AppointmentService
    {
        private AppointmentRepository appointmentRepo;
        private AppointmentServicesRepository appointmentServiceRepo;

        public AppointmentService()
        {
            this.appointmentRepo = new AppointmentRepository();
            this.appointmentServiceRepo = new AppointmentServicesRepository();
        }

        public Appointment GetAppointmentById(int appointmentId)
        {
            return appointmentRepo.GetAppointmentById(appointmentId);
        }

        public List<Appointment> GetAppointmentsByCustomer(int customerId)
        {
            return appointmentRepo.GetAppointmentsByCustomerId(customerId);
        }

        public List<Appointment> GetAppointmentsByMechanic(int mechanicId)
        {
            return appointmentRepo.GetAppointmentsByMechanicId(mechanicId);
        }

        public List<Appointment> GetAllAppointments()
        {
            return appointmentRepo.GetAllAppointments();
        }

        public int AddServicesToAppointment(int appointmentId, List<int> serviceIds) {
            return appointmentServiceRepo.AddMultipleServicesToAppointment(appointmentId, serviceIds);
        }

        public int AddServiceToAppointment(int appointmentId, int serviceId) {
            return appointmentServiceRepo.AddServiceToAppointment(appointmentId, serviceId);
        }

        public int RemoveServiceFromAppointment(int appointmentId, int serviceId) {
            return appointmentServiceRepo.RemoveServiceFromAppointment(appointmentId, serviceId);
        }

        public List<OfferedService> GetServicesByAppointment(int appointmentId) {
            return appointmentServiceRepo.GetServicesByAppointment(appointmentId);
        }
    }
}
