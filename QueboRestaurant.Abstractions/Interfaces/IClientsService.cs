using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface IClientsService
    {
        public Task<List<Clients>> GetAllAsync();
        public Task<bool> AddAsync(Clients client);
        public Task<Clients> PutAsync(Clients client);
        public Task<Clients> DeleteAsync(int clientId);
        public Task<Clients> GetByIdAsync(int clientId);
    }
}
