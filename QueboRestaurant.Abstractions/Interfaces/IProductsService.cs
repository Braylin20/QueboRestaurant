using QueboRestaurant.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueboRestaurant.Abstractions.Interfaces
{
    public interface IProductsService
    {
        public Task<List<Products>> GetAllAsync();
        public Task<bool> AddAsync(Products product);
        public Task<Products> PutAsync(Products product);
        public Task<Products> DeleteAsync(int productId);
        public Task<Products> GetByIdAsync(int productId);
    }
}
