using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface IExpensesService
    {
        public Task<List<Expenses>> GetAllAsync();
        public Task<bool> AddAsync(Expenses expense);
        public Task<Expenses> PutAsync(Expenses expense);
        public Task<Expenses> DeleteAsync(int expenseId);
        public Task<Expenses> GetByIdAsync(int expenseId);
    }
}
