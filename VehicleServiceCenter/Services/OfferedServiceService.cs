using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter.Services
{

    public class OfferedServiceService
    {
        private OfferedServiceRepository serviceRepo;

        public OfferedServiceService()
        {
            this.serviceRepo = new OfferedServiceRepository();
        }

        public int AddService(OfferedService service)
        {
            return serviceRepo.InsertService(service);
        }
        public int UpdateService(OfferedService service)
        {
            return serviceRepo.UpdateService(service);
        }

        public int DeleteService(int serviceId)
        {
            return serviceRepo.DeleteService(serviceId);
        }
        public List<OfferedService> GetAllServices()
        {
            return serviceRepo.GetAllServices();
        }

        public OfferedService GetServiceById(int serviceId)
        {
            return serviceRepo.GetServiceById(serviceId);
        }
    }
}