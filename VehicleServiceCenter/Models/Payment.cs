using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceCenter.Models {
    public class Payment {

        public int PaymentID {  get; set; }
        public int CustomerID {  get; set; }
        public decimal Amount {  get; set; }
        public DateTime PaymentDate {  get; set; }
        public string PaymentMethod {  get; set; } 
        public string Description {  get; set; }  
        public Payment() { }
    }
}
