using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_JWT_API.Models;

namespace Web_JWT_API.Services
{
    public interface IAuthenticateService
    {
        Task<Authenticate> GetObjectByUserAndPass(string userName, string password);
        Task<Authenticate> GetObjectById(Guid id);
        Task<string> AddObject(Authenticate model);
    }
}
