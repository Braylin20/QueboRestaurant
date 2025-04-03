using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface IReconciliationsService
    {
        public Task<List<Reconciliations>> GetAllAsync();
        public Task<bool> AddAsync(Reconciliations reconciliation);
        public Task<Reconciliations> PutAsync(Reconciliations reconciliation);
        public Task<Reconciliations> DeleteAsync(int reconciliationId);
        public Task<Reconciliations> GetByIdAsync(int reconciliationId);
    }
}
