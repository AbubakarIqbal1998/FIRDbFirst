using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Shared.Static
{
    public class DbFactoryPrac<TDbContext> where TDbContext : DbContext
    {
        public Func<TDbContext> Instance;
        public DbContext dbcontext;
        public DbFactoryPrac(Func<TDbContext> instance)
        {
            instance = instance;
        }
        public DbContext DbContext => dbcontext ?? (dbcontext = Instance.Invoke());
   
    }
}
