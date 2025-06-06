using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceCenter.Models {
    public class Mechanic {
        public float Rating { get; set; }
        public string Status { get; set; }  // Available, Busy

        public Mechanic() {


        }

        public Mechanic(float rating, string status) { 
            this.Rating = rating;
            this.Status = status;
        }
    }
}
