using Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts.IManagements
{
    public interface IPaymentManager
    {
        Task<IApiResponse> ProcessPaymentAsync(string orderNumber, decimal totalAmount, string currency);
        Task<IApiResponse> RefundPaymentAsync(string orderNumber, decimal amount, string currency);
    }
}
