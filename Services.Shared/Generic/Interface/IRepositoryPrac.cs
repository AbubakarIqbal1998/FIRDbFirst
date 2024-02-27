using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Shared.Generic.Interface
{
    internal interface IRepositoryPrac<T, TDbContext> where T : class where TDbContext : DbContext
    {
        Task<T> Add(T entity);
        T Update(T entity);
        T Delete(T entity);

    }
}
