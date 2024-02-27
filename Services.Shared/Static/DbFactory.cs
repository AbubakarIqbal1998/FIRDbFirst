using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Shared.Static
{
    public class DbFactory<TDbContext> where TDbContext:DbContext
    {
        public Func<TDbContext> Instance;
        public DbContext dbContext;
        public DbFactory(Func<TDbContext> instance)
        {
            Instance = instance;
        }
        public DbContext DBContext => dbContext ?? (dbContext = Instance.Invoke());
    }
}
