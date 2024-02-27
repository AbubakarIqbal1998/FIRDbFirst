using Microsoft.EntityFrameworkCore;
using Services.Shared.Generic.Interface;
using Services.Shared.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Shared.Generic.RepositoriesPrac
{
    public class RepositoryPractice<T, TDbContext> :DbFactoryPrac<TDbContext>, IRepositoryPrac<T, TDbContext> where T : class where TDbContext : DbContext
    {
        public RepositoryPractice(Func<TDbContext> instance) : base(instance)
        {
        }

        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

