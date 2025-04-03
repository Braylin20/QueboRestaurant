using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface IAcountingAccountsService
    {
        public Task<List<AcountingAccounts>> GetAllAsync();
        public Task<bool> AddAsync(AcountingAccounts account);
        public Task<AcountingAccounts> PutAsync(AcountingAccounts account);
        public Task<AcountingAccounts> DeleteAsync(int acountingAccountId);
        public Task<AcountingAccounts> GetByIdAsync(int acoutingAccountId);
    }
}
