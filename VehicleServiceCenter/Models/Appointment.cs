using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceCenter.Models {
    public class Appointment {

        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int MechanicID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public int TokenNumber { get; set; }

        public Appointment() { 
        
        }

        public Appointment(int customerId, int mechanicId, DateTime date, string status, 
                           int createdBy, int token)
        {
            this.CustomerID = customerId;
            this.MechanicID = mechanicId;
            this.ScheduledDate = date;
            this.Status = status;
            this.CreatedBy = createdBy;
            this.TokenNumber = token;
        }
    }
}
