using Microsoft.EntityFrameworkCore;
using SSL_eCommerce.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_JWT_API.Models;

namespace Web_JWT_API.Services
{
    public class ProductService : IProductService
    {
        private readonly SQLDatabaseContext _context;

        public ProductService(SQLDatabaseContext context)
        {
            _context = context;
        }

        //======================================================| ADD
        public async Task<string> AddObject(Product model)
        {
            var response = _context.MIS_Product.Add(model);
            await _context.SaveChangesAsync();
            if (response != null)
            {
                return "success";
            }
            return "failure";
        }

        public async Task<string> DeleteObjectById(Guid id)
        {
            //Help: www.entityframeworktutorial.net/EntityFramework4.3/raw-sql-query-in-entity-framework.aspx
            //int response = _context.Database.ExecuteSqlCommand("delete from Products where ID=" + id);
            //OR

            Product item = _context.MIS_Product.FirstOrDefault(index => index.ProductId == id);
            if (item != null)
            {
                var response = _context.MIS_Product.Remove(item);
                await _context.SaveChangesAsync();
                if (response != null)
                {
                    return "success";
                }
                return "failure";
            }
            return "failure";
        }

        public async Task<Product> GetObjectById(Guid id)
        {
            //Join Help: https://stackoverflow.com/questions/2767709/join-where-with-linq-and-lambda
            //Link: https://stackoverflow.com/questions/40698126/entity-framework-async-select-with-where-condition
            //return await db.Employee.Where(x => x.FirstName == "Jack").ToListAsync(); //List of data
            return await _context.MIS_Product.FirstOrDefaultAsync(index => index.ProductId == id);
        }

        public async Task<string> UpdateObjectById(Guid id, Product model)
        {
            Product item = _context.MIS_Product.FirstOrDefault(index => index.ProductId == id);
            if (item != null)
            {
                item.ProductName = model.ProductName;
                item.ProductQty = model.ProductQty;
                item.TotalAmount = model.TotalAmount;
                await _context.SaveChangesAsync();
                //_context.SaveChanges();
                return "success";
            }
            return "failure";
        }
    }
}
