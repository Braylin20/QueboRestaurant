using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface ICategoriesService
    {
        public Task<List<Categories>> GetAllAsync();
        public Task<bool> AddAsync(Categories category);
        public Task<Categories> PutAsync(Categories category);
        public Task<Categories> DeleteAsync(int CategoryId);
        public Task<Categories> GetByIdAsync(int CategoryId);

    }
}
