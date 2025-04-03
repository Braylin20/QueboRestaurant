using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface IPaymentMethodsService
    {
        public Task<List<PaymentMethods>> GetAllAsync();
        public Task<bool> AddAsync(PaymentMethods paymentMethod);
        public Task<PaymentMethods> PutAsync(PaymentMethods paymentMethod);
        public Task<PaymentMethods> DeleteAsync(int paymentMethodId);
        public Task<PaymentMethods> GetByIdAsync(int paymentMethodId);
    }
}
