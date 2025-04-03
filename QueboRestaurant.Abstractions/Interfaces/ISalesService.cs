using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface ISalesService
    {
        public Task<List<Sales>> GetAllAsync();
        public Task<bool> AddAsync(Sales sale);
        public Task<Sales> PutAsync(Sales sale);
        public Task<Sales> DeleteAsync(int saleId);
        public Task<Sales> GetByIdAsync(int saleId);

    }
}
