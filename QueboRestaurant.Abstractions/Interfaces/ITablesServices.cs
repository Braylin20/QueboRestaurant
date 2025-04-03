using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface ITablesServices
    {
        public Task<List<Tables>> GetAllAsync();
        public Task<bool> AddAsync(Tables table);
        public Task<Tables> PutAsync(Tables table);
        public Task<Tables> DeleteAsync(int tableId);
        public Task<Tables> GetByIdAsync(int tableId);

    }
}
