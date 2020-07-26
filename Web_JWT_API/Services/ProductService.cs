using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_JWT_API.Models;

namespace Web_JWT_API.Services
{
    public class ProductService : IProductService
    {
        public Task<string> AddObject(Product model)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteObjectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetObjectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateObjectById(Guid id, Product model)
        {
            throw new NotImplementedException();
        }
    }
}
