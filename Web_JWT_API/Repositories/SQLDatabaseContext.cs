using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_JWT_API.Models;

namespace SSL_eCommerce.Repositories
{
    public class SQLDatabaseContext : DbContext
    {
        public SQLDatabaseContext(DbContextOptions<SQLDatabaseContext> options) : base(options)
        {

        }

        //All tables create in database using entity framework
        public DbSet<Product> MIS_Product { get; set; }

        //You can use appsettings.json Or below this
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=MyStudentDb; Integrated Security=True");
        }*/
    }
}
