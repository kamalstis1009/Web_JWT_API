using Microsoft.EntityFrameworkCore;
using SSL_eCommerce.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_JWT_API.Models;

namespace Web_JWT_API.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly SQLDatabaseContext _context;

        public AuthenticateService(SQLDatabaseContext context)
        {
            _context = context;
        }

        public async Task<string> AddObject(Authenticate model)
        {
            var response = _context.MIS_Authenticate.Add(model);
            await _context.SaveChangesAsync();
            if (response != null)
            {
                return "success";
            }
            return "failure";
        }

        public async Task<Authenticate> GetObjectById(Guid id)
        {
            //Join Help: https://stackoverflow.com/questions/2767709/join-where-with-linq-and-lambda
            //Link: https://stackoverflow.com/questions/40698126/entity-framework-async-select-with-where-condition
            //return await db.Employee.Where(x => x.FirstName == "Jack").ToListAsync(); //List of data
            return await _context.MIS_Authenticate.FirstOrDefaultAsync(index => index.Id == id);
        }

        public async Task<Authenticate> GetObjectByUserAndPass(string userName, string password)
        {
            return await _context.MIS_Authenticate.FirstOrDefaultAsync(index => index.Username == userName && index.Password == password);
        }
    }
}
