using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter.Services
{
    public class PaymentService
    {
        private PaymentRepository paymentRepo;

        public PaymentService()
        {
            this.paymentRepo = new PaymentRepository();
        }

        public int MakePayment(Payment payment)
        {
            if (payment == null || payment.CustomerID <= 0 || payment.Amount <= 0)
                return 0;

            return paymentRepo.InsertPayment(payment);
        }

        public List<Payment> GetCustomerPaymentHistory(int customerId)
        {
            if (customerId <= 0) return new List<Payment>();
            return paymentRepo.GetPaymentsByCustomer(customerId);
        }

        public decimal GetTotalAmountPaid(int customerId)
        {
            if (customerId <= 0) return 0;
            return paymentRepo.GetTotalPaidByCustomer(customerId);
        }
    }
}
