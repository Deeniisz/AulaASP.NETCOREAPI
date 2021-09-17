using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NETCoreWebAPI.Model;

namespace ASP.NETCoreWebAPI.Data
{
    public class ASPNETCoreWebAPIContext : DbContext
    {
        public ASPNETCoreWebAPIContext (DbContextOptions<ASPNETCoreWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NETCoreWebAPI.Model.Person> Person { get; set; }
    }
}
