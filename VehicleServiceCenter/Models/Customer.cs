using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceCenter.Models {
    public class Customer: User {

        public string PhoneNumber { get; set; }

        public Customer() { 
        
        }

        public Customer(string phoneNumber) {
            this.PhoneNumber = phoneNumber;
        }
    }
}
