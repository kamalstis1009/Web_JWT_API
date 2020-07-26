using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_JWT_API.Models;

namespace Web_JWT_API.Services
{
    public interface IProductService
    {
        Task<Product> GetObjectById(Guid id);
        Task<string> AddObject(Product model);
        Task<string> UpdateObjectById(Guid id, Product model);
        Task<string> DeleteObjectById(Guid id);
    }
}
