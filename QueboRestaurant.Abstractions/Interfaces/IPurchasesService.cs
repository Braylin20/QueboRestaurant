using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface IPurchasesService
    {
        public Task<List<Purchases>> GetAllAsync();
        public Task<bool> AddAsync(Purchases purchases);
        public Task<Purchases> PutAsync(Purchases purchase);
        public Task<Purchases> DeleteAsync(int purchaseId);
        public Task<Purchases> GetByIdAsync(int purchaseId);
    }
}
