using Core.Abstracts.IManagements;
using Core.Utils;
using Data;

namespace Business.Managements
{
    public class PaymentManager : IPaymentManager
    {
        private readonly PaymentContext context;

        public PaymentManager(PaymentContext context)
        {
            this.context = context;
        }

        public Task<IApiResponse> ProcessPaymentAsync(string orderNumber, decimal totalAmount, string currency)
        {
            throw new NotImplementedException();
        }

        public Task<IApiResponse> RefundPaymentAsync(string orderNumber, decimal amount, string currency)
        {
            throw new NotImplementedException();
        }
    }
}
